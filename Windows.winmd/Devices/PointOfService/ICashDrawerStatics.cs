// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (CashDrawer))]
  [Guid(3751843162, 54327, 20479, 181, 71, 221, 169, 105, 164, 248, 131)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICashDrawerStatics
  {
    [RemoteAsync]
    IAsyncOperation<CashDrawer> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<CashDrawer> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
