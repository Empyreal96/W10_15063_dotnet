// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentCurrencyAmount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentCurrencyAmountFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentCurrencyAmount : IPaymentCurrencyAmount
  {
    [MethodImpl]
    public extern PaymentCurrencyAmount(string value, string currency);

    [MethodImpl]
    public extern PaymentCurrencyAmount(string value, string currency, string currencySystem);

    public extern string Currency { [MethodImpl] get; [MethodImpl] set; }

    public extern string CurrencySystem { [MethodImpl] get; [MethodImpl] set; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
