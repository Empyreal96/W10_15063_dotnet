// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.BackgroundTransferRequest
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using System.Windows;

namespace Microsoft.Phone.BackgroundTransfer
{
  [SecuritySafeCritical]
  public sealed class BackgroundTransferRequest : IDisposable
  {
    private object _statusUpdateLock = new object();
    private BtsRequestHandle _requestHandle;
    private string _requestId;
    private string _tag;
    private Uri _requestUri;
    private Uri _downloadUri;
    private Uri _uploadUri;
    private BackgroundTransferRequest.RequestHeaders _headers;
    private string _method = "GET";
    private TransferPreferences _preferences;
    private RequestStatus _requestStatus;
    private string _scenarioName;

    private event EventHandler<BackgroundTransferEventArgs> _transferStatusChangedEvent;

    private event EventHandler<BackgroundTransferEventArgs> _transferProgressChangedEvent;

    [SecuritySafeCritical]
    public BackgroundTransferRequest(Uri requestUri)
      : this(requestUri, (Uri) null)
    {
    }

    [SecuritySafeCritical]
    public BackgroundTransferRequest(Uri requestUri, Uri downloadLocation)
    {
      this._requestUri = !((Uri) null == requestUri) ? requestUri : throw new ArgumentNullException(nameof (requestUri));
      this._headers = new BackgroundTransferRequest.RequestHeaders();
      this.DownloadLocation = downloadLocation;
      this._requestId = Guid.NewGuid().ToString("B");
    }

    [SecuritySafeCritical]
    internal BackgroundTransferRequest(BtsRequestHandle requestHandle, string requestId)
    {
      TransferParameters transferParameters = BtsApi.QueryBackgroundTransferRequestTransferParameters(requestHandle);
      this._requestHandle = requestHandle;
      this._requestId = requestId;
      this._tag = transferParameters.Tag;
      this._requestUri = transferParameters.RequestUri;
      this._downloadUri = transferParameters.DownloadLocation;
      this._uploadUri = transferParameters.UploadLocation;
      this._headers = new BackgroundTransferRequest.RequestHeaders(transferParameters.Headers);
      this._method = transferParameters.Method;
      this._preferences = transferParameters.TransferPreferences;
      BtsApi.NotifyBackgroundTransferRequestStatus(requestHandle, new RequestStatusNotifyHandler(this.OnStatusChanged));
      this.UpdateStatus(BtsApi.QueryBackgroundTransferRequestStatus(requestHandle));
    }

    public string RequestId
    {
      [SecuritySafeCritical] get => this._requestId;
    }

    public Uri RequestUri
    {
      [SecuritySafeCritical] get => this._requestUri;
    }

    public string Tag
    {
      [SecuritySafeCritical] get => this._tag;
      [SecuritySafeCritical] set
      {
        this.ThrowIfReadOnly();
        this._tag = value;
      }
    }

    public Uri DownloadLocation
    {
      [SecuritySafeCritical] get => this._downloadUri;
      [SecuritySafeCritical] set
      {
        this.ThrowIfReadOnly();
        try
        {
          this._downloadUri = BtsApi.ValidateAndNormalizeTransferUri(value);
        }
        catch (Exception ex)
        {
          throw new ArgumentException(nameof (DownloadLocation), ex);
        }
      }
    }

    public Uri UploadLocation
    {
      [SecuritySafeCritical] get => this._uploadUri;
      [SecuritySafeCritical] set
      {
        this.ThrowIfReadOnly();
        try
        {
          this._uploadUri = BtsApi.ValidateAndNormalizeTransferUri(value);
        }
        catch (Exception ex)
        {
          throw new ArgumentException(nameof (UploadLocation), ex);
        }
      }
    }

    public IDictionary<string, string> Headers
    {
      [SecuritySafeCritical] get => (IDictionary<string, string>) this._headers;
    }

    public string Method
    {
      [SecuritySafeCritical] get => this._method;
      [SecuritySafeCritical] set
      {
        this.ThrowIfReadOnly();
        try
        {
          this._method = BtsApi.ValidateAndNormalizeTransferMethod(value);
        }
        catch (Exception ex)
        {
          throw new ArgumentException(nameof (Method), ex);
        }
      }
    }

    public TransferPreferences TransferPreferences
    {
      [SecuritySafeCritical] get => this._preferences;
      [SecuritySafeCritical] set
      {
        this.ThrowIfReadOnly();
        this._preferences = value;
      }
    }

    public TransferStatus TransferStatus
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return this._requestStatus.TransferStatus;
      }
    }

    public Exception TransferError
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return this._requestStatus.TransferError;
      }
    }

    public long TotalBytesToReceive
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return this._requestStatus.TotalBytesToReceive != uint.MaxValue ? (long) this._requestStatus.TotalBytesToReceive : -1L;
      }
    }

    public long TotalBytesToSend
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return (long) this._requestStatus.TotalBytesToSend;
      }
    }

    public long BytesReceived
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return (long) this._requestStatus.BytesReceived;
      }
    }

    public long BytesSent
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return (long) this._requestStatus.BytesSent;
      }
    }

    public long StatusCode
    {
      [SecuritySafeCritical] get
      {
        lock (this._statusUpdateLock)
          return (long) this._requestStatus.StatusCode;
      }
    }

    public event EventHandler<BackgroundTransferEventArgs> TransferStatusChanged
    {
      [SecuritySafeCritical] add => this._transferStatusChangedEvent += value;
      [SecuritySafeCritical] remove => this._transferStatusChangedEvent -= value;
    }

    public event EventHandler<BackgroundTransferEventArgs> TransferProgressChanged
    {
      [SecuritySafeCritical] add => this._transferProgressChangedEvent += value;
      [SecuritySafeCritical] remove => this._transferProgressChangedEvent -= value;
    }

    [SecuritySafeCritical]
    public void Dispose()
    {
      if (this._requestHandle.IsClosed)
        return;
      this._requestHandle.Close();
      GC.SuppressFinalize((object) this);
    }

    public bool Equals(BackgroundTransferRequest other)
    {
      if (other == null)
        return false;
      return this == other || this._requestId == other._requestId;
    }

    public override bool Equals(object other) => this.Equals(other as BackgroundTransferRequest);

    public override int GetHashCode() => this._requestId.GetHashCode();

    public override string ToString() => this._requestId;

    [SecurityCritical]
    internal void Submit()
    {
      try
      {
        this._scenarioName = !(this._method == "GET") ? "UploadScenario" : "DownloadScenario";
        BtsPerfMarkerUtil.LogScenarioStart(this._scenarioName);
        using (new AutoLogApi("BackgroundTransferService.Add"))
          this.SubmitHelper();
      }
      catch
      {
        BtsPerfMarkerUtil.LogScenarioEnd(this._scenarioName);
        this._scenarioName = (string) null;
        throw;
      }
    }

    [SecuritySafeCritical]
    internal void Cancel()
    {
      if (this._requestHandle == null || this._requestHandle.IsInvalid)
        throw new InvalidOperationException();
      RequestStatus requestStatus;
      lock (this._statusUpdateLock)
        requestStatus = this._requestStatus;
      BtsApi.CancelBackgroundTransferRequest(this._requestHandle);
      if (requestStatus.HrTransferError == 1606336 || TransferStatus.Completed != requestStatus.TransferStatus)
        return;
      this.Dispose();
    }

    [SecuritySafeCritical]
    private void UpdateStatus(RequestStatus requestStatus)
    {
      RequestStatus requestStatus1;
      lock (this._statusUpdateLock)
      {
        requestStatus1 = this._requestStatus;
        if (TransferStatus.Completed != this._requestStatus.TransferStatus)
          this._requestStatus = requestStatus;
      }
      if (requestStatus.HrTransferError == 1606336)
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.AsyncDispose));
      if ((int) requestStatus1.TotalBytesToReceive != (int) requestStatus.TotalBytesToReceive || (int) requestStatus1.BytesReceived != (int) requestStatus.BytesReceived || ((int) requestStatus1.TotalBytesToSend != (int) requestStatus.TotalBytesToSend || (int) requestStatus1.BytesSent != (int) requestStatus.BytesSent))
        this.FireEvent(this._transferProgressChangedEvent);
      if (requestStatus1.TransferStatus == requestStatus.TransferStatus)
        return;
      this.FireEvent(this._transferStatusChangedEvent);
      if (this._scenarioName == null || TransferStatus.Completed != requestStatus.TransferStatus)
        return;
      BtsPerfMarkerUtil.LogScenarioEnd(this._scenarioName);
    }

    [SecuritySafeCritical]
    private void FireEvent(EventHandler<BackgroundTransferEventArgs> handler)
    {
      if (handler == null)
        return;
      Deployment.Current.Dispatcher.BeginInvoke((Delegate) handler, (object) this, (object) new BackgroundTransferEventArgs(this));
    }

    private void SubmitHelper()
    {
      this.ThrowIfReadOnly();
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException();
      if (this._method == "GET")
      {
        if ((Uri) null == this._downloadUri)
          throw new ArgumentNullException("DownloadLocation");
      }
      else if ((Uri) null == this._uploadUri)
        throw new ArgumentNullException("UploadLocation");
      TransferParameters parameters = new TransferParameters()
      {
        RequestUri = this._requestUri,
        Tag = this._tag,
        Method = this._method,
        DownloadLocation = this._downloadUri,
        UploadLocation = this._uploadUri,
        TransferPreferences = this._preferences,
        Headers = this._headers.Serialize()
      };
      BtsRequestHandle backgroundTransferRequest = BtsApi.CreateBackgroundTransferRequest(this._requestId, ref parameters);
      try
      {
        BtsApi.NotifyBackgroundTransferRequestStatus(backgroundTransferRequest, new RequestStatusNotifyHandler(this.OnStatusChanged));
        this.UpdateStatus(BtsApi.QueryBackgroundTransferRequestStatus(backgroundTransferRequest));
      }
      catch
      {
        backgroundTransferRequest.Close();
        throw;
      }
      this._requestHandle = backgroundTransferRequest;
      this._headers.SetReadOnly();
    }

    private void ThrowIfReadOnly()
    {
      if (this._requestHandle != null)
        throw new InvalidOperationException();
    }

    [SecuritySafeCritical]
    private void AsyncDispose(object notUsed) => this.Dispose();

    [SecuritySafeCritical]
    private void OnStatusChanged(
      Exception notifyException,
      string requestId,
      RequestStatus? status)
    {
      if (notifyException != null)
      {
        try
        {
          status = new RequestStatus?(BtsApi.QueryBackgroundTransferRequestStatus(this._requestHandle));
        }
        catch
        {
        }
        if (!status.HasValue || TransferStatus.Completed != status.Value.TransferStatus)
        {
          RequestStatus requestStatus;
          lock (this._statusUpdateLock)
            requestStatus = this._requestStatus;
          requestStatus.TransferError = notifyException;
          requestStatus.TransferStatus = TransferStatus.Unknown;
          status = new RequestStatus?(requestStatus);
        }
        requestId = this._requestId;
      }
      this.UpdateStatus(status.Value);
    }

    private class RequestHeaders : 
      IDictionary<string, string>,
      ICollection<KeyValuePair<string, string>>,
      IEnumerable<KeyValuePair<string, string>>,
      IEnumerable
    {
      private IDictionary<string, string> _headers;
      private bool _isReadOnly;
      private static readonly string[] _reservedHeaders = new string[5]
      {
        "If-Modified-Since",
        "If-None-Match",
        "If-Range",
        "Range",
        "Unless-Modified-Since"
      };
      private static readonly char[] _invalidHeaderNameChars = new char[22]
      {
        '(',
        ')',
        '<',
        '>',
        '@',
        ',',
        ';',
        ':',
        '\\',
        '"',
        '\'',
        '/',
        '[',
        ']',
        '?',
        '=',
        '{',
        '}',
        ' ',
        '\t',
        '\r',
        '\n'
      };

      private RequestHeaders(IDictionary<string, string> headers) => this._headers = headers;

      public RequestHeaders()
        : this((IDictionary<string, string>) new Dictionary<string, string>())
      {
      }

      public RequestHeaders(IList<string> headers)
        : this(BackgroundTransferRequest.RequestHeaders.DeserializeHeaders(headers))
      {
        this._isReadOnly = true;
      }

      public IList<string> Serialize()
      {
        List<string> stringList = new List<string>(this._headers.Count);
        foreach (KeyValuePair<string, string> header in (IEnumerable<KeyValuePair<string, string>>) this._headers)
          stringList.Add(string.Format("{0}: {1}\r\n", (object) header.Key, (object) header.Value));
        return (IList<string>) stringList;
      }

      public void SetReadOnly() => this._isReadOnly = true;

      public void Add(string key, string value)
      {
        this.ThrowIfReadOnly();
        BackgroundTransferRequest.RequestHeaders.ThrowIfInvalidHeaderName(key);
        this._headers.Add(key, BackgroundTransferRequest.RequestHeaders.ValidateAndNormalizeHeaderValue(value));
      }

      public bool ContainsKey(string key) => this._headers.ContainsKey(key);

      public ICollection<string> Keys => this._headers.Keys;

      public bool Remove(string key)
      {
        this.ThrowIfReadOnly();
        return this._headers.Remove(key);
      }

      public bool TryGetValue(string key, out string value) => this._headers.TryGetValue(key, out value);

      public ICollection<string> Values => this._headers.Values;

      public string this[string key]
      {
        get => this._headers[key];
        set
        {
          this.ThrowIfReadOnly();
          BackgroundTransferRequest.RequestHeaders.ThrowIfInvalidHeaderName(key);
          this._headers[key] = BackgroundTransferRequest.RequestHeaders.ValidateAndNormalizeHeaderValue(value);
        }
      }

      public void Add(KeyValuePair<string, string> item)
      {
        this.ThrowIfReadOnly();
        BackgroundTransferRequest.RequestHeaders.ThrowIfInvalidHeaderName(item.Key);
        this._headers.Add(item.Key, BackgroundTransferRequest.RequestHeaders.ValidateAndNormalizeHeaderValue(item.Value));
      }

      public void Clear()
      {
        this.ThrowIfReadOnly();
        this._headers.Clear();
      }

      public bool Contains(KeyValuePair<string, string> item) => this._headers.Contains(item);

      public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => this._headers.CopyTo(array, arrayIndex);

      public int Count => this._headers.Count;

      public bool IsReadOnly => this._isReadOnly;

      public bool Remove(KeyValuePair<string, string> item)
      {
        this.ThrowIfReadOnly();
        return ((ICollection<KeyValuePair<string, string>>) this._headers).Remove(item);
      }

      public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => this._headers.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => this._headers.GetEnumerator();

      private void ThrowIfReadOnly()
      {
        if (this._isReadOnly)
          throw new InvalidOperationException();
      }

      private static IDictionary<string, string> DeserializeHeaders(
        IList<string> headersList)
      {
        Dictionary<string, string> dictionary = new Dictionary<string, string>(headersList.Count, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
        foreach (string headers in (IEnumerable<string>) headersList)
        {
          int length = headers.IndexOf(':');
          string key = headers.Substring(0, length);
          string str = headers.Substring(length + 1).Trim();
          dictionary.Add(key, str);
        }
        return (IDictionary<string, string>) dictionary;
      }

      private static void ThrowIfInvalidHeaderName(string name)
      {
        if (string.IsNullOrEmpty(name))
          throw new ArgumentNullException();
        foreach (string reservedHeader in BackgroundTransferRequest.RequestHeaders._reservedHeaders)
        {
          if (string.Equals(reservedHeader, name, StringComparison.OrdinalIgnoreCase))
            throw new NotSupportedException(name);
        }
        if (name.IndexOfAny(BackgroundTransferRequest.RequestHeaders._invalidHeaderNameChars) != -1)
          throw new ArgumentException();
        for (int index = 0; index < name.Length; ++index)
        {
          if (name[index] < ' ' || name[index] > '~')
            throw new ArgumentException();
        }
      }

      private static string ValidateAndNormalizeHeaderValue(string headerValue)
      {
        if (string.IsNullOrEmpty(headerValue))
          return string.Empty;
        headerValue = headerValue.Trim();
        int num = 0;
        for (int index = 0; index < headerValue.Length; ++index)
        {
          char ch = (char) ((uint) byte.MaxValue & (uint) headerValue[index]);
          switch (num)
          {
            case 0:
              if (ch == '\r')
              {
                num = 1;
                break;
              }
              if (ch == '\n')
                throw new ArgumentException();
              if (ch == '\u007F' || ch < ' ' && ch != '\t')
                throw new ArgumentException();
              break;
            case 1:
              if (ch != '\n')
                throw new ArgumentException();
              num = 2;
              break;
            case 2:
              if (ch != ' ' && ch != '\t')
                throw new ArgumentException();
              num = 0;
              break;
          }
        }
        if (num != 0)
          throw new ArgumentException();
        return headerValue;
      }
    }
  }
}
