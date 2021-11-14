// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.WeakReferenceCache
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  internal class WeakReferenceCache
  {
    private bool _trackResurrection;
    protected WeakReference[] items;

    static WeakReferenceCache() => KillBitHelper.ThrowIfKillBitIsSet();

    internal int Count
    {
      get
      {
        lock (this)
          return this.items.Length;
      }
    }

    internal WeakReferenceCache(bool trackResurrection)
    {
      this.items = new WeakReference[20];
      this._trackResurrection = trackResurrection;
    }

    internal int Add(object value)
    {
      lock (this)
      {
        int length = this.items.Length;
        for (int index = 0; index < length; ++index)
        {
          WeakReference weakReference = this.items[index];
          if (weakReference == null)
          {
            this.items[index] = new WeakReference(value);
            return index;
          }
          if (!ADP.IsAlive(weakReference))
          {
            weakReference.Target = value;
            return index;
          }
        }
        WeakReference[] weakReferenceArray = new WeakReference[5 == length ? 15 : length + 15];
        for (int index = 0; index < length; ++index)
          weakReferenceArray[index] = this.items[index];
        weakReferenceArray[length] = new WeakReference(value);
        this.items = weakReferenceArray;
        return length;
      }
    }

    internal object GetObject(int indx)
    {
      lock (this)
      {
        WeakReference weakReference = this.items[indx];
        return ADP.IsAlive(weakReference) ? weakReference.Target : (object) null;
      }
    }

    internal void Remove(object value)
    {
      lock (this)
      {
        int length = this.items.Length;
        for (int index = 0; index < length; ++index)
        {
          WeakReference weakReference = this.items[index];
          if (ADP.IsAlive(weakReference) && value == weakReference.Target)
          {
            this.items[index] = (WeakReference) null;
            break;
          }
        }
      }
    }

    internal void RemoveAt(int index)
    {
      lock (this)
        this.items[index] = (WeakReference) null;
    }
  }
}
