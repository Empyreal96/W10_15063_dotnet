// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentDetailsFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentDetails : IPaymentDetails
  {
    [MethodImpl]
    public extern PaymentDetails(PaymentItem total);

    [MethodImpl]
    public extern PaymentDetails(PaymentItem total, IIterable<PaymentItem> displayItems);

    [MethodImpl]
    public extern PaymentDetails();

    public extern PaymentItem Total { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<PaymentItem> DisplayItems { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<PaymentShippingOption> ShippingOptions { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<PaymentDetailsModifier> Modifiers { [MethodImpl] get; [MethodImpl] set; }
  }
}
