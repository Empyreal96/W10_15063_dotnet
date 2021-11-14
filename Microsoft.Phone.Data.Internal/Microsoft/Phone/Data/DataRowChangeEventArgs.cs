// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRowChangeEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  public class DataRowChangeEventArgs : EventArgs
  {
    private DataRow row;
    private DataRowAction action;

    public DataRowChangeEventArgs(DataRow row, DataRowAction action)
    {
      this.row = row;
      this.action = action;
    }

    public DataRow Row => this.row;

    public DataRowAction Action => this.action;
  }
}
