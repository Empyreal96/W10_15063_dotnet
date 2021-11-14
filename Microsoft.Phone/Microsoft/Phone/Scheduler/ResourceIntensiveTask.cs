// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.ResourceIntensiveTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public sealed class ResourceIntensiveTask : ScheduledTask
  {
    public ResourceIntensiveTask(string name)
      : base(name, ScheduledActionType.OnIdleTask)
    {
    }

    public override DateTime ExpirationTime
    {
      get => base.ExpirationTime;
      set => base.ExpirationTime = !(value - DateTime.Now > new TimeSpan(14, 0, 0, 0)) ? value : throw new ArgumentOutOfRangeException(nameof (ExpirationTime));
    }

    internal ResourceIntensiveTask(ResourceIntensiveTask onIdleAgent)
      : base((ScheduledTask) onIdleAgent)
    {
    }

    internal override ScheduledAction CreateCopy() => (ScheduledAction) new ResourceIntensiveTask(this);
  }
}
