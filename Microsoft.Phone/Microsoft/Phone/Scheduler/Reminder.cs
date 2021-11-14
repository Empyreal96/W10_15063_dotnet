// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.Reminder
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public sealed class Reminder : ScheduledNotification
  {
    private Uri m_invocationContext;

    public Reminder(string name)
      : base(name, ScheduledActionType.Reminder)
    {
    }

    public Uri NavigationUri
    {
      get => this.m_invocationContext;
      set
      {
        SystemNotificationInterop.ValidateNavigationUri(value, nameof (NavigationUri));
        this.m_invocationContext = value;
      }
    }

    internal Reminder(Reminder reminder)
      : base((ScheduledNotification) reminder)
    {
      this.m_invocationContext = reminder.m_invocationContext;
    }

    internal override ScheduledAction CreateCopy() => (ScheduledAction) new Reminder(this);
  }
}
