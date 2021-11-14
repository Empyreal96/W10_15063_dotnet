// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeResultSet
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;

namespace System.Data.SqlServerCe
{
  public class SqlCeResultSet : SqlCeDataReader, IEnumerable
  {
    private bool isInitialized;
    private IList<int> bookmarkArray;
    private SqlCeUpdatableRecord sqlUpdatableRecord;

    static SqlCeResultSet() => KillBitHelper.ThrowIfKillBitIsSet();

    [SecurityCritical]
    protected SqlCeResultSet() => NativeMethods.LoadNativeBinaries();

    [SecurityCritical]
    internal SqlCeResultSet(SqlCeConnection connection, SqlCeCommand command)
      : base(connection, command)
    {
      NativeMethods.LoadNativeBinaries();
    }

    public override object this[int index] => this.HasColumnChanged(index) ? this.sqlUpdatableRecord[index] : base[index];

    public override object this[string name] => this.HasColumnChanged(this.GetOrdinal(name)) ? this.sqlUpdatableRecord[name] : base[name];

    public bool Updatable
    {
      get
      {
        if (this.IsClosed)
          throw new InvalidOperationException(Res.GetString("SQL_SqlResultSetClosed", (object) nameof (Updatable)));
        return (uint) (this.cursorCapabilities & ResultSetOptions.Updatable) > 0U;
      }
    }

    public bool Scrollable
    {
      get
      {
        if (this.IsClosed)
          throw new InvalidOperationException(Res.GetString("SQL_SqlResultSetClosed", (object) nameof (Scrollable)));
        return (uint) (this.cursorCapabilities & ResultSetOptions.Scrollable) > 0U;
      }
    }

    public ResultSetSensitivity Sensitivity
    {
      get
      {
        ResultSetOptions cursorCapabilities = this.cursorCapabilities;
        if (this.IsClosed)
          throw new InvalidOperationException(Res.GetString("SQL_SqlResultSetClosed", (object) nameof (Sensitivity)));
        if ((cursorCapabilities & ResultSetOptions.Sensitive) != ResultSetOptions.None)
          return ResultSetSensitivity.Sensitive;
        return (cursorCapabilities & ResultSetOptions.Insensitive) != ResultSetOptions.None ? ResultSetSensitivity.Insensitive : ResultSetSensitivity.Asensitive;
      }
    }

    internal IList<int> BookmarkArray
    {
      [SecuritySafeCritical] get
      {
        if (!this.Scrollable)
          throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotScrollable"));
        if (this.bookmarkArray != null)
          return this.bookmarkArray;
        int hBookmark = 0;
        this.bookmarkArray = (IList<int>) new List<int>();
        if (!this.Move(DIRECTION.MOVE_FIRST))
          return this.bookmarkArray;
        bool flag = false;
        while (!flag)
        {
          int hr = NativeMethods.GetBookmark(this.pSeCursor, ref hBookmark, this.pError);
          if (hr == 0)
          {
            this.bookmarkArray.Add(hBookmark);
            hr = NativeMethods.Move(this.pSeCursor, DIRECTION.MOVE_NEXT, this.pError);
          }
          if (NativeMethods.Failed(hr))
          {
            int lMinor = 0;
            int minorError = NativeMethods.GetMinorError(this.pError, ref lMinor);
            if (25001 != lMinor)
            {
              if (minorError != 0)
                this.ProcessResults(minorError);
            }
            else
            {
              NativeMethods.ClearErrorInfo(this.pError);
              flag = true;
            }
          }
        }
        this.Move(DIRECTION.MOVE_FIRST);
        this.Move(DIRECTION.MOVE_PREVIOUS);
        return this.bookmarkArray;
      }
    }

    protected bool ContainsListCollection => false;

    [SecuritySafeCritical]
    internal bool GotoRow(int hBookmark)
    {
      Debug.Assert(-1 != hBookmark, "Attempt to go to HBOOKMARK = -1");
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (this.isOnRow)
        this.ReleaseCurrentRow();
      int hr = NativeMethods.GotoBookmark(this.pSeCursor, hBookmark, this.pError);
      if (NativeMethods.Failed(hr))
      {
        if (-2147217906 == hr)
          return false;
        throw this.connection.ProcessResults(hr, this.pError, (object) this);
      }
      this.cursorPosition = CursorPosition.OnRow;
      this.isOnRow = true;
      this.fetchDirection = FETCH.FORWARD;
      this.OnMove();
      return true;
    }

    private void InitializeMetaData()
    {
      if (this.metadata == null)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderNoData"));
      if (this.fieldNameLookup == null)
        this.fieldNameLookup = new FieldNameLookup((IDataReader) this, -1);
      this.isInitialized = true;
    }

    [SecuritySafeCritical]
    internal void InternalUpdate(object sender)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Updatable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotUpdatable"));
      if (!this.isOnRow)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderNoData"));
      if (this.sqlUpdatableRecord == null)
        return;
      int hr1 = NativeMethods.Prepare(this.pSeCursor, SEPREPAREMODE.PREP_UPDATE, this.pError);
      if (hr1 != 0)
        this.ProcessResults(hr1);
      try
      {
        this.SetValues(SEPREPAREMODE.PREP_UPDATE, this.sqlUpdatableRecord);
        int hr2 = NativeMethods.UpdateRecord(this.pSeCursor, this.pError);
        if (hr2 != 0)
          this.ProcessResults(hr2);
        this.ReleaseCurrentRow();
        this.isOnRow = true;
        this.cursorPosition = CursorPosition.OnRow;
      }
      catch (Exception ex)
      {
        NativeMethods.Prepare(this.pSeCursor, SEPREPAREMODE.PREP_CANCEL, this.pError);
        throw;
      }
    }

    internal void RemoveBookmarkFromCache(int hBookmark)
    {
      if (this.bookmarkArray == null)
        return;
      int index = this.bookmarkArray.IndexOf(hBookmark);
      if (-1 == index)
        return;
      this.bookmarkArray.RemoveAt(index);
    }

    [SecuritySafeCritical]
    internal int InternalInsert(bool fMoveTo, object sender, SqlCeUpdatableRecord record)
    {
      int hBookmark = 0;
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Updatable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotUpdatable"));
      int hr1 = NativeMethods.Prepare(this.pSeCursor, SEPREPAREMODE.PREP_INSERT, this.pError);
      if (hr1 != 0)
        this.ProcessResults(hr1);
      try
      {
        this.SetValues(SEPREPAREMODE.PREP_INSERT, record);
        int hr2 = NativeMethods.InsertRecord(fMoveTo ? 1 : 0, this.pSeCursor, ref hBookmark, this.pError);
        if (hr2 != 0)
          this.ProcessResults(hr2);
        if (fMoveTo)
        {
          if (this.isOnRow)
            this.ReleaseCurrentRow();
          this.isOnRow = true;
          this.cursorPosition = CursorPosition.OnRow;
          this.OnMove();
        }
        if (this.bookmarkArray != null)
          this.bookmarkArray.Add(hBookmark);
        return hBookmark;
      }
      catch (Exception ex)
      {
        NativeMethods.Prepare(this.pSeCursor, SEPREPAREMODE.PREP_CANCEL, this.pError);
        throw;
      }
    }

    [SecurityCritical]
    private unsafe void SetValues(SEPREPAREMODE mode, SqlCeUpdatableRecord record)
    {
      int fieldCount = record.FieldCount;
      ColumnUpdatedStatus[] columnUpdatedStatusArray = record != null ? record.ColumnsUpdatedStatus : throw new ArgumentException(record.GetType().ToString());
      if (columnUpdatedStatusArray == null)
        return;
      try
      {
        for (int ordinal = 0; ordinal < fieldCount; ++ordinal)
        {
          bool flag1 = false;
          bool flag2 = false;
          SqlCeType typeMap = this.metadata[ordinal].typeMap;
          if (columnUpdatedStatusArray[ordinal] == ColumnUpdatedStatus.None)
            flag1 = true;
          if (ColumnUpdatedStatus.ServerDefault == columnUpdatedStatusArray[ordinal])
            flag2 = true;
          if (!typeMap.isBLOB)
          {
            Accessor accessor = this.accessorArray[this.accessorIndex[ordinal]];
            accessor.CurrentIndex = this.bindingIndex[ordinal];
            if (flag1)
              accessor.StatusValue = DBStatus.S_IGNORE;
            else if (flag2)
              accessor.StatusValue = DBStatus.S_DEFAULT;
            else
              accessor.Value = record.values[ordinal];
          }
          else if (!flag1)
          {
            if (flag2)
            {
              int hr = NativeMethods.SetValue(this.pSeCursor, 2, (void*) null, ordinal, 0, this.pError);
              if (hr != 0)
                this.ProcessResults(hr);
            }
            else if (record.IsDBNull(ordinal))
            {
              int hr = NativeMethods.SetValue(this.pSeCursor, 0, (void*) null, ordinal, 0, this.pError);
              if (hr != 0)
                this.ProcessResults(hr);
            }
            else if (SqlDbType.NText == typeMap.sqlDbType)
            {
              object obj = record.values[ordinal];
              switch (obj)
              {
                case char[] _:
                  char[] chArray = (char[]) obj;
                  int size1 = chArray.Length * 2;
                  if (chArray.Length == 0)
                  {
                    chArray = new char[1];
                    size1 = 0;
                  }
                  fixed (char* chPtr = chArray)
                  {
                    int hr = NativeMethods.SetValue(this.pSeCursor, 0, (void*) chPtr, ordinal, size1, this.pError);
                    if (hr != 0)
                    {
                      this.ProcessResults(hr);
                      continue;
                    }
                    continue;
                  }
                case string _:
                  string str = (string) obj;
                  int size2 = str.Length * 2;
                  fixed (char* chPtr = str)
                  {
                    int hr = NativeMethods.SetValue(this.pSeCursor, 0, (void*) chPtr, ordinal, size2, this.pError);
                    if (hr != 0)
                    {
                      this.ProcessResults(hr);
                      continue;
                    }
                    continue;
                  }
                default:
                  continue;
              }
            }
            else if (SqlDbType.Image == typeMap.sqlDbType)
            {
              byte[] numArray = (byte[]) record.values[ordinal];
              int size = numArray.Length;
              if (numArray != null && numArray.Length == 0)
              {
                numArray = new byte[1];
                size = 0;
              }
              fixed (byte* numPtr = numArray)
              {
                int hr = NativeMethods.SetValue(this.pSeCursor, 0, (void*) numPtr, ordinal, size, this.pError);
                if (hr != 0)
                  this.ProcessResults(hr);
              }
            }
          }
        }
        if (this.accessorArray[0] == null)
          return;
        Accessor accessor1 = this.accessorArray[0];
        fixed (MEDBBINDING* medbbindingPtr = accessor1.DbBinding)
        {
          int hr = NativeMethods.SetValues(this.connection.IQPServices, this.pSeCursor, (IntPtr) (void*) medbbindingPtr, accessor1.Count, accessor1.DataHandle, this.pError);
          if (hr == 0)
            return;
          this.ProcessResults(hr);
        }
      }
      catch (SqlCeException ex)
      {
        NativeMethods.Prepare(this.pSeCursor, SEPREPAREMODE.PREP_CANCEL, this.pError);
        throw;
      }
    }

    protected override void OnMove()
    {
      if (this.sqlUpdatableRecord == null)
        return;
      foreach (ColumnUpdatedStatus columnUpdatedStatus in this.sqlUpdatableRecord.ColumnsUpdatedStatus)
        columnUpdatedStatus = ColumnUpdatedStatus.None;
    }

    internal SqlCeUpdatableRecord GetCurrentRecord()
    {
      if (!this.isInitialized)
        this.InitializeMetaData();
      SqlCeUpdatableRecord ceUpdatableRecord = new SqlCeUpdatableRecord(this.metadata, (object[]) null, true, 0, this.fieldNameLookup);
      for (int ordinal = 0; ordinal < this.FieldCount; ++ordinal)
      {
        ceUpdatableRecord[ordinal] = SETYPE.NUMERIC != this.metadata[ordinal].typeMap.seType ? this.GetValue(ordinal) : (object) this.GetSqlDecimal(ordinal);
        ceUpdatableRecord.ColumnsUpdatedStatus[ordinal] = ColumnUpdatedStatus.None;
      }
      return ceUpdatableRecord;
    }

    private void ValidateSet(string method)
    {
      if (!this.Updatable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotUpdatable"));
      if (!this.isInitialized)
        this.InitializeMetaData();
      if (this.sqlUpdatableRecord != null)
        return;
      if (!this.isInitialized)
        this.InitializeMetaData();
      this.sqlUpdatableRecord = new SqlCeUpdatableRecord(this.metadata, (object[]) null, true, 0, this.fieldNameLookup);
    }

    private bool HasColumnChanged(int ordinal)
    {
      if (this.sqlUpdatableRecord == null)
        return false;
      switch (this.sqlUpdatableRecord.ColumnsUpdatedStatus[ordinal])
      {
        case ColumnUpdatedStatus.None:
          return false;
        case ColumnUpdatedStatus.ServerDefault:
          throw new InvalidOperationException(Res.GetString("SQLCE_UnableToFetchDefaultValue"));
        default:
          return true;
      }
    }

    public SqlCeUpdatableRecord CreateRecord()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Updatable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotUpdatable"));
      if (!this.isInitialized)
        this.InitializeMetaData();
      return new SqlCeUpdatableRecord(this.metadata, (object[]) null, this.Updatable, 0, this.fieldNameLookup);
    }

    public void Update() => this.InternalUpdate((object) this);

    [SecuritySafeCritical]
    public void Delete()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Updatable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotUpdatable"));
      if (!this.isOnRow)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderNoData"));
      try
      {
        int hBookmark = -1;
        if (this.bookmarkArray != null)
        {
          int bookmark = NativeMethods.GetBookmark(this.pSeCursor, ref hBookmark, this.pError);
          if (bookmark != 0)
            this.ProcessResults(bookmark);
        }
        int hr = NativeMethods.DeleteRecord(this.pSeCursor, this.pError);
        if (hr != 0)
          this.ProcessResults(hr);
        this.RemoveBookmarkFromCache(hBookmark);
      }
      finally
      {
        this.ReleaseCurrentRow();
      }
    }

    public void Insert(SqlCeUpdatableRecord record) => this.InternalInsert(false, (object) this, record);

    public void Insert(SqlCeUpdatableRecord record, DbInsertOptions options)
    {
      if ((DbInsertOptions.PositionOnInsertedRow & options) != (DbInsertOptions) 0 && (DbInsertOptions.KeepCurrentPosition & options) != (DbInsertOptions) 0)
        throw new ArgumentException(options.ToString());
      this.InternalInsert(DbInsertOptions.PositionOnInsertedRow == options, (object) this, record);
    }

    public bool ReadFirst()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Scrollable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotScrollable"));
      if (IntPtr.Zero != this.pSeCursor)
      {
        int num = this.Move(DIRECTION.MOVE_FIRST) ? 1 : 0;
        this.OnMove();
        return num != 0;
      }
      if (this.IsClosed)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderClosed", (object) nameof (ReadFirst)));
      return false;
    }

    public bool ReadLast()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Scrollable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotScrollable"));
      if (IntPtr.Zero != this.pSeCursor)
      {
        int num = this.Move(DIRECTION.MOVE_LAST) ? 1 : 0;
        this.OnMove();
        return num != 0;
      }
      if (this.IsClosed)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderClosed", (object) nameof (ReadLast)));
      return false;
    }

    public bool ReadPrevious()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Scrollable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotScrollable"));
      if (IntPtr.Zero != this.pSeCursor)
      {
        if (CursorPosition.BeforeFirst == this.cursorPosition)
          return false;
        int num = this.Move(DIRECTION.MOVE_PREVIOUS) ? 1 : 0;
        this.OnMove();
        return num != 0;
      }
      if (this.IsClosed)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderClosed", (object) nameof (ReadPrevious)));
      return false;
    }

    public bool ReadAbsolute(int position)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      if (!this.Scrollable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotScrollable"));
      IList<int> bookmarkArray = this.BookmarkArray;
      if (this.isOnRow)
        this.ReleaseCurrentRow();
      if (position >= 0 && position < bookmarkArray.Count)
        return this.GotoRow(bookmarkArray[position]);
      if (position >= 0 || Math.Abs(position) > bookmarkArray.Count)
        return false;
      IList<int> intList = bookmarkArray;
      return this.GotoRow(intList[intList.Count + position]);
    }

    public bool ReadRelative(int position)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeResultSet));
      bool flag = true;
      if (!this.Scrollable)
        throw new InvalidOperationException(Res.GetString("SQLCE_CursorNotScrollable"));
      if (position == 0)
        return this.isOnRow;
      if (IntPtr.Zero != this.pSeCursor)
      {
        for (; flag && position > 0; flag = this.Move(DIRECTION.MOVE_NEXT))
          --position;
        for (; flag && position < 0; flag = this.Move(DIRECTION.MOVE_PREVIOUS))
          ++position;
      }
      else if (this.IsClosed)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderClosed", (object) nameof (ReadRelative)));
      this.OnMove();
      return flag;
    }

    public void SetDefault(int ordinal)
    {
      this.ValidateSet(nameof (SetDefault));
      this.sqlUpdatableRecord.ColumnsUpdatedStatus[ordinal] = ColumnUpdatedStatus.ServerDefault;
    }

    public bool IsSetAsDefault(int ordinal)
    {
      this.ValidateSet(nameof (IsSetAsDefault));
      return ColumnUpdatedStatus.ServerDefault == this.sqlUpdatableRecord.ColumnsUpdatedStatus[ordinal];
    }

    public override IEnumerator GetEnumerator() => ((IEnumerable) this).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
      ResultSetEnumerator resultSetEnumerator = new ResultSetEnumerator(this);
      resultSetEnumerator.Reset();
      return (IEnumerator) resultSetEnumerator;
    }

    public SqlMetaData GetSqlMetaData(int ordinal)
    {
      if (this.metadata == null)
        throw new InvalidOperationException(Res.GetString("ADP_DataReaderNoData"));
      return this.metadata[ordinal].SqlMetaData;
    }

    public override bool IsDBNull(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.IsDBNull(ordinal) : base.IsDBNull(ordinal);

    public override bool GetBoolean(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetBoolean(ordinal) : base.GetBoolean(ordinal);

    public override Decimal GetDecimal(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetDecimal(ordinal) : base.GetDecimal(ordinal);

    public override byte GetByte(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetByte(ordinal) : base.GetByte(ordinal);

    public override long GetBytes(
      int ordinal,
      long dataIndex,
      byte[] buffer,
      int bufferIndex,
      int length)
    {
      return this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetBytes(ordinal, dataIndex, buffer, bufferIndex, length) : base.GetBytes(ordinal, dataIndex, buffer, bufferIndex, length);
    }

    public override long GetChars(
      int ordinal,
      long dataIndex,
      char[] buffer,
      int bufferIndex,
      int length)
    {
      return this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetChars(ordinal, dataIndex, buffer, bufferIndex, length) : base.GetChars(ordinal, dataIndex, buffer, bufferIndex, length);
    }

    public override DateTime GetDateTime(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetDateTime(ordinal) : base.GetDateTime(ordinal);

    public override double GetDouble(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetDouble(ordinal) : base.GetDouble(ordinal);

    public override float GetFloat(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetFloat(ordinal) : base.GetFloat(ordinal);

    public override Guid GetGuid(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetGuid(ordinal) : base.GetGuid(ordinal);

    public override short GetInt16(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetInt16(ordinal) : base.GetInt16(ordinal);

    public override int GetInt32(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetInt32(ordinal) : base.GetInt32(ordinal);

    public override long GetInt64(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetInt64(ordinal) : base.GetInt64(ordinal);

    public override string GetString(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetString(ordinal) : base.GetString(ordinal);

    public override object GetValue(int ordinal) => this.HasColumnChanged(ordinal) ? this.sqlUpdatableRecord.GetValue(ordinal) : base.GetValue(ordinal);

    public override int GetValues(object[] values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      int num = Math.Min(values.Length, this.FieldCount);
      for (int ordinal = 0; ordinal < num; ++ordinal)
        values[ordinal] = this.GetValue(ordinal);
      return num;
    }

    public void SetObjectRef(int ordinal, object buffer)
    {
      this.ValidateSet("SetValue");
      this.sqlUpdatableRecord.SetObjectRef(ordinal, buffer);
    }

    public int SetValues(object[] values)
    {
      this.ValidateSet(nameof (SetValues));
      return this.sqlUpdatableRecord.SetValues(values);
    }

    public void SetValue(int ordinal, object value)
    {
      this.ValidateSet(nameof (SetValue));
      this.sqlUpdatableRecord.SetValue(ordinal, value);
    }

    public void SetBoolean(int ordinal, bool value)
    {
      this.ValidateSet(nameof (SetBoolean));
      this.sqlUpdatableRecord.SetBoolean(ordinal, value);
    }

    public void SetByte(int ordinal, byte value)
    {
      this.ValidateSet(nameof (SetByte));
      this.sqlUpdatableRecord.SetByte(ordinal, value);
    }

    public void SetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length)
    {
      this.ValidateSet(nameof (SetBytes));
      SqlDbType sqlDbType = this.GetSqlMetaData(ordinal).SqlDbType;
      switch (sqlDbType)
      {
        case SqlDbType.Binary:
        case SqlDbType.Image:
        case SqlDbType.VarBinary:
          long num = 0;
          if (!this.IsDBNull(ordinal))
            num = this.GetBytes(ordinal, 0L, (byte[]) null, 0, 0);
          if (dataIndex > 0L || (long) length < num)
            this.sqlUpdatableRecord[ordinal] = this.GetValue(ordinal);
          this.sqlUpdatableRecord.SetBytes(ordinal, dataIndex, buffer, bufferIndex, length);
          break;
        default:
          throw new ArgumentException(Res.GetString("SQLCE_DataColumn_SetFailed", (object) buffer.ToString(), (object) this.GetName(ordinal), (object) sqlDbType.ToString()));
      }
    }

    public void SetChar(int ordinal, char c)
    {
      this.ValidateSet(nameof (SetChar));
      this.sqlUpdatableRecord.SetChar(ordinal, c);
    }

    public void SetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length)
    {
      this.ValidateSet(nameof (SetChars));
      SqlDbType sqlDbType = this.GetSqlMetaData(ordinal).SqlDbType;
      switch (sqlDbType)
      {
        case SqlDbType.NChar:
        case SqlDbType.NText:
        case SqlDbType.NVarChar:
          long num = 0;
          if (!this.IsDBNull(ordinal))
            num = this.GetChars(ordinal, 0L, (char[]) null, 0, 0);
          if (dataIndex > 0L || (long) length < num)
            this.sqlUpdatableRecord[ordinal] = this.GetValue(ordinal);
          this.sqlUpdatableRecord.SetChars(ordinal, dataIndex, buffer, bufferIndex, length);
          break;
        default:
          throw new ArgumentException(Res.GetString("SQLCE_DataColumn_SetFailed", (object) buffer.ToString(), (object) this.GetName(ordinal), (object) sqlDbType.ToString()));
      }
    }

    public void SetDouble(int ordinal, double value)
    {
      this.ValidateSet(nameof (SetDouble));
      this.sqlUpdatableRecord.SetDouble(ordinal, value);
    }

    public void SetDecimal(int ordinal, Decimal value)
    {
      this.ValidateSet(nameof (SetDecimal));
      this.sqlUpdatableRecord.SetDecimal(ordinal, value);
    }

    public void SetDateTime(int ordinal, DateTime value)
    {
      this.ValidateSet(nameof (SetDateTime));
      this.sqlUpdatableRecord.SetDateTime(ordinal, value);
    }

    public void SetGuid(int ordinal, Guid value)
    {
      this.ValidateSet(nameof (SetGuid));
      this.sqlUpdatableRecord.SetGuid(ordinal, value);
    }

    public void SetInt16(int ordinal, short value)
    {
      this.ValidateSet(nameof (SetInt16));
      this.sqlUpdatableRecord.SetInt16(ordinal, value);
    }

    public void SetInt32(int ordinal, int value)
    {
      this.ValidateSet(nameof (SetInt32));
      this.sqlUpdatableRecord.SetInt32(ordinal, value);
    }

    public void SetInt64(int ordinal, long value)
    {
      this.ValidateSet(nameof (SetInt64));
      this.sqlUpdatableRecord.SetInt64(ordinal, value);
    }

    public void SetFloat(int ordinal, float value)
    {
      this.ValidateSet(nameof (SetFloat));
      this.sqlUpdatableRecord.SetFloat(ordinal, value);
    }

    public void SetString(int ordinal, string value)
    {
      this.ValidateSet(nameof (SetString));
      this.sqlUpdatableRecord.SetString(ordinal, value);
    }
  }
}
