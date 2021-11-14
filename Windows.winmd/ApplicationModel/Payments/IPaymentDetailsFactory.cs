// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetailsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3488133102, 49386, 19617, 139, 199, 109, 230, 123, 31, 55, 99)]
  [ExclusiveTo(typeof (PaymentDetails))]
  internal interface IPaymentDetailsFactory
  {
    PaymentDetails Create(PaymentItem total);

    PaymentDetails CreateWithDisplayItems(
      PaymentItem total,
      IIterable<PaymentItem> displayItems);
  }
}
