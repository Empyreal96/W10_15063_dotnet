// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.ScheduledAction
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public abstract class ScheduledAction
  {
    private Guid m_id;
    private string m_name;
    private ScheduledActionType m_type;
    private ScheduledActionStatus m_status;
    private DateTime m_startTime;
    private DateTime m_endTime;
    private string m_content;

    internal ScheduledAction(string name, ScheduledActionType type)
    {
      this.m_id = Guid.NewGuid();
      this.m_content = string.Empty;
      this.Name = name;
      this.m_type = type;
      this.m_status = ScheduledActionStatus.Completed;
      this.m_startTime = DateTime.MinValue;
      this.m_endTime = DateTime.MaxValue;
    }

    public string Name
    {
      get => this.m_name;
      internal set
      {
        SystemNotificationInterop.ValidateName(value, nameof (Name));
        this.m_name = value;
      }
    }

    public virtual DateTime BeginTime
    {
      get => this.m_startTime;
      set => this.m_startTime = value;
    }

    public virtual DateTime ExpirationTime
    {
      get => this.m_endTime;
      set => this.m_endTime = !(value <= DateTime.Now) ? value : throw new ArgumentOutOfRangeException(nameof (ExpirationTime));
    }

    public bool IsEnabled => this.m_status != ScheduledActionStatus.Disabled;

    public bool IsScheduled => this.m_status == ScheduledActionStatus.Scheduled;

    internal Guid ID
    {
      get => this.m_id;
      set => this.m_id = value;
    }

    internal virtual bool NeedUpdateStatus => true;

    internal ScheduledActionType Type => this.m_type;

    internal virtual void UpdateStatusFrom(ScheduledAction action)
    {
      this.m_startTime = action.m_startTime;
      this.m_status = action.Status;
    }

    internal ScheduledAction(ScheduledAction action)
    {
      this.m_id = action.m_id;
      this.m_name = action.m_name;
      this.m_type = action.m_type;
      this.m_status = action.m_status;
      this.m_startTime = action.m_startTime;
      this.m_endTime = action.m_endTime;
      this.m_content = action.m_content;
    }

    internal ScheduledActionStatus Status
    {
      get => this.m_status;
      set => this.m_status = value;
    }

    internal abstract ScheduledAction CreateCopy();

    internal virtual DateTime BeginTimeInternal
    {
      get => this.m_startTime;
      set => this.m_startTime = value;
    }

    internal virtual DateTime ExpirationTimeInternal
    {
      get => this.m_endTime;
      set => this.m_endTime = value;
    }

    internal string ContentInternal
    {
      get => this.m_content;
      set => this.m_content = value;
    }
  }
}
