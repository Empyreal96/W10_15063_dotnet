// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetailsModifierFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentDetailsModifier))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2030064262, 21726, 17052, 158, 79, 93, 206, 110, 16, 235, 206)]
  internal interface IPaymentDetailsModifierFactory
  {
    PaymentDetailsModifier Create(
      IIterable<string> supportedMethodIds,
      PaymentItem total);

    PaymentDetailsModifier CreateWithAdditionalDisplayItems(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems);

    PaymentDetailsModifier CreateWithAdditionalDisplayItemsAndJsonData(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems,
      string jsonData);
  }
}
