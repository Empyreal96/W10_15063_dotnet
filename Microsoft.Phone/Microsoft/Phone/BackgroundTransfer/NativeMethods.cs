// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.NativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.BackgroundTransfer
{
  [SecurityCritical]
  internal static class NativeMethods
  {
    public const int SEVERITY_SUCCESS = 0;
    public const int SEVERITY_ERROR = -2147483648;
    public const int FACILITY_WINDOWS_CE = 1572864;
    public const int BTS_ERR_BASE = 33472;
    public const int S_OK = 0;
    public const int E_ALREADY_EXISTS = -2147024713;
    public const int E_NOT_FOUND = -2147023728;
    public const int E_RPC_INVALID_BOUNDS = -2147023162;
    public const int BTS_W_REQUEST_CANCELED_BY_API = 1606336;
    public const int BTS_E_PER_APP_REQUEST_LIMIT_REACHED = -2145877311;
    public const int BTS_E_UNABLE_TO_ENQUEUE_REQUEST = -2145877310;
    public const int BTS_E_UNABLE_TO_NOTIFY_STATUS = -2145877309;
    public const int BTS_E_RETRY_CLOSE_REQUEST = -2145877308;
    public const int BTS_W_REQUEST_POWER_CONDITION_UNSATISFIED = 1606341;
    public const int BTS_W_REQUEST_PAUSED_EXTERNAL = 1606342;
    public const int BTS_E_PAUSE_FAILED = -2145877305;
    public const int BTS_E_RESUME_FAILED = -2145877304;
    public const int BTS_W_WIFI_CONDITION_UNSATISFIED = 1606345;
    public const int BTS_W_NO_CONNECTIVITY = 1606346;
    public const int BTS_E_HTTP_PROVIDER_ERROR = -2145877301;
    public const int BTS_E_HTTP_PROVIDER_ERROR_RANGE_RELATED = -2145877300;
    public const int BTS_E_TOTAL_REQUEST_LIMIT_REACHED = -2145877299;
    public const int BTS_E_CANCEL_FAILED = -2145877298;
    public const int BTS_W_RETRYING_ON_PROVIDER_ERROR = 1606351;
    public const int BTS_E_FILE_SIZE_TOO_BIG = -2145877296;
    public const int BTS_E_HTTP_PROVIDER_ERROR_NETWORK = -2145877295;
    public const int BTS_E_HTTP_PROVIDER_ERROR_SLOW_TRANSFER = -2145877294;
    public const int BTS_E_HTTP_PROVIDER_ERROR_INVALID_PARAMETER = -2145877293;
    public const int BTS_W_TRANSFER_WAITING_BATTERY_SAVER_MODE = 1606356;
    public const int FACILITY_DATASHARING = 16659;
    public const int DS_ERR_BASE = 0;
    public const int DS_E_INVALID_PATH = -1055719416;

    public static bool Succeeded(int hr) => hr >= 0;

    public static bool Failed(int hr) => !NativeMethods.Succeeded(hr);

    public static int FacilityFromHr(int hr) => hr >> 16 & (int) short.MaxValue;

    [DllImport("btscli.dll", EntryPoint = "#1", CharSet = CharSet.Unicode)]
    public static extern int BtsCreateBackgroundTransferRequest(
      [MarshalAs(UnmanagedType.LPWStr), In] string requestId,
      [In] BtsRequestCreationDisposition creationDisposition,
      [MarshalAs(UnmanagedType.Struct), In] ref BtsTransferParams transferParams,
      out BtsRequestHandle requestHandle);

    [DllImport("btscli.dll", EntryPoint = "#1", CharSet = CharSet.Unicode)]
    public static extern int BtsCreateBackgroundTransferRequest(
      [MarshalAs(UnmanagedType.LPWStr), In] string requestId,
      [In] BtsRequestCreationDisposition creationDisposition,
      [In] IntPtr notUsed,
      out BtsRequestHandle requestHandle);

    [DllImport("btscli.dll", EntryPoint = "#2", CharSet = CharSet.Unicode)]
    public static extern int BtsCloseBackgroundTransferRequest([In] IntPtr requestHandle);

    [DllImport("btscli.dll", EntryPoint = "#3", CharSet = CharSet.Unicode)]
    public static extern int BtsQueryBackgroundTransferRequestStatus(
      [In] BtsRequestHandle requestHandle,
      out BtsRequestStatus requestStatus);

    [DllImport("btscli.dll", EntryPoint = "#4", CharSet = CharSet.Unicode)]
    public static extern int BtsCancelBackgroundTransferRequest([In] BtsRequestHandle requestHandle);

    [DllImport("btscli.dll", EntryPoint = "#5", CharSet = CharSet.Unicode)]
    public static extern int BtsEnumBackgroundTransferRequests(out BtsBufferHandle buffer);

    [DllImport("btscli.dll", EntryPoint = "#6", CharSet = CharSet.Unicode)]
    public static extern int BtsEnqueueBackgroundTransferRequest(
      [In] BtsRequestHandle requestHandle,
      [MarshalAs(UnmanagedType.Struct), In] ref BtsTransferParams transferParams);

    [DllImport("btscli.dll", EntryPoint = "#7", CharSet = CharSet.Unicode)]
    public static extern int BtsNotifyBackgroundTransferRequestStatus(
      [In] BtsRequestHandle requestHandle,
      [MarshalAs((UnmanagedType) 28), In] IBtsRequestStatusNotificationCallback notifyCallback);

    [DllImport("btscli.dll", EntryPoint = "#8", CharSet = CharSet.Unicode)]
    public static extern int BtsApiFree([In] IntPtr buffer);

    [DllImport("btscli.dll", EntryPoint = "#9", CharSet = CharSet.Unicode)]
    public static extern int BtsQueryBackgroundTransferRequestParameters(
      [In] BtsRequestHandle requestHandle,
      out BtsBufferHandle buffer);

    [DllImport("combase.dll", CharSet = CharSet.Unicode)]
    public static extern CoTaskBufferHandle CoTaskMemAlloc([In] int size);

    [DllImport("combase.dll", CharSet = CharSet.Unicode)]
    public static extern void CoTaskMemFree([In] IntPtr buffer);
  }
}
