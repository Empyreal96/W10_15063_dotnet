// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.BackgroundTransferService
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Phone.BackgroundTransfer
{
  [SecuritySafeCritical]
  public static class BackgroundTransferService
  {
    [SecuritySafeCritical]
    public static BackgroundTransferRequest Find(string requestId)
    {
      using (new AutoLogApi("BackgroundTransferService.Find"))
        return BackgroundTransferService.FindHelper(requestId);
    }

    private static BackgroundTransferRequest FindHelper(string requestId)
    {
      BtsRequestHandle requestHandle = !string.IsNullOrEmpty(requestId) ? BtsApi.OpenBackgroundTransferRequest(requestId) : throw new ArgumentNullException(nameof (requestId));
      if (requestHandle.IsInvalid)
        return (BackgroundTransferRequest) null;
      try
      {
        return new BackgroundTransferRequest(requestHandle, requestId);
      }
      catch
      {
        requestHandle.Close();
        throw;
      }
    }

    [SecuritySafeCritical]
    public static void Add(BackgroundTransferRequest request)
    {
      if (request == null)
        throw new ArgumentNullException(nameof (request));
      request.Submit();
    }

    [SecuritySafeCritical]
    public static void Remove(BackgroundTransferRequest request)
    {
      if (request == null)
        throw new ArgumentNullException(nameof (request));
      using (new AutoLogApi("BackgroundTransferService.Remove"))
        request.Cancel();
    }

    public static IEnumerable<BackgroundTransferRequest> Requests
    {
      get
      {
        using (new AutoLogApi("BackgroundTransferService.Requests"))
          return (IEnumerable<BackgroundTransferRequest>) new BackgroundTransferService.BackgroundTransferRequests();
      }
    }

    [SecuritySafeCritical]
    private class BackgroundTransferRequests : IEnumerable<BackgroundTransferRequest>, IEnumerable
    {
      private IEnumerable<RequestInfo> _enumRequestInfo;

      public BackgroundTransferRequests() => this._enumRequestInfo = (IEnumerable<RequestInfo>) BtsApi.EnumBackgroundTransferRequests();

      [SecuritySafeCritical]
      public IEnumerator<BackgroundTransferRequest> GetEnumerator() => (IEnumerator<BackgroundTransferRequest>) new BackgroundTransferService.BackgroundTransferRequestsEnumerator(this._enumRequestInfo);

      [SecuritySafeCritical]
      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
    }

    [SecuritySafeCritical]
    private class BackgroundTransferRequestsEnumerator : 
      IEnumerator<BackgroundTransferRequest>,
      IEnumerator,
      IDisposable
    {
      private IEnumerator<RequestInfo> _requestInfoEnumerator;
      private BackgroundTransferRequest _current;

      public BackgroundTransferRequestsEnumerator(IEnumerable<RequestInfo> enumRequestInfo) => this._requestInfoEnumerator = enumRequestInfo.GetEnumerator();

      public BackgroundTransferRequest Current => this._current != null ? this._current : throw new InvalidOperationException();

      [SecuritySafeCritical]
      public void Dispose()
      {
        this._requestInfoEnumerator.Dispose();
        this._current = (BackgroundTransferRequest) null;
      }

      object IEnumerator.Current => (object) this.Current;

      [SecuritySafeCritical]
      public bool MoveNext()
      {
        this._current = (BackgroundTransferRequest) null;
        while (this._requestInfoEnumerator.MoveNext())
        {
          BtsRequestHandle requestHandle = BtsApi.OpenBackgroundTransferRequest(this._requestInfoEnumerator.Current.RequestId);
          if (!requestHandle.IsInvalid)
          {
            BackgroundTransferRequest backgroundTransferRequest;
            try
            {
              backgroundTransferRequest = new BackgroundTransferRequest(requestHandle, this._requestInfoEnumerator.Current.RequestId);
            }
            catch
            {
              requestHandle.Close();
              throw;
            }
            this._current = backgroundTransferRequest;
            return true;
          }
        }
        return false;
      }

      [SecuritySafeCritical]
      public void Reset()
      {
        this._requestInfoEnumerator.Reset();
        this._current = (BackgroundTransferRequest) null;
      }
    }
  }
}
