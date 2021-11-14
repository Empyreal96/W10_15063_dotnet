// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3522217776, 55872, 17192, 191, 118, 81, 86, 250, 51, 183, 71)]
  [ExclusiveTo(typeof (PosPrinterStatus))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPosPrinterStatus
  {
    PosPrinterStatusKind StatusKind { get; }

    uint ExtendedStatus { get; }
  }
}
