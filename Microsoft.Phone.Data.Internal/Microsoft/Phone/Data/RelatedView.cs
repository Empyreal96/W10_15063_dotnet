// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.RelatedView
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class RelatedView : DataView, IFilter
  {
    private readonly DataKey key;
    private object[] values;

    public RelatedView(DataColumn[] columns, object[] values)
      : base(columns[0].Table, false)
    {
      if (values == null)
        throw ExceptionBuilder.ArgumentNull(nameof (values));
      this.key = new DataKey(columns, true);
      this.values = values;
      Debug.Assert(this.Table == this.key.Table, "Key.Table Must be equal to Current Table");
      this.ResetRowViewCache();
    }

    public bool Invoke(DataRow row, DataRowVersion version)
    {
      object[] keyValues = row.GetKeyValues(this.key, version);
      bool flag = true;
      if (keyValues.Length != this.values.Length)
      {
        flag = false;
      }
      else
      {
        for (int index = 0; index < keyValues.Length; ++index)
        {
          if (!keyValues[index].Equals(this.values[index]))
          {
            flag = false;
            break;
          }
        }
      }
      IFilter filter = base.GetFilter();
      if (filter != null)
        flag &= filter.Invoke(row, version);
      return flag;
    }

    internal override IFilter GetFilter() => (IFilter) this;

    public override DataRowView AddNew()
    {
      DataRowView dataRowView = base.AddNew();
      dataRowView.Row.SetKeyValues(this.key, this.values);
      return dataRowView;
    }

    internal override void SetIndex(
      string newSort,
      DataViewRowState newRowStates,
      IFilter newRowFilter)
    {
      this.SetIndex2(newSort, newRowStates, newRowFilter, false);
      this.Reset();
    }

    public override bool Equals(DataView dv)
    {
      if (!(dv is RelatedView) || !base.Equals(dv))
        return false;
      DataKey key = this.key;
      DataColumn[] columnsReference1 = key.ColumnsReference;
      key = ((RelatedView) dv).key;
      DataColumn[] columnsReference2 = key.ColumnsReference;
      return this.CompareArray((object[]) columnsReference1, (object[]) columnsReference2) || this.CompareArray(this.values, ((RelatedView) dv).values);
    }

    private bool CompareArray(object[] value1, object[] value2)
    {
      if (value1.Length != value2.Length)
        return false;
      for (int index = 0; index < value1.Length; ++index)
      {
        if (value1[index] != value2[index])
          return false;
      }
      return true;
    }
  }
}
