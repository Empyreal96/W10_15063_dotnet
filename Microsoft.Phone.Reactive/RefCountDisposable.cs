// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.RefCountDisposable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public sealed class RefCountDisposable : IDisposable
  {
    private readonly object gate;
    private readonly IDisposable underlyingDisposable;
    private int count;
    private bool isPrimaryDisposed;
    private bool isUnderlyingDisposed;

    public RefCountDisposable(IDisposable underlyingDisposable)
    {
      if (underlyingDisposable == null)
        throw new ArgumentNullException(nameof (underlyingDisposable));
      this.isUnderlyingDisposed = false;
      this.isPrimaryDisposed = false;
      this.gate = new object();
      this.count = 0;
      this.underlyingDisposable = underlyingDisposable;
    }

    public void Dispose()
    {
      bool flag = false;
      lock (this.gate)
      {
        if (!this.isUnderlyingDisposed)
        {
          if (!this.isPrimaryDisposed)
          {
            this.isPrimaryDisposed = true;
            if (this.count == 0)
            {
              this.isUnderlyingDisposed = true;
              flag = true;
            }
          }
        }
      }
      if (!flag)
        return;
      this.underlyingDisposable.Dispose();
    }

    public IDisposable GetDisposable()
    {
      lock (this.gate)
        return this.isUnderlyingDisposed ? Disposable.Empty : (IDisposable) new RefCountDisposable.InnerDisposable(this);
    }

    private sealed class InnerDisposable : IDisposable
    {
      private readonly RefCountDisposable disposable;
      private bool isInnerDisposed;

      public InnerDisposable(RefCountDisposable disposable)
      {
        this.disposable = disposable;
        ++this.disposable.count;
      }

      public void Dispose()
      {
        bool flag = false;
        lock (this.disposable.gate)
        {
          if (!this.disposable.isUnderlyingDisposed)
          {
            if (!this.isInnerDisposed)
            {
              this.isInnerDisposed = true;
              --this.disposable.count;
              if (this.disposable.count == 0)
              {
                if (this.disposable.isPrimaryDisposed)
                {
                  this.disposable.isUnderlyingDisposed = true;
                  flag = true;
                }
              }
            }
          }
        }
        if (!flag)
          return;
        this.disposable.underlyingDisposable.Dispose();
      }
    }
  }
}
