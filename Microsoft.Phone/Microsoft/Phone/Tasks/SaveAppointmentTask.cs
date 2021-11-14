// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.SaveAppointmentTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Phone.UserData;
using System;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;

namespace Microsoft.Phone.Tasks
{
  public sealed class SaveAppointmentTask
  {
    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsAllDayEvent { get; set; }

    public string Subject { get; set; }

    public string Location { get; set; }

    public string Details { get; set; }

    public Reminder Reminder { get; set; }

    public AppointmentStatus AppointmentStatus { get; set; }

    public SaveAppointmentTask()
    {
      this.Reminder = Reminder.FifteenMinutes;
      this.AppointmentStatus = AppointmentStatus.Busy;
    }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a child task in headless host");
      WindowsRuntimeSystemExtensions.AsTask<string>((IAsyncOperation<M0>) AppointmentManager.ShowEditNewAppointmentAsync(this.BuildAppointment()));
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    internal Appointment BuildAppointment()
    {
      Appointment appointment = new Appointment();
      DateTime? startTime = this.StartTime;
      DateTime? endTime = this.EndTime;
      TimeSpan timeSpan = TimeSpan.FromHours(1.0);
      DateTime dateTime1;
      if (startTime.HasValue && endTime.HasValue)
      {
        dateTime1 = startTime.Value;
        DateTime dateTime2 = endTime.Value;
        DateTime universalTime1 = dateTime2.ToUniversalTime();
        dateTime2 = startTime.Value;
        DateTime universalTime2 = dateTime2.ToUniversalTime();
        timeSpan = universalTime1 - universalTime2;
      }
      else
      {
        if (!startTime.HasValue && endTime.HasValue)
          throw new InvalidOperationException("StartTime is required if EndTime is set");
        dateTime1 = !startTime.HasValue || endTime.HasValue ? DateTime.Now : startTime.Value;
      }
      if (timeSpan.Ticks < 0L)
        throw new InvalidOperationException("EndTime must be the same as or after StartTime, or null");
      appointment.put_StartTime((DateTimeOffset) dateTime1);
      appointment.put_Duration(TimeSpan.FromMinutes(Math.Ceiling(timeSpan.TotalMinutes)));
      appointment.put_AllDay(this.IsAllDayEvent);
      appointment.put_Subject(this.Subject ?? "");
      appointment.put_Location(this.Location ?? "");
      appointment.put_Details(this.Details ?? "");
      appointment.put_Reminder(SaveAppointmentTask.GetReminderTimeSpan(this.Reminder));
      appointment.put_BusyStatus(SaveAppointmentTask.ConvertAppointmentStatusToRt(this.AppointmentStatus));
      return appointment;
    }

    internal static AppointmentBusyStatus ConvertAppointmentStatusToRt(
      AppointmentStatus status)
    {
      switch (status)
      {
        case AppointmentStatus.Free:
          return (AppointmentBusyStatus) 2;
        case AppointmentStatus.Tentative:
          return (AppointmentBusyStatus) 1;
        case AppointmentStatus.Busy:
          return (AppointmentBusyStatus) 0;
        case AppointmentStatus.OutOfOffice:
          return (AppointmentBusyStatus) 3;
        default:
          throw new InvalidOperationException("Appointment status out of range");
      }
    }

    internal static TimeSpan? GetReminderTimeSpan(Reminder reminder)
    {
      switch (reminder)
      {
        case Reminder.None:
          return new TimeSpan?();
        case Reminder.AtStartTime:
          return new TimeSpan?(TimeSpan.Zero);
        case Reminder.FiveMinutes:
          return new TimeSpan?(TimeSpan.FromMinutes(5.0));
        case Reminder.TenMinutes:
          return new TimeSpan?(TimeSpan.FromMinutes(10.0));
        case Reminder.FifteenMinutes:
          return new TimeSpan?(TimeSpan.FromMinutes(15.0));
        case Reminder.ThirtyMinutes:
          return new TimeSpan?(TimeSpan.FromMinutes(30.0));
        case Reminder.OneHour:
          return new TimeSpan?(TimeSpan.FromHours(1.0));
        case Reminder.EighteenHours:
          return new TimeSpan?(TimeSpan.FromHours(18.0));
        case Reminder.OneDay:
          return new TimeSpan?(TimeSpan.FromDays(1.0));
        case Reminder.OneWeek:
          return new TimeSpan?(TimeSpan.FromDays(7.0));
        default:
          throw new InvalidOperationException("Reminder out of range");
      }
    }
  }
}
