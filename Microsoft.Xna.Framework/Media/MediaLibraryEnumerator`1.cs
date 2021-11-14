// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.MediaLibraryEnumerator`1
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  internal abstract class MediaLibraryEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
  {
    protected bool disposed;
    protected uint handleList = uint.MaxValue;
    protected int curIndex = -1;
    protected int count;

    internal MediaLibraryEnumerator()
    {
    }

    [SecuritySafeCritical]
    internal MediaLibraryEnumerator(uint handle)
    {
      this.handleList = handle;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaList_GetCount(this.handleList, ref this.count));
    }

    ~MediaLibraryEnumerator() => this.Dispose(false);

    T IEnumerator<T>.Current => (T) ((IEnumerator) this).Current;

    object IEnumerator.Current => (object) this[this.curIndex];

    bool IEnumerator.MoveNext()
    {
      bool flag = false;
      this.curIndex = this.curIndex < this.count ? ++this.curIndex : this.count;
      if (this.curIndex < this.count)
        flag = true;
      return flag;
    }

    void IEnumerator.Reset() => this.curIndex = -1;

    internal T this[int index]
    {
      [SecuritySafeCritical] get
      {
        if (index < 0 || index >= this.count)
          throw new ArgumentOutOfRangeException(nameof (index), FrameworkResources.MustBeValidIndex);
        uint maxValue = uint.MaxValue;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaList_GetItemAtIndex(this.handleList, index, ref maxValue));
        return this.CreateItemInstance(maxValue);
      }
    }

    internal int Count => this.count;

    protected abstract T CreateItemInstance(uint handleItem);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private void Dispose(bool disposing)
    {
      if (this.IsDisposed)
        return;
      this.disposed = true;
    }

    public bool IsDisposed => this.disposed;
  }
}
