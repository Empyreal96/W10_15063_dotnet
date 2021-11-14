// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderAamvaCardDataReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MagneticStripeReaderAamvaCardDataReceivedEventArgs))]
  [Guid(172735825, 49942, 18704, 135, 243, 122, 98, 186, 134, 45, 49)]
  internal interface IMagneticStripeReaderAamvaCardDataReceivedEventArgs
  {
    MagneticStripeReaderReport Report { get; }

    string LicenseNumber { get; }

    string ExpirationDate { get; }

    string Restrictions { get; }

    string Class { get; }

    string Endorsements { get; }

    string BirthDate { get; }

    string FirstName { get; }

    string Surname { get; }

    string Suffix { get; }

    string Gender { get; }

    string HairColor { get; }

    string EyeColor { get; }

    string Height { get; }

    string Weight { get; }

    string Address { get; }

    string City { get; }

    string State { get; }

    string PostalCode { get; }
  }
}
