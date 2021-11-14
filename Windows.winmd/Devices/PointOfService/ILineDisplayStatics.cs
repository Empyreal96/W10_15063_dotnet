// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(36552886, 4528, 18064, 149, 71, 11, 57, 197, 175, 33, 20)]
  internal interface ILineDisplayStatics
  {
    [RemoteAsync]
    IAsyncOperation<LineDisplay> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<LineDisplay> GetDefaultAsync();

    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
