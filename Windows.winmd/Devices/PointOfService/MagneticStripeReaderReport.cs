// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderReport : IMagneticStripeReaderReport
  {
    public extern uint CardType { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackData Track1 { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackData Track2 { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackData Track3 { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackData Track4 { [MethodImpl] get; }

    public extern IMapView<string, string> Properties { [MethodImpl] get; }

    public extern IBuffer CardAuthenticationData { [MethodImpl] get; }

    public extern uint CardAuthenticationDataLength { [MethodImpl] get; }

    public extern IBuffer AdditionalSecurityInformation { [MethodImpl] get; }
  }
}
