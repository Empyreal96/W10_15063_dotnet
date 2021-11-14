// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.TimeInterval`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Phone.Reactive
{
  public struct TimeInterval<T>
  {
    private readonly TimeSpan interval;
    private readonly T value;

    public TimeInterval(T value, TimeSpan interval)
    {
      this.interval = interval;
      this.value = value;
    }

    public TimeSpan Interval => this.interval;

    public T Value => this.value;

    public override bool Equals(object obj) => obj is TimeInterval<T> timeInterval && timeInterval.Interval.Equals(this.Interval) && object.Equals((object) this.Value, (object) timeInterval.Value);

    public override int GetHashCode()
    {
      int num = (object) this.Value == null ? 1963 : this.Value.GetHashCode();
      return this.Interval.GetHashCode() ^ num;
    }

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0}@{1}", (object) this.Value, (object) this.Interval);

    public static bool operator ==(TimeInterval<T> first, TimeInterval<T> second) => first.Equals((object) second);

    public static bool operator !=(TimeInterval<T> first, TimeInterval<T> second) => !first.Equals((object) second);
  }
}
