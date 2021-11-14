// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderStatusUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(164391856, 12898, 16413, 158, 138, 232, 13, 99, 88, 144, 107)]
  [ExclusiveTo(typeof (MagneticStripeReaderStatusUpdatedEventArgs))]
  internal interface IMagneticStripeReaderStatusUpdatedEventArgs
  {
    MagneticStripeReaderStatus Status { get; }

    uint ExtendedStatus { get; }
  }
}
