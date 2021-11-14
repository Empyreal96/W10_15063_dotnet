// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.GroupedObservable`2
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal class GroupedObservable<TKey, TElement> : 
    IGroupedObservable<TKey, TElement>,
    IObservable<TElement>
  {
    private readonly IObservable<TElement> underlyingObservable;

    public GroupedObservable(
      TKey key,
      IObservable<TElement> underlyingObservable,
      RefCountDisposable mergedDisposable)
    {
      this.Key = key;
      this.underlyingObservable = (IObservable<TElement>) new AnonymousObservable<TElement>((Func<IObserver<TElement>, IDisposable>) (observer => (IDisposable) new CompositeDisposable(new IDisposable[2]
      {
        mergedDisposable.GetDisposable(),
        underlyingObservable.Subscribe(observer)
      })));
    }

    public TKey Key { get; private set; }

    public IDisposable Subscribe(IObserver<TElement> observer) => this.underlyingObservable.Subscribe(observer);
  }
}
