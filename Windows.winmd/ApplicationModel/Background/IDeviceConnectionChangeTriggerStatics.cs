// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceConnectionChangeTriggerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (DeviceConnectionChangeTrigger))]
  [Guid(3286901866, 20221, 17560, 170, 96, 164, 228, 227, 177, 122, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceConnectionChangeTriggerStatics
  {
    [RemoteAsync]
    IAsyncOperation<DeviceConnectionChangeTrigger> FromIdAsync(
      string deviceId);
  }
}
