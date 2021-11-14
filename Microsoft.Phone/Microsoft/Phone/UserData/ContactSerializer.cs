// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.ContactSerializer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecurityCritical]
  internal class ContactSerializer : IElementSerializer<Contact>
  {
    [SecurityCritical]
    public Contact GetObject(object handle)
    {
      IntPtr ptr1 = (IntPtr) handle;
      Contact contact = new Contact();
      Type structureType = typeof (CONTACT);
      CONTACT structure1 = (CONTACT) Marshal.PtrToStructure(ptr1, structureType);
      IntPtr ptr2 = structure1.rgPropVals;
      for (int index = 0; (long) index < (long) structure1.cProps; ++index)
      {
        CEPROPVAL structure2 = (CEPROPVAL) Marshal.PtrToStructure(ptr2, typeof (CEPROPVAL));
        ptr2 = (IntPtr) (ptr2.ToInt32() + Marshal.SizeOf((object) structure2));
        this.AddSingleValuePropertyToContact(structure2, contact);
      }
      IntPtr ptr3 = structure1.rgAccounts;
      AccountSerializer accountSerializer = new AccountSerializer();
      for (int index = 0; (long) index < (long) structure1.cSources; ++index)
      {
        Account account = accountSerializer.GetObject((object) ptr3);
        ACCOUNT structure2 = (ACCOUNT) Marshal.PtrToStructure(ptr3, typeof (ACCOUNT));
        ptr3 = (IntPtr) (ptr3.ToInt32() + Marshal.SizeOf((object) structure2));
        contact.AddAccount(account);
      }
      this.HandleMultiValuedProperties(structure1.cAggregatedProps, structure1.rgAggregatedPropVals, contact);
      contact.Id = structure1.contactId;
      return contact;
    }

    private void EnsureContactHasCompleteName(Contact contact)
    {
      if (contact.CompleteName != null)
        return;
      contact.CompleteName = new CompleteName();
    }

    [SecurityCritical]
    private void AddSingleValuePropertyToContact(CEPROPVAL cePropVal, Contact contact)
    {
      switch ((PIMPR_PROPS) cePropVal.propid)
      {
        case PIMPR_PROPS.PIMPR_TITLE:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.Title = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_FIRST_NAME:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.FirstName = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_MIDDLE_NAME:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.MiddleName = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_LAST_NAME:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.LastName = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_SUFFIX:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.Suffix = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_NICKNAME:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.Nickname = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_YOMI_FIRSTNAME:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.YomiFirstName = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_YOMI_LASTNAME:
          this.EnsureContactHasCompleteName(contact);
          contact.CompleteName.YomiLastName = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_IS_FAVORITE:
          contact.IsPinnedToStart = cePropVal.val.boolVal;
          break;
        case PIMPR_PROPS.PIMPR_DISPLAY_NAME:
          contact.DisplayName = this.GetString(cePropVal.val.lpwstr);
          break;
      }
    }

    [SecurityCritical]
    private void HandleMultiValuedProperties(
      uint cAggregatedProps,
      IntPtr rgAggregatedProps,
      Contact contact)
    {
      List<List<SOURCE>> accountIndexes1 = new List<List<SOURCE>>();
      List<List<SOURCE>> accountIndexes2 = new List<List<SOURCE>>();
      List<List<SOURCE>> accountIndexes3 = new List<List<SOURCE>>();
      List<List<SOURCE>> accountIndexes4 = new List<List<SOURCE>>();
      IntPtr ptr = rgAggregatedProps;
      for (int index = 0; (long) index < (long) cAggregatedProps; ++index)
      {
        SOURCEDPROPVAL structure1 = (SOURCEDPROPVAL) Marshal.PtrToStructure(ptr, typeof (SOURCEDPROPVAL));
        CEPROPVAL structure2 = (CEPROPVAL) Marshal.PtrToStructure(structure1.pPropVal, typeof (CEPROPVAL));
        ptr = (IntPtr) (ptr.ToInt32() + Marshal.SizeOf((object) structure1));
        List<SOURCE> sourceList = this.MarshalArrayOfSources(structure1.cSources, structure1.rgSources);
        switch ((PIMPR_PROPS) structure2.propid)
        {
          case PIMPR_PROPS.PIMPR_JOB_INFO:
            accountIndexes1.Add(sourceList);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_ADDRESS:
            accountIndexes3.Add(sourceList);
            break;
          case PIMPR_PROPS.PIMPR_HOME_ADDRESS:
            accountIndexes2.Add(sourceList);
            break;
          case PIMPR_PROPS.PIMPR_OTHER_ADDRESS:
            accountIndexes4.Add(sourceList);
            break;
        }
      }
      contact.AddAddresses(AddressKind.Home, accountIndexes2);
      contact.AddAddresses(AddressKind.Work, accountIndexes3);
      contact.AddAddresses(AddressKind.Other, accountIndexes4);
      contact.AddCompanies(accountIndexes1);
      ptr = rgAggregatedProps;
      for (int index = 0; (long) index < (long) cAggregatedProps; ++index)
      {
        SOURCEDPROPVAL structure1 = (SOURCEDPROPVAL) Marshal.PtrToStructure(ptr, typeof (SOURCEDPROPVAL));
        CEPROPVAL structure2 = (CEPROPVAL) Marshal.PtrToStructure(structure1.pPropVal, typeof (CEPROPVAL));
        ptr = (IntPtr) (ptr.ToInt32() + Marshal.SizeOf((object) structure1));
        List<SOURCE> AccountIndexes = this.MarshalArrayOfSources(structure1.cSources, structure1.rgSources);
        switch ((PIMPR_PROPS) structure2.propid)
        {
          case PIMPR_PROPS.PIMPR_YOMI_COMPANY:
            contact.UpdateCompany(this.GetString(structure2.val.lpwstr), COMPANY_PART.YomiCompanyName, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_COMPANY_NAME:
            contact.UpdateCompany(this.GetString(structure2.val.lpwstr), COMPANY_PART.CompanyName, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_JOB_TITLE:
            contact.UpdateCompany(this.GetString(structure2.val.lpwstr), COMPANY_PART.JobTitle, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_OFFICE_LOCATION:
            contact.UpdateCompany(this.GetString(structure2.val.lpwstr), COMPANY_PART.OfficeLocation, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_EMAIL1_ADDRESS:
            contact.AddEmail(this.GetString(structure2.val.lpwstr), EmailAddressKind.Personal, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_EMAIL2_ADDRESS:
            contact.AddEmail(this.GetString(structure2.val.lpwstr), EmailAddressKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_EMAIL3_ADDRESS:
            contact.AddEmail(this.GetString(structure2.val.lpwstr), EmailAddressKind.Other, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_MOBILE_TELEPHONE_NUMBER:
          case PIMPR_PROPS.PIMPR_MOBILE2_TELEPHONE_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.Mobile, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_TELEPHONE_NUMBER:
          case PIMPR_PROPS.PIMPR_BUSINESS2_TELEPHONE_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_TELEPHONE_NUMBER:
          case PIMPR_PROPS.PIMPR_HOME2_TELEPHONE_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.Home, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_FAX_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.WorkFax, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_FAX_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.HomeFax, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_PAGER_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.Pager, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_COMPANY_TELEPHONE_NUMBER:
            contact.AddPhoneNumber(this.GetString(structure2.val.lpwstr), PhoneNumberKind.Company, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_SPOUSE:
            contact.AddSignificantOther(this.GetString(structure2.val.lpwstr));
            break;
          case PIMPR_PROPS.PIMPR_CHILDREN:
            contact.AddChildren(this.GetString(structure2.val.lpwstr));
            break;
          case PIMPR_PROPS.PIMPR_WEB_PAGE:
            contact.AddWebsite(this.GetString(structure2.val.lpwstr));
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_ADDRESS_STREET:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.Street, AddressKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_ADDRESS_CITY:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.City, AddressKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_ADDRESS_STATE:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.State, AddressKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_ADDRESS_POSTAL_CODE:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.PostalCode, AddressKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_BUSINESS_ADDRESS_COUNTRY:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.Country, AddressKind.Work, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_ADDRESS_STREET:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.Street, AddressKind.Home, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_ADDRESS_CITY:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.City, AddressKind.Home, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_ADDRESS_STATE:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.State, AddressKind.Home, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_ADDRESS_POSTAL_CODE:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.PostalCode, AddressKind.Home, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_HOME_ADDRESS_COUNTRY:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.Country, AddressKind.Home, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_OTHER_ADDRESS_STREET:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.Street, AddressKind.Other, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_OTHER_ADDRESS_CITY:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.City, AddressKind.Other, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_OTHER_ADDRESS_STATE:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.State, AddressKind.Other, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_OTHER_ADDRESS_POSTAL_CODE:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.PostalCode, AddressKind.Other, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_OTHER_ADDRESS_COUNTRY:
            contact.UpdateAddress(this.GetString(structure2.val.lpwstr), ADDRESS_PART.Country, AddressKind.Other, AccountIndexes);
            break;
          case PIMPR_PROPS.PIMPR_FLOATING_BIRTHDAY:
            DateTime birthday = DateTime.FromFileTime(((long) structure2.val.filetime.dwHighDateTime << 32) + (long) structure2.val.filetime.dwLowDateTime);
            if (birthday.Year <= 1904)
            {
              DateTime dateTime = birthday;
              birthday = new DateTime(4, dateTime.Month, dateTime.Day);
            }
            contact.AddBirthday(birthday);
            break;
          case PIMPR_PROPS.PIMPR_BODY_TEXT:
            contact.AddNotes(this.GetString(structure2.val.lpwstr));
            break;
        }
      }
    }

    private List<SOURCE> MarshalArrayOfSources(uint cSources, IntPtr rgSources)
    {
      IntPtr ptr = rgSources;
      List<SOURCE> sourceList = new List<SOURCE>();
      for (uint index = 0; index < cSources; ++index)
      {
        SOURCE structure = (SOURCE) Marshal.PtrToStructure(ptr, typeof (SOURCE));
        sourceList.Add(structure);
        ptr = (IntPtr) (ptr.ToInt32() + Marshal.SizeOf((object) structure));
      }
      return sourceList;
    }

    [SecurityCritical]
    private string GetString(IntPtr sz) => Marshal.PtrToStringUni(sz);
  }
}
