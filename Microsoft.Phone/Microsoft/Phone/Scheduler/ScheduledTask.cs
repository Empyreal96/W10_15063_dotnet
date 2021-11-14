// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.ScheduledTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public abstract class ScheduledTask : ScheduledAction
  {
    private DateTime m_lastScheduledTime;
    private AgentExitReason m_lastExitReason;

    internal ScheduledTask(string name, ScheduledActionType type)
      : base(name, type)
    {
      this.m_lastExitReason = AgentExitReason.None;
    }

    internal override void UpdateStatusFrom(ScheduledAction action)
    {
      this.m_lastScheduledTime = action is ScheduledTask scheduledTask ? scheduledTask.m_lastScheduledTime : throw new ArgumentException("'action' must be a type of 'ScheduledTask'", nameof (action));
      this.m_lastExitReason = scheduledTask.m_lastExitReason;
      base.UpdateStatusFrom(action);
    }

    public override DateTime BeginTime
    {
      get => throw new NotSupportedException(nameof (BeginTime));
      set => throw new NotSupportedException(nameof (BeginTime));
    }

    public string Description
    {
      get => this.ContentInternal;
      set => this.ContentInternal = value;
    }

    public DateTime LastScheduledTime
    {
      get => this.LastExitReason != AgentExitReason.None ? this.m_lastScheduledTime.ToLocalTime() : DateTime.MinValue;
      internal set => this.m_lastScheduledTime = value;
    }

    public AgentExitReason LastExitReason
    {
      get => this.m_lastExitReason;
      internal set => this.m_lastExitReason = value;
    }

    internal ScheduledTask(ScheduledTask agent)
      : base((ScheduledAction) agent)
    {
      this.m_lastScheduledTime = agent.LastScheduledTime;
      this.m_lastExitReason = agent.LastExitReason;
    }

    internal static TimeSpan MaximumLife => new TimeSpan(14, 0, 0, 0);
  }
}
