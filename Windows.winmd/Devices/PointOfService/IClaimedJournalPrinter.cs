// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedJournalPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1743390256, 20861, 18559, 159, 223, 210, 224, 160, 162, 100, 165)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ClaimedJournalPrinter))]
  internal interface IClaimedJournalPrinter : ICommonClaimedPosPrinterStation
  {
    JournalPrintJob CreateJob();
  }
}
