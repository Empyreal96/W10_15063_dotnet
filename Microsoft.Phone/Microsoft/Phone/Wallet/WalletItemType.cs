// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletItemType
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Wallet
{
  internal enum WalletItemType
  {
    Undefined = 0,
    PaymentCard = 1,
    OtherCard = 2,
    Coupon = 4,
    Notification = 10, // 0x0000000A
    Transaction = 11, // 0x0000000B
    RootItem = 15, // 0x0000000F
  }
}
