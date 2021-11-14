// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Notification.HttpNotificationChannel
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Xml;

namespace Microsoft.Phone.Notification
{
  public class HttpNotificationChannel : IDisposable
  {
    private uint channelId;
    private string name;
    private string serviceName;
    private Uri uri;
    private ChannelConnectionStatus connectionStatus = ChannelConnectionStatus.Disconnected;
    private bool disposed;
    private static readonly object syncRoot = new object();
    private static int instanceCount;
    private static SafeNativeMethods.ReverseHandler reverseHandler;
    [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "More code efficient to initialize with declaration since we have too many constructors")]
    private static readonly Dictionary<uint, HttpNotificationChannel.NotificationChannelHandler> callbackDictionary = new Dictionary<uint, HttpNotificationChannel.NotificationChannelHandler>();

    [SecuritySafeCritical]
    public static HttpNotificationChannel Find(string channelName)
    {
      uint channelId = 0;
      HttpNotificationChannel notificationChannel = (HttpNotificationChannel) null;
      HttpNotificationChannel.Initialize();
      try
      {
        int channel = SafeNativeMethods.PushInteropFindChannel(channelName, out channelId);
        SafeNativeMethods.ThrowExceptionFromHResult(channel);
        if (channel != 1)
        {
          if (channelId != 0U)
            notificationChannel = new HttpNotificationChannel(channelName, channelId);
        }
      }
      finally
      {
        HttpNotificationChannel.Uninitialize();
      }
      return notificationChannel;
    }

    [SecuritySafeCritical]
    static HttpNotificationChannel()
    {
    }

    [SecuritySafeCritical]
    public HttpNotificationChannel(string channelName)
      : this(channelName, string.Empty)
    {
    }

    [SecuritySafeCritical]
    public HttpNotificationChannel(string channelName, string serviceName)
    {
      this.name = channelName;
      this.serviceName = serviceName;
      HttpNotificationChannel.Initialize();
    }

    [SecuritySafeCritical]
    ~HttpNotificationChannel() => this.Dispose(false);

    [SecuritySafeCritical]
    public void Open()
    {
      uint channelId = 0;
      lock (((ICollection) HttpNotificationChannel.callbackDictionary).SyncRoot)
      {
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.PushInteropOpenChannel(this.name, this.serviceName, out channelId), (Exception) new InvalidOperationException(LocalizeString.PushNotificationChannelOpenFailed));
        this.channelId = channelId != 0U ? channelId : throw new InvalidOperationException(LocalizeString.PushNotificationChannelOpenFailed);
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
    }

    [SecuritySafeCritical]
    public void Close()
    {
      if (this.IsShellTileBound)
        this.UnbindToShellTile();
      if (this.IsShellToastBound)
        this.UnbindToShellToast();
      SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.PushInteropCloseChannel(this.channelId));
      HttpNotificationChannel.RemoveCallback(this.channelId);
      this.channelId = 0U;
    }

    public void BindToShellTile()
    {
    }

    public void BindToShellTile(Collection<Uri> baseUri)
    {
    }

    public void BindToShellToast()
    {
    }

    public void UnbindToShellTile()
    {
    }

    public void UnbindToShellToast()
    {
    }

    public bool IsShellTileBound => true;

    public bool IsShellToastBound => true;

    public string ChannelName => this.name;

    public Uri ChannelUri
    {
      [SecuritySafeCritical] get
      {
        if (this.uri == (Uri) null)
        {
          IntPtr channelUri1 = IntPtr.Zero;
          uint channelUriSize = 0;
          try
          {
            int channelUri2 = SafeNativeMethods.PushInteropGetChannelUri(this.channelId, out channelUri1, out channelUriSize);
            if (channelUri2 != -2129590009)
            {
              SafeNativeMethods.ThrowExceptionFromHResult(channelUri2);
              if (channelUri1 != IntPtr.Zero)
                this.uri = HttpNotificationChannel.GetChannelUriFromPtr(channelUri1, channelUriSize);
            }
          }
          finally
          {
            if (channelUri1 != IntPtr.Zero)
              SafeNativeMethods.PushInteropFreeMemory(ref channelUri1);
            channelUri1 = IntPtr.Zero;
          }
        }
        return this.uri;
      }
    }

    public ChannelConnectionStatus ConnectionStatus
    {
      [SecuritySafeCritical] get
      {
        bool connectionStatus;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.PushInteropGetConnectionStatus(this.channelId, out connectionStatus));
        return !connectionStatus ? ChannelConnectionStatus.Disconnected : ChannelConnectionStatus.Connected;
      }
    }

    [SecuritySafeCritical]
    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", Justification = "Best effort in dispose")]
    [SecurityCritical]
    private void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      HttpNotificationChannel.Uninitialize();
      if (disposing)
        HttpNotificationChannel.RemoveCallback(this.channelId);
      this.channelId = 0U;
      this.disposed = true;
    }

    public event EventHandler<NotificationChannelErrorEventArgs> ErrorOccurred
    {
      [SecuritySafeCritical] add
      {
        this.errorOccurredEvent += value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
      [SecuritySafeCritical] remove
      {
        this.errorOccurredEvent -= value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
    }

    public event EventHandler<NotificationChannelUriEventArgs> ChannelUriUpdated
    {
      [SecuritySafeCritical] add
      {
        this.channelUriUpdatedEvent += value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
      [SecuritySafeCritical] remove
      {
        this.channelUriUpdatedEvent -= value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
    }

    public event EventHandler<NotificationChannelConnectionEventArgs> ConnectionStatusChanged
    {
      [SecuritySafeCritical] add
      {
        this.connectionStatusChangedEvent += value;
        HttpNotificationChannel.CheckAndAddCallback(this);
        this.OnConnectionStatusChanged(true);
      }
      [SecuritySafeCritical] remove
      {
        this.connectionStatusChangedEvent -= value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
    }

    public event EventHandler<HttpNotificationEventArgs> HttpNotificationReceived
    {
      [SecuritySafeCritical] add
      {
        this.rawHttpNotificationReceivedEvent += value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
      [SecuritySafeCritical] remove
      {
        this.rawHttpNotificationReceivedEvent -= value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
    }

    public event EventHandler<NotificationEventArgs> ShellToastNotificationReceived
    {
      [SecuritySafeCritical] add
      {
        this.toastHttpNotificationReceivedEvent += value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
      [SecuritySafeCritical] remove
      {
        this.toastHttpNotificationReceivedEvent -= value;
        HttpNotificationChannel.CheckAndAddCallback(this);
      }
    }

    private event EventHandler<NotificationChannelErrorEventArgs> errorOccurredEvent;

    private event EventHandler<NotificationChannelUriEventArgs> channelUriUpdatedEvent;

    private event EventHandler<HttpNotificationEventArgs> rawHttpNotificationReceivedEvent;

    private event EventHandler<NotificationEventArgs> toastHttpNotificationReceivedEvent;

    private event EventHandler<NotificationChannelConnectionEventArgs> connectionStatusChangedEvent;

    [SecuritySafeCritical]
    internal static void Initialize()
    {
      lock (HttpNotificationChannel.syncRoot)
      {
        if (HttpNotificationChannel.instanceCount == 0)
        {
          HttpNotificationChannel.reverseHandler = new SafeNativeMethods.ReverseHandler(HttpNotificationChannel.DispatchCallback);
          SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.PushInteropInitialize(HttpNotificationChannel.reverseHandler));
        }
        ++HttpNotificationChannel.instanceCount;
      }
    }

    [SecurityCritical]
    internal static void Uninitialize()
    {
      lock (HttpNotificationChannel.syncRoot)
      {
        --HttpNotificationChannel.instanceCount;
        if (HttpNotificationChannel.instanceCount < 0)
          HttpNotificationChannel.instanceCount = 0;
        if (HttpNotificationChannel.instanceCount != 0)
          return;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.PushInteropUninitialize());
      }
    }

    [SecurityCritical]
    private static void CheckAndAddCallback(HttpNotificationChannel channel)
    {
      if (channel.rawHttpNotificationReceivedEvent != null || channel.toastHttpNotificationReceivedEvent != null || (channel.errorOccurredEvent != null || channel.channelUriUpdatedEvent != null) || channel.connectionStatusChangedEvent != null)
        HttpNotificationChannel.AddCallback(channel.ChannelId, new HttpNotificationChannel.NotificationChannelHandler(channel.ChannelHandler));
      else
        HttpNotificationChannel.RemoveCallback(channel.ChannelId);
    }

    [SecuritySafeCritical]
    internal static void AddCallback(
      uint channelId,
      HttpNotificationChannel.NotificationChannelHandler channelHandler)
    {
      if (channelId == 0U)
        return;
      lock (((ICollection) HttpNotificationChannel.callbackDictionary).SyncRoot)
      {
        if (HttpNotificationChannel.callbackDictionary.ContainsKey(channelId))
          return;
        HttpNotificationChannel.callbackDictionary.Add(channelId, channelHandler);
      }
    }

    [SecurityCritical]
    internal static void RemoveCallback(uint channelId)
    {
      if (channelId == 0U)
        return;
      lock (((ICollection) HttpNotificationChannel.callbackDictionary).SyncRoot)
      {
        if (!HttpNotificationChannel.callbackDictionary.ContainsKey(channelId))
          return;
        HttpNotificationChannel.callbackDictionary.Remove(channelId);
      }
    }

    [SecurityCritical]
    internal static void RemoveAllCallback()
    {
      lock (((ICollection) HttpNotificationChannel.callbackDictionary).SyncRoot)
        HttpNotificationChannel.callbackDictionary.Clear();
    }

    [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Catch all exception before returning callback to Native")]
    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal static void DispatchCallback(
      uint channelId,
      uint eventType,
      IntPtr blob1,
      uint blobSize1)
    {
      try
      {
        HttpNotificationChannel.DispatchObject dispatchObject;
        dispatchObject.channelId = channelId;
        dispatchObject.eventType = eventType;
        dispatchObject.blob1 = blob1;
        dispatchObject.blobSize1 = blobSize1;
        ThreadPool.QueueUserWorkItem(new WaitCallback(HttpNotificationChannel.Dispatch), (object) dispatchObject);
      }
      catch (Exception ex)
      {
      }
    }

    [SecuritySafeCritical]
    internal static void Dispatch(object threadContext)
    {
      HttpNotificationChannel.DispatchObject dispatchObject = (HttpNotificationChannel.DispatchObject) threadContext;
      try
      {
        HttpNotificationChannel.NotificationChannelHandler notificationChannelHandler = (HttpNotificationChannel.NotificationChannelHandler) null;
        lock (((ICollection) HttpNotificationChannel.callbackDictionary).SyncRoot)
        {
          if (HttpNotificationChannel.callbackDictionary.ContainsKey(dispatchObject.channelId))
            notificationChannelHandler = HttpNotificationChannel.callbackDictionary[dispatchObject.channelId];
        }
        if (notificationChannelHandler == null)
          return;
        notificationChannelHandler(dispatchObject.eventType, dispatchObject.blob1, dispatchObject.blobSize1);
      }
      finally
      {
        if (dispatchObject.blob1 != IntPtr.Zero)
          SafeNativeMethods.PushInteropFreeMemory(ref dispatchObject.blob1);
      }
    }

    [SecurityCritical]
    internal static string TrimString(string input)
    {
      int length = input.IndexOf(char.MinValue);
      return length < 0 ? input : input.Substring(0, length);
    }

    [SecurityCritical]
    private static Uri GetChannelUriFromPtr(IntPtr channelUriPtr, uint channelUriSize)
    {
      if (channelUriPtr == IntPtr.Zero || channelUriSize == 0U)
        return (Uri) null;
      byte[] numArray = new byte[(int) channelUriSize];
      Marshal.Copy(channelUriPtr, numArray, 0, (int) channelUriSize);
      return new Uri(HttpNotificationChannel.TrimString(Encoding.UTF8.GetString(numArray, 0, (int) channelUriSize)));
    }

    [SecurityCritical]
    private HttpNotificationChannel(string channelName, uint channelId)
    {
      this.name = channelName;
      this.channelId = channelId;
      HttpNotificationChannel.Initialize();
    }

    [SecurityCritical]
    internal void ChannelHandler(uint eventType, IntPtr blob1, uint int1)
    {
      switch (eventType)
      {
        case 0:
          this.OnChannelUriReceived(blob1, int1);
          break;
        case 1:
          this.OnToastNotificationReceived(blob1, int1);
          break;
        case 2:
          this.OnRawNotificationReceived(blob1, int1);
          break;
        case 3:
          this.OnConnectionStatusChanged(blob1, int1);
          break;
        default:
          throw new ArgumentException("", nameof (eventType));
      }
    }

    [SecurityCritical]
    private void OnRawNotificationReceived(IntPtr blob1, uint blobSize1)
    {
      HttpNotification notif = (HttpNotification) null;
      EventHandler<HttpNotificationEventArgs> eventHandler = (EventHandler<HttpNotificationEventArgs>) null;
      if (this.rawHttpNotificationReceivedEvent != null)
      {
        notif = new HttpNotification();
        notif.Channel = this;
        WebHeaderCollection headerCollection = new WebHeaderCollection();
        notif.Headers = headerCollection;
        if (blob1 != IntPtr.Zero && blobSize1 != 0U)
        {
          byte[] numArray = new byte[(int) blobSize1];
          Marshal.Copy(blob1, numArray, 0, (int) blobSize1);
          MemoryStream memoryStream = new MemoryStream(numArray);
          notif.Body = (Stream) memoryStream;
        }
        else
          notif.Body = (Stream) null;
        eventHandler = this.rawHttpNotificationReceivedEvent;
      }
      if (eventHandler == null || blobSize1 == 0U)
        return;
      eventHandler((object) this, new HttpNotificationEventArgs(notif));
    }

    [SecurityCritical]
    private void OnToastNotificationReceived(IntPtr blob, uint blobSize)
    {
      EventHandler<NotificationEventArgs> eventHandler = (EventHandler<NotificationEventArgs>) null;
      IDictionary<string, string> propertyBag = (IDictionary<string, string>) null;
      if (this.toastHttpNotificationReceivedEvent != null)
      {
        byte[] numArray = new byte[(int) blobSize];
        Marshal.Copy(blob, numArray, 0, (int) blobSize);
        string xmlString = HttpNotificationChannel.TrimString(Encoding.UTF8.GetString(numArray, 0, (int) blobSize));
        try
        {
          HttpNotificationChannel.ParseXMLToProperties(xmlString, out propertyBag);
          eventHandler = this.toastHttpNotificationReceivedEvent;
        }
        catch (XmlException ex)
        {
        }
      }
      if (eventHandler == null)
        return;
      eventHandler((object) this, new NotificationEventArgs(propertyBag));
    }

    [SecurityCritical]
    internal static void ParseXMLToProperties(
      string xmlString,
      out IDictionary<string, string> propertyBag)
    {
      propertyBag = (IDictionary<string, string>) new Dictionary<string, string>();
      XmlReader xmlReader = XmlReader.Create((TextReader) new StringReader(xmlString), new XmlReaderSettings()
      {
        ConformanceLevel = ConformanceLevel.Document,
        IgnoreWhitespace = true,
        IgnoreComments = true
      });
      string empty = string.Empty;
      while (xmlReader.Read())
      {
        switch (xmlReader.NodeType)
        {
          case XmlNodeType.Element:
            empty = xmlReader.Name.ToString();
            if (!xmlReader.IsEmptyElement)
              continue;
            continue;
          case XmlNodeType.Text:
            string str = xmlReader.Value.ToString();
            if (!propertyBag.ContainsKey(empty))
            {
              propertyBag.Add(new KeyValuePair<string, string>(empty, str));
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }

    [SecurityCritical]
    private void OnChannelUriReceived(IntPtr blob, uint blobSize)
    {
      IntPtr channelUriPtr = blob;
      uint channelUriSize = blobSize;
      EventHandler<NotificationChannelUriEventArgs> eventHandler = (EventHandler<NotificationChannelUriEventArgs>) null;
      if (channelUriPtr != IntPtr.Zero)
      {
        Uri channelUriFromPtr = HttpNotificationChannel.GetChannelUriFromPtr(channelUriPtr, channelUriSize);
        if (!channelUriFromPtr.Equals((object) this.uri) && this.channelUriUpdatedEvent != null)
        {
          this.uri = channelUriFromPtr;
          eventHandler = this.channelUriUpdatedEvent;
        }
      }
      if (eventHandler == null)
        return;
      eventHandler((object) this, new NotificationChannelUriEventArgs(this.uri));
    }

    [SecurityCritical]
    private void OnConnectionStatusChanged(IntPtr blob, uint blobSize)
    {
      if (!(blob == IntPtr.Zero))
        return;
      this.OnConnectionStatusChanged(blobSize > 0U);
    }

    private void OnConnectionStatusChanged(bool status)
    {
      EventHandler<NotificationChannelConnectionEventArgs> eventHandler = (EventHandler<NotificationChannelConnectionEventArgs>) null;
      ChannelConnectionStatus status1 = status ? ChannelConnectionStatus.Connected : ChannelConnectionStatus.Disconnected;
      if (status1 != this.connectionStatus && this.connectionStatusChangedEvent != null)
      {
        this.connectionStatus = status1;
        eventHandler = this.connectionStatusChangedEvent;
      }
      if (eventHandler == null)
        return;
      eventHandler((object) this, new NotificationChannelConnectionEventArgs(status1));
    }

    internal uint ChannelId => this.channelId;

    private struct DispatchObject
    {
      public uint channelId;
      public uint eventType;
      public IntPtr blob1;
      public uint blobSize1;
    }

    [SecurityCritical]
    internal delegate void NotificationChannelHandler(uint eventType, IntPtr blob1, uint blobSize1);
  }
}
