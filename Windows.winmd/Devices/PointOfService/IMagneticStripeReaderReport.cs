// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Guid(1784373319, 39344, 16776, 190, 241, 237, 223, 121, 247, 143, 230)]
  [ExclusiveTo(typeof (MagneticStripeReaderReport))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderReport
  {
    uint CardType { get; }

    MagneticStripeReaderTrackData Track1 { get; }

    MagneticStripeReaderTrackData Track2 { get; }

    MagneticStripeReaderTrackData Track3 { get; }

    MagneticStripeReaderTrackData Track4 { get; }

    IMapView<string, string> Properties { get; }

    IBuffer CardAuthenticationData { get; }

    uint CardAuthenticationDataLength { get; }

    IBuffer AdditionalSecurityInformation { get; }
  }
}
