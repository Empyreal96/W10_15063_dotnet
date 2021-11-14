// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.AppointmentSerializer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecurityCritical]
  internal class AppointmentSerializer : IElementSerializer<Appointment>
  {
    [SecurityCritical]
    public Appointment GetObject(object handle)
    {
      IntPtr ptr1 = (IntPtr) handle;
      Appointment appointment = new Appointment();
      Type structureType = typeof (APPOINTMENT);
      APPOINTMENT structure1 = (APPOINTMENT) Marshal.PtrToStructure(ptr1, structureType);
      IntPtr ptr2 = structure1.rgPropVals;
      for (int index = 0; (long) index < (long) structure1.cProps; ++index)
      {
        CEPROPVAL structure2 = (CEPROPVAL) Marshal.PtrToStructure(ptr2, typeof (CEPROPVAL));
        ptr2 = (IntPtr) (ptr2.ToInt32() + Marshal.SizeOf((object) structure2));
        this.AddPropertyToAppointment(structure2, appointment);
      }
      IntPtr ptr3 = structure1.rgAttendees;
      for (int index = 0; (long) index < (long) structure1.cAttendees; ++index)
      {
        ATTENDEE structure2 = (ATTENDEE) Marshal.PtrToStructure(ptr3, typeof (ATTENDEE));
        ptr3 = (IntPtr) (ptr3.ToInt32() + Marshal.SizeOf((object) structure2));
        this.AddAttendeeToAppointment(structure2, appointment);
      }
      this.AddAccountToAppointment(structure1.pAccount, appointment);
      appointment.Id = structure1.appointmentId;
      long fileTime = ((long) structure1.ftOriginal.dwHighDateTime << 32) + (long) structure1.ftOriginal.dwLowDateTime;
      appointment.OriginalStart = fileTime != 0L ? DateTime.FromFileTime(fileTime) : DateTime.MinValue;
      return appointment;
    }

    private void EnsureAppointmentHasOrganizer(Appointment appointment)
    {
      if (appointment.Organizer != null)
        return;
      appointment.Organizer = new Attendee();
    }

    [SecurityCritical]
    private void AddPropertyToAppointment(CEPROPVAL cePropVal, Appointment appointment)
    {
      switch ((PIMPR_PROPS) cePropVal.propid)
      {
        case PIMPR_PROPS.PIMPR_SUBJECT:
          appointment.Subject = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_SENSITIVITY:
          appointment.IsPrivate = cePropVal.val.ulVal == 2U;
          break;
        case PIMPR_PROPS.PIMPR_LOCATION:
          appointment.Location = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_ALL_DAY_EVENT:
          appointment.IsAllDayEvent = cePropVal.val.boolVal;
          break;
        case PIMPR_PROPS.PIMPR_BUSY_STATUS:
          switch (cePropVal.val.ulVal)
          {
            case 0:
              appointment.Status = AppointmentStatus.Free;
              return;
            case 1:
              appointment.Status = AppointmentStatus.Tentative;
              return;
            case 2:
              appointment.Status = AppointmentStatus.Busy;
              return;
            case 3:
              appointment.Status = AppointmentStatus.OutOfOffice;
              return;
            default:
              return;
          }
        case PIMPR_PROPS.PIMPR_MEETING_ORGANIZER_NAME:
          this.EnsureAppointmentHasOrganizer(appointment);
          appointment.Organizer.DisplayName = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_MEETING_ORGANIZER_EMAIL:
          this.EnsureAppointmentHasOrganizer(appointment);
          appointment.Organizer.EmailAddress = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_BODY_TEXT:
          appointment.Details = this.GetString(cePropVal.val.lpwstr);
          break;
        case PIMPR_PROPS.PIMPR_START:
          long fileTime1 = ((long) cePropVal.val.filetime.dwHighDateTime << 32) + (long) cePropVal.val.filetime.dwLowDateTime;
          appointment.StartTime = DateTime.FromFileTime(fileTime1);
          break;
        case PIMPR_PROPS.PIMPR_END:
          long fileTime2 = ((long) cePropVal.val.filetime.dwHighDateTime << 32) + (long) cePropVal.val.filetime.dwLowDateTime;
          appointment.EndTime = DateTime.FromFileTime(fileTime2);
          break;
      }
    }

    [SecurityCritical]
    private void AddAttendeeToAppointment(ATTENDEE nativeAttendee, Appointment appointment)
    {
      Attendee attendee = new Attendee();
      IntPtr ptr = nativeAttendee.rgPropVals;
      for (int index = 0; (long) index < (long) nativeAttendee.cProps; ++index)
      {
        CEPROPVAL structure = (CEPROPVAL) Marshal.PtrToStructure(ptr, typeof (CEPROPVAL));
        ptr = (IntPtr) (ptr.ToInt32() + Marshal.SizeOf((object) structure));
        switch ((PIMPR_PROPS) structure.propid)
        {
          case PIMPR_PROPS.PIMPR_DISPLAY_NAME:
            attendee.DisplayName = this.GetString(structure.val.lpwstr);
            break;
          case PIMPR_PROPS.PIMPR_EMAIL_ADDRESS:
            attendee.EmailAddress = this.GetString(structure.val.lpwstr);
            break;
        }
      }
      appointment.AddAttendee(attendee);
    }

    [SecurityCritical]
    private void AddAccountToAppointment(IntPtr nativeAccount, Appointment appointment)
    {
      AccountSerializer accountSerializer = new AccountSerializer();
      appointment.Account = accountSerializer.GetObject((object) nativeAccount);
    }

    [SecurityCritical]
    private string GetString(IntPtr sz) => Marshal.PtrToStringUni(sz);
  }
}
