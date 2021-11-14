// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.LongListSelectorItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Controls
{
  internal struct LongListSelectorItem
  {
    private object _data;
    private LongListSelectorItemKind _itemKind;
    private object _group;
    private int _indexInGroup;

    internal LongListSelectorItem(
      object data,
      LongListSelectorItemKind itemKind,
      object group,
      int indexInGroup)
    {
      this._data = data;
      this._itemKind = itemKind;
      this._indexInGroup = indexInGroup;
      this._group = group;
    }

    internal LongListSelectorItem(object data, LongListSelectorItemKind itemKind)
      : this(data, itemKind, (object) null, -1)
    {
    }

    public object Data => this._data;

    public override int GetHashCode()
    {
      int hashCode = this.ItemKind.GetHashCode();
      if (this.Data != null)
        hashCode ^= this.Data.GetHashCode();
      if (this.Group != null)
        hashCode ^= this.Group.GetHashCode();
      return hashCode;
    }

    public override bool Equals(object obj)
    {
      bool flag = obj is LongListSelectorItem;
      if (flag)
      {
        LongListSelectorItem listSelectorItem = (LongListSelectorItem) obj;
        flag = this.ItemKind == listSelectorItem.ItemKind && this.Group == listSelectorItem.Group && (this.Data == listSelectorItem.Data || this.Data is ValueType && this.Data.Equals(listSelectorItem.Data));
      }
      return flag;
    }

    internal LongListSelectorItemKind ItemKind => this._itemKind;

    internal object Group => this._group;

    internal int IndexInGroup => this._indexInGroup;
  }
}
