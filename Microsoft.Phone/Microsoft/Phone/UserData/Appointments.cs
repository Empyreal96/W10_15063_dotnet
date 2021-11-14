// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.Appointments
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Microsoft.Phone.UserData
{
  public sealed class Appointments : PhoneDataSharingContext
  {
    public const int DefaultMaximumItems = 100;
    private const string DateTimeSeparator = ".";
    private const string AppointmentsQueryString = "Appointments:";
    private const string AppointmentStartTimeQueryString = " Start=";
    private const string AppointmentEndTimeQueryString = " End=";
    private const string AppointmentMaxQueryString = " Max=";
    private const string AppointmentAccountQueryString = " Account=";
    private const string AccountsQuery = "Accounts: Appointment";

    public Appointments()
      : base("AppointmentsContext")
    {
      if (PhoneDataSharingSurface.ProviderAlreadyRegistered(this.BaseUri))
        return;
      PhoneDataSharingSurface.RegisterProvider((PhoneDataSharingProvider) new AppointmentsSharingProvider());
    }

    public event EventHandler<AppointmentsSearchEventArgs> SearchCompleted;

    public IEnumerable<Account> Accounts => this.ExecuteRequest<Account>("Accounts: Appointment");

    public void SearchAsync(DateTime startTimeInclusive, DateTime endTimeInclusive, object state) => this.SearchAsync(startTimeInclusive, endTimeInclusive, 100, (Account) null, state);

    public void SearchAsync(
      DateTime startTimeInclusive,
      DateTime endTimeInclusive,
      int maximumItems,
      object state)
    {
      this.SearchAsync(startTimeInclusive, endTimeInclusive, maximumItems, (Account) null, state);
    }

    public void SearchAsync(
      DateTime startTimeInclusive,
      DateTime endTimeInclusive,
      Account account,
      object state)
    {
      this.SearchAsync(startTimeInclusive, endTimeInclusive, 100, account, state);
    }

    public void SearchAsync(
      DateTime startTimeInclusive,
      DateTime endTimeInclusive,
      int maximumItems,
      Account account,
      object state)
    {
      this.InitializeInteropContext();
      SynchronizationContext synchronizationContext = AsyncOperationManager.SynchronizationContext;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetAppointments), (object) new AppointmentsSearchEventArgs()
      {
        StartTimeInclusive = startTimeInclusive,
        EndTimeInclusive = endTimeInclusive,
        MaxItems = maximumItems,
        Account = account,
        State = state,
        SyncContext = synchronizationContext
      });
    }

    private void GetAppointments(object state)
    {
      if (!(state is AppointmentsSearchEventArgs appointmentsSearchEventArgs))
        throw new ArgumentException("Invalid state parameter");
      string query = "Appointments: Start=" + this.GetDataString(appointmentsSearchEventArgs.StartTimeInclusive) + " End=" + this.GetDataString(appointmentsSearchEventArgs.EndTimeInclusive) + " Max=" + appointmentsSearchEventArgs.MaxItems.ToString();
      if (appointmentsSearchEventArgs.Account != null)
        query = query + " Account=" + appointmentsSearchEventArgs.Account.Name;
      appointmentsSearchEventArgs.Results = this.ExecuteRequest<Appointment>(query);
      foreach (Appointment result in appointmentsSearchEventArgs.Results)
        ;
      appointmentsSearchEventArgs.SyncContext.Post(new SendOrPostCallback(this.OnSearchCompleted), (object) appointmentsSearchEventArgs);
    }

    private string GetDataString(DateTime dateTime) => dateTime.Month.ToString() + "." + dateTime.Day.ToString() + "." + dateTime.Year.ToString() + "." + dateTime.Hour.ToString() + "." + dateTime.Minute.ToString();

    private void OnSearchCompleted(object e)
    {
      if (!(e is AppointmentsSearchEventArgs e1))
        throw new ArgumentException();
      EventHandler<AppointmentsSearchEventArgs> searchCompleted = this.SearchCompleted;
      if (searchCompleted == null)
        return;
      searchCompleted((object) this, e1);
    }
  }
}
