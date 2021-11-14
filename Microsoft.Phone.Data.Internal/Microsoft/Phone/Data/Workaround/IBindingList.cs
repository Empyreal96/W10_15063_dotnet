// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.IBindingList
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;
using System.ComponentModel;

namespace Microsoft.Phone.Data.Workaround
{
  public interface IBindingList : IList, ICollection, IEnumerable
  {
    bool AllowNew { get; }

    object AddNew();

    bool AllowEdit { get; }

    bool AllowRemove { get; }

    bool SupportsChangeNotification { get; }

    bool SupportsSearching { get; }

    bool SupportsSorting { get; }

    bool IsSorted { get; }

    PropertyDescriptor SortProperty { get; }

    ListSortDirection SortDirection { get; }

    event ListChangedEventHandler ListChanged;

    void AddIndex(PropertyDescriptor property);

    void ApplySort(PropertyDescriptor property, ListSortDirection direction);

    int Find(PropertyDescriptor property, object key);

    void RemoveIndex(PropertyDescriptor property);

    void RemoveSort();
  }
}
