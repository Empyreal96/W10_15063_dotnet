// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataColumnChangeEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  public class DataColumnChangeEventArgs : EventArgs
  {
    private readonly DataRow _row;
    private DataColumn _column;
    private object _proposedValue;

    internal DataColumnChangeEventArgs(DataRow row) => this._row = row;

    public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value)
    {
      this._row = row;
      this._column = column;
      this._proposedValue = value;
    }

    public DataColumn Column => this._column;

    public DataRow Row => this._row;

    public object ProposedValue
    {
      get => this._proposedValue;
      set => this._proposedValue = value;
    }

    internal void InitializeColumnChangeEvent(DataColumn column, object value)
    {
      this._column = column;
      this._proposedValue = value;
    }
  }
}
