// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1558501552, 42121, 19350, 134, 196, 240, 191, 138, 55, 117, 61)]
  [ExclusiveTo(typeof (BarcodeScannerReport))]
  internal interface IBarcodeScannerReport
  {
    uint ScanDataType { get; }

    IBuffer ScanData { get; }

    IBuffer ScanDataLabel { get; }
  }
}
