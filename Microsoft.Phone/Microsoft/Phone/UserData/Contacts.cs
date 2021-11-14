// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.Contacts
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Microsoft.Phone.UserData
{
  public sealed class Contacts : PhoneDataSharingContext
  {
    private const string AllContactsQueryString = "Contacts: All";
    private const string PinnedContactsQueryString = "Contacts: FindPinned";
    private const string SearchByEmailQueryString = "Contacts: FindByEmail: ";
    private const string SearchByPhoneNumberQueryString = "Contacts: FindByPhone: ";
    private const string SearchByNameQueryString = "Contacts: FindByName: ";
    private const string SearchByIdQueryString = "Contacts: FindById: ";
    private const string AccountsQuery = "Accounts: Contact";

    public Contacts()
      : base("ContactsContext")
    {
      if (PhoneDataSharingSurface.ProviderAlreadyRegistered(this.BaseUri))
        return;
      PhoneDataSharingSurface.RegisterProvider((PhoneDataSharingProvider) new ContactsSharingProvider());
    }

    public IEnumerable<Account> Accounts => this.ExecuteRequest<Account>("Accounts: Contact");

    public void SearchAsync(string filter, FilterKind filterKind, object state)
    {
      this.InitializeInteropContext();
      SynchronizationContext synchronizationContext = AsyncOperationManager.SynchronizationContext;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetContacts), (object) new ContactsSearchEventArgs()
      {
        Filter = filter,
        FilterKind = filterKind,
        State = state,
        SyncContext = synchronizationContext
      });
    }

    public event EventHandler<ContactsSearchEventArgs> SearchCompleted;

    private void GetContacts(object state)
    {
      if (!(state is ContactsSearchEventArgs contactsSearchEventArgs))
        throw new ArgumentException("Invalid state parameter");
      string queryString = this.GetQueryString(contactsSearchEventArgs.FilterKind, contactsSearchEventArgs.Filter);
      contactsSearchEventArgs.Results = this.ExecuteRequest<Contact>(queryString);
      foreach (Contact result in contactsSearchEventArgs.Results)
        ;
      contactsSearchEventArgs.SyncContext.Post(new SendOrPostCallback(this.OnSearchCompleted), (object) contactsSearchEventArgs);
    }

    private string GetQueryString(FilterKind filterKind, string filter)
    {
      string str;
      switch (filterKind)
      {
        case FilterKind.None:
          str = "Contacts: All";
          break;
        case FilterKind.PinnedToStart:
          str = "Contacts: FindPinned";
          break;
        case FilterKind.EmailAddress:
          str = "Contacts: FindByEmail: " + filter;
          break;
        case FilterKind.PhoneNumber:
          str = "Contacts: FindByPhone: " + filter;
          break;
        case FilterKind.DisplayName:
          str = "Contacts: FindByName: " + filter;
          break;
        case FilterKind.Identifier:
          str = "Contacts: FindById: " + filter;
          break;
        default:
          str = (string) null;
          break;
      }
      return str;
    }

    private void OnSearchCompleted(object e)
    {
      if (!(e is ContactsSearchEventArgs e1))
        throw new ArgumentException();
      EventHandler<ContactsSearchEventArgs> searchCompleted = this.SearchCompleted;
      if (searchCompleted == null)
        return;
      searchCompleted((object) this, e1);
    }
  }
}
