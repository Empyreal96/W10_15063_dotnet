// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.Contact
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.IO;
using System.Security;

namespace Microsoft.Phone.UserData
{
  public sealed class Contact
  {
    private List<ContactPhoneNumber> _phoneNumbers = new List<ContactPhoneNumber>();
    private List<ContactEmailAddress> _emailAddresses = new List<ContactEmailAddress>();
    private List<ContactAddress> _addresses = new List<ContactAddress>();
    private List<ContactCompanyInformation> _companies = new List<ContactCompanyInformation>();
    private List<string> _websites = new List<string>();
    private List<string> _significantOthers = new List<string>();
    private List<string> _children = new List<string>();
    private List<string> _notes = new List<string>();
    private List<DateTime> _birthdays = new List<DateTime>();
    private List<Account> _accounts = new List<Account>();

    internal Contact()
    {
    }

    public string DisplayName { get; internal set; }

    public CompleteName CompleteName { get; internal set; }

    public IEnumerable<ContactPhoneNumber> PhoneNumbers => (IEnumerable<ContactPhoneNumber>) this._phoneNumbers.AsReadOnly();

    public IEnumerable<ContactEmailAddress> EmailAddresses => (IEnumerable<ContactEmailAddress>) this._emailAddresses.AsReadOnly();

    public IEnumerable<ContactAddress> Addresses => (IEnumerable<ContactAddress>) this._addresses.AsReadOnly();

    public IEnumerable<ContactCompanyInformation> Companies => (IEnumerable<ContactCompanyInformation>) this._companies.AsReadOnly();

    public IEnumerable<string> Websites => (IEnumerable<string>) this._websites.AsReadOnly();

    public IEnumerable<string> SignificantOthers => (IEnumerable<string>) this._significantOthers.AsReadOnly();

    public IEnumerable<string> Children => (IEnumerable<string>) this._children.AsReadOnly();

    public IEnumerable<string> Notes => (IEnumerable<string>) this._notes.AsReadOnly();

    public IEnumerable<DateTime> Birthdays => (IEnumerable<DateTime>) this._birthdays.AsReadOnly();

    public bool IsPinnedToStart { get; internal set; }

    public IEnumerable<Account> Accounts => (IEnumerable<Account>) this._accounts.AsReadOnly();

    public Stream GetPicture()
    {
      ContactPicture picture;
      return ContactPicture.TryGetContactPicture(this.Id, out picture) ? (Stream) picture : (Stream) null;
    }

    public override string ToString() => this.DisplayName;

    internal uint Id { get; set; }

    public override int GetHashCode() => (int) this.Id;

    public override bool Equals(object obj) => obj is Contact contact && (int) contact.Id == (int) this.Id;

    internal void AddAccount(Account account)
    {
      if (this._accounts.Contains(account))
        return;
      this._accounts.Add(account);
    }

    [SecurityCritical]
    internal void AddPhoneNumber(
      string phoneNumberString,
      PhoneNumberKind kind,
      List<SOURCE> AccountIndexes)
    {
      ContactPhoneNumber contactPhoneNumber = new ContactPhoneNumber()
      {
        PhoneNumber = phoneNumberString,
        Kind = kind
      };
      foreach (SOURCE accountIndex in AccountIndexes)
        contactPhoneNumber.AddAccount(this._accounts[accountIndex.sourceIndex]);
      this._phoneNumbers.Add(contactPhoneNumber);
    }

    [SecurityCritical]
    internal void AddEmail(string emailString, EmailAddressKind kind, List<SOURCE> AccountIndexes)
    {
      ContactEmailAddress contactEmailAddress = new ContactEmailAddress()
      {
        EmailAddress = emailString,
        Kind = kind
      };
      foreach (SOURCE accountIndex in AccountIndexes)
        contactEmailAddress.AddAccount(this._accounts[accountIndex.sourceIndex]);
      this._emailAddresses.Add(contactEmailAddress);
    }

    internal void AddWebsite(string website) => this._websites.Add(website);

    internal void AddSignificantOther(string significantOther) => this._significantOthers.Add(significantOther);

    internal void AddChildren(string children) => this._children.Add(children);

    internal void AddNotes(string notes) => this._notes.Add(notes);

    internal void AddBirthday(DateTime birthday) => this._birthdays.Add(birthday);

    [SecurityCritical]
    internal void AddAddresses(AddressKind kind, List<List<SOURCE>> accountIndexes)
    {
      foreach (List<SOURCE> accountIndex in accountIndexes)
      {
        ContactAddress contactAddress = new ContactAddress()
        {
          Kind = kind
        };
        foreach (SOURCE source in accountIndex)
        {
          contactAddress.AddAccount(this._accounts[source.sourceIndex]);
          contactAddress.AddContactId(source.contactId);
        }
        this._addresses.Add(contactAddress);
      }
    }

    [SecurityCritical]
    internal void AddCompanies(List<List<SOURCE>> accountIndexes)
    {
      foreach (List<SOURCE> accountIndex in accountIndexes)
      {
        ContactCompanyInformation companyInformation = new ContactCompanyInformation();
        foreach (SOURCE source in accountIndex)
        {
          companyInformation.AddAccount(this._accounts[source.sourceIndex]);
          companyInformation.AddContactId(source.contactId);
        }
        this._companies.Add(companyInformation);
      }
    }

    [SecurityCritical]
    internal void UpdateAddress(
      string value,
      ADDRESS_PART addressPart,
      AddressKind kind,
      List<SOURCE> AccountIndexes)
    {
      List<ContactAddress> contactAddressList = new List<ContactAddress>();
      foreach (SOURCE accountIndex in AccountIndexes)
      {
        foreach (ContactAddress address in this._addresses)
        {
          if (address.Kind == kind && this.IsContactIdInList(address.ContactIds, accountIndex.contactId) && !contactAddressList.Contains(address))
          {
            contactAddressList.Add(address);
            break;
          }
        }
      }
      foreach (ContactAddress contactAddress in contactAddressList)
      {
        if (contactAddress.PhysicalAddress == null)
          contactAddress.PhysicalAddress = new CivicAddress();
        switch (addressPart)
        {
          case ADDRESS_PART.Street:
            contactAddress.PhysicalAddress.AddressLine1 = value;
            continue;
          case ADDRESS_PART.City:
            contactAddress.PhysicalAddress.City = value;
            continue;
          case ADDRESS_PART.State:
            contactAddress.PhysicalAddress.StateProvince = value;
            continue;
          case ADDRESS_PART.PostalCode:
            contactAddress.PhysicalAddress.PostalCode = value;
            continue;
          case ADDRESS_PART.Country:
            contactAddress.PhysicalAddress.CountryRegion = value;
            continue;
          default:
            continue;
        }
      }
    }

    [SecurityCritical]
    internal void UpdateCompany(
      string value,
      COMPANY_PART companyPart,
      List<SOURCE> AccountIndexes)
    {
      List<ContactCompanyInformation> companyInformationList = new List<ContactCompanyInformation>();
      foreach (SOURCE accountIndex in AccountIndexes)
      {
        foreach (ContactCompanyInformation company in this._companies)
        {
          if (this.IsContactIdInList(company.ContactIds, accountIndex.contactId) && !companyInformationList.Contains(company))
          {
            companyInformationList.Add(company);
            break;
          }
        }
      }
      foreach (ContactCompanyInformation companyInformation in companyInformationList)
      {
        switch (companyPart)
        {
          case COMPANY_PART.CompanyName:
            companyInformation.CompanyName = value;
            continue;
          case COMPANY_PART.YomiCompanyName:
            companyInformation.YomiCompanyName = value;
            continue;
          case COMPANY_PART.OfficeLocation:
            companyInformation.OfficeLocation = value;
            continue;
          case COMPANY_PART.JobTitle:
            companyInformation.JobTitle = value;
            continue;
          default:
            continue;
        }
      }
    }

    internal bool IsContactIdInList(IEnumerable<int> ids, int idToFind)
    {
      foreach (int id in ids)
      {
        if (id == idToFind)
          return true;
      }
      return false;
    }
  }
}
