// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentShippingOption
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentShippingOptionFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentShippingOption : IPaymentShippingOption
  {
    [MethodImpl]
    public extern PaymentShippingOption(string label, PaymentCurrencyAmount amount);

    [MethodImpl]
    public extern PaymentShippingOption(string label, PaymentCurrencyAmount amount, bool selected);

    [MethodImpl]
    public extern PaymentShippingOption(
      string label,
      PaymentCurrencyAmount amount,
      bool selected,
      string tag);

    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    public extern PaymentCurrencyAmount Amount { [MethodImpl] get; [MethodImpl] set; }

    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSelected { [MethodImpl] get; [MethodImpl] set; }
  }
}
