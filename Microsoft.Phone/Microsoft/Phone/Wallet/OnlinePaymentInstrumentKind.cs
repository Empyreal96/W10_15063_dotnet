// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.OnlinePaymentInstrumentKind
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;

namespace Microsoft.Phone.Wallet
{
  public static class OnlinePaymentInstrumentKind
  {
    private static Dictionary<int, string> _mappingToNativeValue = new Dictionary<int, string>();
    public const string ConsumerStoredValue = "ConsumerStoredValue";
    public const string PayPal = "PayPal";
    public const string AliPay = "AliPay";
    public const string MobileOperator = "MobileOperator";

    static OnlinePaymentInstrumentKind()
    {
      OnlinePaymentInstrumentKind._mappingToNativeValue.Add(4, nameof (ConsumerStoredValue));
      OnlinePaymentInstrumentKind._mappingToNativeValue.Add(8, nameof (PayPal));
      OnlinePaymentInstrumentKind._mappingToNativeValue.Add(16, nameof (AliPay));
      OnlinePaymentInstrumentKind._mappingToNativeValue.Add(32, nameof (MobileOperator));
    }

    internal static string MapNativeValueToManagedString(int value) => OnlinePaymentInstrumentKind._mappingToNativeValue[value];
  }
}
