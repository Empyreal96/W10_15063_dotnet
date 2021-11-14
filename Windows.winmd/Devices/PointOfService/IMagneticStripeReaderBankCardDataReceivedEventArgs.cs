// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderBankCardDataReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(781551651, 41754, 18275, 136, 44, 35, 114, 94, 57, 176, 142)]
  [ExclusiveTo(typeof (MagneticStripeReaderBankCardDataReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderBankCardDataReceivedEventArgs
  {
    MagneticStripeReaderReport Report { get; }

    string AccountNumber { get; }

    string ExpirationDate { get; }

    string ServiceCode { get; }

    string Title { get; }

    string FirstName { get; }

    string MiddleInitial { get; }

    string Surname { get; }

    string Suffix { get; }
  }
}
