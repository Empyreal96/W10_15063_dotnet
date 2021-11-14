// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.MetaData
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using System.Diagnostics;
using System.Security;

namespace System.Data.SqlServerCe
{
  internal class MetaData : IDisposable
  {
    internal uint ordinal;
    internal uint size;
    internal object value;
    internal bool isReadOnly;
    internal bool isRowVersion;
    internal bool isExpression;
    internal bool isIdentity;
    internal bool isUnique;
    internal bool isKey;
    internal bool isNullable;
    internal bool hasDefault;
    internal string baseTableName;
    internal string baseColumnName;
    internal SqlCeType typeMap;
    private SqlMetaData sqlMetaData;
    private object thisLock = new object();
    private bool isFinalized;

    public SqlMetaData SqlMetaData => this.sqlMetaData;

    public string ColumnName => this.sqlMetaData.Name;

    static MetaData() => KillBitHelper.ThrowIfKillBitIsSet();

    private MetaData()
    {
    }

    public MetaData(
      string name,
      SqlCeType typeMap,
      byte precision,
      byte scale,
      long maxLength,
      string databaseName,
      string schemaName)
    {
      Debug.Assert(typeMap != null);
      this.typeMap = typeMap;
      SqlDbType sqlDbType = typeMap.sqlDbType;
      if (precision == (byte) 0)
        precision = typeMap.maxpre;
      if (maxLength == 0L)
        maxLength = (long) typeMap.fixlen;
      if (scale == (byte) 0)
        scale = typeMap.scale;
      if (sqlDbType == SqlDbType.NText || sqlDbType == SqlDbType.Image)
        maxLength = -1L;
      if (sqlDbType == SqlDbType.NVarChar && maxLength > 4000L)
        maxLength = 4000L;
      else if (sqlDbType == SqlDbType.VarBinary && maxLength > 8000L)
        maxLength = 8000L;
      this.sqlMetaData = new SqlMetaData(name, sqlDbType, maxLength, precision, scale, 0L, SqlCompareOptions.None, (Type) null);
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~MetaData() => this.Dispose(false);

    [SecuritySafeCritical]
    private void Dispose(bool disposing)
    {
      lock (this.thisLock)
      {
        if (this.isFinalized)
          return;
        if (this.value != null && this.value is IntPtr && this.typeMap.isBLOB)
        {
          IntPtr ppUnknown = (IntPtr) this.value;
          if (IntPtr.Zero != ppUnknown)
          {
            NativeMethods.SafeRelease(ref ppUnknown);
            this.value = (object) null;
          }
        }
        if (disposing)
        {
          this.value = (object) null;
          this.sqlMetaData = (SqlMetaData) null;
          this.baseTableName = (string) null;
          this.baseColumnName = (string) null;
          this.typeMap = (SqlCeType) null;
        }
        if (disposing)
          return;
        this.isFinalized = true;
      }
    }
  }
}
