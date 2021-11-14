// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IJournalPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(995937347, 57415, 17507, 187, 88, 23, 181, 186, 29, 128, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (JournalPrinterCapabilities))]
  internal interface IJournalPrinterCapabilities : ICommonPosPrintStationCapabilities
  {
  }
}
