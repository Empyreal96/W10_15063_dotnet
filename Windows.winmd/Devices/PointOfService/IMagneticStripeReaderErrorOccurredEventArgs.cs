// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderErrorOccurredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(535689565, 11396, 16813, 183, 120, 242, 53, 106, 120, 154, 177)]
  [ExclusiveTo(typeof (MagneticStripeReaderErrorOccurredEventArgs))]
  internal interface IMagneticStripeReaderErrorOccurredEventArgs
  {
    MagneticStripeReaderTrackErrorType Track1Status { get; }

    MagneticStripeReaderTrackErrorType Track2Status { get; }

    MagneticStripeReaderTrackErrorType Track3Status { get; }

    MagneticStripeReaderTrackErrorType Track4Status { get; }

    UnifiedPosErrorData ErrorData { get; }

    MagneticStripeReaderReport PartialInputData { get; }
  }
}
