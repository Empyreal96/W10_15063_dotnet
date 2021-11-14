// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ImmediateScheduler
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  public sealed class ImmediateScheduler : IScheduler
  {
    internal static readonly ImmediateScheduler Instance = new ImmediateScheduler();

    private ImmediateScheduler()
    {
    }

    public DateTimeOffset Now => Scheduler.Now;

    public IDisposable Schedule(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      action();
      return Disposable.Empty;
    }

    public IDisposable Schedule(Action action, TimeSpan dueTime)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      Thread.Sleep(Scheduler.Normalize(dueTime));
      action();
      return Disposable.Empty;
    }
  }
}
