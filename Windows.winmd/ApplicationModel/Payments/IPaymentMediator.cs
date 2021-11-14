// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMediator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentMediator))]
  [Guid(4212058153, 60428, 17562, 131, 218, 122, 227, 7, 51, 101, 162)]
  internal interface IPaymentMediator
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetSupportedMethodIdsAsync();

    [Overload("SubmitPaymentRequestAsync")]
    [RemoteAsync]
    IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest);

    [RemoteAsync]
    [Overload("SubmitPaymentRequestWithChangeHandlerAsync")]
    IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest,
      PaymentRequestChangedHandler changeHandler);
  }
}
