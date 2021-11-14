// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeFlushFailureEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeFlushFailureEventArgs : EventArgs
  {
    private object src;
    private SqlCeErrorCollection errors;

    static SqlCeFlushFailureEventArgs() => KillBitHelper.ThrowIfKillBitIsSet();

    internal SqlCeFlushFailureEventArgs(int hr, IntPtr pError, object src)
    {
      this.src = src;
      this.errors = new SqlCeErrorCollection();
      this.errors.FillErrorInformation(hr, pError);
      Debug.Assert(this.errors[0].HResult != 0 || (uint) this.errors[0].NativeError > 0U, "IError is missing return status and/or minor code");
    }

    public SqlCeErrorCollection Errors => this.errors;

    public string Message => this.Errors[0].Message;

    public override string ToString() => this.Message;
  }
}
