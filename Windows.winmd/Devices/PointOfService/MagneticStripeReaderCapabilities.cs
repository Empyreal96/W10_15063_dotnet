// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MagneticStripeReaderCapabilities : IMagneticStripeReaderCapabilities
  {
    public extern string CardAuthentication { [MethodImpl] get; }

    public extern uint SupportedEncryptionAlgorithms { [MethodImpl] get; }

    public extern MagneticStripeReaderAuthenticationLevel AuthenticationLevel { [MethodImpl] get; }

    public extern bool IsIsoSupported { [MethodImpl] get; }

    public extern bool IsJisOneSupported { [MethodImpl] get; }

    public extern bool IsJisTwoSupported { [MethodImpl] get; }

    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    public extern bool IsTrackDataMaskingSupported { [MethodImpl] get; }

    public extern bool IsTransmitSentinelsSupported { [MethodImpl] get; }
  }
}
