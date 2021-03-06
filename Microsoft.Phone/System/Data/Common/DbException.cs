// Decompiled with JetBrains decompiler
// Type: System.Data.Common.DbException
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;

namespace System.Data.Common
{
  [CLSCompliant(true)]
  public abstract class DbException : ExternalException
  {
    protected DbException()
    {
    }

    protected DbException(string message)
      : base(message)
    {
    }

    protected DbException(string message, Exception innerException)
      : base(message, innerException)
    {
    }

    protected DbException(string message, int errorCode)
      : base(message)
    {
      this.HResult = errorCode;
    }
  }
}
