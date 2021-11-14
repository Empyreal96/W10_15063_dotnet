// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.ResultSetEnumerator
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;

namespace System.Data.SqlServerCe
{
  public sealed class ResultSetEnumerator : IEnumerator
  {
    internal SqlCeResultSet _resultset;
    internal SqlCeUpdatableRecord _current;

    static ResultSetEnumerator() => KillBitHelper.ThrowIfKillBitIsSet();

    public ResultSetEnumerator(SqlCeResultSet resultSet) => this._resultset = resultSet != null ? resultSet : throw new ArgumentNullException("resultset");

    object IEnumerator.Current => (object) this._current;

    public SqlCeUpdatableRecord Current => this._current;

    public bool MoveNext()
    {
      this._current = (SqlCeUpdatableRecord) null;
      if (!this._resultset.Read())
        return false;
      this._current = this._resultset.GetCurrentRecord();
      return true;
    }

    public void Reset()
    {
      this._current = (SqlCeUpdatableRecord) null;
      this._resultset.ReadFirst();
      this._resultset.ReadPrevious();
    }
  }
}
