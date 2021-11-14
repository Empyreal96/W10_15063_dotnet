// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Networking.Voip.VoipKeepAliveTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Scheduler;
using System;
using System.Security;

namespace Microsoft.Phone.Networking.Voip
{
  [SecuritySafeCritical]
  public sealed class VoipKeepAliveTask : ScheduledTask
  {
    private const int c_defaultIntervalInMinutes = 360;
    private TimeSpan _recurringInterval;

    public VoipKeepAliveTask(string name)
      : base(name, ScheduledActionType.VoipKeepAliveTask)
    {
      this._recurringInterval = TimeSpan.FromMinutes(360.0);
    }

    public TimeSpan Interval
    {
      get => this._recurringInterval;
      set => this._recurringInterval = value;
    }

    internal VoipKeepAliveTask(VoipKeepAliveTask agent)
      : base((ScheduledTask) agent)
    {
      this._recurringInterval = agent.Interval;
    }

    internal override ScheduledAction CreateCopy() => (ScheduledAction) new VoipKeepAliveTask(this);

    internal override void UpdateStatusFrom(ScheduledAction action)
    {
      this.Interval = action is VoipKeepAliveTask voipKeepAliveTask ? voipKeepAliveTask.Interval : throw new ArgumentException("'action' must be a type of 'VoipKeepAliveTask'", nameof (action));
      base.UpdateStatusFrom(action);
    }
  }
}
