// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DeletedRowInaccessibleException
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Data;

namespace Microsoft.Phone.Data
{
  public class DeletedRowInaccessibleException : DataException
  {
    public DeletedRowInaccessibleException()
      : base(Res.GetString("DataSet_DefaultDeletedRowInaccessibleException"))
    {
      // ISSUE: reference to a compiler-generated method (out of statement scope)
      this.HResult = -2146232031;
    }

    public DeletedRowInaccessibleException(string s)
      : base(s)
    {
      this.HResult = -2146232031;
    }

    public DeletedRowInaccessibleException(string message, Exception innerException)
      : base(message, innerException)
    {
      this.HResult = -2146232031;
    }
  }
}
