// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataError
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class DataError
  {
    private string rowError = string.Empty;
    private int count;
    private DataError.ColumnError[] errorList;
    internal const int initialCapacity = 1;

    internal DataError()
    {
    }

    internal DataError(string rowError) => this.SetText(rowError);

    internal string Text
    {
      get => this.rowError;
      set => this.SetText(value);
    }

    internal bool HasErrors => this.rowError.Length != 0 || (uint) this.count > 0U;

    internal void SetColumnError(DataColumn column, string error)
    {
      Debug.Assert(column != null, "Invalid (null) argument");
      Debug.Assert(column.Table != null, "Invalid (loose) column");
      switch (error)
      {
        case "":
        case null:
          this.Clear(column);
          break;
        default:
          if (this.errorList == null)
            this.errorList = new DataError.ColumnError[1];
          int index = this.IndexOf(column);
          this.errorList[index].column = column;
          this.errorList[index].error = error;
          ++column.errors;
          if (index != this.count)
            break;
          ++this.count;
          break;
      }
    }

    internal string GetColumnError(DataColumn column)
    {
      for (int index = 0; index < this.count; ++index)
      {
        if (this.errorList[index].column == column)
          return this.errorList[index].error;
      }
      return string.Empty;
    }

    internal void Clear(DataColumn column)
    {
      if (this.count == 0)
        return;
      for (int destinationIndex = 0; destinationIndex < this.count; ++destinationIndex)
      {
        if (this.errorList[destinationIndex].column == column)
        {
          Array.Copy((Array) this.errorList, destinationIndex + 1, (Array) this.errorList, destinationIndex, this.count - destinationIndex - 1);
          --this.count;
          --column.errors;
          Debug.Assert(column.errors >= 0, "missing error counts");
        }
      }
    }

    internal void Clear()
    {
      for (int index = 0; index < this.count; ++index)
      {
        --this.errorList[index].column.errors;
        Debug.Assert(this.errorList[index].column.errors >= 0, "missing error counts");
      }
      this.count = 0;
      this.rowError = string.Empty;
    }

    internal DataColumn[] GetColumnsInError()
    {
      DataColumn[] dataColumnArray = new DataColumn[this.count];
      for (int index = 0; index < this.count; ++index)
        dataColumnArray[index] = this.errorList[index].column;
      return dataColumnArray;
    }

    private void SetText(string errorText)
    {
      if (errorText == null)
        errorText = string.Empty;
      this.rowError = errorText;
    }

    internal int IndexOf(DataColumn column)
    {
      for (int index = 0; index < this.count; ++index)
      {
        if (this.errorList[index].column == column)
          return index;
      }
      if (this.count >= this.errorList.Length)
      {
        DataError.ColumnError[] columnErrorArray = new DataError.ColumnError[Math.Min(this.count * 2, column.Table.Columns.Count)];
        Array.Copy((Array) this.errorList, 0, (Array) columnErrorArray, 0, this.count);
        this.errorList = columnErrorArray;
      }
      return this.count;
    }

    internal struct ColumnError
    {
      internal DataColumn column;
      internal string error;
    }
  }
}
