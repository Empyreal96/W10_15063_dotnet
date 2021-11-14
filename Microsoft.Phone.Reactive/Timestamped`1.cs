// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Timestamped`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Phone.Reactive
{
  public struct Timestamped<T>
  {
    private readonly T value;
    private DateTimeOffset timestamp;

    public Timestamped(T value, DateTimeOffset timestamp)
    {
      this.timestamp = timestamp;
      this.value = value;
    }

    public DateTimeOffset Timestamp => this.timestamp;

    public T Value => this.value;

    public override bool Equals(object obj) => obj is Timestamped<T> timestamped && timestamped.Timestamp.Equals(this.Timestamp) && EqualityComparer<T>.Default.Equals(this.Value, timestamped.Value);

    public override int GetHashCode()
    {
      int num = (object) this.Value == null ? 1979 : this.Value.GetHashCode();
      return this.timestamp.GetHashCode() ^ num;
    }

    public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0}@{1}", (object) this.Value, (object) this.Timestamp);

    public static bool operator ==(Timestamped<T> first, Timestamped<T> second) => first.Equals((object) second);

    public static bool operator !=(Timestamped<T> first, Timestamped<T> second) => !first.Equals((object) second);
  }
}
