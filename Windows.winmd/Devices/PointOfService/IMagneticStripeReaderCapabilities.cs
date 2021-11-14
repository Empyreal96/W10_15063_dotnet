// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReaderCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1898479772, 50240, 17570, 164, 103, 70, 145, 117, 208, 40, 150)]
  internal interface IMagneticStripeReaderCapabilities
  {
    string CardAuthentication { get; }

    uint SupportedEncryptionAlgorithms { get; }

    MagneticStripeReaderAuthenticationLevel AuthenticationLevel { get; }

    bool IsIsoSupported { get; }

    bool IsJisOneSupported { get; }

    bool IsJisTwoSupported { get; }

    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    bool IsTrackDataMaskingSupported { get; }

    bool IsTransmitSentinelsSupported { get; }
  }
}
