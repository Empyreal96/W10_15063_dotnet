// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeCommand
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeCommand : DbCommand, Microsoft.Phone.Data.Workaround.ICloneable
  {
    private object thisLock = new object();
    private int recordsAffected;
    internal uint[] indexColOrdinals;
    private bool dbRangeSet;
    private bool isHostControlled;
    private bool isPrepared;
    private bool isDisposed;
    private bool isFinalized;
    private SqlCeCommand.ExecuteType executeType;
    private IntPtr pQpPlan;
    private IntPtr pQpCommand;
    private IntPtr pError;
    private string commandText;
    private string indexName;
    private object[] dbRangeStart;
    private object[] dbRangeEnd;
    private DbRangeOptions dbRangeOptions;
    internal ResultSetOptions cursorCapabilities;
    private ResultSetOptions resultSetOptions;
    private CommandType type;
    private UpdateRowSource updatedRowSource;
    internal CommandBehavior behavior;
    private Accessor accessor;
    private SqlCeConnection connection;
    private SqlCeTransaction transaction;
    private SqlCeParameterCollection parameters;
    private SqlCeResultSet resultSet;
    private WeakReferenceCache cursorWeakRefList;
    private MetaData[] metadata;
    private SqlCeDataReader cursor;

    static SqlCeCommand() => KillBitHelper.ThrowIfKillBitIsSet();

    public override string CommandText
    {
      get => this.commandText == null ? string.Empty : this.commandText;
      set
      {
        this.CloseInternalCommand();
        this.commandText = value;
      }
    }

    public string IndexName
    {
      get => this.indexName == null || this.indexName.Length == 0 ? (string) null : this.indexName;
      set => this.indexName = value;
    }

    public override int CommandTimeout
    {
      get => 0;
      set
      {
        if (value != 0)
          throw new ArgumentException(Res.GetString("ADP_InvalidCommandTimeOut"));
      }
    }

    public override CommandType CommandType
    {
      get => this.type;
      set
      {
        if (this.type == value)
          return;
        this.CloseInternalCommand();
        if (CommandType.TableDirect == this.type)
          this.dbRangeSet = false;
        switch (value)
        {
          case CommandType.Text:
          case CommandType.TableDirect:
            this.type = value;
            break;
          case CommandType.StoredProcedure:
            throw new ArgumentException(Res.GetString("ADP_InvalidCommandType", (object) "CommandType.StoredProcedure"));
          default:
            throw new ArgumentException(Res.GetString("ADP_InvalidCommandType", (object) ((int) this.type).ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
      }
    }

    protected override DbConnection DbConnection
    {
      get => (DbConnection) this.Connection;
      set => this.Connection = (SqlCeConnection) value;
    }

    public SqlCeConnection Connection
    {
      get => this.connection;
      set
      {
        if (value == this.connection)
          return;
        this.CloseInternalCommand();
        if (this.connection != null)
        {
          this.connection.RemoveWeakReference((object) this);
          if (this.HasOpenedCursors())
            this.ClearCursorList();
          this.Transaction = (SqlCeTransaction) null;
        }
        this.connection = value;
        if (this.connection == null)
          return;
        this.connection.AddWeakReference((object) this);
      }
    }

    protected override DbParameterCollection DbParameterCollection => (DbParameterCollection) this.Parameters;

    public SqlCeParameterCollection Parameters
    {
      get
      {
        if (this.parameters == null)
          this.parameters = new SqlCeParameterCollection(this);
        return this.parameters;
      }
    }

    protected override DbTransaction DbTransaction
    {
      get => (DbTransaction) this.Transaction;
      set => this.Transaction = (SqlCeTransaction) value;
    }

    public SqlCeTransaction Transaction
    {
      get => this.transaction;
      set
      {
        lock (this.thisLock)
        {
          if (this.isFinalized || this.transaction == value)
            return;
          if (value != null && value.IsZombied)
            throw new InvalidOperationException(Res.GetString("ADP_TransactionZombied", (object) value.GetType().Name));
          if (this.HasOpenedCursors())
            throw new InvalidOperationException(Res.GetString("SQLCE_OpenedCursorsOnTxChange"));
          this.CloseInternalCommand();
          this.transaction = value;
        }
      }
    }

    internal SqlCeTransaction InternalTransaction
    {
      set
      {
        lock (this.thisLock)
        {
          if (this.isFinalized)
            return;
          Debug.Assert(value == null);
          if (value != null)
            return;
          if (this.HasOpenedCursors())
            throw new InvalidOperationException(Res.GetString("SQLCE_OpenedCursorsOnTxChange"));
          this.CloseInternalCommand();
        }
      }
      get => this.transaction;
    }

    public override UpdateRowSource UpdatedRowSource
    {
      get => this.updatedRowSource;
      set
      {
        switch (value)
        {
          case UpdateRowSource.None:
          case UpdateRowSource.OutputParameters:
          case UpdateRowSource.FirstReturnedRecord:
          case UpdateRowSource.Both:
            this.updatedRowSource = value;
            break;
          default:
            throw new ArgumentException(Res.GetString("ADP_InvalidUpdateRowSource", (object) value.ToString()));
        }
      }
    }

    internal IntPtr IQPSession
    {
      get
      {
        if (this.InternalTransaction != null)
          return this.InternalTransaction.IQPSession;
        return this.connection != null ? this.connection.IQPSession : IntPtr.Zero;
      }
    }

    internal IntPtr ITransact
    {
      get
      {
        if (this.InternalTransaction != null)
          return this.InternalTransaction.ITransact;
        return this.connection != null ? this.connection.ITransact : IntPtr.Zero;
      }
    }

    internal IntPtr IQPPlan => this.pQpPlan;

    internal SqlCeCommand(bool isHostControlled)
    {
      NativeMethods.LoadNativeBinaries();
      this.isHostControlled = isHostControlled;
    }

    [SecuritySafeCritical]
    public SqlCeCommand()
    {
      NativeMethods.LoadNativeBinaries();
      this.isDisposed = false;
      this.isFinalized = false;
      this.isPrepared = false;
      this.dbRangeSet = false;
      this.isHostControlled = false;
      this.type = CommandType.Text;
      this.updatedRowSource = UpdateRowSource.Both;
      this.cursorWeakRefList = new WeakReferenceCache(false);
      int errorInstance = NativeMethods.CreateErrorInstance(ref this.pError);
      if (errorInstance == 0)
        return;
      this.ProcessResults(errorInstance);
    }

    public SqlCeCommand(string commandText)
      : this()
    {
      this.CommandText = commandText;
    }

    public SqlCeCommand(string commandText, SqlCeConnection connection)
      : this(commandText)
    {
      this.Connection = connection;
    }

    public SqlCeCommand(
      string commandText,
      SqlCeConnection connection,
      SqlCeTransaction transaction)
      : this(commandText, connection)
    {
      this.Transaction = transaction;
    }

    ~SqlCeCommand() => this.Dispose(false);

    [SecurityCritical]
    private void ReleaseNativeInterfaces()
    {
      if (IntPtr.Zero != this.pQpPlan)
        NativeMethods.SafeRelease(ref this.pQpPlan);
      if (IntPtr.Zero != this.pQpCommand)
        NativeMethods.SafeRelease(ref this.pQpCommand);
      if (!(IntPtr.Zero != this.pError))
        return;
      NativeMethods.SafeDelete(ref this.pError);
    }

    [SecuritySafeCritical]
    protected override void Dispose(bool disposing)
    {
      lock (this.thisLock)
      {
        if (this.isFinalized)
          return;
        if (disposing)
        {
          if (this.connection != null)
          {
            this.connection.RemoveWeakReference((object) this);
            this.connection = (SqlCeConnection) null;
          }
          if (this.accessor != null)
          {
            this.accessor.Dispose();
            this.accessor = (Accessor) null;
          }
          if (this.transaction != null)
            this.transaction = (SqlCeTransaction) null;
          if (this.parameters != null)
          {
            this.parameters.Clear();
            this.parameters = (SqlCeParameterCollection) null;
          }
          this.cursor = (SqlCeDataReader) null;
          this.commandText = (string) null;
          this.parameters = (SqlCeParameterCollection) null;
          this.indexName = (string) null;
          this.indexColOrdinals = (uint[]) null;
          this.dbRangeStart = (object[]) null;
          this.dbRangeEnd = (object[]) null;
          this.isDisposed = true;
        }
        this.ReleaseNativeInterfaces();
        if (disposing)
          return;
        this.isFinalized = true;
      }
    }

    public void SetRange(DbRangeOptions dbRangeOptions, object[] startData, object[] endData)
    {
      this.dbRangeSet = true;
      this.dbRangeOptions = dbRangeOptions;
      this.dbRangeStart = startData;
      this.dbRangeEnd = endData;
    }

    [SecurityCritical]
    private void CreateAccessorFromParameterList()
    {
      Debug.Assert(this.parameters != null);
      int count = 0;
      int num1 = 0;
      for (int index = 0; index < this.parameters.Count; ++index)
      {
        if (this.parameters[index].IsUserSpecifiedType)
          ++count;
      }
      Accessor accessor = new Accessor(count);
      for (int index = 0; index < this.parameters.Count; ++index)
      {
        SqlCeParameter parameter = this.parameters[index];
        Debug.Assert(parameter != null);
        if (parameter.IsUserSpecifiedType)
        {
          Debug.Assert(num1 < count, "CreateAccessorFromParameterList: Incorrect accessor count");
          int num2 = parameter.ParameterName == null ? 0 : 1;
          bool flag = parameter.NativeType.clrType == typeof (string);
          accessor.CurrentIndex = num1;
          accessor.Ordinal = index;
          accessor.ColumnName = num2 == 0 ? (string) null : (parameter.ParameterName.StartsWith("@") ? parameter.ParameterName.Substring(1) : parameter.ParameterName);
          accessor.SeType = parameter.NativeType.seType;
          accessor.MaxLen = parameter.NativeType.fixlen >= 0 ? parameter.NativeType.fixlen : (parameter.UserSpecifiedSize != 0 ? (flag ? (parameter.UserSpecifiedSize + 1) * 2 : parameter.UserSpecifiedSize) : 0);
          if (parameter.SqlDbType == SqlDbType.Decimal && parameter.Value != null && parameter.Value != DBNull.Value && (!(parameter.Value is INullable) || !((INullable) parameter.Value).IsNull))
          {
            accessor.Precision = parameter.Precision;
            accessor.Scale = parameter.Scale;
          }
          ++num1;
        }
      }
      accessor.AllocData();
      this.accessor = accessor;
    }

    [SecurityCritical]
    private void CreateParameterAccessor(MetaData[] metadata)
    {
      Debug.Assert(CommandType.Text == this.CommandType, "CreateAccessor: incorrect CommandType");
      Debug.Assert(this.accessor == null, "CreateAccessor: already has accessor");
      Debug.Assert(metadata != null, "null metadata");
      int length = metadata.Length;
      Accessor accessor = new Accessor(length);
      for (int index = 0; index < length; ++index)
      {
        MetaData info = metadata[index];
        bool flag = false;
        SqlCeParameter parameter;
        if (info.ColumnName.StartsWith("?_", StringComparison.InvariantCultureIgnoreCase))
        {
          parameter = this.parameters[index];
        }
        else
        {
          flag = true;
          parameter = this.parameters[info.ColumnName];
        }
        Debug.Assert(parameter != null);
        if (parameter.IsUserSpecifiedType && parameter.SqlDbType != info.typeMap.sqlDbType)
          SqlCeType.ValidateDataConversion(info.typeMap.sqlDbType, parameter.SqlDbType);
        accessor.CurrentIndex = index;
        accessor.Ordinal = (int) info.ordinal;
        accessor.ColumnName = !flag ? (string) null : (info.ColumnName.StartsWith("@") ? info.ColumnName.Substring(1) : info.ColumnName);
        accessor.SeType = info.typeMap.seType;
        accessor.MaxLen = SqlCeCommand.GetParameterSize(info, parameter);
        accessor.Precision = info.SqlMetaData.Precision;
        accessor.Scale = info.SqlMetaData.Scale;
      }
      accessor.AllocData();
      this.accessor = accessor;
    }

    private static int GetParameterSize(MetaData info, SqlCeParameter p)
    {
      Debug.Assert(info != null, "null base column metadata");
      Debug.Assert(p != null, "null parameter");
      int num;
      if (info.typeMap.fixlen < 0)
      {
        bool isBlob = info.typeMap.isBLOB;
        bool flag1 = info.typeMap.clrType == typeof (string);
        bool flag2 = info.typeMap.sqlDbType != p.SqlDbType;
        if (((!flag1 ? 0 : (!isBlob ? 1 : 0)) & (flag2 ? 1 : 0)) != 0)
          num = p.UserSpecifiedSize != 0 ? Math.Min((p.UserSpecifiedSize + 1) * 2, (int) info.size + 2) : (int) info.size + 2;
        else if (p.UserSpecifiedSize == 0)
        {
          int parameterLength = p.GetParameterLength();
          num = !flag1 ? Math.Min(parameterLength, (int) info.size) : Math.Min((parameterLength + 1) * 2, (int) info.size + 2);
        }
        else
          num = !flag1 ? Math.Min(p.UserSpecifiedSize, (int) info.size) : Math.Min((p.UserSpecifiedSize + 1) * 2, (int) info.size + 2);
      }
      else
        num = info.typeMap.fixlen;
      return num;
    }

    public override void Cancel() => throw new NotSupportedException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (Cancel)));

    object Microsoft.Phone.Data.Workaround.ICloneable.Clone()
    {
      SqlCeCommand instance = (SqlCeCommand) Activator.CreateInstance(this.GetType());
      instance.Connection = this.Connection;
      instance.CommandText = this.CommandText;
      instance.CommandTimeout = this.CommandTimeout;
      instance.CommandType = this.CommandType;
      instance.Transaction = this.Transaction;
      instance.UpdatedRowSource = this.UpdatedRowSource;
      if (this.parameters != null && 0 < this.parameters.Count)
      {
        SqlCeParameterCollection parameters = instance.Parameters;
        foreach (Microsoft.Phone.Data.Workaround.ICloneable parameter in (DbParameterCollection) this.Parameters)
          parameters.Add(parameter.Clone());
      }
      return (object) instance;
    }

    internal void CloseFromConnection()
    {
      lock (this.thisLock)
      {
        if (this.isFinalized)
          return;
        this.CloseInternalCommand();
        this.transaction = (SqlCeTransaction) null;
      }
    }

    [SecuritySafeCritical]
    private void CloseInternalCommand()
    {
      this.behavior = CommandBehavior.SequentialAccess;
      this.isPrepared = false;
      this.cursor = (SqlCeDataReader) null;
      if (this.metadata != null)
      {
        foreach (MetaData metaData in this.metadata)
          metaData?.Dispose();
        Array.Clear((Array) this.metadata, 0, this.metadata.Length);
        this.metadata = (MetaData[]) null;
      }
      if (this.accessor != null)
      {
        this.accessor.Dispose();
        this.accessor = (Accessor) null;
      }
      if (IntPtr.Zero != this.pQpPlan)
        NativeMethods.SafeRelease(ref this.pQpPlan);
      if (!(IntPtr.Zero != this.pQpCommand))
        return;
      NativeMethods.SafeRelease(ref this.pQpCommand);
    }

    protected override DbParameter CreateDbParameter() => (DbParameter) this.CreateParameter();

    public SqlCeParameter CreateParameter() => new SqlCeParameter();

    protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) => (DbDataReader) this.ExecuteReader(behavior);

    public SqlCeDataReader ExecuteReader() => this.ExecuteReader(CommandBehavior.Default);

    public SqlCeDataReader ExecuteReader(CommandBehavior behavior)
    {
      this.executeType = SqlCeCommand.ExecuteType.DataReader;
      return this.ExecuteCommand(behavior, nameof (ExecuteReader), ResultSetOptions.None);
    }

    public SqlCeResultSet ExecuteResultSet(ResultSetOptions options) => this.ExecuteResultSet(options, (SqlCeResultSet) null);

    public SqlCeResultSet ExecuteResultSet(
      ResultSetOptions options,
      SqlCeResultSet resultSet)
    {
      this.executeType = SqlCeCommand.ExecuteType.ResultSet;
      this.resultSet = resultSet;
      return (SqlCeResultSet) this.ExecuteCommand(CommandBehavior.KeyInfo, nameof (ExecuteResultSet), options);
    }

    [SecuritySafeCritical]
    private SqlCeDataReader ExecuteCommand(
      CommandBehavior behavior,
      string method,
      ResultSetOptions options)
    {
      IntPtr zero = IntPtr.Zero;
      SqlCeDataReader reader = (SqlCeDataReader) null;
      try
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(nameof (SqlCeCommand));
        if (this.isPrepared && this.resultSetOptions != options)
          this.CloseInternalCommand();
        if (this.cursor != null && !this.cursor.IsClosed)
          this.CloseInternalCommand();
        this.SetResultSetOptions(options);
        this.behavior = behavior;
        this.ValidateCommand(method);
        this.transaction = this.ValidateTransaction();
        bool isBaseTableCursor = false;
        int resultType;
        switch (this.type)
        {
          case CommandType.Text:
            if (!this.isPrepared)
            {
              this.InitializeCommand(behavior, "Prepare");
              this.CompileQueryPlan();
            }
            if (this.accessor != null && (CommandBehavior.SchemaOnly & this.behavior) == CommandBehavior.Default)
            {
              this.FillParameterDataBindings(true);
              if (!this.isPrepared)
              {
                this.CloseInternalCommand();
                this.InitializeCommand(behavior, "Prepare");
                this.CompileQueryPlan();
                this.FillParameterDataBindings(false);
                Debug.Assert(this.isPrepared);
              }
            }
            resultType = (CommandBehavior.SchemaOnly & this.behavior) == CommandBehavior.Default ? this.ExecuteCommandText(ref zero, ref isBaseTableCursor) : 3;
            break;
          case CommandType.TableDirect:
            this.OpenCursor(behavior, method, ref zero);
            isBaseTableCursor = true;
            resultType = (CommandBehavior.SchemaOnly & this.behavior) == CommandBehavior.Default ? 1 : 3;
            break;
          default:
            throw new ArgumentException(Res.GetString("ADP_InvalidCommandType", (object) this.CommandType.ToString()));
        }
        if (SqlCeCommand.ExecuteType.DataReader == this.executeType)
        {
          reader = new SqlCeDataReader(this.connection, this);
          reader.fetchDirection = FETCH.FORWARD;
        }
        else if (SqlCeCommand.ExecuteType.ResultSet == this.executeType)
        {
          if (this.resultSet == null)
          {
            reader = (SqlCeDataReader) new SqlCeResultSet(this.connection, this);
          }
          else
          {
            reader = (SqlCeDataReader) this.resultSet;
            reader.InitializeReader(this.connection, this);
          }
          if (!isBaseTableCursor)
          {
            reader.fetchDirection = FETCH.FORWARD;
            reader.cursorPosition = this.MoveFirst(zero);
          }
        }
        if (reader != null)
        {
          try
          {
            this.cursor = reader;
            reader.pSeCursor = zero;
            zero = IntPtr.Zero;
            reader.isBaseTableCursor = isBaseTableCursor;
            this.InitializeDataReader(reader, resultType);
            this.cursorWeakRefList.Add((object) reader);
          }
          catch (SqlCeException ex)
          {
            reader.Dispose();
            throw;
          }
        }
      }
      finally
      {
        if (IntPtr.Zero != zero)
          NativeMethods.SafeRelease(ref zero);
      }
      return reader;
    }

    internal bool HasOpenedCursors()
    {
      int count = this.cursorWeakRefList.Count;
      for (int index = 0; index < count; ++index)
      {
        object obj = this.cursorWeakRefList.GetObject(index);
        if (obj != null)
        {
          Debug.Assert(obj is SqlCeDataReader);
          if (!((DbDataReader) obj).IsClosed)
            return true;
          this.cursorWeakRefList.RemoveAt(index);
        }
      }
      return false;
    }

    internal void ClearCursorList()
    {
      int count = this.cursorWeakRefList.Count;
      for (int index = 0; index < count; ++index)
      {
        object obj = this.cursorWeakRefList.GetObject(index);
        if (obj != null)
        {
          Debug.Assert(obj is SqlCeDataReader);
          this.cursorWeakRefList.RemoveAt(index);
        }
      }
    }

    private void SetResultSetOptions(ResultSetOptions options)
    {
      if ((ResultSetOptions.Sensitive & options) != ResultSetOptions.None && (ResultSetOptions.Insensitive & options) != ResultSetOptions.None)
        throw new InvalidOperationException(Res.GetString("SQLCE_ConflictingSensitivityOptions"));
      if (CommandType.TableDirect == this.type)
      {
        if ((ResultSetOptions.Insensitive & options) != ResultSetOptions.None)
          throw new InvalidOperationException(Res.GetString("SQLCE_InsensitiveBaseTableCursor"));
        this.resultSetOptions = options | ResultSetOptions.Sensitive;
      }
      else
        this.resultSetOptions = options;
    }

    [SecurityCritical]
    private CursorPosition MoveFirst(IntPtr pSeCursor)
    {
      if (IntPtr.Zero == pSeCursor)
        return CursorPosition.Undefined;
      int hr = NativeMethods.Move(pSeCursor, DIRECTION.MOVE_FIRST, this.pError);
      if (NativeMethods.Failed(hr))
      {
        int lMinor = 0;
        NativeMethods.GetMinorError(this.pError, ref lMinor);
        if (25001 != lMinor)
        {
          this.ProcessResults(hr);
        }
        else
        {
          NativeMethods.ClearErrorInfo(this.pError);
          return CursorPosition.Undefined;
        }
      }
      return CursorPosition.OnRow;
    }

    [SecurityCritical]
    private SqlCeDataReader InitializeDataReader(
      SqlCeDataReader reader,
      int resultType)
    {
      Debug.Assert(reader != null);
      switch (resultType)
      {
        case 1:
          reader.recordsAffected = this.recordsAffected;
          reader.FillMetaData(this);
          int fieldCount = reader.FieldCount;
          if ((CommandBehavior.SchemaOnly & this.behavior) != CommandBehavior.Default)
          {
            reader.BuildSchemaTable();
            break;
          }
          if (0 < fieldCount)
          {
            reader.CreateAccessors(this, fieldCount, true);
            break;
          }
          break;
        case 2:
          reader.recordsAffected = this.recordsAffected;
          break;
        case 3:
          reader.FillMetaData(this);
          reader.BuildSchemaTable();
          break;
        default:
          Debug.Assert(false, "Unknown command type.");
          break;
      }
      this.connection.AddWeakReference((object) reader);
      if (this.dbRangeSet && (CommandBehavior.SchemaOnly & this.behavior) == CommandBehavior.Default)
        reader.SetRange(this.dbRangeOptions, this.dbRangeStart, this.dbRangeEnd);
      return reader;
    }

    [SecuritySafeCritical]
    private unsafe int ExecuteCommandText(ref IntPtr pCursor, ref bool isBaseTableCursor)
    {
      Debug.Assert(this.connection != null, "null connection");
      isBaseTableCursor = false;
      int hr;
      if (this.accessor != null)
      {
        fixed (MEDBBINDING* medbbindingPtr = this.accessor.DbBinding)
        {
          IntPtr prgBinding = (IntPtr) (void*) medbbindingPtr;
          int cDbBinding = 0;
          IntPtr pData = IntPtr.Zero;
          if (this.accessor != null)
          {
            cDbBinding = this.accessor.Count;
            pData = this.accessor.DataHandle;
          }
          int fIsBaseTableCursor = 0;
          hr = NativeMethods.ExecuteQueryPlan(this.ITransact, this.connection.IQPServices, this.pQpCommand, this.pQpPlan, prgBinding, cDbBinding, pData, ref this.recordsAffected, ref this.cursorCapabilities, ref pCursor, ref fIsBaseTableCursor, this.pError);
          isBaseTableCursor = 1 == fIsBaseTableCursor;
        }
      }
      else
      {
        int fIsBaseTableCursor = 0;
        hr = NativeMethods.ExecuteQueryPlan(this.ITransact, this.connection.IQPServices, this.pQpCommand, this.pQpPlan, IntPtr.Zero, 0, IntPtr.Zero, ref this.recordsAffected, ref this.cursorCapabilities, ref pCursor, ref fIsBaseTableCursor, this.pError);
        isBaseTableCursor = 1 == fIsBaseTableCursor;
      }
      if (hr != 0)
        this.ProcessResults(hr);
      if (IntPtr.Zero != pCursor)
        this.recordsAffected = -1;
      return IntPtr.Zero != pCursor ? 1 : 2;
    }

    public override int ExecuteNonQuery()
    {
      this.executeType = SqlCeCommand.ExecuteType.NonQuery;
      this.ExecuteCommand(CommandBehavior.Default, nameof (ExecuteNonQuery), ResultSetOptions.None);
      return this.recordsAffected;
    }

    public override object ExecuteScalar()
    {
      object obj = (object) null;
      SqlCeDataReader sqlCeDataReader = (SqlCeDataReader) null;
      try
      {
        this.executeType = SqlCeCommand.ExecuteType.DataReader;
        sqlCeDataReader = this.ExecuteCommand(CommandBehavior.Default, nameof (ExecuteScalar), ResultSetOptions.None);
        if (sqlCeDataReader.Read())
        {
          if (0 < sqlCeDataReader.FieldCount)
            obj = sqlCeDataReader.GetValue(0);
        }
      }
      finally
      {
        sqlCeDataReader?.Dispose();
      }
      return obj;
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    [SecurityCritical]
    private unsafe void OpenCursor(CommandBehavior behavior, string method, ref IntPtr pSeCursor)
    {
      this.behavior = behavior;
      string source = this.ExpandCommandText(method);
      IntPtr zero = IntPtr.Zero;
      IntPtr num1 = IntPtr.Zero;
      IntPtr num2 = IntPtr.Zero;
      try
      {
        num1 = NativeMethods.MarshalStringToLPWSTR(source);
        num2 = NativeMethods.MarshalStringToLPWSTR(this.IndexName);
        int hr = NativeMethods.OpenCursor(this.ITransact, num1, num2, ref pSeCursor, this.pError);
        if (hr != 0)
          this.ProcessResults(hr);
        this.cursorCapabilities = this.resultSetOptions;
        if (this.IndexName == null || this.IndexName.Length <= 0)
          return;
        uint cColumns = 0;
        int indexColumnOrdinals = NativeMethods.GetIndexColumnOrdinals(pSeCursor, num2, ref cColumns, ref zero, this.pError);
        if (indexColumnOrdinals != 0)
          this.ProcessResults(indexColumnOrdinals);
        this.indexColOrdinals = new uint[(int) cColumns];
        fixed (uint* numPtr1 = this.indexColOrdinals)
        {
          uint* numPtr2 = (uint*) (void*) zero;
          for (int index = 0; (long) index < (long) cColumns; ++index)
            numPtr1[index] = numPtr2[index];
        }
      }
      finally
      {
        NativeMethods.CoTaskMemFree(num1);
        NativeMethods.CoTaskMemFree(num2);
        NativeMethods.DeleteArray(ref zero);
        this.recordsAffected = -1;
      }
    }

    private string ExpandCommandText(string method)
    {
      if (this.commandText == null || this.commandText.Length == 0)
        throw new InvalidOperationException(Res.GetString("ADP_CommandTextRequired", (object) method));
      switch (this.CommandType)
      {
        case CommandType.Text:
        case CommandType.TableDirect:
          return this.commandText;
        default:
          throw new ArgumentException(Res.GetString("ADP_InvalidCommandType", (object) ((int) this.CommandType).ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
    }

    private void FillParameterDataBindings(bool verifyValue)
    {
      Debug.Assert(this.accessor != null, "Parameter accessor is null");
      int count = this.accessor.Count;
      if (count == 0)
        return;
      Debug.Assert(this.metadata != null);
      if (verifyValue)
      {
        for (int index = 0; index < count; ++index)
        {
          this.accessor.CurrentIndex = index;
          string columnName = this.accessor.ColumnName;
          SqlCeParameter p = columnName == null ? this.parameters[index] : this.parameters[columnName];
          if (!this.metadata[index].typeMap.isFixed && SqlCeCommand.GetParameterSize(this.metadata[index], p) > this.accessor.MaxLen)
          {
            this.OnDataBindingChange();
            return;
          }
          if (p.SqlDbType == SqlDbType.Decimal && p.Value != null && DBNull.Value != p.Value && ((!(p.Value is INullable) || !((INullable) p.Value).IsNull) && ((int) p.Precision - (int) p.Scale > (int) this.accessor.Precision - (int) this.accessor.Scale || (int) p.Scale > (int) this.accessor.Scale)))
          {
            this.OnDataBindingChange();
            return;
          }
        }
      }
      for (int index = 0; index < count; ++index)
      {
        this.accessor.CurrentIndex = index;
        string columnName = this.accessor.ColumnName;
        SqlCeParameter sqlCeParameter = columnName == null ? this.parameters[index] : this.parameters[columnName];
        object parameterValue = sqlCeParameter.GetParameterValue();
        if (parameterValue == null)
          throw new ArgumentNullException(sqlCeParameter.ParameterName, string.Format((IFormatProvider) CultureInfo.CurrentCulture, Res.GetString("ADP_ParameterNotSpecified")));
        try
        {
          this.accessor.doTruncate = sqlCeParameter.UserSpecifiedSize > 0;
          this.accessor.Value = parameterValue;
        }
        catch (InvalidOperationException ex)
        {
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} : {1}", (object) sqlCeParameter.ParameterName, (object) ex.Message));
        }
        catch (InvalidCastException ex)
        {
          throw new InvalidCastException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} : {1}", (object) sqlCeParameter.ParameterName, (object) ex.Message));
        }
        catch (FormatException ex)
        {
          throw new FormatException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} : {1} - {2}", (object) sqlCeParameter.ParameterName, (object) parameterValue.ToString(), (object) ex.Message));
        }
      }
    }

    private void FillParameterDataBindings() => this.FillParameterDataBindings(true);

    [SecurityCritical]
    private void InitializeCommand(CommandBehavior behavior, string method)
    {
      bool flag = false;
      try
      {
        Debug.Assert(this.connection != null);
        this.behavior = behavior;
        if (IntPtr.Zero == this.pQpCommand)
        {
          int command = NativeMethods.CreateCommand(this.IQPSession, ref this.pQpCommand, this.pError);
          if (command != 0)
            this.ProcessResults(command);
        }
        if (this.accessor == null)
          return;
        this.accessor.Dispose();
        this.accessor = (Accessor) null;
      }
      catch (Exception ex)
      {
        flag = true;
        throw;
      }
      finally
      {
        if (flag)
        {
          if (this.accessor != null)
          {
            this.accessor.Dispose();
            this.accessor = (Accessor) null;
          }
          this.CloseInternalCommand();
        }
      }
    }

    [SecuritySafeCritical]
    internal void OnDataBindingChange()
    {
      if (this.accessor == null)
        return;
      this.accessor.Dispose();
      this.accessor = (Accessor) null;
      this.isPrepared = false;
    }

    public override void Prepare()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeCommand));
      this.ValidateCommand(nameof (Prepare));
      this.transaction = this.ValidateTransaction();
      this.CloseInternalCommand();
      this.isPrepared = false;
    }

    internal SqlCeTransaction ValidateTransaction()
    {
      SqlCeTransaction transaction = this.Transaction;
      if (transaction == null)
        return (SqlCeTransaction) null;
      if (transaction != null && this.Connection == ((DbTransaction) transaction).Connection)
        return transaction;
      throw new InvalidOperationException(Res.GetString("ADP_TransactionConnectionMismatch"));
    }

    [SecurityCritical]
    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    private unsafe void CompileQueryPlan()
    {
      bool flag = false;
      try
      {
        this.isPrepared = false;
        if (IntPtr.Zero == this.pQpPlan)
        {
          this.CreateDataBindings();
          string pwszCommandText = this.ExpandCommandText("Prepare");
          Debug.Assert(pwszCommandText != null && pwszCommandText.Length > 0);
          int hr = 0;
          if (this.accessor != null)
          {
            int count = this.accessor.Count;
            IntPtr[] pParamNames = new IntPtr[count];
            try
            {
              fixed (MEDBBINDING* medbbindingPtr = this.accessor.DbBinding)
              {
                IntPtr prgBinding = (IntPtr) (void*) medbbindingPtr;
                for (int index = 0; index < count; ++index)
                {
                  this.accessor.CurrentIndex = index;
                  pParamNames[index] = NativeMethods.MarshalStringToLPWSTR(this.accessor.ColumnName);
                }
                hr = NativeMethods.CompileQueryPlan(this.pQpCommand, pwszCommandText, this.resultSetOptions, pParamNames, prgBinding, count, ref this.pQpPlan, this.pError);
              }
            }
            finally
            {
              for (int index = 0; index < count; ++index)
              {
                if (IntPtr.Zero != pParamNames[index])
                  NativeMethods.CoTaskMemFree(pParamNames[index]);
              }
            }
          }
          else
            hr = NativeMethods.CompileQueryPlan(this.pQpCommand, pwszCommandText, this.resultSetOptions, new IntPtr[0], IntPtr.Zero, 0, ref this.pQpPlan, this.pError);
          if (hr != 0)
            this.ProcessResults(hr);
        }
        this.OnDataBindingChange();
        this.isPrepared = true;
        this.CreateDataBindings();
      }
      catch (Exception ex)
      {
        flag = true;
        throw;
      }
      finally
      {
        if (flag)
        {
          if (this.accessor != null)
          {
            this.accessor.Dispose();
            this.accessor = (Accessor) null;
          }
          this.CloseInternalCommand();
        }
      }
    }

    [SecurityCritical]
    private void CreateDataBindings()
    {
      if (this.parameters == null || this.parameters.Count == 0)
        return;
      if (this.isPrepared)
      {
        this.metadata = this.GetQueryParameters(this.pQpCommand);
        if (this.metadata == null)
          return;
        if (this.accessor != null)
        {
          this.accessor.Dispose();
          this.accessor = (Accessor) null;
        }
        this.CreateParameterAccessor(this.metadata);
      }
      else
      {
        if (this.accessor != null)
        {
          this.accessor.Dispose();
          this.accessor = (Accessor) null;
        }
        if (this.parameters == null || this.parameters.Count == 0)
          return;
        this.CreateAccessorFromParameterList();
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    [SecurityCritical]
    private MetaData[] GetQueryParameters(IntPtr pQpCommand)
    {
      Debug.Assert(IntPtr.Zero != pQpCommand, "Unexpected IQPCommand");
      uint columnCount = 0;
      IntPtr zero = IntPtr.Zero;
      MetaData[] metaDataArray = (MetaData[]) null;
      try
      {
        int parameterInfo = NativeMethods.GetParameterInfo(pQpCommand, ref columnCount, ref zero, this.pError);
        if (parameterInfo != 0)
          this.ProcessResults(parameterInfo);
        if (columnCount == 0U)
          return (MetaData[]) null;
        metaDataArray = new MetaData[(int) columnCount];
        QPPARAMINFO qpparaminfo = new QPPARAMINFO();
        int num1 = Marshal.SizeOf(typeof (QPPARAMINFO));
        int num2 = 0;
        int offset = 0;
        while ((long) num2 < (long) columnCount)
        {
          try
          {
            Marshal.PtrToStructure(ADP.IntPtrOffset(zero, offset), (object) qpparaminfo);
            string stringUni = Marshal.PtrToStringUni(qpparaminfo.pwszParam);
            SqlCeType sqlCeType = SqlCeType.FromSeType(qpparaminfo.type);
            uint num3 = sqlCeType.SqlDbType == SqlDbType.NVarChar || sqlCeType.SqlDbType == SqlDbType.NChar ? qpparaminfo.ulSize / 2U : qpparaminfo.ulSize;
            SqlCeType typeMap = sqlCeType;
            int bPrecision = (int) qpparaminfo.bPrecision;
            int bScale = (int) qpparaminfo.bScale;
            long maxLength = (long) num3;
            MetaData metaData = new MetaData(stringUni, typeMap, (byte) bPrecision, (byte) bScale, maxLength, (string) null, (string) null);
            metaData.ordinal = qpparaminfo.iOrdinal;
            metaData.size = qpparaminfo.ulSize;
            metaData.typeMap = sqlCeType;
            Debug.Assert(metaData.ordinal < columnCount, "Column ordinal value is greater than number of columns");
            metaDataArray[(int) metaData.ordinal] = metaData;
          }
          finally
          {
            NativeMethods.SafeDelete(ref qpparaminfo.pwszParam);
          }
          ++num2;
          offset += num1;
        }
      }
      finally
      {
        NativeMethods.DeleteArray(ref zero);
      }
      return metaDataArray;
    }

    private void ProcessResults(int hr)
    {
      Exception exception = (Exception) this.connection.ProcessResults(hr, this.pError, (object) this);
      if (exception != null)
        throw exception;
    }

    internal void ValidateCommand(string method)
    {
      if (this.connection == null)
      {
        string name = (string) null;
        if (!(method == "Prepare"))
        {
          if (!(method == "ExecuteReader"))
          {
            if (!(method == "ExecuteNonQuery"))
            {
              if (!(method == "ExecuteScalar"))
              {
                if (method == "ExecuteResultSet")
                  name = "ADP_ConnectionRequired_ExecuteReader";
              }
              else
                name = "ADP_ConnectionRequired_ExecuteScalar";
            }
            else
              name = "ADP_ConnectionRequired_ExecuteNonQuery";
          }
          else
            name = "ADP_ConnectionRequired_ExecuteReader";
        }
        else
          name = "ADP_ConnectionRequired_Prepare";
        throw new InvalidOperationException(Res.GetString(name, (object) method));
      }
      if (ConnectionState.Open != this.connection.State)
      {
        string name = (string) null;
        if (!(method == "Prepare"))
        {
          if (!(method == "ExecuteReader"))
          {
            if (!(method == "ExecuteNonQuery"))
            {
              if (!(method == "ExecuteScalar"))
              {
                if (method == "ExecuteResultSet")
                  name = "ADP_ConnectionRequired_ExecuteReader";
              }
              else
                name = "ADP_OpenConnectionRequired_ExecuteScalar";
            }
            else
              name = "ADP_OpenConnectionRequired_ExecuteNonQuery";
          }
          else
            name = "ADP_OpenConnectionRequired_ExecuteReader";
        }
        else
          name = "ADP_OpenConnectionRequired_Prepare";
        throw new InvalidOperationException(Res.GetString(name, (object) method, (object) this.connection.State));
      }
    }

    public override bool DesignTimeVisible
    {
      get => false;
      set
      {
        if (value)
          throw new NotSupportedException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (DesignTimeVisible)));
      }
    }

    internal enum ExecuteType
    {
      NonQuery,
      DataReader,
      ResultSet,
    }
  }
}
