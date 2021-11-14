// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.CollectionManager`1
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Microsoft.Phone.Maps.Controls
{
  internal abstract class CollectionManager<T> : Collection<T>
  {
    public void AddRange(IEnumerable<T> items)
    {
      foreach (T obj in items)
        this.Add(obj);
    }

    internal void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      switch ((int) e.Action)
      {
        case 0:
          for (int index = e.NewItems.Count - 1; index >= 0; --index)
            this.Insert(e.NewStartingIndex, (T) e.NewItems[index]);
          break;
        case 1:
          IEnumerator enumerator = e.OldItems.GetEnumerator();
          try
          {
            while (enumerator.MoveNext())
              this.Remove((T) enumerator.Current);
            break;
          }
          finally
          {
            if (enumerator is IDisposable disposable3)
              disposable3.Dispose();
          }
        case 2:
          foreach (T oldItem in (IEnumerable) e.OldItems)
            this.Remove(oldItem);
          for (int index = e.NewItems.Count - 1; index >= 0; --index)
            this.Insert(e.NewStartingIndex, (T) e.NewItems[index]);
          break;
        case 3:
          this.RemoveAt(e.OldStartingIndex);
          this.Insert(e.NewStartingIndex, (T) e.NewItems[0]);
          break;
        case 4:
          this.Clear();
          this.AddRange((IEnumerable<T>) sender);
          break;
      }
    }

    protected override void InsertItem(int index, T item)
    {
      if ((object) item == null)
        throw new ArgumentNullException(nameof (item));
      this.InsertItemInternal(index, item);
      base.InsertItem(index, item);
    }

    protected override void RemoveItem(int index)
    {
      this.RemoveItemInternal(this[index]);
      base.RemoveItem(index);
    }

    protected override void SetItem(int index, T item)
    {
      if ((object) item == null)
        throw new ArgumentNullException(nameof (item));
      this.RemoveItem(index);
      this.InsertItem(index, item);
    }

    protected override void ClearItems()
    {
      foreach (T obj in (Collection<T>) this)
        this.RemoveItemInternal(obj);
      base.ClearItems();
    }

    protected abstract void InsertItemInternal(int index, T obj);

    protected abstract void RemoveItemInternal(T obj);
  }
}
