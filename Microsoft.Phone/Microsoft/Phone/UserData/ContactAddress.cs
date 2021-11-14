// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.ContactAddress
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;
using System.Device.Location;

namespace Microsoft.Phone.UserData
{
  public sealed class ContactAddress
  {
    private List<Account> _accounts = new List<Account>();
    private List<int> _contactIds = new List<int>();

    internal ContactAddress()
    {
    }

    public CivicAddress PhysicalAddress { get; internal set; }

    public AddressKind Kind { get; internal set; }

    public IEnumerable<Account> Accounts => (IEnumerable<Account>) this._accounts.AsReadOnly();

    internal IEnumerable<int> ContactIds => (IEnumerable<int>) this._contactIds.AsReadOnly();

    internal void AddAccount(Account account)
    {
      if (this._accounts.Contains(account))
        return;
      this._accounts.Add(account);
    }

    internal void AddContactId(int contactId) => this._contactIds.Add(contactId);
  }
}
