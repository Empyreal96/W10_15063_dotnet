// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.System.RemoteSystems;

namespace Windows.ApplicationModel.AppService
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppServiceConnection : IAppServiceConnection, IClosable, IAppServiceConnection2
  {
    [MethodImpl]
    public extern AppServiceConnection();

    public extern string AppServiceName { [MethodImpl] get; [MethodImpl] set; }

    public extern string PackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceConnectionStatus> OpenAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceResponse> SendMessageAsync(
      ValueSet message);

    public extern event TypedEventHandler<AppServiceConnection, AppServiceRequestReceivedEventArgs> RequestReceived;

    public extern event TypedEventHandler<AppServiceConnection, AppServiceClosedEventArgs> ServiceClosed;

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceConnectionStatus> OpenRemoteAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest);

    public extern User User { [MethodImpl] get; [MethodImpl] set; }
  }
}
