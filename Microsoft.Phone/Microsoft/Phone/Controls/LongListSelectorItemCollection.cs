// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.LongListSelectorItemCollection
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Microsoft.Phone.Controls
{
  internal abstract class LongListSelectorItemCollection : IEnumerable, IDisposable
  {
    internal const int InvalidIndex = -1;
    protected IList _source;
    private bool _hasListHeader;
    private bool _hasListFooter;
    private bool _hasGroupHeader;
    private bool _hasGroupFooter;
    private bool _includeEmptyGroups;
    private NotifyCollectionChangedEventHandler _collectionChanged;

    protected LongListSelectorItemCollection(
      IList source,
      NotifyCollectionChangedEventHandler collectionChanged)
    {
      this._source = source;
      this._collectionChanged = collectionChanged;
    }

    public abstract Iterator<LongListSelectorItem> GetIterator();

    public abstract Iterator<LongListSelectorItem> GetIterator(
      object data,
      bool? isGroup);

    public abstract Iterator<LongListSelectorItem> GetHeaderIterator();

    public virtual void Dispose()
    {
    }

    public IEnumerator<LongListSelectorItem> GetEnumerator() => (IEnumerator<LongListSelectorItem>) this.GetIterator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetIterator();

    public abstract IEnumerable<IList> GetGroupLists();

    public object ListHeader { get; set; }

    public object ListFooter { get; set; }

    public bool HasListHeader
    {
      get => this._hasListHeader;
      set
      {
        if (value == this._hasListHeader)
          return;
        this._hasListHeader = value;
        this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(this._hasListHeader ? (NotifyCollectionChangedAction) 0 : (NotifyCollectionChangedAction) 1, (object) new LongListSelectorItem(this.ListHeader, LongListSelectorItemKind.ListHeader, (object) null, -1), -1));
      }
    }

    public bool HasListFooter
    {
      get => this._hasListFooter;
      set
      {
        if (value == this._hasListFooter)
          return;
        this._hasListFooter = value;
        this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(this._hasListFooter ? (NotifyCollectionChangedAction) 0 : (NotifyCollectionChangedAction) 1, (object) new LongListSelectorItem(this.ListFooter, LongListSelectorItemKind.ListFooter, (object) null, -1), -1));
      }
    }

    public virtual bool HasGroupHeader
    {
      get => this._hasGroupHeader;
      set => this._hasGroupHeader = value;
    }

    public virtual bool HasGroupFooter
    {
      get => this._hasGroupFooter;
      set => this._hasGroupFooter = value;
    }

    public virtual bool IncludeEmptyGroups
    {
      get => this._includeEmptyGroups;
      set => this._includeEmptyGroups = value;
    }

    protected void FireCollectionChanged(NotifyCollectionChangedEventArgs args)
    {
      if (this._collectionChanged == null)
        return;
      this._collectionChanged.Invoke((object) this, args);
    }

    private class IListTReadWrapper<TItem> : IList, ICollection, IEnumerable
    {
      private IList<TItem> _source;

      internal IListTReadWrapper(IList<TItem> source) => this._source = source;

      public object this[int index]
      {
        get => (object) this._source[index];
        set => throw new NotSupportedException(Resources.ItemCollection_NotSupportedReadOnlyCollection);
      }

      public bool IsFixedSize => true;

      public bool IsReadOnly => true;

      public int IndexOf(object value)
      {
        int num = -1;
        if (value != null)
        {
          if (typeof (TItem).IsAssignableFrom(value.GetType()))
            num = this._source.IndexOf((TItem) value);
        }
        else
          num = this._source.IndexOf(default (TItem));
        return num;
      }

      public bool Contains(object value) => this.IndexOf(value) >= 0;

      public void Insert(int index, object value) => throw new NotSupportedException(Resources.ItemCollection_NotSupportedReadOnlyCollection);

      public int Add(object value) => throw new NotSupportedException(Resources.ItemCollection_NotSupportedReadOnlyCollection);

      public void Clear() => throw new NotSupportedException(Resources.ItemCollection_NotSupportedReadOnlyCollection);

      public void Remove(object value) => throw new NotSupportedException(Resources.ItemCollection_NotSupportedReadOnlyCollection);

      public void RemoveAt(int index) => throw new NotSupportedException(Resources.ItemCollection_NotSupportedReadOnlyCollection);

      public int Count => this._source.Count;

      public bool IsSynchronized => false;

      public object SyncRoot => (object) this._source;

      public void CopyTo(Array array, int index)
      {
        if (array == null || !typeof (TItem[]).IsAssignableFrom(array.GetType()))
          throw new ArgumentException(Resources.ItemCollection_NotSupportedReadOnlyCollection);
        this._source.CopyTo((TItem[]) array, index);
      }

      public IEnumerator GetEnumerator() => (IEnumerator) this._source.GetEnumerator();
    }

    protected abstract class ItemIterator<TCollection> : Iterator<LongListSelectorItem>
      where TCollection : LongListSelectorItemCollection
    {
      protected const int BOF = -1;
      protected const int EOF = 5;
      protected TCollection _collection;
      protected IList _currentItemList;
      protected int _currentListIndex = -1;
      protected int _itemKind = -1;
      protected LongListSelectorItem _current;
      protected object _currentGroup;
      protected bool _isBetweenItems;
      private WeakCollectionChangedListenerToken _sourceChangedListener;

      internal ItemIterator(TCollection collection)
      {
        this._collection = collection;
        this._currentItemList = this._collection._source;
        IList source = this._collection._source;
        LongListSelectorItemCollection.ItemIterator<TCollection> itemIterator = this;
        // ISSUE: virtual method pointer
        NotifyCollectionChangedEventHandler handler = new NotifyCollectionChangedEventHandler((object) itemIterator, __vmethodptr(itemIterator, OnSourceCollectionChanged));
        this._sourceChangedListener = WeakCollectionChangedListener.CreateIfNecessary((object) source, handler);
      }

      ~ItemIterator() => this.DisconnectListener();

      public override LongListSelectorItem Current
      {
        get
        {
          LongListSelectorItem current = this._current;
          if (this._itemKind != -1 && this._itemKind != 5)
            return current;
          this._current = new LongListSelectorItem();
          return current;
        }
      }

      public override void Reset() => this.GotoBOF();

      public override void Dispose()
      {
        this.DisconnectListener();
        GC.SuppressFinalize((object) this);
      }

      protected void CopyTo(
        LongListSelectorItemCollection.ItemIterator<TCollection> clone)
      {
        clone._current = this._current;
        clone._currentItemList = this._currentItemList;
        clone._currentListIndex = this._currentListIndex;
        clone._itemKind = this._itemKind;
      }

      protected virtual bool AdvanceTo(object item)
      {
        bool flag = false;
        while (this.MoveNext())
        {
          if (object.Equals(this._current.Data, item))
          {
            flag = true;
            break;
          }
        }
        return flag;
      }

      protected virtual bool GotoListHeader()
      {
        int num = this._collection.HasListHeader ? 1 : 0;
        if (num == 0)
          return num != 0;
        this._currentListIndex = -1;
        this.UpdateCurrentItem(LongListSelectorItemKind.ListHeader);
        return num != 0;
      }

      protected virtual bool GotoListFooter()
      {
        int num = this._collection.HasListFooter ? 1 : 0;
        if (num == 0)
          return num != 0;
        this._currentListIndex = this._currentItemList != null ? this._currentItemList.Count : 0;
        this.UpdateCurrentItem(LongListSelectorItemKind.ListFooter);
        return num != 0;
      }

      protected virtual bool GotoNextItem()
      {
        bool flag = false;
        if (this._currentItemList != null && this._currentListIndex < this._currentItemList.Count - 1)
        {
          ++this._currentListIndex;
          this.UpdateCurrentItem(LongListSelectorItemKind.Item);
          flag = true;
        }
        return flag;
      }

      protected virtual bool GotoPreviousItem()
      {
        bool flag = false;
        if (this._currentItemList != null)
        {
          if (this._currentListIndex > this._currentItemList.Count || this._itemKind == 4 || (this._itemKind == 3 || this._itemKind == 5))
            this._currentListIndex = this._currentItemList.Count;
          if (this._currentListIndex > 0)
          {
            --this._currentListIndex;
            this.UpdateCurrentItem(LongListSelectorItemKind.Item);
            flag = true;
          }
        }
        return flag;
      }

      protected virtual bool UpdateCurrentItem(LongListSelectorItemKind ItemKind)
      {
        bool flag = true;
        this._itemKind = (int) ItemKind;
        switch (ItemKind)
        {
          case LongListSelectorItemKind.ListHeader:
            this._current = new LongListSelectorItem(this._collection.ListHeader, ItemKind, (object) null, -1);
            break;
          case LongListSelectorItemKind.Item:
            if (this._currentListIndex >= 0 && this._currentListIndex < this._currentItemList.Count)
            {
              this._current = new LongListSelectorItem(this._currentItemList[this._currentListIndex], ItemKind, this._currentGroup, this._currentListIndex);
              break;
            }
            break;
          case LongListSelectorItemKind.ListFooter:
            this._current = new LongListSelectorItem(this._collection.ListFooter, ItemKind, (object) null, -1);
            break;
          default:
            flag = false;
            break;
        }
        return flag;
      }

      protected virtual bool GotoBOF()
      {
        this._itemKind = -1;
        this._currentListIndex = -1;
        this._current = new LongListSelectorItem();
        return false;
      }

      protected virtual bool GotoEOF()
      {
        this._itemKind = 5;
        this._currentListIndex = this._currentItemList != null ? this._currentItemList.Count : 0;
        this._current = new LongListSelectorItem();
        return false;
      }

      protected virtual void OnSourceCollectionChanged(
        object sender,
        NotifyCollectionChangedEventArgs e)
      {
        switch ((int) e.Action)
        {
          case 0:
            if (this._currentListIndex == 0 && this._itemKind == 5)
            {
              this.UpdateCurrentItem(LongListSelectorItemKind.Item);
              break;
            }
            if (e.NewStartingIndex > this._currentListIndex)
              break;
            this._currentListIndex += e.NewItems.Count;
            this.UpdateCurrentItem((LongListSelectorItemKind) this._itemKind);
            break;
          case 1:
            if (e.OldStartingIndex < this._currentListIndex)
            {
              this._currentListIndex -= e.OldItems.Count;
              this.UpdateCurrentItem((LongListSelectorItemKind) this._itemKind);
              break;
            }
            if (e.OldStartingIndex != this._currentListIndex)
              break;
            this._isBetweenItems = true;
            break;
          case 2:
            if (this._currentListIndex != e.NewStartingIndex)
              break;
            this.UpdateCurrentItem((LongListSelectorItemKind) this._itemKind);
            break;
          case 4:
            this.Reset();
            this.MoveNext();
            break;
        }
      }

      private void DisconnectListener()
      {
        if (this._sourceChangedListener == null)
          return;
        this._sourceChangedListener.Disconnect();
        this._sourceChangedListener = (WeakCollectionChangedListenerToken) null;
      }

      public override bool IsCurrentValid => !this._isBetweenItems;
    }
  }
}
