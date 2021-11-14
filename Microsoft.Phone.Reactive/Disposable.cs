// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Disposable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public static class Disposable
  {
    public static IDisposable Empty => (IDisposable) DefaultDisposable.Instance;

    public static IDisposable Create(Action dispose) => dispose != null ? (IDisposable) new AnonymousDisposable(dispose) : throw new ArgumentNullException(nameof (dispose));
  }
}
