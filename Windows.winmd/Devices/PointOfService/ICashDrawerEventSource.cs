// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerEventSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (CashDrawerEventSource))]
  [Guid(3758548076, 62201, 17455, 141, 214, 6, 193, 10, 66, 39, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICashDrawerEventSource
  {
    event TypedEventHandler<CashDrawerEventSource, CashDrawerClosedEventArgs> DrawerClosed;

    event TypedEventHandler<CashDrawerEventSource, CashDrawerOpenedEventArgs> DrawerOpened;
  }
}
