// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.ListChangedEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Workaround
{
  public class ListChangedEventArgs : EventArgs
  {
    private ListChangedType listChangedType;
    private int newIndex;
    private int oldIndex;
    private PropertyDescriptor propDesc;

    public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
      : this(listChangedType, newIndex, -1)
    {
    }

    public ListChangedEventArgs(
      ListChangedType listChangedType,
      int newIndex,
      PropertyDescriptor propDesc)
      : this(listChangedType, newIndex)
    {
      this.propDesc = propDesc;
      this.oldIndex = newIndex;
    }

    public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
    {
      Debug.Assert((uint) listChangedType > 0U, "this constructor is used only for changes in the list MetaData");
      Debug.Assert(listChangedType != ListChangedType.ItemAdded, "this constructor is used only for changes in the list MetaData");
      Debug.Assert(listChangedType != ListChangedType.ItemDeleted, "this constructor is used only for changes in the list MetaData");
      Debug.Assert(listChangedType != ListChangedType.ItemChanged, "this constructor is used only for changes in the list MetaData");
      this.listChangedType = listChangedType;
      this.propDesc = propDesc;
    }

    public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
    {
      Debug.Assert(listChangedType != ListChangedType.PropertyDescriptorAdded, "this constructor is used only for item changed in the list");
      Debug.Assert(listChangedType != ListChangedType.PropertyDescriptorDeleted, "this constructor is used only for item changed in the list");
      Debug.Assert(listChangedType != ListChangedType.PropertyDescriptorChanged, "this constructor is used only for item changed in the list");
      this.listChangedType = listChangedType;
      this.newIndex = newIndex;
      this.oldIndex = oldIndex;
    }

    public ListChangedType ListChangedType => this.listChangedType;

    public int NewIndex => this.newIndex;

    public int OldIndex => this.oldIndex;
  }
}
