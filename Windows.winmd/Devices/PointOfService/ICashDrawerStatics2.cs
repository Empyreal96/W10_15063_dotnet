// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1048674593, 35906, 16616, 156, 14, 64, 41, 112, 72, 16, 76)]
  [ExclusiveTo(typeof (CashDrawer))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICashDrawerStatics2
  {
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
