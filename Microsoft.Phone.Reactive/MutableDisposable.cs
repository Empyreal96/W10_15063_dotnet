// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.MutableDisposable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public sealed class MutableDisposable : IDisposable
  {
    private readonly object gate = new object();
    private IDisposable current;
    private bool disposed;

    public IDisposable Disposable
    {
      get => this.current;
      set
      {
        bool flag = false;
        lock (this.gate)
        {
          flag = this.disposed;
          if (!flag)
          {
            if (this.current != null)
              this.current.Dispose();
            this.current = value;
          }
        }
        if (!flag || value == null)
          return;
        value.Dispose();
      }
    }

    public void Dispose()
    {
      lock (this.gate)
      {
        if (this.disposed)
          return;
        this.disposed = true;
        if (this.current == null)
          return;
        this.current.Dispose();
        this.current = (IDisposable) null;
      }
    }
  }
}
