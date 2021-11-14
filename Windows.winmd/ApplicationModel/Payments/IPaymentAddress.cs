// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1596089577, 28474, 16742, 160, 24, 10, 11, 6, 187, 50, 181)]
  [ExclusiveTo(typeof (PaymentAddress))]
  internal interface IPaymentAddress
  {
    string Country { get; set; }

    IVectorView<string> AddressLines { get; set; }

    string Region { get; set; }

    string City { get; set; }

    string DependentLocality { get; set; }

    string PostalCode { get; set; }

    string SortingCode { get; set; }

    string LanguageCode { get; set; }

    string Organization { get; set; }

    string Recipient { get; set; }

    string PhoneNumber { get; set; }

    ValueSet Properties { get; }
  }
}
