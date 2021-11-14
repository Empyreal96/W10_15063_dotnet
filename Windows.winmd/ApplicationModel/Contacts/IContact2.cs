// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContact2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4078105445, 47991, 19604, 128, 45, 131, 40, 206, 228, 12, 8)]
  [ExclusiveTo(typeof (Contact))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContact2 : IContact
  {
    string Id { get; set; }

    string Notes { get; set; }

    IVector<ContactPhone> Phones { get; }

    IVector<ContactEmail> Emails { get; }

    IVector<ContactAddress> Addresses { get; }

    IVector<ContactConnectedServiceAccount> ConnectedServiceAccounts { get; }

    IVector<ContactDate> ImportantDates { get; }

    IVector<string> DataSuppliers { get; }

    IVector<ContactJobInfo> JobInfo { get; }

    IVector<ContactSignificantOther> SignificantOthers { get; }

    IVector<ContactWebsite> Websites { get; }

    IPropertySet ProviderProperties { get; }
  }
}
