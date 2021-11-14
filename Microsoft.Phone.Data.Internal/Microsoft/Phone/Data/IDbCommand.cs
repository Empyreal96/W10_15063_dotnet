// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.IDbCommand
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  public interface IDbCommand : IDisposable
  {
    IDbConnection Connection { get; set; }

    IDbTransaction Transaction { get; set; }

    string CommandText { get; set; }

    int CommandTimeout { get; set; }

    CommandType CommandType { get; set; }

    IDataParameterCollection Parameters { get; }

    void Prepare();

    UpdateRowSource UpdatedRowSource { get; set; }

    void Cancel();

    IDbDataParameter CreateParameter();

    int ExecuteNonQuery();

    IDataReader ExecuteReader();

    IDataReader ExecuteReader(CommandBehavior behavior);

    object ExecuteScalar();
  }
}
