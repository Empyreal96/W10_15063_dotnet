// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestChangedResultFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(141823830, 7475, 17457, 129, 75, 103, 234, 36, 191, 33, 219)]
  [ExclusiveTo(typeof (PaymentRequestChangedResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentRequestChangedResultFactory
  {
    PaymentRequestChangedResult Create(bool changeAcceptedByMerchant);

    PaymentRequestChangedResult CreateWithPaymentDetails(
      bool changeAcceptedByMerchant,
      PaymentDetails updatedPaymentDetails);
  }
}
