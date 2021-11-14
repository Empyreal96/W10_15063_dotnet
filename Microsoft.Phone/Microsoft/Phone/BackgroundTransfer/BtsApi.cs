// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.BtsApi
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.BackgroundTransfer
{
  [SecuritySafeCritical]
  internal static class BtsApi
  {
    public const string HttpMethodGet = "GET";
    public const string HttpMethodPut = "PUT";
    public const string HttpMethodPost = "POST";
    public const string TransfersRoot = "\\shared\\transfers\\";

    public static string IsolatedStoreRoot => ApplicationHost.Current.AppIsolatedStorePath;

    public static Uri ValidateAndNormalizeTransferUri(Uri transferUri)
    {
      if ((Uri) null == transferUri)
        return (Uri) null;
      if (transferUri.IsAbsoluteUri)
        throw new NotSupportedException(transferUri.ToString());
      string str = new Uri("file://" + Path.Combine("/", transferUri.OriginalString.Trim().Replace('\\', '/')), UriKind.Absolute).AbsolutePath.Replace('/', '\\');
      if (!str.StartsWith("\\shared\\transfers\\", StringComparison.OrdinalIgnoreCase))
        throw new NotSupportedException(transferUri.ToString());
      return !string.IsNullOrEmpty(Path.GetFileName(str)) ? new Uri(str, UriKind.Relative) : throw new ArgumentException(transferUri.ToString());
    }

    public static string ValidateAndNormalizeTransferMethod(string method)
    {
      if (string.IsNullOrEmpty(method))
        throw new ArgumentNullException();
      if (string.Compare(method, "GET", StringComparison.OrdinalIgnoreCase) == 0)
        return "GET";
      if (string.Compare(method, "POST", StringComparison.OrdinalIgnoreCase) == 0)
        return "POST";
      if (string.Compare(method, "PUT", StringComparison.OrdinalIgnoreCase) == 0)
        return "PUT";
      throw new NotSupportedException();
    }

    public static Exception GetExceptionForHR(int hr)
    {
      switch (hr)
      {
        case -2147024713:
          return (Exception) new InvalidOperationException("The request has already been submitted");
        case -2147023728:
          return (Exception) new InvalidOperationException("The request cannot be found");
        case -2147023162:
          return (Exception) new ArgumentException();
        case -2145877311:
          return (Exception) new InvalidOperationException("The application request limit has been reached");
        case -2145877301:
          return (Exception) new BackgroundTransferInternalException("The http network provider returned an error", hr);
        case -2145877300:
          return (Exception) new BackgroundTransferInternalException("The http network provider returned an error related to content-range request or response", hr);
        case -2145877299:
          return (Exception) new BackgroundTransferInternalException("The total request limit accross all applications has been reached", hr);
        case -2145877298:
          return (Exception) new InvalidOperationException("The request cancelation failed");
        case -2145877296:
          return (Exception) new InvalidOperationException("The transfer file size is bigger than the allowed limit");
        case -2145877295:
          return (Exception) new BackgroundTransferInternalException("The http network provider returned a network related error", hr);
        case -2145877294:
          return (Exception) new BackgroundTransferInternalException("The http network provider returned a slow transfer error", hr);
        case -2145877293:
          return (Exception) new InvalidOperationException("The http network provider returned an invalid parameter error");
        case -1055719416:
          return (Exception) new InvalidOperationException("The isolated storage provider returned an invalid file path error");
        case 1606336:
          return (Exception) new InvalidOperationException("The request has already been canceled");
        default:
          if (NativeMethods.FacilityFromHr(hr) == 16659)
            return (Exception) new BackgroundTransferInternalException("The isolated storage provider returned an error", hr);
          return NativeMethods.Failed(hr) ? Marshal.GetExceptionForHR(hr) : (Exception) null;
      }
    }

    public static BtsRequestHandle CreateBackgroundTransferRequest(
      string requestId,
      ref TransferParameters parameters)
    {
      BtsTransferParams transferParams = new BtsTransferParams();
      CoTaskBufferHandle taskBufferHandle = BtsApi.MarshalHeaders(parameters.Headers);
      using (taskBufferHandle)
      {
        transferParams.Uri = parameters.RequestUri.OriginalString;
        transferParams.FileName = BtsApi.GetPathFromUri(parameters.DownloadLocation);
        transferParams.UploadFileName = BtsApi.GetPathFromUri(parameters.UploadLocation);
        transferParams.TransferFlags = BtsApi.GetBtsTransferFlags(parameters.TransferPreferences);
        transferParams.Verb = BtsApi.GetBtsHttpVerb(parameters.Method);
        transferParams.NumCustomAddRequestHeaders = (uint) parameters.Headers.Count;
        transferParams.CustomAddRequestHeaders = taskBufferHandle.DangerousGetHandle();
        transferParams.CustomData = parameters.Tag;
        transferParams.RequestStateWnfStateNameSize = 0U;
        transferParams.RequestStateWnfStateName = IntPtr.Zero;
        transferParams.ConnectionDataPlanUsageState = 0U;
        transferParams.DataAttributionType = 0U;
        transferParams.TransferOriginatorProductId = IntPtr.Zero;
        BtsRequestHandle requestHandle;
        BtsApi.ThrowExceptionForHR(NativeMethods.BtsCreateBackgroundTransferRequest(requestId, BtsRequestCreationDisposition.CreateNewRequest, ref transferParams, out requestHandle));
        return requestHandle;
      }
    }

    public static BtsRequestHandle OpenBackgroundTransferRequest(string requestId)
    {
      BtsRequestHandle requestHandle;
      int backgroundTransferRequest = NativeMethods.BtsCreateBackgroundTransferRequest(requestId, BtsRequestCreationDisposition.OpenExistingRequest, IntPtr.Zero, out requestHandle);
      if (NativeMethods.Failed(backgroundTransferRequest) && -2147023728 != backgroundTransferRequest)
        BtsApi.ThrowExceptionForHR(backgroundTransferRequest);
      return requestHandle;
    }

    public static RequestStatus QueryBackgroundTransferRequestStatus(
      BtsRequestHandle requestHandle)
    {
      BtsRequestStatus requestStatus;
      BtsApi.ThrowExceptionForHR(NativeMethods.BtsQueryBackgroundTransferRequestStatus(requestHandle, out requestStatus));
      return BtsApi.GetRequestStatus(ref requestStatus);
    }

    public static TransferParameters QueryBackgroundTransferRequestTransferParameters(
      BtsRequestHandle requestHandle)
    {
      BtsBufferHandle buffer;
      BtsApi.ThrowExceptionForHR(NativeMethods.BtsQueryBackgroundTransferRequestParameters(requestHandle, out buffer));
      using (buffer)
      {
        BtsTransferParams structure = (BtsTransferParams) Marshal.PtrToStructure(buffer.DangerousGetHandle(), typeof (BtsTransferParams));
        TransferParameters transferParameters = new TransferParameters();
        transferParameters.RequestUri = new Uri(structure.Uri);
        transferParameters.Headers = BtsApi.UnmarshalHeaders((int) structure.NumCustomAddRequestHeaders, structure.CustomAddRequestHeaders);
        transferParameters.DownloadLocation = BtsApi.GetUriFromPath(structure.FileName);
        transferParameters.UploadLocation = BtsApi.GetUriFromPath(structure.UploadFileName);
        transferParameters.Tag = structure.CustomData;
        transferParameters.Method = BtsApi.GetHttpMethod(structure.Verb);
        transferParameters.TransferPreferences = BtsApi.GetTransferPreferences(structure.TransferFlags);
        transferParameters = transferParameters;
        return transferParameters;
      }
    }

    public static void CancelBackgroundTransferRequest(BtsRequestHandle requestHandle) => BtsApi.ThrowExceptionForHR(NativeMethods.BtsCancelBackgroundTransferRequest(requestHandle));

    public static RequestInfo[] EnumBackgroundTransferRequests()
    {
      BtsBufferHandle buffer;
      BtsApi.ThrowExceptionForHR(NativeMethods.BtsEnumBackgroundTransferRequests(out buffer));
      RequestInfo[] requestInfoArray = (RequestInfo[]) null;
      using (buffer)
      {
        BtsRequestEnum structure1 = (BtsRequestEnum) Marshal.PtrToStructure(buffer.DangerousGetHandle(), typeof (BtsRequestEnum));
        IntPtr num = structure1.Requests;
        int increment = Marshal.SizeOf(typeof (BtsRequestInfo));
        requestInfoArray = new RequestInfo[(int) structure1.NumRequests];
        for (uint index = 0; index < structure1.NumRequests; ++index)
        {
          BtsRequestInfo structure2 = (BtsRequestInfo) Marshal.PtrToStructure(num, typeof (BtsRequestInfo));
          requestInfoArray[(int) index] = new RequestInfo()
          {
            RequestId = structure2.RequestId,
            RequestStatus = BtsApi.GetRequestStatus(ref structure2.RequestStatus)
          };
          num = num.Increment(increment);
        }
      }
      return requestInfoArray;
    }

    public static bool NotifyBackgroundTransferRequestStatus(
      BtsRequestHandle requestHandle,
      RequestStatusNotifyHandler notifyHandler)
    {
      int hr = NativeMethods.BtsNotifyBackgroundTransferRequestStatus(requestHandle, (IBtsRequestStatusNotificationCallback) new BtsApi.BtsNotificationCallback(notifyHandler));
      if (-2145877309 == hr)
        return false;
      BtsApi.ThrowExceptionForHR(hr);
      return true;
    }

    private static BtsTransferFlags GetBtsTransferFlags(
      TransferPreferences preferences)
    {
      switch (preferences)
      {
        case TransferPreferences.None:
          return BtsTransferFlags.All;
        case TransferPreferences.AllowCellular:
          return BtsTransferFlags.ACPower;
        case TransferPreferences.AllowBattery:
          return BtsTransferFlags.WiFi;
        default:
          return BtsTransferFlags.None;
      }
    }

    private static TransferPreferences GetTransferPreferences(
      BtsTransferFlags transferFlags)
    {
      transferFlags &= BtsTransferFlags.All;
      switch (transferFlags)
      {
        case BtsTransferFlags.WiFi:
          return TransferPreferences.AllowBattery;
        case BtsTransferFlags.ACPower:
          return TransferPreferences.AllowCellular;
        case BtsTransferFlags.All:
          return TransferPreferences.None;
        default:
          return TransferPreferences.AllowCellularAndBattery;
      }
    }

    private static TransferStatus GetTransferStatus(
      BtsRequestState requestState,
      int hr)
    {
      switch (requestState)
      {
        case BtsRequestState.Transferring:
          return TransferStatus.Transferring;
        case BtsRequestState.Paused:
          return TransferStatus.Paused;
        case BtsRequestState.Completed:
          return TransferStatus.Completed;
        default:
          switch (hr)
          {
            case 1606341:
              return TransferStatus.WaitingForExternalPower;
            case 1606345:
              return TransferStatus.WaitingForWiFi;
            case 1606346:
              return TransferStatus.WaitingForNonVoiceBlockingNetwork;
            case 1606356:
              return TransferStatus.WaitingForExternalPowerDueToBatterySaverMode;
            default:
              return TransferStatus.Waiting;
          }
      }
    }

    private static BtsHttpVerb GetBtsHttpVerb(string method)
    {
      if (method == "PUT")
        return BtsHttpVerb.Put;
      return method == "POST" ? BtsHttpVerb.Post : BtsHttpVerb.Get;
    }

    private static string GetHttpMethod(BtsHttpVerb verb)
    {
      if (verb == BtsHttpVerb.Post)
        return "POST";
      return verb == BtsHttpVerb.Put ? "PUT" : "GET";
    }

    private static uint GetBytesSent(ref BtsRequestStatus btsStatus)
    {
      if (btsStatus.Uploading)
        return btsStatus.CurrentBytes;
      switch (btsStatus.RequestState)
      {
        case BtsRequestState.Transferring:
          return btsStatus.TotalUploadBytes;
        case BtsRequestState.Completed:
          if (NativeMethods.Succeeded(btsStatus.HrStatus))
            return btsStatus.TotalUploadBytes;
          break;
      }
      return 0;
    }

    private static uint GetBytesReceived(ref BtsRequestStatus btsStatus) => !btsStatus.Uploading ? btsStatus.CurrentBytes : 0U;

    private static uint GetTotalBytesToReceive(ref BtsRequestStatus btsStatus) => !btsStatus.Uploading ? btsStatus.TotalBytes : 0U;

    private static RequestStatus GetRequestStatus(ref BtsRequestStatus btsStatus) => new RequestStatus()
    {
      TotalBytesToSend = btsStatus.TotalUploadBytes,
      TotalBytesToReceive = BtsApi.GetTotalBytesToReceive(ref btsStatus),
      BytesSent = BtsApi.GetBytesSent(ref btsStatus),
      BytesReceived = BtsApi.GetBytesReceived(ref btsStatus),
      StatusCode = btsStatus.HttpStatus,
      TransferError = BtsApi.GetExceptionForHR(btsStatus.HrStatus),
      TransferStatus = BtsApi.GetTransferStatus(btsStatus.RequestState, btsStatus.HrStatus),
      HrTransferError = btsStatus.HrStatus
    };

    private static CoTaskBufferHandle MarshalHeaders(IList<string> headers)
    {
      if (headers.Count == 0)
        return new CoTaskBufferHandle();
      int num1 = Marshal.SizeOf(typeof (IntPtr));
      int size = headers.Count * num1;
      for (int index = 0; index < headers.Count; ++index)
        size += Encoding.Unicode.GetByteCount(headers[index]) + 2;
      CoTaskBufferHandle taskBufferHandle = NativeMethods.CoTaskMemAlloc(size);
      if (taskBufferHandle.IsInvalid)
        throw new OutOfMemoryException();
      try
      {
        IntPtr handle = taskBufferHandle.DangerousGetHandle();
        IntPtr num2 = handle.Increment(headers.Count * num1);
        for (int index = 0; index < headers.Count; ++index)
        {
          Marshal.WriteIntPtr(new IntPtr(handle.ToInt64() + (long) (index * num1)), num2);
          byte[] bytes = Encoding.Unicode.GetBytes(headers[index]);
          Marshal.Copy(bytes, 0, num2, bytes.Length);
          IntPtr num3 = num2.Increment(bytes.Length);
          Marshal.WriteInt16(num3, (short) 0);
          num2 = num3.Increment(2);
        }
      }
      catch
      {
        taskBufferHandle.Close();
        throw;
      }
      return taskBufferHandle;
    }

    private static IList<string> UnmarshalHeaders(int count, IntPtr buffer)
    {
      List<string> stringList = new List<string>(count);
      int num = Marshal.SizeOf(typeof (IntPtr));
      for (int index = 0; index < count; ++index)
      {
        IntPtr ptr = Marshal.ReadIntPtr(buffer.Increment(index * num));
        stringList.Add(Marshal.PtrToStringUni(ptr));
      }
      return (IList<string>) stringList;
    }

    private static string GetPathFromUri(Uri transferUri) => (Uri) null == transferUri ? (string) null : Path.Combine(BtsApi.IsolatedStoreRoot, transferUri.OriginalString.Substring(1));

    private static Uri GetUriFromPath(string filePath) => string.IsNullOrEmpty(filePath) ? (Uri) null : new Uri(filePath.Substring(BtsApi.IsolatedStoreRoot.Length), UriKind.Relative);

    public static void ThrowExceptionForHR(int hr)
    {
      if (NativeMethods.Failed(hr))
        throw BtsApi.GetExceptionForHR(hr);
    }

    private static IntPtr Increment(this IntPtr val, int increment) => new IntPtr(val.ToInt64() + (long) increment);

    [SecuritySafeCritical]
    private class BtsNotificationCallback : IBtsRequestStatusNotificationCallback
    {
      private RequestStatusNotifyHandler _handler;

      public BtsNotificationCallback(RequestStatusNotifyHandler handler) => this._handler = handler;

      [SecuritySafeCritical]
      public void OnNotify(int hrNotify, IntPtr notifyData)
      {
        Exception exceptionForHr = BtsApi.GetExceptionForHR(hrNotify);
        string requestId = (string) null;
        RequestStatus? status = new RequestStatus?();
        if (exceptionForHr == null)
        {
          BtsRequestNotificationParams structure = (BtsRequestNotificationParams) Marshal.PtrToStructure(notifyData, typeof (BtsRequestNotificationParams));
          requestId = structure.RequestId;
          status = new RequestStatus?(BtsApi.GetRequestStatus(ref structure.RequestStatus));
        }
        this._handler(exceptionForHr, requestId, status);
      }
    }
  }
}
