// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.ScheduledNotification
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public abstract class ScheduledNotification : ScheduledAction
  {
    private RecurrenceInterval m_recurrenceType;
    private string m_title;

    internal ScheduledNotification(string name, ScheduledActionType type)
      : base(name, type)
    {
      this.m_recurrenceType = RecurrenceInterval.None;
      this.m_title = string.Empty;
    }

    public virtual string Content
    {
      get => this.ContentInternal;
      set
      {
        SystemNotificationInterop.ValidateContent(value, nameof (Content));
        this.ContentInternal = value;
      }
    }

    public RecurrenceInterval RecurrenceType
    {
      get => this.m_recurrenceType;
      set => this.m_recurrenceType = value;
    }

    public virtual string Title
    {
      get => this.TitleInternal;
      set
      {
        SystemNotificationInterop.ValidateTitle(value, nameof (Title));
        this.TitleInternal = value;
      }
    }

    internal string TitleInternal
    {
      get => this.m_title;
      set => this.m_title = value;
    }

    internal override void UpdateStatusFrom(ScheduledAction action)
    {
      if (!(action is ScheduledNotification))
        throw new ArgumentException("'action' must be a type of 'ScheduledNotification'", nameof (action));
      base.UpdateStatusFrom(action);
    }

    internal ScheduledNotification(ScheduledNotification timebasedNotification)
      : base((ScheduledAction) timebasedNotification)
    {
      this.m_recurrenceType = timebasedNotification.m_recurrenceType;
      this.ContentInternal = timebasedNotification.ContentInternal;
      this.m_title = timebasedNotification.m_title;
    }
  }
}
