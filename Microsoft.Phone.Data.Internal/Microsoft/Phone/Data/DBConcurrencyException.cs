// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DBConcurrencyException
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Data;

namespace Microsoft.Phone.Data
{
  public sealed class DBConcurrencyException : DataException
  {
    private DataRow[] _dataRows;

    public DBConcurrencyException()
      : this(Res.GetString("ADP_DBConcurrencyExceptionMessage"), (Exception) null)
    {
      // ISSUE: reference to a compiler-generated method (out of statement scope)
    }

    public DBConcurrencyException(string message)
      : this(message, (Exception) null)
    {
    }

    public DBConcurrencyException(string message, Exception inner)
      : base(message, inner)
    {
      this.HResult = -2146232011;
    }

    public DBConcurrencyException(string message, Exception inner, DataRow[] dataRows)
      : base(message, inner)
    {
      this.HResult = -2146232011;
      this._dataRows = dataRows;
    }

    public DataRow Row
    {
      get
      {
        DataRow[] dataRows = this._dataRows;
        return dataRows == null || dataRows.Length == 0 ? (DataRow) null : dataRows[0];
      }
      set => this._dataRows = new DataRow[1]{ value };
    }

    public int RowCount
    {
      get
      {
        DataRow[] dataRows = this._dataRows;
        return dataRows == null ? 0 : dataRows.Length;
      }
    }

    public void CopyToRows(DataRow[] array) => this.CopyToRows(array, 0);

    public void CopyToRows(DataRow[] array, int arrayIndex) => this._dataRows?.CopyTo((Array) array, arrayIndex);
  }
}
