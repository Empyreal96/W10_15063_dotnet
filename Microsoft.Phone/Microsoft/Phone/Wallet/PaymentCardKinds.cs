// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.PaymentCardKinds
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Wallet
{
  [Flags]
  internal enum PaymentCardKinds
  {
    Undefined = 0,
    Credit = 1,
    Debit = 2,
    CreditDebit = Debit | Credit, // 0x00000003
    Csv = 4,
    PayPal = 8,
    AliPay = 16, // 0x00000010
    MobileOperator = 32, // 0x00000020
    Inicis = 64, // 0x00000040
  }
}
