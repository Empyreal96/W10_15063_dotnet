// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentOptions))]
  [Guid(2862811220, 7979, 17253, 130, 81, 1, 181, 137, 21, 165, 188)]
  internal interface IPaymentOptions
  {
    PaymentOptionPresence RequestPayerEmail { get; set; }

    PaymentOptionPresence RequestPayerName { get; set; }

    PaymentOptionPresence RequestPayerPhoneNumber { get; set; }

    bool RequestShipping { get; set; }

    PaymentShippingType ShippingType { get; set; }
  }
}
