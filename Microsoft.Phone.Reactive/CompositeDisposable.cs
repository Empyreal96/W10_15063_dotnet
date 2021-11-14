// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.CompositeDisposable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  public sealed class CompositeDisposable : 
    ICollection<IDisposable>,
    IEnumerable<IDisposable>,
    IEnumerable,
    IDisposable
  {
    private readonly List<IDisposable> disposables;
    private bool disposed;

    public CompositeDisposable(params IDisposable[] disposables)
    {
      if (disposables == null)
        throw new ArgumentNullException(nameof (disposables));
      foreach (IDisposable disposable in disposables)
      {
        if (disposable == null)
          throw new ArgumentOutOfRangeException(nameof (disposables));
      }
      this.disposables = new List<IDisposable>((IEnumerable<IDisposable>) disposables);
    }

    public int Count => this.disposables.Count;

    public void Add(IDisposable disposable)
    {
      if (disposable == null)
        throw new ArgumentNullException(nameof (disposable));
      bool flag = false;
      lock (this.disposables)
      {
        flag = this.disposed;
        if (!this.disposed)
          this.disposables.Add(disposable);
      }
      if (!flag)
        return;
      disposable.Dispose();
    }

    public bool Remove(IDisposable disposable)
    {
      if (disposable == null)
        throw new ArgumentNullException(nameof (disposable));
      bool flag = false;
      lock (this.disposables)
      {
        if (!this.disposed)
          flag = this.disposables.Remove(disposable);
      }
      if (flag)
        disposable.Dispose();
      return flag;
    }

    public void Clear()
    {
      lock (this.disposables)
      {
        foreach (IDisposable disposable in this.disposables)
          disposable.Dispose();
        this.disposables.Clear();
      }
    }

    public bool Contains(IDisposable disposable)
    {
      lock (this.disposables)
        return this.disposables.Contains(disposable);
    }

    public void CopyTo(IDisposable[] array, int arrayIndex)
    {
      if (array == null)
        throw new ArgumentNullException(nameof (array));
      if (arrayIndex < 0 || arrayIndex >= array.Length)
        throw new IndexOutOfRangeException();
      lock (this.disposables)
        Array.Copy((Array) this.disposables.ToArray(), 0, (Array) array, arrayIndex, array.Length - arrayIndex);
    }

    public bool IsReadOnly => false;

    public IEnumerator<IDisposable> GetEnumerator()
    {
      lock (this.disposables)
        return ((IEnumerable<IDisposable>) this.disposables.ToArray()).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    public void Dispose()
    {
      lock (this.disposables)
      {
        if (this.disposed)
          return;
        this.disposed = true;
        this.Clear();
      }
    }
  }
}
