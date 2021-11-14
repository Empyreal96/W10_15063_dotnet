// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedLineDisplayStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedLineDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2026543355, 35691, 18803, 134, 240, 62, 87, 12, 53, 24, 37)]
  internal interface IClaimedLineDisplayStatics
  {
    [RemoteAsync]
    IAsyncOperation<ClaimedLineDisplay> FromIdAsync(string deviceId);

    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
