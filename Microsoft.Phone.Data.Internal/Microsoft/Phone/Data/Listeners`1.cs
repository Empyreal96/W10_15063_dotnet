// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Listeners`1
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class Listeners<TElem> where TElem : class
  {
    private readonly List<TElem> listeners;
    private readonly Listeners<TElem>.Func<TElem, bool> filter;
    private readonly int ObjectID;
    private int _listenerReaderCount;

    internal Listeners(int ObjectID, Listeners<TElem>.Func<TElem, bool> notifyFilter)
    {
      this.listeners = new List<TElem>();
      this.filter = notifyFilter;
      this.ObjectID = ObjectID;
      this._listenerReaderCount = 0;
    }

    internal bool HasListeners => 0 < this.listeners.Count;

    internal void Add(TElem listener)
    {
      Debug.Assert((object) listener != null, "null listener");
      Debug.Assert(!Index.ContainsReference<TElem>(this.listeners, listener), "already contains reference");
      this.listeners.Add(listener);
    }

    internal int IndexOfReference(TElem listener) => Index.IndexOfReference<TElem>(this.listeners, listener);

    internal void Remove(TElem listener)
    {
      Debug.Assert((object) listener != null, "null listener");
      int index = this.IndexOfReference(listener);
      Debug.Assert(0 <= index, "listeners don't contain listener");
      this.listeners[index] = default (TElem);
      if (this._listenerReaderCount != 0)
        return;
      this.listeners.RemoveAt(index);
      this.listeners.TrimExcess();
    }

    internal void Notify<T1, T2, T3>(
      T1 arg1,
      T2 arg2,
      T3 arg3,
      Listeners<TElem>.Action<TElem, T1, T2, T3> action)
    {
      Debug.Assert(action != null, "no action");
      Debug.Assert(0 <= this._listenerReaderCount, "negative _listEventCount");
      int count = this.listeners.Count;
      if (0 >= count)
        return;
      int nullIndex = -1;
      ++this._listenerReaderCount;
      try
      {
        for (int index = 0; index < count; ++index)
        {
          TElem listener = this.listeners[index];
          if (this.filter(listener))
          {
            action(listener, arg1, arg2, arg3);
          }
          else
          {
            this.listeners[index] = default (TElem);
            nullIndex = index;
          }
        }
      }
      finally
      {
        --this._listenerReaderCount;
      }
      if (this._listenerReaderCount != 0)
        return;
      this.RemoveNullListeners(nullIndex);
    }

    private void RemoveNullListeners(int nullIndex)
    {
      Debug.Assert(-1 == nullIndex || (object) this.listeners[nullIndex] == null, "non-null listener");
      Debug.Assert(this._listenerReaderCount == 0, "0 < _listenerReaderCount");
      for (int index = nullIndex; 0 <= index; --index)
      {
        if ((object) this.listeners[index] == null)
          this.listeners.RemoveAt(index);
      }
    }

    internal delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4) where TElem : class;

    internal delegate TResult Func<T1, TResult>(T1 arg1) where TElem : class;
  }
}
