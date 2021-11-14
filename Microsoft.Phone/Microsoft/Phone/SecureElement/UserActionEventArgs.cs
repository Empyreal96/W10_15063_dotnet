// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.SecureElement.UserActionEventArgs
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Wallet;
using System;

namespace Microsoft.Phone.SecureElement
{
  public class UserActionEventArgs : EventArgs
  {
    public byte[] ActionData { get; internal set; }

    public ISecureElementItem Item { get; internal set; }

    public WalletUserActionResultKind Result { get; set; }

    public string TransactionAmount { get; set; }
  }
}
