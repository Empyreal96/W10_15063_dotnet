// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.BinaryObserver`2
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal class BinaryObserver<TLeft, TRight> : 
    IObserver<Either<Notification<TLeft>, Notification<TRight>>>
  {
    public BinaryObserver(IObserver<TLeft> leftObserver, IObserver<TRight> rightObserver)
    {
      this.LeftObserver = leftObserver;
      this.RightObserver = rightObserver;
    }

    public BinaryObserver(Action<Notification<TLeft>> left, Action<Notification<TRight>> right)
      : this(left.ToObserver<TLeft>(), right.ToObserver<TRight>())
    {
    }

    public IObserver<TLeft> LeftObserver { get; private set; }

    public IObserver<TRight> RightObserver { get; private set; }

    void IObserver<Either<Notification<TLeft>, Notification<TRight>>>.OnNext(
      Either<Notification<TLeft>, Notification<TRight>> value)
    {
      value.Switch((Action<Notification<TLeft>>) (left => left.Accept(this.LeftObserver)), (Action<Notification<TRight>>) (right => right.Accept(this.RightObserver)));
    }

    void IObserver<Either<Notification<TLeft>, Notification<TRight>>>.OnError(
      Exception exception)
    {
    }

    void IObserver<Either<Notification<TLeft>, Notification<TRight>>>.OnCompleted()
    {
    }
  }
}
