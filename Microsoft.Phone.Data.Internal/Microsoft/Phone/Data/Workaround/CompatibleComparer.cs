// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.CompatibleComparer
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;

namespace Microsoft.Phone.Data.Workaround
{
  internal class CompatibleComparer : IEqualityComparer
  {
    private IComparer _comparer;
    private IHashCodeProvider _hcp;

    internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
    {
      this._comparer = comparer;
      this._hcp = hashCodeProvider;
    }

    public int Compare(object a, object b)
    {
      if (a == b)
        return 0;
      if (a == null)
        return -1;
      if (b == null)
        return 1;
      if (this._comparer != null)
        return this._comparer.Compare(a, b);
      if (a is IComparable comparable1)
        return comparable1.CompareTo(b);
      int num = b is IComparable comparable2 ? comparable2.CompareTo(a) : throw new ArgumentException("a, b");
      return num == int.MinValue ? 1 : -num;
    }

    public bool Equals(object a, object b) => this.Compare(a, b) == 0;

    public int GetHashCode(object obj)
    {
      if (obj == null)
        throw new ArgumentNullException(nameof (obj));
      return this._hcp != null ? this._hcp.GetHashCode(obj) : obj.GetHashCode();
    }

    internal IComparer Comparer => this._comparer;

    internal IHashCodeProvider HashCodeProvider => this._hcp;
  }
}
