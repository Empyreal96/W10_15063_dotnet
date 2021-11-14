// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.DevicePortalConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IDevicePortalConnectionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DevicePortalConnection : IDevicePortalConnection
  {
    public extern event TypedEventHandler<DevicePortalConnection, DevicePortalConnectionClosedEventArgs> Closed;

    public extern event TypedEventHandler<DevicePortalConnection, DevicePortalConnectionRequestReceivedEventArgs> RequestReceived;

    [MethodImpl]
    public static extern DevicePortalConnection GetForAppServiceConnection(
      AppServiceConnection appServiceConnection);
  }
}
