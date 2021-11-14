// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.KeyValuePairsEnumerator`2
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;
using System.Collections.Generic;

namespace System.Data.SqlServerCe
{
  internal class KeyValuePairsEnumerator<TKey, TValue> : IEnumerator
  {
    private IEnumerator<KeyValuePair<TKey, TValue>> m_collection;

    static KeyValuePairsEnumerator() => KillBitHelper.ThrowIfKillBitIsSet();

    public KeyValuePairsEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator) => this.m_collection = enumerator;

    public void Reset() => this.m_collection.Reset();

    public bool MoveNext() => this.m_collection.MoveNext();

    public object Current => (object) this.m_collection.Current.Value;
  }
}
