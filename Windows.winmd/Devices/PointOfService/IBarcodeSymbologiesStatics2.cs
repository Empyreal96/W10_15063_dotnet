// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeSymbologiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (BarcodeSymbologies))]
  [Guid(2339707124, 39376, 16575, 148, 36, 185, 29, 109, 212, 198, 224)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IBarcodeSymbologiesStatics2
  {
    uint Gs1DWCode { get; }
  }
}
