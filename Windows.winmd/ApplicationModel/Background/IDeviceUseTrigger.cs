// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceUseTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (DeviceUseTrigger))]
  [Guid(229015569, 13135, 19799, 182, 236, 109, 202, 100, 180, 18, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceUseTrigger : IBackgroundTrigger
  {
    [RemoteAsync]
    [DefaultOverload]
    [Overload("RequestAsyncSimple")]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId);

    [Overload("RequestAsyncWithArguments")]
    [RemoteAsync]
    [DefaultOverload]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      string arguments);
  }
}
