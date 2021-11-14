// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderEncryptionAlgorithmsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReaderEncryptionAlgorithms))]
  [Guid(1404400464, 50139, 18260, 156, 0, 65, 57, 35, 116, 161, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderEncryptionAlgorithmsStatics
  {
    uint None { get; }

    uint TripleDesDukpt { get; }

    uint ExtendedBase { get; }
  }
}
