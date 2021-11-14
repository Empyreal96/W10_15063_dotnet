// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.ContactPhoneNumber
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Phone.UserData
{
  public sealed class ContactPhoneNumber
  {
    private List<Account> _accounts = new List<Account>();

    internal ContactPhoneNumber()
    {
    }

    public string PhoneNumber { get; internal set; }

    public PhoneNumberKind Kind { get; internal set; }

    public IEnumerable<Account> Accounts => (IEnumerable<Account>) this._accounts.AsReadOnly();

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} ({1})", (object) this.PhoneNumber, (object) this.Kind);

    internal void AddAccount(Account account)
    {
      if (this._accounts.Contains(account))
        return;
      this._accounts.Add(account);
    }
  }
}
