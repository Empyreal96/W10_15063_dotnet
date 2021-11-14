// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.ContactsSharingProvider
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecuritySafeCritical]
  internal class ContactsSharingProvider : PhoneDataSharingProvider
  {
    private PoomDataServiceInteropContext _Interop = new PoomDataServiceInteropContext();
    private ContactSerializer _contactSerializer = new ContactSerializer();
    private AccountSerializer _accountSerializer = new AccountSerializer();

    public override string BaseUri => "ContactsContext";

    [SecuritySafeCritical]
    public override IEnumerable<TElement> GetObjects<TElement>(string queryUri) => (IEnumerable<TElement>) new QueryDataEnumerable<TElement>(this.GetInteropContext(), this.GetSerializer<TElement>(), queryUri);

    [SecuritySafeCritical]
    protected override IElementSerializer<TElement> GetSerializer<TElement>()
    {
      if (typeof (TElement) == typeof (Contact))
        return (IElementSerializer<TElement>) this._contactSerializer;
      if (typeof (TElement) == typeof (Account))
        return (IElementSerializer<TElement>) this._accountSerializer;
      throw new ArgumentException("Invalid type for serializer");
    }

    [SecuritySafeCritical]
    protected override IInteropContext GetInteropContext() => (IInteropContext) this._Interop;
  }
}
