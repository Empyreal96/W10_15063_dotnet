// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentRequest))]
  [Guid(1049262556, 27508, 17107, 177, 3, 240, 222, 53, 251, 24, 72)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentRequestFactory
  {
    PaymentRequest Create(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData);

    PaymentRequest CreateWithMerchantInfo(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo);

    PaymentRequest CreateWithMerchantInfoAndOptions(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo,
      PaymentOptions options);
  }
}
