// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScanner2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (BarcodeScanner))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2300662119, 36078, 17261, 137, 171, 141, 251, 67, 187, 66, 134)]
  internal interface IBarcodeScanner2
  {
    string VideoDeviceId { get; }
  }
}
