// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderErrorOccurredEventArgs : 
    IMagneticStripeReaderErrorOccurredEventArgs
  {
    public extern MagneticStripeReaderTrackErrorType Track1Status { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackErrorType Track2Status { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackErrorType Track3Status { [MethodImpl] get; }

    public extern MagneticStripeReaderTrackErrorType Track4Status { [MethodImpl] get; }

    public extern UnifiedPosErrorData ErrorData { [MethodImpl] get; }

    public extern MagneticStripeReaderReport PartialInputData { [MethodImpl] get; }
  }
}
