// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeException
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Security;
using System.Text;

namespace System.Data.SqlServerCe
{
  public class SqlCeException : DbException
  {
    private SqlCeErrorCollection _errors;
    private string _customMessage;

    static SqlCeException() => KillBitHelper.ThrowIfKillBitIsSet();

    private SqlCeException()
      : this(string.Empty)
    {
    }

    private SqlCeException(string msg)
      : base(msg)
    {
      this.Errors = new SqlCeErrorCollection();
    }

    private SqlCeException(string msg, Exception inner)
      : base(msg, inner)
    {
      this.Errors = new SqlCeErrorCollection();
    }

    internal SqlCeException(SqlCeErrorCollection errors)
      : this(string.Empty)
    {
      this.Errors = errors;
    }

    internal SqlCeException(SqlCeErrorCollection errors, string customMessage)
      : this(string.Empty)
    {
      this.Errors = errors;
      this._customMessage = string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0};{1}", (object) customMessage, (object) this.Message);
    }

    public SqlCeErrorCollection Errors
    {
      get
      {
        if (this._errors == null)
          this._errors = new SqlCeErrorCollection();
        return this._errors;
      }
      private set
      {
        this._errors = value;
        this._customMessage = this.BuildExceptionMessage();
      }
    }

    public new int HResult => this.Errors.Count > 0 ? this.Errors[0].HResult : -1;

    public int NativeError => this.Errors.Count > 0 ? this.Errors[0].NativeError : -1;

    public override string Message => !string.IsNullOrEmpty(this._customMessage) ? this._customMessage : base.Message;

    public override string Source
    {
      [SecurityCritical] get => this.Errors.Count > 0 ? this.Errors[0].Source : string.Empty;
    }

    internal static SqlCeException FillErrorInformation(int hr, IntPtr pIError)
    {
      SqlCeErrorCollection errors = new SqlCeErrorCollection();
      errors.FillErrorInformation(hr, pIError);
      return SqlCeException.CreateException(errors);
    }

    internal static SqlCeException FillErrorCollection(int hr, IntPtr pISSCEErrors)
    {
      SqlCeErrorCollection errors = new SqlCeErrorCollection();
      errors.FillErrorCollection(hr, pISSCEErrors);
      return SqlCeException.CreateException(errors);
    }

    internal static SqlCeException CreateException(SqlCeErrorCollection errors)
    {
      Debug.Assert(errors != null, "Error collection is null");
      switch (errors[0].NativeError)
      {
        case 25090:
          return (SqlCeException) new SqlCeLockTimeoutException(errors);
        case 25122:
        case 25155:
          return new SqlCeException(errors, "SQLCE_DbConnectionFailed");
        case 25126:
          return (SqlCeException) new SqlCeTransactionInProgressException(errors);
        case 25138:
          return (SqlCeException) new SqlCeInvalidDatabaseFormatException(errors);
        default:
          return new SqlCeException(errors);
      }
    }

    internal static SqlCeException CreateException(string message)
    {
      Debug.Assert(!string.IsNullOrEmpty(message), "Message is not defined");
      return new SqlCeException(message);
    }

    internal static SqlCeException CreateException(string message, Exception inner)
    {
      Debug.Assert(!string.IsNullOrEmpty(message), "Message is not defined");
      Debug.Assert(inner != null, "Inner exception is null");
      return new SqlCeException(message, inner);
    }

    private string BuildExceptionMessage()
    {
      Debug.Assert(this.Errors != null, "Error collection is null");
      if (this.Errors.Count <= 0)
        return string.Empty;
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < this.Errors.Count; ++index)
      {
        if (index > 0)
          stringBuilder.Append("; ");
        stringBuilder.Append(this.Errors[index].Message);
      }
      return stringBuilder.ToString();
    }
  }
}
