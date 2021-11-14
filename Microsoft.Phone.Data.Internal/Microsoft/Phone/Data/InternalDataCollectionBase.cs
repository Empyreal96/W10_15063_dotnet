// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.InternalDataCollectionBase
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public class InternalDataCollectionBase : ICollection, IEnumerable
  {
    internal static CollectionChangeEventArgs RefreshEventArgs = new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) null);

    public virtual int Count => this.List.Count;

    public virtual void CopyTo(Array ar, int index) => this.List.CopyTo(ar, index);

    public virtual IEnumerator GetEnumerator() => this.List.GetEnumerator();

    public bool IsReadOnly => false;

    public bool IsSynchronized => false;

    internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale)
    {
      if (fCaseSensitive)
        return string.Compare(s1, s2, locale, CompareOptions.None) == 0 ? 1 : 0;
      if (locale.CompareInfo.Compare(s1, s2, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth) != 0)
        return 0;
      return string.Compare(s1, s2, locale, CompareOptions.None) == 0 ? 1 : -1;
    }

    public object SyncRoot => (object) this;

    protected virtual Microsoft.Phone.Data.Workaround.ArrayList List => (Microsoft.Phone.Data.Workaround.ArrayList) null;
  }
}
