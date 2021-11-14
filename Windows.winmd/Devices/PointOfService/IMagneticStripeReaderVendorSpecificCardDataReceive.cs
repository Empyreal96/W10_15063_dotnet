// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderVendorSpecificCardDataReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs))]
  [Guid(2936689940, 22988, 19040, 153, 232, 153, 165, 61, 172, 229, 170)]
  internal interface IMagneticStripeReaderVendorSpecificCardDataReceivedEventArgs
  {
    MagneticStripeReaderReport Report { get; }
  }
}
