// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerStatusUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BarcodeScannerStatusUpdatedEventArgs))]
  [Guid(895321478, 40003, 17963, 169, 26, 129, 109, 201, 127, 69, 44)]
  internal interface IBarcodeScannerStatusUpdatedEventArgs
  {
    BarcodeScannerStatus Status { get; }

    uint ExtendedStatus { get; }
  }
}
