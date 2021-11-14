// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceServicingTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(447879085, 28212, 18899, 158, 111, 23, 241, 182, 223, 168, 129)]
  [ExclusiveTo(typeof (DeviceServicingTrigger))]
  internal interface IDeviceServicingTrigger : IBackgroundTrigger
  {
    [Overload("RequestAsyncSimple")]
    [DefaultOverload]
    [RemoteAsync]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration);

    [DefaultOverload]
    [Overload("RequestAsyncWithArguments")]
    [RemoteAsync]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration,
      string arguments);
  }
}
