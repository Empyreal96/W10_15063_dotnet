// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.LongListSelectorFlatItemCollection
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
  internal class LongListSelectorFlatItemCollection : LongListSelectorItemCollection
  {
    private WeakCollectionChangedListenerToken _sourceChangedListener;

    public LongListSelectorFlatItemCollection(
      IList source,
      NotifyCollectionChangedEventHandler collectionChanged)
      : base(source, collectionChanged)
    {
      // ISSUE: method pointer
      this._sourceChangedListener = WeakCollectionChangedListener.CreateIfNecessary((object) source, new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnSourceCollectionChanged)));
    }

    ~LongListSelectorFlatItemCollection() => this.DisconnectListener();

    public override IEnumerable<IList> GetGroupLists()
    {
      yield return this._source;
    }

    public override Iterator<LongListSelectorItem> GetIterator() => (Iterator<LongListSelectorItem>) new LongListSelectorFlatItemCollection.FlatItemIterator(this);

    public override Iterator<LongListSelectorItem> GetIterator(
      object item,
      bool? isGroup)
    {
      Iterator<LongListSelectorItem> iterator = (Iterator<LongListSelectorItem>) null;
      if (!isGroup.GetValueOrDefault())
        iterator = (Iterator<LongListSelectorItem>) LongListSelectorFlatItemCollection.FlatItemIterator.Create(this, item);
      return iterator;
    }

    public override Iterator<LongListSelectorItem> GetHeaderIterator() => (Iterator<LongListSelectorItem>) new LongListSelectorFlatItemCollection.EmptyIterator<LongListSelectorItem>();

    public override void Dispose()
    {
      base.Dispose();
      this.DisconnectListener();
      GC.SuppressFinalize((object) this);
    }

    private void DisconnectListener()
    {
      if (this._sourceChangedListener == null)
        return;
      this._sourceChangedListener.Disconnect();
      this._sourceChangedListener = (WeakCollectionChangedListenerToken) null;
    }

    private void OnSourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
    {
      switch ((int) args.Action)
      {
        case 0:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action, (object) new LongListSelectorItem(args.NewItems[0], LongListSelectorItemKind.Item), -1));
          break;
        case 1:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action, (object) new LongListSelectorItem(args.OldItems[0], LongListSelectorItemKind.Item), -1));
          break;
        case 2:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action, (object) new LongListSelectorItem(args.NewItems[0], LongListSelectorItemKind.Item), (object) new LongListSelectorItem(args.OldItems[0], LongListSelectorItemKind.Item), -1));
          break;
        case 4:
          this.FireCollectionChanged(new NotifyCollectionChangedEventArgs(args.Action));
          break;
      }
    }

    private class FlatItemIterator : 
      LongListSelectorItemCollection.ItemIterator<LongListSelectorFlatItemCollection>
    {
      internal FlatItemIterator(LongListSelectorFlatItemCollection collection)
        : base(collection)
      {
      }

      internal static LongListSelectorFlatItemCollection.FlatItemIterator Create(
        LongListSelectorFlatItemCollection collection,
        object item)
      {
        LongListSelectorFlatItemCollection.FlatItemIterator flatItemIterator = new LongListSelectorFlatItemCollection.FlatItemIterator(collection);
        if (!flatItemIterator.AdvanceTo(item))
          flatItemIterator = (LongListSelectorFlatItemCollection.FlatItemIterator) null;
        return flatItemIterator;
      }

      public override Iterator<LongListSelectorItem> Clone()
      {
        LongListSelectorFlatItemCollection.FlatItemIterator flatItemIterator = new LongListSelectorFlatItemCollection.FlatItemIterator(this._collection);
        this.CopyTo((LongListSelectorItemCollection.ItemIterator<LongListSelectorFlatItemCollection>) flatItemIterator);
        return (Iterator<LongListSelectorItem>) flatItemIterator;
      }

      public override bool MoveNext()
      {
        if (this._isBetweenItems)
        {
          this._isBetweenItems = false;
          this.MovePrevious();
        }
        switch (this._itemKind)
        {
          case -1:
            return this.GotoListHeader() || this.GotoNextItem() || this.GotoListFooter() || this.GotoEOF();
          case 0:
            return this.GotoNextItem() || this.GotoListFooter() || this.GotoEOF();
          case 2:
            return this.GotoNextItem() || this.GotoListFooter() || this.GotoEOF();
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
        this._isBetweenItems = false;
        switch (this._itemKind)
        {
          case -1:
            return false;
          case 0:
            return this.GotoBOF();
          case 1:
          case 2:
          case 3:
            return this.GotoPreviousItem() || this.GotoListHeader() || this.GotoBOF();
          case 4:
            return this.GotoPreviousItem() || this.GotoListHeader() || this.GotoBOF();
          case 5:
            return this.GotoListFooter() || this.GotoPreviousItem() || this.GotoListHeader() || this.GotoBOF();
          default:
            throw new InvalidOperationException(Resources.ItemIterator_InvalidState);
        }
      }

      public override bool AtSamePosition(Iterator<LongListSelectorItem> other)
      {
        bool flag = false;
        if (other is LongListSelectorFlatItemCollection.FlatItemIterator flatItemIterator)
          flag = flatItemIterator._currentItemList == this._currentItemList && flatItemIterator._currentListIndex == this._currentListIndex && flatItemIterator._itemKind == this._itemKind && (flatItemIterator.Current.Equals((object) this.Current) && !this._isBetweenItems) && !flatItemIterator._isBetweenItems;
        return flag;
      }

      public override string ToString() => string.Format("FlatItemIterator: index {0}, kind {1} {2}", (object) this._currentListIndex, (object) this._itemKind, this._isBetweenItems ? (object) "(between items)" : (object) "");
    }

    private class EmptyIterator<TItem> : Iterator<TItem>
    {
      public override TItem Current => default (TItem);

      public override Iterator<TItem> Clone() => (Iterator<TItem>) new LongListSelectorFlatItemCollection.EmptyIterator<TItem>();

      public override bool MovePrevious() => false;

      public override bool MoveNext() => false;

      public override void Reset()
      {
      }

      public override void Dispose()
      {
      }

      public override bool AtSamePosition(Iterator<TItem> other) => true;
    }
  }
}
