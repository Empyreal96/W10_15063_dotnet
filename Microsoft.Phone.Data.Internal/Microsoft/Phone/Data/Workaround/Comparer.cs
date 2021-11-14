// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.Comparer
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Globalization;

namespace Microsoft.Phone.Data.Workaround
{
  internal sealed class Comparer : IComparer
  {
    private CompareInfo m_compareInfo;
    public static readonly Comparer Default = new Comparer(CultureInfo.CurrentCulture);
    public static readonly Comparer DefaultInvariant = new Comparer(CultureInfo.InvariantCulture);

    private Comparer() => this.m_compareInfo = (CompareInfo) null;

    public Comparer(CultureInfo culture) => this.m_compareInfo = culture != null ? culture.CompareInfo : throw new ArgumentNullException(nameof (culture));

    public int Compare(object a, object b)
    {
      if (a == b)
        return 0;
      if (a == null)
        return -1;
      if (b == null)
        return 1;
      if (this.m_compareInfo != null)
      {
        string string1 = a as string;
        string string2 = b as string;
        if (string1 != null && string2 != null)
          return this.m_compareInfo.Compare(string1, string2);
      }
      return a is IComparable comparable ? comparable.CompareTo(b) : throw new ArgumentException();
    }
  }
}
