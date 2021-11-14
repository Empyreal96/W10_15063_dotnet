// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ContextDisposable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  public sealed class ContextDisposable : IDisposable
  {
    private readonly IDisposable disposable;
    private int disposed;

    public ContextDisposable(SynchronizationContext context, IDisposable disposable)
    {
      if (context == null)
        throw new ArgumentNullException(nameof (context));
      if (disposable == null)
        throw new ArgumentNullException(nameof (disposable));
      this.Context = context;
      this.disposable = disposable;
    }

    public SynchronizationContext Context { get; private set; }

    public void Dispose()
    {
      if (Interlocked.Exchange(ref this.disposed, 1) != 0)
        return;
      this.Context.Post((SendOrPostCallback) (_ => this.disposable.Dispose()), (object) null);
    }
  }
}
