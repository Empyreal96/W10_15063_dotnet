// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.AnonymousEnumerable`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  internal class AnonymousEnumerable<T> : IEnumerable<T>, IEnumerable
  {
    private readonly Func<IEnumerator<T>> getEnumerator;

    public AnonymousEnumerable(Func<IEnumerator<T>> getEnumerator) => this.getEnumerator = getEnumerator;

    public IEnumerator<T> GetEnumerator() => this.getEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
