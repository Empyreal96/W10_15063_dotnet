// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs
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
  public sealed class MagneticStripeReaderAamvaCardDataReceivedEventArgs : 
    IMagneticStripeReaderAamvaCardDataReceivedEventArgs
  {
    public extern MagneticStripeReaderReport Report { [MethodImpl] get; }

    public extern string LicenseNumber { [MethodImpl] get; }

    public extern string ExpirationDate { [MethodImpl] get; }

    public extern string Restrictions { [MethodImpl] get; }

    public extern string Class { [MethodImpl] get; }

    public extern string Endorsements { [MethodImpl] get; }

    public extern string BirthDate { [MethodImpl] get; }

    public extern string FirstName { [MethodImpl] get; }

    public extern string Surname { [MethodImpl] get; }

    public extern string Suffix { [MethodImpl] get; }

    public extern string Gender { [MethodImpl] get; }

    public extern string HairColor { [MethodImpl] get; }

    public extern string EyeColor { [MethodImpl] get; }

    public extern string Height { [MethodImpl] get; }

    public extern string Weight { [MethodImpl] get; }

    public extern string Address { [MethodImpl] get; }

    public extern string City { [MethodImpl] get; }

    public extern string State { [MethodImpl] get; }

    public extern string PostalCode { [MethodImpl] get; }
  }
}
