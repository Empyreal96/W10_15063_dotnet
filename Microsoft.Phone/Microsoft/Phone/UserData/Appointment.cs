// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.Appointment
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.UserData
{
  public sealed class Appointment
  {
    private List<Attendee> _attendees = new List<Attendee>();

    internal Appointment()
    {
    }

    public string Subject { get; internal set; }

    public string Location { get; internal set; }

    public DateTime StartTime { get; internal set; }

    public DateTime EndTime { get; internal set; }

    public bool IsAllDayEvent { get; internal set; }

    public AppointmentStatus Status { get; internal set; }

    public string Details { get; internal set; }

    public Attendee Organizer { get; internal set; }

    internal uint Id { get; set; }

    internal DateTime OriginalStart { get; set; }

    public override int GetHashCode() => (int) this.Id ^ this.OriginalStart.GetHashCode();

    public override bool Equals(object obj) => obj is Appointment appointment && (int) appointment.Id == (int) this.Id && appointment.OriginalStart.Equals(this.OriginalStart);

    public IEnumerable<Attendee> Attendees => (IEnumerable<Attendee>) this._attendees.AsReadOnly();

    public bool IsPrivate { get; internal set; }

    public Account Account { get; internal set; }

    internal void AddAttendee(Attendee attendee) => this._attendees.Add(attendee);
  }
}
