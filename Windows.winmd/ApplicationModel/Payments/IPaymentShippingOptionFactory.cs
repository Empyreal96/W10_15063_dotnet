// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentShippingOptionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(1575352599, 45783, 17515, 157, 115, 97, 35, 251, 202, 59, 198)]
  [ExclusiveTo(typeof (PaymentShippingOption))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentShippingOptionFactory
  {
    PaymentShippingOption Create(string label, PaymentCurrencyAmount amount);

    PaymentShippingOption CreateWithSelected(
      string label,
      PaymentCurrencyAmount amount,
      bool selected);

    PaymentShippingOption CreateWithSelectedAndTag(
      string label,
      PaymentCurrencyAmount amount,
      bool selected,
      string tag);
  }
}
