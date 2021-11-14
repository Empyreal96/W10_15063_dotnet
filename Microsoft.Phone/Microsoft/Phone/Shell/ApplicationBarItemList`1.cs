// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBarItemList`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.Phone.Shell
{
  internal class ApplicationBarItemList<TApplicationBarItem> : 
    IList,
    ICollection,
    IEnumerable,
    IList<TApplicationBarItem>,
    ICollection<TApplicationBarItem>,
    IEnumerable<TApplicationBarItem>
    where TApplicationBarItem : IApplicationBarMenuItem
  {
    internal int MAX_ITEMS;
    private List<TApplicationBarItem> mList;
    private System.Collections.Generic.Dictionary<TApplicationBarItem, ApplicationBarItemContainer> mDictionary;
    private IListInterop mListInterop;
    private MenuBarItemType mMenuBarItemListType;
    private readonly int MinCommandID;
    private readonly int MaxCommandID;
    private static readonly int TotalMenuIDs = (int) ushort.MaxValue;
    private static readonly int MinButtonID = 0;
    private static readonly int MaxButtonID = ApplicationBarItemList<TApplicationBarItem>.TotalMenuIDs / 2;
    private static readonly int MinMenuID = ApplicationBarItemList<TApplicationBarItem>.TotalMenuIDs / 2 + 1;
    private static readonly int MaxMenuID = ApplicationBarItemList<TApplicationBarItem>.TotalMenuIDs;
    protected int mNextItemId;
    protected object mLock = new object();

    internal int NextItemId => this.mNextItemId < this.MaxCommandID ? Interlocked.Increment(ref this.mNextItemId) : throw new InvalidOperationException("Too many menu items created");

    internal void AttachToAppBar(IListInterop listInterop)
    {
      lock (this.mLock)
        this.mListInterop = listInterop;
    }

    internal void DetachFromAppBar()
    {
      lock (this.mLock)
      {
        this.mListInterop = (IListInterop) null;
        foreach (ApplicationBarItemContainer barItemContainer in this.mDictionary.Values)
          barItemContainer.DetachFromAppBar();
      }
    }

    internal ApplicationBarItemList(MenuBarItemType listType)
    {
      if (listType.IsButton())
      {
        this.MinCommandID = ApplicationBarItemList<TApplicationBarItem>.MinButtonID;
        this.MaxCommandID = ApplicationBarItemList<TApplicationBarItem>.MaxButtonID;
      }
      else
      {
        this.MinCommandID = ApplicationBarItemList<TApplicationBarItem>.MinMenuID;
        this.MaxCommandID = ApplicationBarItemList<TApplicationBarItem>.MaxMenuID;
      }
      this.mNextItemId = this.MinCommandID;
      this.mList = new List<TApplicationBarItem>();
      this.mDictionary = new System.Collections.Generic.Dictionary<TApplicationBarItem, ApplicationBarItemContainer>();
      this.mMenuBarItemListType = listType;
    }

    internal ApplicationBarItemContainer GetItemById(int id)
    {
      ApplicationBarItemContainer barItemContainer1 = (ApplicationBarItemContainer) null;
      lock (this.mLock)
      {
        foreach (ApplicationBarItemContainer barItemContainer2 in this.mDictionary.Values)
        {
          if (barItemContainer2.IdCommand == id)
          {
            barItemContainer1 = barItemContainer2;
            break;
          }
        }
      }
      return barItemContainer1;
    }

    public int IndexOf(TApplicationBarItem item)
    {
      lock (this.mLock)
        return this.mList.IndexOf(item);
    }

    public void Insert(int index, TApplicationBarItem item)
    {
      if ((object) item == null)
        throw new ArgumentNullException(nameof (item));
      lock (this.mLock)
      {
        if (index < 0 || index > this.mList.Count)
          throw new ArgumentOutOfRangeException(nameof (item));
        if (this.mList.Count == this.MAX_ITEMS)
          throw new InvalidOperationException("Too many items in list");
        ApplicationBarItemContainer barItemContainer = !this.mDictionary.ContainsKey(item) ? ApplicationBarItemContainerFactory.GetApplicationBarItemContainer((IApplicationBarMenuItem) item, this.mMenuBarItemListType) : throw new InvalidOperationException("Cannot add same item to multiple lists at once or to same list twice");
        barItemContainer.BeginAttachToAppBar();
        int nextItemId = this.NextItemId;
        this.mListInterop.InsertMenuItem(nextItemId, barItemContainer.Type, index);
        barItemContainer.AttachToAppBar(this.mListInterop, nextItemId);
        this.mList.Insert(index, item);
        this.mDictionary[item] = barItemContainer;
      }
    }

    public void RemoveAt(int index)
    {
      lock (this.mLock)
      {
        TApplicationBarItem m1 = this.mList[index];
        ApplicationBarItemContainer m2 = this.mDictionary[m1];
        this.mListInterop.RemoveMenuItem(m2.Type, index);
        this.mList.Remove(m1);
        m2.DetachFromAppBar();
        this.mDictionary.Remove(m1);
      }
    }

    public TApplicationBarItem this[int index]
    {
      get => this.mList[index];
      set
      {
        lock (this.mLock)
        {
          this.RemoveAt(index);
          this.Insert(index, value);
        }
      }
    }

    public void Add(TApplicationBarItem item) => this.Insert(this.mList.Count, item);

    public void Clear()
    {
      while (this.mList.Count > 0)
        this.RemoveAt(0);
    }

    public bool Contains(TApplicationBarItem item) => this.mList.Contains(item);

    public void CopyTo(TApplicationBarItem[] array, int arrayIndex) => this.mList.CopyTo(array, arrayIndex);

    public int Count => this.mList.Count;

    public bool IsReadOnly => false;

    public bool Remove(TApplicationBarItem item)
    {
      lock (this.mLock)
      {
        int index = this.mList.IndexOf(item);
        if (index == -1)
          return false;
        this.RemoveAt(index);
      }
      return true;
    }

    public IEnumerator<TApplicationBarItem> GetEnumerator() => (IEnumerator<TApplicationBarItem>) this.mList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.mList.GetEnumerator();

    int IList.Add(object value)
    {
      if (value == null)
        throw new ArgumentNullException("item");
      if (!(value is TApplicationBarItem applicationBarItem))
        throw new ArgumentException("This list does not support that type");
      this.Add(applicationBarItem);
      return this.mList.Count;
    }

    bool IList.Contains(object value) => value != null && value is TApplicationBarItem applicationBarItem && this.Contains(applicationBarItem);

    int IList.IndexOf(object value) => value == null || !(value is TApplicationBarItem applicationBarItem) ? -1 : this.IndexOf(applicationBarItem);

    void IList.Insert(int index, object value)
    {
      if (value == null)
        throw new ArgumentNullException("item");
      if (!(value is TApplicationBarItem applicationBarItem))
        throw new ArgumentException("This list does not support that type");
      this.Insert(index, applicationBarItem);
    }

    bool IList.IsFixedSize => false;

    void IList.Remove(object value)
    {
      if (value == null || !(value is TApplicationBarItem applicationBarItem))
        return;
      this.Remove(applicationBarItem);
    }

    object IList.this[int index]
    {
      get => (object) this[index];
      set => this[index] = (TApplicationBarItem) value;
    }

    public void CopyTo(Array array, int index) => Array.Copy((Array) this.mList.ToArray(), array, this.mList.Count);

    public bool IsSynchronized => false;

    public object SyncRoot => this.mLock;

    internal IListInterop ListInterop => this.mListInterop;

    internal System.Collections.Generic.Dictionary<TApplicationBarItem, ApplicationBarItemContainer> Dictionary => this.mDictionary;
  }
}
