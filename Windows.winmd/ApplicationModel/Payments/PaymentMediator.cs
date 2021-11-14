// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentMediator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentMediator : IPaymentMediator
  {
    [MethodImpl]
    public extern PaymentMediator();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetSupportedMethodIdsAsync();

    [Overload("SubmitPaymentRequestAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest);

    [RemoteAsync]
    [Overload("SubmitPaymentRequestWithChangeHandlerAsync")]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest,
      PaymentRequestChangedHandler changeHandler);
  }
}
