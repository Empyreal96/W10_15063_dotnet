// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentDetailsModifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Activatable(typeof (IPaymentDetailsModifierFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentDetailsModifier : IPaymentDetailsModifier
  {
    [MethodImpl]
    public extern PaymentDetailsModifier(IIterable<string> supportedMethodIds, PaymentItem total);

    [MethodImpl]
    public extern PaymentDetailsModifier(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems);

    [MethodImpl]
    public extern PaymentDetailsModifier(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems,
      string jsonData);

    public extern string JsonData { [MethodImpl] get; }

    public extern IVectorView<string> SupportedMethodIds { [MethodImpl] get; }

    public extern PaymentItem Total { [MethodImpl] get; }

    public extern IVectorView<PaymentItem> AdditionalDisplayItems { [MethodImpl] get; }
  }
}
