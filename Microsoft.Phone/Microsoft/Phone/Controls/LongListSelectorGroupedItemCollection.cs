// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.LongListSelectorGroupedItemCollection
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
  internal class LongListSelectorGroupedItemCollection : LongListSelectorItemCollection
  {
    private WeakCollectionChangedListenerToken _sourceChangedListener;
    private IList<object> _groups = (IList<object>) new List<object>();
    private Dictionary<object, WeakCollectionChangedListenerToken> _groupChangedListeners = new Dictionary<object, WeakCollectionChangedListenerToken>();
    private NotifyCollectionChangedEventHandler _groupChanged;

    public LongListSelectorGroupedItemCollection(
      IList source,
      NotifyCollectionChangedEventHandler collectionChanged,
      NotifyCollectionChangedEventHandler groupChanged)
      : base(source, collectionChanged)
    {
      this._groupChanged = groupChanged;
      // ISSUE: method pointer
      this._sourceChangedListener = WeakCollectionChangedListener.CreateIfNecessary((object) source, new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnSourceCollectionChanged)));
      foreach (object group in (IEnumerable) this._source)
        this.AddGroup(group);
    }

    ~LongListSelectorGroupedItemCollection() => this.DisconnectListeners();

    public override void Dispose()
    {
      base.Dispose();
      this.DisconnectListeners();
      GC.SuppressFinalize((object) this);
    }

    public override bool HasGroupHeader
    {
      get => base.HasGroupHeader;
      set
      {
        if (this.HasGroupHeader == value)
          return;
        base.HasGroupHeader = value;
        this.FireGroupPartChangeEvents(this.HasGroupHeader, LongListSelectorItemKind.GroupHeader);
      }
    }

    public override bool HasGroupFooter
    {
      get => base.HasGroupFooter;
      set
      {
        if (this.HasGroupFooter == value)
          return;
        base.HasGroupFooter = value;
        this.FireGroupPartChangeEvents(this.HasGroupFooter, LongListSelectorItemKind.GroupFooter);
      }
    }

    public override bool IncludeEmptyGroups
    {
      get => base.IncludeEmptyGroups;
      set
      {
        if (this.IncludeEmptyGroups == value)
          return;
        base.IncludeEmptyGroups = value;
        NotifyCollectionChangedAction collectionChangedAction = this.IncludeEmptyGroups ? (NotifyCollectionChangedAction) 0 : (NotifyCollectionChangedAction) 1;
        foreach (object obj in (IEnumerable) this._source)
        {
          if (this.IsEmptyGroup(obj))
          {
            if (this.HasGroupHeader)
              this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(collectionChangedAction, (object) new LongListSelectorItem(obj, LongListSelectorItemKind.GroupHeader, obj, -1), -1));
            if (this.HasGroupFooter)
              this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(collectionChangedAction, (object) new LongListSelectorItem(obj, LongListSelectorItemKind.GroupFooter, obj, -1), -1));
          }
        }
      }
    }

    public override Iterator<LongListSelectorItem> GetIterator() => (Iterator<LongListSelectorItem>) new LongListSelectorGroupedItemCollection.GroupItemIterator(this);

    public override Iterator<LongListSelectorItem> GetIterator(
      object item,
      bool? isGroup)
    {
      return (Iterator<LongListSelectorItem>) LongListSelectorGroupedItemCollection.GroupItemIterator.Create(this, item, isGroup);
    }

    public override Iterator<LongListSelectorItem> GetHeaderIterator() => (Iterator<LongListSelectorItem>) new LongListSelectorGroupedItemCollection.HeaderIterator(this);

    public override IEnumerable<IList> GetGroupLists()
    {
      for (int index = 0; index < this._source.Count; ++index)
        yield return this._source[index] as IList;
    }

    private void AddGroup(object group)
    {
      if (group == null)
        throw new InvalidOperationException(Resources.LongListSelector_NullGroup);
      if (this._groups.Contains(group))
        throw new InvalidOperationException(Resources.LongListSelector_DuplicateGroups);
      this._groups.Add(group);
      // ISSUE: method pointer
      WeakCollectionChangedListenerToken ifNecessary = WeakCollectionChangedListener.CreateIfNecessary(group, new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnGroupCollectionChanged)));
      if (ifNecessary == null)
        return;
      this._groupChangedListeners[group] = ifNecessary;
    }

    private void RemoveGroup(object group)
    {
      this._groups.Remove(group);
      if (!this._groupChangedListeners.ContainsKey(group))
        return;
      this._groupChangedListeners[group].Disconnect();
      this._groupChangedListeners.Remove(group);
    }

    private void OnSourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
    {
      switch ((int) args.Action)
      {
        case 0:
          this.AddGroup(args.NewItems[0]);
          this.FireGroupChanged(new NotifyCollectionChangedEventArgs(args.Action, args.NewItems[0], -1));
          break;
        case 1:
          this.RemoveGroup(args.OldItems[0]);
          this.FireGroupChanged(new NotifyCollectionChangedEventArgs(args.Action, args.OldItems[0], -1));
          break;
        case 2:
          this.RemoveGroup(args.OldItems[0]);
          this.AddGroup(args.NewItems[0]);
          this.FireGroupChanged(new NotifyCollectionChangedEventArgs(args.Action, args.NewItems[0], args.OldItems[0], -1));
          break;
        case 4:
          IList<object> objectList = (IList<object>) new List<object>((IEnumerable<object>) this._groups);
          foreach (object group in (IEnumerable) this._source)
          {
            int index = objectList.IndexOf(group);
            if (index >= 0)
              objectList.RemoveAt(index);
            else
              this.AddGroup(group);
          }
          foreach (object group in (IEnumerable<object>) objectList)
            this.RemoveGroup(group);
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs((NotifyCollectionChangedAction) 4));
          break;
      }
    }

    private void OnGroupCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
    {
      IList list = sender as IList;
      switch ((int) args.Action)
      {
        case 0:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action, (object) new LongListSelectorItem(args.NewItems[0], LongListSelectorItemKind.Item, sender, -1), -1));
          if (this.IncludeEmptyGroups || list == null || list.Count != 1)
            break;
          this.FireGroupEmptyChangeEvents(false, sender);
          break;
        case 1:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action, (object) new LongListSelectorItem(args.OldItems[0], LongListSelectorItemKind.Item, sender, -1), -1));
          if (this.IncludeEmptyGroups || list == null || list.Count != 0)
            break;
          this.FireGroupEmptyChangeEvents(true, sender);
          break;
        case 2:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action, (object) new LongListSelectorItem(args.NewItems[0], LongListSelectorItemKind.Item, sender, -1), (object) new LongListSelectorItem(args.OldItems[0], LongListSelectorItemKind.Item, sender, -1), -1));
          break;
        case 4:
          object obj = sender;
          this.FireGroupChanged(new NotifyCollectionChangedEventArgs((NotifyCollectionChangedAction) 2, obj, obj, -1));
          break;
      }
    }

    private bool IsEmptyGroup(object group) => !(group is IList list) || list.Count == 0;

    private bool ShouldDisplayGroup(object group) => this.IncludeEmptyGroups || !this.IsEmptyGroup(group);

    private void FireGroupPartChangeEvents(bool added, LongListSelectorItemKind ItemKind)
    {
      NotifyCollectionChangedAction collectionChangedAction = added ? (NotifyCollectionChangedAction) 0 : (NotifyCollectionChangedAction) 1;
      foreach (object obj in (IEnumerable) this._source)
      {
        if (this.ShouldDisplayGroup(obj))
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(collectionChangedAction, (object) new LongListSelectorItem(obj, ItemKind, obj, -1), -1));
      }
    }

    private void FireGroupEmptyChangeEvents(bool isEmpty, object group)
    {
      NotifyCollectionChangedAction collectionChangedAction = isEmpty ? (NotifyCollectionChangedAction) 1 : (NotifyCollectionChangedAction) 0;
      if (this.HasGroupHeader)
        this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(collectionChangedAction, (object) new LongListSelectorItem(group, LongListSelectorItemKind.GroupHeader, group, -1), -1));
      if (!this.HasGroupFooter)
        return;
      this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(collectionChangedAction, (object) new LongListSelectorItem(group, LongListSelectorItemKind.GroupFooter, group, -1), -1));
    }

    private void FireGroupChanged(NotifyCollectionChangedEventArgs args)
    {
      if (this._groupChanged == null)
        return;
      this._groupChanged.Invoke((object) this, args);
    }

    private void DisconnectListeners()
    {
      if (this._sourceChangedListener != null)
      {
        this._sourceChangedListener.Disconnect();
        this._sourceChangedListener = (WeakCollectionChangedListenerToken) null;
      }
      foreach (KeyValuePair<object, WeakCollectionChangedListenerToken> groupChangedListener in this._groupChangedListeners)
        groupChangedListener.Value.Disconnect();
      this._groupChangedListeners.Clear();
    }

    protected class GroupItemIterator : 
      LongListSelectorItemCollection.ItemIterator<LongListSelectorGroupedItemCollection>
    {
      private int _groupIndex = -1;
      private IList _groupList;
      private WeakCollectionChangedListenerToken _currentNotifyGroupChangedListener;
      private bool _isBetweenGroups;

      internal GroupItemIterator(LongListSelectorGroupedItemCollection collection)
        : base(collection)
      {
        this._groupList = collection._source;
        this._currentItemList = (IList) null;
      }

      internal static LongListSelectorGroupedItemCollection.GroupItemIterator Create(
        LongListSelectorGroupedItemCollection collection,
        object item,
        bool? isGroup)
      {
        LongListSelectorGroupedItemCollection.GroupItemIterator groupItemIterator = new LongListSelectorGroupedItemCollection.GroupItemIterator(collection);
        if (!groupItemIterator.AdvanceTo(item, isGroup))
          groupItemIterator = (LongListSelectorGroupedItemCollection.GroupItemIterator) null;
        return groupItemIterator;
      }

      private bool ShouldDisplayCurrentGroup => this._collection.ShouldDisplayGroup(this._currentGroup);

      public override bool MoveNext()
      {
        if (this._isBetweenGroups)
        {
          this._isBetweenItems = this._isBetweenGroups = false;
          if (!this.GotoPreviousGroup() && !this.GotoListHeader())
            this.GotoBOF();
        }
        else if (this._isBetweenItems)
        {
          this._isBetweenItems = false;
          this.MovePrevious();
        }
        switch (this._itemKind)
        {
          case -1:
            return this.GotoListHeader() || this.GotoNextGroup() || this.GotoListFooter() || this.GotoEOF();
          case 0:
            return this.GotoNextGroup() || this.GotoListFooter() || this.GotoEOF();
          case 1:
            return this.GotoNextItem() || this.GotoGroupFooter() || (this.GotoNextGroup() || this.GotoListFooter()) || this.GotoEOF();
          case 2:
            return this.GotoNextItem() || this.GotoGroupFooter() || (this.GotoNextGroup() || this.GotoListFooter()) || this.GotoEOF();
          case 3:
            return this.GotoNextGroup() || this.GotoListFooter() || this.GotoEOF();
          case 4:
            return this.GotoEOF();
          case 5:
            return false;
          default:
            throw new InvalidOperationException(Resources.ItemIterator_InvalidState);
        }
      }

      public override bool MovePrevious()
      {
        if (this._isBetweenGroups)
        {
          this._isBetweenGroups = false;
          this._itemKind = 1;
        }
        this._isBetweenItems = false;
        switch (this._itemKind)
        {
          case -1:
            return false;
          case 0:
            return this.GotoBOF();
          case 1:
            return this.GotoPreviousGroup() || this.GotoListHeader() || this.GotoBOF();
          case 2:
            return this.GotoPreviousItem() || this.GotoGroupHeader() || (this.GotoPreviousGroup() || this.GotoListHeader()) || this.GotoBOF();
          case 3:
            return this.GotoPreviousItem() || this.GotoGroupHeader() || (this.GotoPreviousGroup() || this.GotoListHeader()) || this.GotoBOF();
          case 4:
            return this.GotoPreviousGroup() || this.GotoListHeader() || this.GotoBOF();
          case 5:
            return this.GotoListFooter() || this.GotoPreviousGroup() || this.GotoListHeader() || this.GotoBOF();
          default:
            throw new InvalidOperationException(Resources.ItemIterator_InvalidState);
        }
      }

      public override Iterator<LongListSelectorItem> Clone()
      {
        LongListSelectorGroupedItemCollection.GroupItemIterator groupItemIterator = new LongListSelectorGroupedItemCollection.GroupItemIterator(this._collection);
        this.CopyTo((LongListSelectorItemCollection.ItemIterator<LongListSelectorGroupedItemCollection>) groupItemIterator);
        groupItemIterator._groupIndex = this._groupIndex;
        groupItemIterator._groupList = this._groupList;
        groupItemIterator.UpdateCurrentGroup();
        return (Iterator<LongListSelectorItem>) groupItemIterator;
      }

      protected override bool UpdateCurrentItem(LongListSelectorItemKind ItemKind)
      {
        if (!base.UpdateCurrentItem(ItemKind))
          this._current = new LongListSelectorItem(this._currentGroup, ItemKind, this._currentGroup, -1);
        return true;
      }

      protected override bool GotoBOF()
      {
        this._groupIndex = -1;
        this.UpdateCurrentGroup();
        return base.GotoBOF();
      }

      protected override bool GotoEOF()
      {
        this._groupIndex = this._groupList.Count;
        this.UpdateCurrentGroup();
        return base.GotoEOF();
      }

      protected override bool GotoListHeader()
      {
        int num = base.GotoListHeader() ? 1 : 0;
        if (num == 0)
          return num != 0;
        this._groupIndex = -1;
        this.UpdateCurrentGroup();
        return num != 0;
      }

      protected override bool GotoListFooter()
      {
        int num = base.GotoListFooter() ? 1 : 0;
        if (num == 0)
          return num != 0;
        this._groupIndex = this._groupList.Count;
        this.UpdateCurrentGroup();
        return num != 0;
      }

      private bool AdvanceTo(object data, bool? isGroup)
      {
        bool flag = false;
        if (!isGroup.HasValue || isGroup.Value)
        {
          int num = this._groupList.IndexOf(data);
          if (num >= 0)
          {
            this._groupIndex = num - 1;
            this._itemKind = 3;
            this.MoveNext();
            flag = true;
          }
        }
        if (!flag && !isGroup.GetValueOrDefault())
          flag = this.AdvanceTo(data);
        return flag;
      }

      private bool GotoNextGroup()
      {
        bool flag;
        for (flag = false; !flag && this._groupIndex < this._groupList.Count - 1; flag = this.GotoGroupHeader() || this.GotoNextItem() || this.GotoGroupFooter())
        {
          ++this._groupIndex;
          this.UpdateCurrentGroup();
          this._currentListIndex = -1;
        }
        return flag;
      }

      private bool GotoPreviousGroup()
      {
        bool flag = false;
        if (this._groupIndex > this._groupList.Count || this._itemKind == 4 || this._itemKind == 5)
          this._groupIndex = this._groupList.Count;
        for (; !flag && this._groupIndex > 0; flag = this.GotoGroupFooter() || this.GotoPreviousItem() || this.GotoGroupHeader())
        {
          --this._groupIndex;
          this.UpdateCurrentGroup();
          this._currentListIndex = this._currentItemList == null ? 0 : this._currentItemList.Count;
        }
        return flag;
      }

      private bool GotoGroupHeader()
      {
        int num = !this.ShouldDisplayCurrentGroup ? 0 : (this._collection.HasGroupHeader ? 1 : 0);
        if (num == 0)
          return num != 0;
        this._currentListIndex = -1;
        this.UpdateCurrentItem(LongListSelectorItemKind.GroupHeader);
        return num != 0;
      }

      private bool GotoGroupFooter()
      {
        int num = !this.ShouldDisplayCurrentGroup ? 0 : (this._collection.HasGroupFooter ? 1 : 0);
        if (num == 0)
          return num != 0;
        this._currentListIndex = this._currentItemList != null ? this._currentItemList.Count : 0;
        this.UpdateCurrentItem(LongListSelectorItemKind.GroupFooter);
        return num != 0;
      }

      private void UpdateCurrentGroup()
      {
        this._currentGroup = (object) null;
        if (this._groupIndex >= 0 && this._groupIndex < this._groupList.Count)
          this._currentGroup = this._groupList[this._groupIndex];
        if (this._currentNotifyGroupChangedListener != null)
          this._currentNotifyGroupChangedListener.Disconnect();
        if (this._currentGroup != null)
        {
          this._currentItemList = this._currentGroup as IList;
          // ISSUE: method pointer
          this._currentNotifyGroupChangedListener = WeakCollectionChangedListener.CreateIfNecessary(this._currentGroup, new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnCurrentGroupCollectionChanged)));
        }
        else
        {
          this._currentItemList = (IList) null;
          this._currentNotifyGroupChangedListener = (WeakCollectionChangedListenerToken) null;
        }
      }

      protected override void OnSourceCollectionChanged(
        object sender,
        NotifyCollectionChangedEventArgs args)
      {
        switch ((int) args.Action)
        {
          case 0:
            if (this._groupIndex == 0 && this._itemKind == 5)
            {
              this.UpdateCurrentGroup();
              this.UpdateCurrentItem(LongListSelectorItemKind.GroupHeader);
              break;
            }
            if (args.NewStartingIndex > this._groupIndex)
              break;
            this._groupIndex += args.NewItems.Count;
            break;
          case 1:
            if (args.OldStartingIndex < this._groupIndex)
            {
              this._groupIndex -= args.OldItems.Count;
              this.UpdateCurrentGroup();
              break;
            }
            if (args.OldStartingIndex != this._groupIndex || this._itemKind == 5)
              break;
            this._isBetweenGroups = true;
            break;
          case 2:
            if (args.NewStartingIndex != this._groupIndex)
              break;
            this.UpdateCurrentGroup();
            if (this._currentListIndex < this._currentItemList.Count)
              break;
            this._isBetweenItems = true;
            break;
          case 4:
            this.Reset();
            this.MoveNext();
            break;
        }
      }

      private void OnCurrentGroupCollectionChanged(
        object sender,
        NotifyCollectionChangedEventArgs args)
      {
        if (args.Action != 4)
        {
          base.OnSourceCollectionChanged(sender, args);
        }
        else
        {
          this.UpdateCurrentGroup();
          if (this._currentListIndex < this._currentItemList.Count)
            return;
          this._isBetweenItems = true;
        }
      }

      public override bool AtSamePosition(Iterator<LongListSelectorItem> other)
      {
        bool flag = false;
        if (other is LongListSelectorGroupedItemCollection.GroupItemIterator groupItemIterator)
          flag = groupItemIterator._currentItemList == this._currentItemList && groupItemIterator._currentListIndex == this._currentListIndex && (groupItemIterator._groupIndex == this._groupIndex && groupItemIterator._groupList == this._groupList) && groupItemIterator._itemKind == this._itemKind && (groupItemIterator.Current.Equals((object) this.Current) && !this._isBetweenGroups && (!groupItemIterator._isBetweenGroups && !this._isBetweenItems)) && !groupItemIterator._isBetweenItems;
        return flag;
      }

      public override string ToString() => string.Format("GroupItemIterator: gindex {0}, lindex {1}, kind {2} {3}{4}", (object) this._groupIndex, (object) this._currentListIndex, (object) this._itemKind, this._isBetweenGroups ? (object) "(between groups)" : (object) "", this._isBetweenItems ? (object) "(between items)" : (object) "");

      public override bool IsCurrentValid => !this._isBetweenItems && !this._isBetweenGroups;
    }

    private class HeaderIterator : Iterator<LongListSelectorItem>
    {
      private LongListSelectorGroupedItemCollection _collection;
      private LongListSelectorItem _current;
      private int _index = -1;

      internal HeaderIterator(LongListSelectorGroupedItemCollection collection) => this._collection = collection;

      public override bool MovePrevious()
      {
        bool flag = false;
        object obj = (object) null;
        if (this._index > this._collection._source.Count)
          this._index = this._collection._source.Count;
        while (this._index > 0 && !flag)
        {
          --this._index;
          obj = this._collection._source[this._index];
          if (this._collection.ShouldDisplayGroup(obj))
            flag = true;
        }
        if (flag)
        {
          this._current = new LongListSelectorItem(obj, LongListSelectorItemKind.GroupHeader, obj, -1);
        }
        else
        {
          this._current = new LongListSelectorItem();
          this._index = -1;
        }
        return flag;
      }

      public override Iterator<LongListSelectorItem> Clone() => (Iterator<LongListSelectorItem>) new LongListSelectorGroupedItemCollection.HeaderIterator(this._collection)
      {
        _index = this._index
      };

      public override LongListSelectorItem Current => this._current;

      public override bool MoveNext()
      {
        bool flag = false;
        object obj = (object) null;
        while (this._index < this._collection._source.Count - 1 && !flag)
        {
          ++this._index;
          obj = this._collection._source[this._index];
          if (this._collection.ShouldDisplayGroup(obj))
            flag = true;
        }
        if (flag)
        {
          this._current = new LongListSelectorItem(obj, LongListSelectorItemKind.GroupHeader, obj, -1);
        }
        else
        {
          this._current = new LongListSelectorItem();
          this._index = this._collection._source.Count;
        }
        return flag;
      }

      public override void Reset()
      {
        this._index = -1;
        this._current = new LongListSelectorItem();
      }

      public override void Dispose()
      {
      }

      public override bool AtSamePosition(Iterator<LongListSelectorItem> other)
      {
        bool flag = false;
        if (other is LongListSelectorGroupedItemCollection.HeaderIterator headerIterator)
          flag = headerIterator._collection == this._collection && headerIterator._index == this._index && headerIterator.Current.Equals((object) this.Current);
        return flag;
      }
    }
  }
}
