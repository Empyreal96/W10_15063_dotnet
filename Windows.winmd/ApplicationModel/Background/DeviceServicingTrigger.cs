// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceServicingTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DeviceServicingTrigger : IDeviceServicingTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern DeviceServicingTrigger();

    [Overload("RequestAsyncSimple")]
    [DefaultOverload]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration);

    [RemoteAsync]
    [DefaultOverload]
    [Overload("RequestAsyncWithArguments")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration,
      string arguments);
  }
}
