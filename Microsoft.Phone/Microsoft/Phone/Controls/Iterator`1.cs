// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Iterator`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Controls
{
  internal abstract class Iterator<TItem> : IEnumerator<TItem>, IEnumerator, IDisposable
  {
    public abstract bool MovePrevious();

    public abstract Iterator<TItem> Clone();

    public virtual bool IsCurrentValid => true;

    public abstract TItem Current { get; }

    object IEnumerator.Current => (object) this.Current;

    public abstract bool MoveNext();

    public abstract void Reset();

    public abstract void Dispose();

    public abstract bool AtSamePosition(Iterator<TItem> other);
  }
}
