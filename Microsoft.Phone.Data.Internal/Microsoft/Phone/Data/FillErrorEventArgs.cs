// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.FillErrorEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  public class FillErrorEventArgs : EventArgs
  {
    private bool continueFlag;
    private DataTable dataTable;
    private Exception errors;
    private object[] values;

    public FillErrorEventArgs(DataTable dataTable, object[] values)
    {
      this.dataTable = dataTable;
      this.values = values;
      if (this.values != null)
        return;
      this.values = new object[0];
    }

    public bool Continue
    {
      get => this.continueFlag;
      set => this.continueFlag = value;
    }

    public DataTable DataTable => this.dataTable;

    public Exception Errors
    {
      get => this.errors;
      set => this.errors = value;
    }

    public object[] Values
    {
      get
      {
        object[] objArray = new object[this.values.Length];
        for (int index = 0; index < this.values.Length; ++index)
          objArray[index] = this.values[index];
        return objArray;
      }
    }
  }
}
