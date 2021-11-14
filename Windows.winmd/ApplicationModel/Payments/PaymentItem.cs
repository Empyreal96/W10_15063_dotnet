// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Activatable(typeof (IPaymentItemFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentItem : IPaymentItem
  {
    [MethodImpl]
    public extern PaymentItem(string label, PaymentCurrencyAmount amount);

    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    public extern PaymentCurrencyAmount Amount { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Pending { [MethodImpl] get; [MethodImpl] set; }
  }
}
