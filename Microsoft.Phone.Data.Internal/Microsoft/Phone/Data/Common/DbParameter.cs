// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbParameter
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbParameter : IDbDataParameter, IDataParameter
  {
    public abstract DbType DbType { get; set; }

    public abstract void ResetDbType();

    public abstract ParameterDirection Direction { get; set; }

    public abstract bool IsNullable { get; set; }

    public abstract string ParameterName { get; set; }

    byte IDbDataParameter.Precision
    {
      get => 0;
      set
      {
      }
    }

    byte IDbDataParameter.Scale
    {
      get => 0;
      set
      {
      }
    }

    public abstract int Size { get; set; }

    public abstract string SourceColumn { get; set; }

    public abstract bool SourceColumnNullMapping { get; set; }

    public abstract DataRowVersion SourceVersion { get; set; }

    public abstract object Value { get; set; }
  }
}
