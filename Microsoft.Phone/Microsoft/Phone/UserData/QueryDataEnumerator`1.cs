// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.QueryDataEnumerator`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.UserData
{
  internal class QueryDataEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
  {
    private QueryDataEnumerable<T> _enumerable;
    private int _currentIndex;
    private bool _disposed;

    internal QueryDataEnumerator(QueryDataEnumerable<T> enumarable)
    {
      this._enumerable = enumarable;
      this._currentIndex = -1;
    }

    public T Current
    {
      get
      {
        this.VerifyObject();
        if (this._currentIndex < this._enumerable.ObjectCache.Count && this._currentIndex >= 0)
          return this._enumerable.ObjectCache[this._currentIndex];
        throw new InvalidOperationException();
      }
    }

    object IEnumerator.Current => (object) this.Current;

    public bool MoveNext()
    {
      this.VerifyObject();
      int num = this._enumerable.GetNextBatch(this._currentIndex + 1) ? 1 : 0;
      if (num == 0)
        return num != 0;
      ++this._currentIndex;
      return num != 0;
    }

    public void Reset()
    {
      this.VerifyObject();
      this._currentIndex = -1;
    }

    public void Dispose() => this._disposed = true;

    private void VerifyObject()
    {
      if (this._disposed)
        throw new ObjectDisposedException(this.GetType().Name);
    }
  }
}
