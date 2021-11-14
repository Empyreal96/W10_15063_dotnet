// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.ADP
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Microsoft.Phone.Data.Common
{
  internal static class ADP
  {
    private static readonly Type StackOverflowType = typeof (StackOverflowException);
    private static readonly Type OutOfMemoryType = typeof (OutOfMemoryException);
    private static readonly Type ThreadAbortType = typeof (ThreadAbortException);
    private static readonly Type NullReferenceType = typeof (NullReferenceException);
    internal const string ConnectionString = "ConnectionString";
    internal const string DataSetColumn = "DataSetColumn";
    internal const string DataSetTable = "DataSetTable";
    internal const string Fill = "Fill";
    internal const string FillSchema = "FillSchema";
    internal const string SourceColumn = "SourceColumn";
    internal const string SourceTable = "SourceTable";
    internal const CompareOptions compareOptions = CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth;
    internal const int DefaultConnectionTimeout = 15;
    internal static readonly string StrEmpty = "";
    internal static readonly int CharSize = 2;

    private static void TraceException(string trace, Exception e)
    {
    }

    internal static void TraceExceptionAsReturnValue(Exception e) => ADP.TraceException("<comm.ADP.TraceException|ERR|THROW> '%ls'\n", e);

    internal static void TraceExceptionForCapture(Exception e)
    {
      Debug.Assert(ADP.IsCatchableExceptionType(e), "Invalid exception type, should have been re-thrown!");
      ADP.TraceException("<comm.ADP.TraceException|ERR|CATCH> '%ls'\n", e);
    }

    internal static void TraceExceptionWithoutRethrow(Exception e)
    {
      Debug.Assert(ADP.IsCatchableExceptionType(e), "Invalid exception type, should have been re-thrown!");
      ADP.TraceException("<comm.ADP.TraceException|ERR|CATCH> '%ls'\n", e);
    }

    internal static ArgumentException Argument(string error)
    {
      ArgumentException argumentException = new ArgumentException(error);
      ADP.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    internal static ArgumentException Argument(string error, Exception inner)
    {
      ArgumentException argumentException = new ArgumentException(error, inner);
      ADP.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    internal static ArgumentException Argument(string error, string parameter)
    {
      ArgumentException argumentException = new ArgumentException(error, parameter);
      ADP.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    internal static ArgumentNullException ArgumentNull(string parameter)
    {
      ArgumentNullException argumentNullException = new ArgumentNullException(parameter);
      ADP.TraceExceptionAsReturnValue((Exception) argumentNullException);
      return argumentNullException;
    }

    internal static ArgumentNullException ArgumentNull(
      string parameter,
      string error)
    {
      ArgumentNullException argumentNullException = new ArgumentNullException(parameter, error);
      ADP.TraceExceptionAsReturnValue((Exception) argumentNullException);
      return argumentNullException;
    }

    internal static ArgumentOutOfRangeException ArgumentOutOfRange(
      string parameterName)
    {
      ArgumentOutOfRangeException ofRangeException = new ArgumentOutOfRangeException(parameterName);
      ADP.TraceExceptionAsReturnValue((Exception) ofRangeException);
      return ofRangeException;
    }

    internal static ArgumentOutOfRangeException ArgumentOutOfRange(
      string message,
      string parameterName)
    {
      ArgumentOutOfRangeException ofRangeException = new ArgumentOutOfRangeException(parameterName, message);
      ADP.TraceExceptionAsReturnValue((Exception) ofRangeException);
      return ofRangeException;
    }

    internal static DataException Data(string message)
    {
      DataException dataException = new DataException(message);
      ADP.TraceExceptionAsReturnValue((Exception) dataException);
      return dataException;
    }

    internal static IndexOutOfRangeException IndexOutOfRange(string error)
    {
      IndexOutOfRangeException ofRangeException = new IndexOutOfRangeException(error);
      ADP.TraceExceptionAsReturnValue((Exception) ofRangeException);
      return ofRangeException;
    }

    internal static InvalidCastException InvalidCast(string error) => ADP.InvalidCast(error, (Exception) null);

    internal static InvalidCastException InvalidCast(
      string error,
      Exception inner)
    {
      InvalidCastException invalidCastException = new InvalidCastException(error, inner);
      ADP.TraceExceptionAsReturnValue((Exception) invalidCastException);
      return invalidCastException;
    }

    internal static InvalidOperationException InvalidOperation(string error)
    {
      InvalidOperationException operationException = new InvalidOperationException(error);
      ADP.TraceExceptionAsReturnValue((Exception) operationException);
      return operationException;
    }

    internal static NotSupportedException NotSupported()
    {
      NotSupportedException supportedException = new NotSupportedException();
      ADP.TraceExceptionAsReturnValue((Exception) supportedException);
      return supportedException;
    }

    internal static NotSupportedException NotSupported(string error)
    {
      NotSupportedException supportedException = new NotSupportedException(error);
      ADP.TraceExceptionAsReturnValue((Exception) supportedException);
      return supportedException;
    }

    internal static InvalidOperationException DataAdapter(string error) => ADP.InvalidOperation(error);

    private static InvalidOperationException Provider(string error) => ADP.InvalidOperation(error);

    internal static void CheckArgumentLength(string value, string parameterName)
    {
      ADP.CheckArgumentNull((object) value, parameterName);
      if (value.Length == 0)
      {
        // ISSUE: reference to a compiler-generated method
        throw ADP.Argument(Res.GetString("ADP_EmptyString", (object) parameterName));
      }
    }

    internal static void CheckArgumentLength(Array value, string parameterName)
    {
      ADP.CheckArgumentNull((object) value, parameterName);
      if (value.Length == 0)
      {
        // ISSUE: reference to a compiler-generated method
        throw ADP.Argument(Res.GetString("ADP_EmptyArray", (object) parameterName));
      }
    }

    internal static void CheckArgumentNull(object value, string parameterName)
    {
      if (value == null)
        throw ADP.ArgumentNull(parameterName);
    }

    internal static bool IsCatchableExceptionType(Exception e)
    {
      Debug.Assert(e != null, "Unexpected null exception!");
      Type type = e.GetType();
      return type != ADP.StackOverflowType && type != ADP.OutOfMemoryType && type != ADP.ThreadAbortType && type != ADP.NullReferenceType;
    }

    internal static bool IsCatchableOrSecurityExceptionType(Exception e)
    {
      Debug.Assert(e != null, "Unexpected null exception!");
      Type type = e.GetType();
      return type != ADP.StackOverflowType && type != ADP.OutOfMemoryType && type != ADP.ThreadAbortType && type != ADP.NullReferenceType;
    }

    internal static ArgumentOutOfRangeException InvalidEnumerationValue(
      Type type,
      int value)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.ArgumentOutOfRange(Res.GetString("ADP_InvalidEnumerationValue", (object) type.Name, (object) value.ToString((IFormatProvider) CultureInfo.InvariantCulture)), type.Name);
    }

    internal static ArgumentOutOfRangeException NotSupportedEnumerationValue(
      Type type,
      string value,
      string method)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.ArgumentOutOfRange(Res.GetString("ADP_NotSupportedEnumerationValue", (object) type.Name, (object) value, (object) method), type.Name);
    }

    internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(
      AcceptRejectRule value)
    {
      if (value == AcceptRejectRule.None || value == AcceptRejectRule.Cascade)
        Debug.Assert(false, "valid AcceptRejectRule " + value.ToString());
      return ADP.InvalidEnumerationValue(typeof (AcceptRejectRule), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidCatalogLocation(
      CatalogLocation value)
    {
      if (value == CatalogLocation.Start || value == CatalogLocation.End)
        Debug.Assert(false, "valid CatalogLocation " + value.ToString());
      return ADP.InvalidEnumerationValue(typeof (CatalogLocation), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidConflictOptions(
      ConflictOption value)
    {
      switch (value)
      {
        case ConflictOption.CompareAllSearchableValues:
        case ConflictOption.CompareRowVersion:
        case ConflictOption.OverwriteChanges:
          Debug.Assert(false, "valid ConflictOption " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (ConflictOption), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidDataRowState(
      DataRowState value)
    {
      switch (value)
      {
        case DataRowState.Detached:
        case DataRowState.Unchanged:
        case DataRowState.Added:
        case DataRowState.Deleted:
        case DataRowState.Modified:
          Debug.Assert(false, "valid DataRowState " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (DataRowState), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidLoadOption(
      LoadOption value)
    {
      switch (value)
      {
        case LoadOption.OverwriteChanges:
        case LoadOption.PreserveChanges:
        case LoadOption.Upsert:
          Debug.Assert(false, "valid LoadOption " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (LoadOption), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidMissingMappingAction(
      MissingMappingAction value)
    {
      switch (value)
      {
        case MissingMappingAction.Passthrough:
        case MissingMappingAction.Ignore:
        case MissingMappingAction.Error:
          Debug.Assert(false, "valid MissingMappingAction " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (MissingMappingAction), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(
      MissingSchemaAction value)
    {
      switch (value)
      {
        case MissingSchemaAction.Add:
        case MissingSchemaAction.Ignore:
        case MissingSchemaAction.Error:
        case MissingSchemaAction.AddWithKey:
          Debug.Assert(false, "valid MissingSchemaAction " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (MissingSchemaAction), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidRule(Rule value)
    {
      switch (value)
      {
        case Rule.None:
        case Rule.Cascade:
        case Rule.SetNull:
        case Rule.SetDefault:
          Debug.Assert(false, "valid Rule " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (Rule), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidSchemaType(
      SchemaType value)
    {
      if (value == SchemaType.Source || value == SchemaType.Mapped)
        Debug.Assert(false, "valid SchemaType " + value.ToString());
      return ADP.InvalidEnumerationValue(typeof (SchemaType), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidStatementType(
      StatementType value)
    {
      switch (value)
      {
        case StatementType.Select:
        case StatementType.Insert:
        case StatementType.Update:
        case StatementType.Delete:
        case StatementType.Batch:
          Debug.Assert(false, "valid StatementType " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (StatementType), (int) value);
    }

    internal static ArgumentOutOfRangeException InvalidUpdateStatus(
      UpdateStatus value)
    {
      switch (value)
      {
        case UpdateStatus.Continue:
        case UpdateStatus.ErrorsOccurred:
        case UpdateStatus.SkipCurrentRow:
        case UpdateStatus.SkipAllRemainingRows:
          Debug.Assert(false, "valid UpdateStatus " + value.ToString());
          break;
      }
      return ADP.InvalidEnumerationValue(typeof (UpdateStatus), (int) value);
    }

    internal static ArgumentOutOfRangeException NotSupportedStatementType(
      StatementType value,
      string method)
    {
      return ADP.NotSupportedEnumerationValue(typeof (StatementType), value.ToString(), method);
    }

    internal static ArgumentException ConnectionStringSyntax(int index) => ADP.Argument(Res.GetString("ADP_ConnectionStringSyntax", (object) index));

    internal static ArgumentException KeywordNotSupported(string keyword) => ADP.Argument(Res.GetString("ADP_KeywordNotSupported", (object) keyword));

    internal static ArgumentException InvalidKeyname(string parameterName) => ADP.Argument(Res.GetString("ADP_InvalidKey"), parameterName);

    internal static ArgumentException InvalidValue(string parameterName) => ADP.Argument(Res.GetString("ADP_InvalidValue"), parameterName);

    internal static ArgumentException ConvertFailed(
      Type fromType,
      Type toType,
      Exception innerException)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.Argument(Res.GetString("SqlConvert_ConvertFailed", (object) fromType.FullName, (object) toType.FullName), innerException);
    }

    private static string ConnectionStateMsg(ConnectionState state)
    {
      switch (state)
      {
        case ConnectionState.Closed:
        case ConnectionState.Connecting | ConnectionState.Broken:
          // ISSUE: reference to a compiler-generated method
          return Res.GetString("ADP_ConnectionStateMsg_Closed");
        case ConnectionState.Open:
          // ISSUE: reference to a compiler-generated method
          return Res.GetString("ADP_ConnectionStateMsg_Open");
        case ConnectionState.Connecting:
          // ISSUE: reference to a compiler-generated method
          return Res.GetString("ADP_ConnectionStateMsg_Connecting");
        case ConnectionState.Open | ConnectionState.Executing:
          // ISSUE: reference to a compiler-generated method
          return Res.GetString("ADP_ConnectionStateMsg_OpenExecuting");
        case ConnectionState.Open | ConnectionState.Fetching:
          // ISSUE: reference to a compiler-generated method
          return Res.GetString("ADP_ConnectionStateMsg_OpenFetching");
        default:
          // ISSUE: reference to a compiler-generated method
          return Res.GetString("ADP_ConnectionStateMsg", (object) state.ToString());
      }
    }

    internal static Exception WrongType(Type got, Type expected) => (Exception) ADP.Argument(Res.GetString("SQL_WrongType", (object) got.ToString(), (object) expected.ToString()));

    internal static ArgumentException CollectionRemoveInvalidObject(
      Type itemType,
      ICollection collection)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.Argument(Res.GetString("ADP_CollectionRemoveInvalidObject", (object) itemType.Name, (object) collection.GetType().Name));
    }

    internal static ArgumentNullException CollectionNullValue(
      string parameter,
      Type collection,
      Type itemType)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.ArgumentNull(parameter, Res.GetString("ADP_CollectionNullValue", (object) collection.Name, (object) itemType.Name));
    }

    internal static IndexOutOfRangeException CollectionIndexInt32(
      int index,
      Type collection,
      int count)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.IndexOutOfRange(Res.GetString("ADP_CollectionIndexInt32", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) collection.Name, (object) count.ToString((IFormatProvider) CultureInfo.InvariantCulture)));
    }

    internal static IndexOutOfRangeException CollectionIndexString(
      Type itemType,
      string propertyName,
      string propertyValue,
      Type collection)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.IndexOutOfRange(Res.GetString("ADP_CollectionIndexString", (object) itemType.Name, (object) propertyName, (object) propertyValue, (object) collection.Name));
    }

    internal static InvalidCastException CollectionInvalidType(
      Type collection,
      Type itemType,
      object invalidValue)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidCast(Res.GetString("ADP_CollectionInvalidType", (object) collection.Name, (object) itemType.Name, (object) invalidValue.GetType().Name));
    }

    internal static Exception CollectionUniqueValue(
      Type itemType,
      string propertyName,
      string propertyValue)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ADP.Argument(Res.GetString("ADP_CollectionUniqueValue", (object) itemType.Name, (object) propertyName, (object) propertyValue));
    }

    internal static ArgumentException ParametersIsNotParent(
      Type parameterType,
      ICollection collection)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.Argument(Res.GetString("ADP_CollectionIsNotParent", (object) parameterType.Name, (object) collection.GetType().Name));
    }

    internal static ArgumentException ParametersIsParent(
      Type parameterType,
      ICollection collection)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.Argument(Res.GetString("ADP_CollectionIsNotParent", (object) parameterType.Name, (object) collection.GetType().Name));
    }

    internal static InvalidOperationException MissingSelectCommand(
      string method)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.Provider(Res.GetString("ADP_MissingSelectCommand", (object) method));
    }

    private static InvalidOperationException DataMapping(string error) => ADP.InvalidOperation(error);

    internal static InvalidOperationException ColumnSchemaExpression(
      string srcColumn,
      string cacheColumn)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataMapping(Res.GetString("ADP_ColumnSchemaExpression", (object) srcColumn, (object) cacheColumn));
    }

    internal static InvalidOperationException ColumnSchemaMismatch(
      string srcColumn,
      Type srcType,
      DataColumn column)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataMapping(Res.GetString("ADP_ColumnSchemaMismatch", (object) srcColumn, (object) srcType.Name, (object) column.ColumnName, (object) column.DataType.Name));
    }

    internal static InvalidOperationException ColumnSchemaMissing(
      string cacheColumn,
      string tableName,
      string srcColumn)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ADP.IsEmpty(tableName) ? ADP.InvalidOperation(Res.GetString("ADP_ColumnSchemaMissing1", (object) cacheColumn, (object) tableName, (object) srcColumn)) : ADP.DataMapping(Res.GetString("ADP_ColumnSchemaMissing2", (object) cacheColumn, (object) tableName, (object) srcColumn));
    }

    internal static InvalidOperationException MissingColumnMapping(
      string srcColumn)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataMapping(Res.GetString("ADP_MissingColumnMapping", (object) srcColumn));
    }

    internal static InvalidOperationException MissingTableSchema(
      string cacheTable,
      string srcTable)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataMapping(Res.GetString("ADP_MissingTableSchema", (object) cacheTable, (object) srcTable));
    }

    internal static InvalidOperationException MissingTableMapping(
      string srcTable)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataMapping(Res.GetString("ADP_MissingTableMapping", (object) srcTable));
    }

    internal static InvalidOperationException MissingTableMappingDestination(
      string dstTable)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataMapping(Res.GetString("ADP_MissingTableMappingDestination", (object) dstTable));
    }

    internal static Exception InvalidSourceColumn(string parameter) => (Exception) ADP.Argument(Res.GetString("ADP_InvalidSourceColumn"), parameter);

    internal static Exception ColumnsAddNullAttempt(string parameter) => (Exception) ADP.CollectionNullValue(parameter, typeof (DataColumnMappingCollection), typeof (DataColumnMapping));

    internal static Exception ColumnsDataSetColumn(string cacheColumn) => (Exception) ADP.CollectionIndexString(typeof (DataColumnMapping), "DataSetColumn", cacheColumn, typeof (DataColumnMappingCollection));

    internal static Exception ColumnsIndexInt32(
      int index,
      IColumnMappingCollection collection)
    {
      return (Exception) ADP.CollectionIndexInt32(index, collection.GetType(), collection.Count);
    }

    internal static Exception ColumnsIndexSource(string srcColumn) => (Exception) ADP.CollectionIndexString(typeof (DataColumnMapping), "SourceColumn", srcColumn, typeof (DataColumnMappingCollection));

    internal static Exception ColumnsIsNotParent(ICollection collection) => (Exception) ADP.ParametersIsNotParent(typeof (DataColumnMapping), collection);

    internal static Exception ColumnsIsParent(ICollection collection) => (Exception) ADP.ParametersIsParent(typeof (DataColumnMapping), collection);

    internal static Exception ColumnsUniqueSourceColumn(string srcColumn) => ADP.CollectionUniqueValue(typeof (DataColumnMapping), "SourceColumn", srcColumn);

    internal static Exception NotADataColumnMapping(object value) => (Exception) ADP.CollectionInvalidType(typeof (DataColumnMappingCollection), typeof (DataColumnMapping), value);

    internal static Exception InvalidSourceTable(string parameter) => (Exception) ADP.Argument(Res.GetString("ADP_InvalidSourceTable"), parameter);

    internal static Exception TablesAddNullAttempt(string parameter) => (Exception) ADP.CollectionNullValue(parameter, typeof (DataTableMappingCollection), typeof (DataTableMapping));

    internal static Exception TablesDataSetTable(string cacheTable) => (Exception) ADP.CollectionIndexString(typeof (DataTableMapping), "DataSetTable", cacheTable, typeof (DataTableMappingCollection));

    internal static Exception TablesIndexInt32(
      int index,
      ITableMappingCollection collection)
    {
      return (Exception) ADP.CollectionIndexInt32(index, collection.GetType(), collection.Count);
    }

    internal static Exception TablesIsNotParent(ICollection collection) => (Exception) ADP.ParametersIsNotParent(typeof (DataTableMapping), collection);

    internal static Exception TablesIsParent(ICollection collection) => (Exception) ADP.ParametersIsParent(typeof (DataTableMapping), collection);

    internal static Exception TablesSourceIndex(string srcTable) => (Exception) ADP.CollectionIndexString(typeof (DataTableMapping), "SourceTable", srcTable, typeof (DataTableMappingCollection));

    internal static Exception TablesUniqueSourceTable(string srcTable) => ADP.CollectionUniqueValue(typeof (DataTableMapping), "SourceTable", srcTable);

    internal static Exception NotADataTableMapping(object value) => (Exception) ADP.CollectionInvalidType(typeof (DataTableMappingCollection), typeof (DataTableMapping), value);

    internal static InvalidOperationException UpdateConnectionRequired(
      StatementType statementType,
      bool isRowUpdatingCommand)
    {
      string key;
      if (isRowUpdatingCommand)
      {
        key = "ADP_ConnectionRequired_Clone";
      }
      else
      {
        switch (statementType)
        {
          case StatementType.Select:
            Debug.Assert(false, "shouldn't be here");
            break;
          case StatementType.Insert:
            key = "ADP_ConnectionRequired_Insert";
            goto label_9;
          case StatementType.Update:
            key = "ADP_ConnectionRequired_Update";
            goto label_9;
          case StatementType.Delete:
            key = "ADP_ConnectionRequired_Delete";
            goto label_9;
        }
        throw ADP.InvalidStatementType(statementType);
      }
label_9:
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString(key));
    }

    internal static InvalidOperationException ConnectionRequired_Res(
      string method)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString("ADP_ConnectionRequired_" + method));
    }

    internal static InvalidOperationException UpdateOpenConnectionRequired(
      StatementType statementType,
      bool isRowUpdatingCommand,
      ConnectionState state)
    {
      string key;
      if (isRowUpdatingCommand)
      {
        key = "ADP_OpenConnectionRequired_Clone";
      }
      else
      {
        switch (statementType)
        {
          case StatementType.Select:
            Debug.Assert(false, "shouldn't be here");
            break;
          case StatementType.Insert:
            key = "ADP_OpenConnectionRequired_Insert";
            goto label_9;
          case StatementType.Update:
            key = "ADP_OpenConnectionRequired_Update";
            goto label_9;
          case StatementType.Delete:
            key = "ADP_OpenConnectionRequired_Delete";
            goto label_9;
          case StatementType.Batch:
            Debug.Assert(false, "isRowUpdatingCommand should have been true");
            break;
        }
        throw ADP.InvalidStatementType(statementType);
      }
label_9:
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString(key, (object) ADP.ConnectionStateMsg(state)));
    }

    internal static Exception InvalidSeekOrigin(string parameterName) => (Exception) ADP.ArgumentOutOfRange(Res.GetString("ADP_InvalidSeekOrigin"), parameterName);

    internal static ArgumentException UnwantedStatementType(
      StatementType statementType)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.Argument(Res.GetString("ADP_UnwantedStatementType", (object) statementType.ToString()));
    }

    internal static Exception FillSchemaRequiresSourceTableName(string parameter) => (Exception) ADP.Argument(Res.GetString("ADP_FillSchemaRequiresSourceTableName"), parameter);

    internal static Exception InvalidMaxRecords(string parameter, int max) => (Exception) ADP.Argument(Res.GetString("ADP_InvalidMaxRecords", (object) max.ToString((IFormatProvider) CultureInfo.InvariantCulture)), parameter);

    internal static Exception InvalidStartRecord(string parameter, int start) => (Exception) ADP.Argument(Res.GetString("ADP_InvalidStartRecord", (object) start.ToString((IFormatProvider) CultureInfo.InvariantCulture)), parameter);

    internal static Exception FillRequires(string parameter) => (Exception) ADP.ArgumentNull(parameter);

    internal static Exception FillRequiresSourceTableName(string parameter) => (Exception) ADP.Argument(Res.GetString("ADP_FillRequiresSourceTableName"), parameter);

    internal static Exception FillChapterAutoIncrement() => (Exception) ADP.InvalidOperation(Res.GetString("ADP_FillChapterAutoIncrement"));

    internal static InvalidOperationException MissingDataReaderFieldType(
      int index)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.DataAdapter(Res.GetString("ADP_MissingDataReaderFieldType", (object) index));
    }

    internal static InvalidOperationException OnlyOneTableForStartRecordOrMaxRecords() => ADP.DataAdapter(Res.GetString("ADP_OnlyOneTableForStartRecordOrMaxRecords"));

    internal static ArgumentNullException UpdateRequiresNonNullDataSet(
      string parameter)
    {
      return ADP.ArgumentNull(parameter);
    }

    internal static InvalidOperationException UpdateRequiresSourceTable(
      string defaultSrcTableName)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString("ADP_UpdateRequiresSourceTable", (object) defaultSrcTableName));
    }

    internal static InvalidOperationException UpdateRequiresSourceTableName(
      string srcTable)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString("ADP_UpdateRequiresSourceTableName", (object) srcTable));
    }

    internal static ArgumentNullException UpdateRequiresDataTable(
      string parameter)
    {
      return ADP.ArgumentNull(parameter);
    }

    internal static Exception UpdateConcurrencyViolation(
      StatementType statementType,
      int affected,
      int expected,
      DataRow[] dataRows)
    {
      string key;
      switch (statementType)
      {
        case StatementType.Select:
        case StatementType.Insert:
          Debug.Assert(false, "should be here");
          goto default;
        case StatementType.Update:
          key = "ADP_UpdateConcurrencyViolation_Update";
          break;
        case StatementType.Delete:
          key = "ADP_UpdateConcurrencyViolation_Delete";
          break;
        case StatementType.Batch:
          key = "ADP_UpdateConcurrencyViolation_Batch";
          break;
        default:
          throw ADP.InvalidStatementType(statementType);
      }
      // ISSUE: reference to a compiler-generated method
      DBConcurrencyException concurrencyException = new DBConcurrencyException(Res.GetString(key, (object) affected.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) expected.ToString((IFormatProvider) CultureInfo.InvariantCulture)), (Exception) null, dataRows);
      ADP.TraceExceptionAsReturnValue((Exception) concurrencyException);
      return (Exception) concurrencyException;
    }

    internal static InvalidOperationException UpdateRequiresCommand(
      StatementType statementType,
      bool isRowUpdatingCommand)
    {
      string key;
      if (isRowUpdatingCommand)
      {
        key = "ADP_UpdateRequiresCommandClone";
      }
      else
      {
        switch (statementType)
        {
          case StatementType.Select:
            key = "ADP_UpdateRequiresCommandSelect";
            goto label_9;
          case StatementType.Insert:
            key = "ADP_UpdateRequiresCommandInsert";
            goto label_9;
          case StatementType.Update:
            key = "ADP_UpdateRequiresCommandUpdate";
            goto label_9;
          case StatementType.Delete:
            key = "ADP_UpdateRequiresCommandDelete";
            goto label_9;
          case StatementType.Batch:
            Debug.Assert(false, "isRowUpdatingCommand should have been true");
            break;
        }
        throw ADP.InvalidStatementType(statementType);
      }
label_9:
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString(key));
    }

    internal static ArgumentException UpdateMismatchRowTable(int i) => ADP.Argument(Res.GetString("ADP_UpdateMismatchRowTable", (object) i.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    internal static DataException RowUpdatedErrors() => ADP.Data(Res.GetString("ADP_RowUpdatedErrors"));

    internal static DataException RowUpdatingErrors() => ADP.Data(Res.GetString("ADP_RowUpdatingErrors"));

    internal static InvalidOperationException ResultsNotAllowedDuringBatch() => ADP.DataAdapter(Res.GetString("ADP_ResultsNotAllowedDuringBatch"));

    internal static Exception InternalError(ADP.InternalErrorCode internalError) => (Exception) ADP.InvalidOperation(Res.GetString("ADP_InternalProviderError", (object) (int) internalError));

    internal static Exception DataReaderClosed(string method) => (Exception) ADP.InvalidOperation(Res.GetString("ADP_DataReaderClosed", (object) method));

    internal static ArgumentOutOfRangeException InvalidSourceBufferIndex(
      int maxLen,
      long srcOffset,
      string parameterName)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.ArgumentOutOfRange(Res.GetString("ADP_InvalidSourceBufferIndex", (object) maxLen.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) srcOffset.ToString((IFormatProvider) CultureInfo.InvariantCulture)), parameterName);
    }

    internal static ArgumentOutOfRangeException InvalidDestinationBufferIndex(
      int maxLen,
      int dstOffset,
      string parameterName)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.ArgumentOutOfRange(Res.GetString("ADP_InvalidDestinationBufferIndex", (object) maxLen.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) dstOffset.ToString((IFormatProvider) CultureInfo.InvariantCulture)), parameterName);
    }

    internal static IndexOutOfRangeException InvalidBufferSizeOrIndex(
      int numBytes,
      int bufferIndex)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.IndexOutOfRange(Res.GetString("SQL_InvalidBufferSizeOrIndex", (object) numBytes.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) bufferIndex.ToString((IFormatProvider) CultureInfo.InvariantCulture)));
    }

    internal static Exception InvalidDataLength(long length) => (Exception) ADP.IndexOutOfRange(Res.GetString("SQL_InvalidDataLength", (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    internal static Exception StreamClosed(string method) => (Exception) ADP.InvalidOperation(Res.GetString("ADP_StreamClosed", (object) method));

    internal static InvalidOperationException DynamicSQLJoinUnsupported() => ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLJoinUnsupported"));

    internal static InvalidOperationException DynamicSQLNoTableInfo() => ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLNoTableInfo"));

    internal static InvalidOperationException DynamicSQLNoKeyInfoDelete() => ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLNoKeyInfoDelete"));

    internal static InvalidOperationException DynamicSQLNoKeyInfoUpdate() => ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLNoKeyInfoUpdate"));

    internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionDelete() => ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLNoKeyInfoRowVersionDelete"));

    internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionUpdate() => ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLNoKeyInfoRowVersionUpdate"));

    internal static InvalidOperationException DynamicSQLNestedQuote(
      string name,
      string quote)
    {
      // ISSUE: reference to a compiler-generated method
      return ADP.InvalidOperation(Res.GetString("ADP_DynamicSQLNestedQuote", (object) name, (object) quote));
    }

    internal static InvalidOperationException NoQuoteChange() => ADP.InvalidOperation(Res.GetString("ADP_NoQuoteChange"));

    internal static InvalidOperationException MissingSourceCommand() => ADP.InvalidOperation(Res.GetString("ADP_MissingSourceCommand"));

    internal static InvalidOperationException MissingSourceCommandConnection() => ADP.InvalidOperation(Res.GetString("ADP_MissingSourceCommandConnection"));

    internal static bool CompareInsensitiveInvariant(string strvalue, string strconst) => CultureInfo.InvariantCulture.CompareInfo.Compare(strvalue, strconst, CompareOptions.IgnoreCase) == 0;

    internal static string BuildQuotedString(
      string quotePrefix,
      string quoteSuffix,
      string unQuotedString)
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      if (!ADP.IsEmpty(quotePrefix))
        stringBuilder1.Append(quotePrefix);
      if (!ADP.IsEmpty(quoteSuffix))
      {
        StringBuilder stringBuilder2 = stringBuilder1;
        string str1 = unQuotedString;
        string oldValue = quoteSuffix;
        string str2 = quoteSuffix;
        string newValue = str2 + str2;
        string str3 = str1.Replace(oldValue, newValue);
        stringBuilder2.Append(str3);
        stringBuilder1.Append(quoteSuffix);
      }
      else
        stringBuilder1.Append(unQuotedString);
      return stringBuilder1.ToString();
    }

    internal static DataRow[] SelectAdapterRows(DataTable dataTable, bool sorted)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      DataRowCollection rows = dataTable.Rows;
      foreach (DataRow dataRow in (InternalDataCollectionBase) rows)
      {
        switch (dataRow.RowState)
        {
          case DataRowState.Added:
            ++num1;
            continue;
          case DataRowState.Deleted:
            ++num2;
            continue;
          case DataRowState.Modified:
            ++num3;
            continue;
          default:
            Debug.Assert(((DataRowState.Added | DataRowState.Deleted | DataRowState.Modified) & dataRow.RowState) == (DataRowState) 0, "flagged RowState");
            continue;
        }
      }
      DataRow[] dataRowArray = new DataRow[num1 + num2 + num3];
      if (sorted)
      {
        int num4 = num1 + num2;
        int num5 = num1;
        int num6 = 0;
        foreach (DataRow dataRow in (InternalDataCollectionBase) rows)
        {
          switch (dataRow.RowState)
          {
            case DataRowState.Added:
              dataRowArray[num6++] = dataRow;
              continue;
            case DataRowState.Deleted:
              dataRowArray[num5++] = dataRow;
              continue;
            case DataRowState.Modified:
              dataRowArray[num4++] = dataRow;
              continue;
            default:
              Debug.Assert(((DataRowState.Added | DataRowState.Deleted | DataRowState.Modified) & dataRow.RowState) == (DataRowState) 0, "flagged RowState");
              continue;
          }
        }
      }
      else
      {
        int num4 = 0;
        foreach (DataRow dataRow in (InternalDataCollectionBase) rows)
        {
          if ((dataRow.RowState & (DataRowState.Added | DataRowState.Deleted | DataRowState.Modified)) != (DataRowState) 0)
          {
            dataRowArray[num4++] = dataRow;
            if (num4 == dataRowArray.Length)
              break;
          }
        }
      }
      return dataRowArray;
    }

    internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray)
    {
      Dictionary<string, int> hash = new Dictionary<string, int>(columnNameArray.Length);
      int val1 = columnNameArray.Length;
      for (int index = columnNameArray.Length - 1; 0 <= index; --index)
      {
        string columnName = columnNameArray[index];
        if (columnName != null && 0 < columnName.Length)
        {
          string lower = columnName.ToLower(CultureInfo.InvariantCulture);
          int val2;
          if (hash.TryGetValue(lower, out val2))
            val1 = Math.Min(val1, val2);
          hash[lower] = index;
        }
        else
        {
          columnNameArray[index] = ADP.StrEmpty;
          val1 = index;
        }
      }
      int uniqueIndex = 1;
      for (int index = val1; index < columnNameArray.Length; ++index)
      {
        string columnName = columnNameArray[index];
        if (columnName.Length == 0)
        {
          columnNameArray[index] = "Column";
          uniqueIndex = ADP.GenerateUniqueName(hash, ref columnNameArray[index], index, uniqueIndex);
        }
        else
        {
          string lower = columnName.ToLower(CultureInfo.InvariantCulture);
          if (index != hash[lower])
            ADP.GenerateUniqueName(hash, ref columnNameArray[index], index, 1);
        }
      }
    }

    private static int GenerateUniqueName(
      Dictionary<string, int> hash,
      ref string columnName,
      int index,
      int uniqueIndex)
    {
      string str;
      string lower;
      while (true)
      {
        str = columnName + uniqueIndex.ToString((IFormatProvider) CultureInfo.InvariantCulture);
        lower = str.ToLower(CultureInfo.InvariantCulture);
        if (hash.ContainsKey(lower))
          ++uniqueIndex;
        else
          break;
      }
      columnName = str;
      hash.Add(lower, index);
      return uniqueIndex;
    }

    internal static int SrcCompare(string strA, string strB) => !(strA == strB) ? 1 : 0;

    internal static int DstCompare(string strA, string strB) => CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

    internal static bool IsEmpty(string str) => str == null || str.Length == 0;

    internal static bool IsNull(object value) => value == null || DBNull.Value == value;

    internal enum ConnectionError
    {
      BeginGetConnectionReturnsNull,
      GetConnectionReturnsNull,
      ConnectionOptionsMissing,
      CouldNotSwitchToClosedPreviouslyOpenedState,
    }

    internal enum InternalErrorCode
    {
      UnpooledObjectHasOwner = 0,
      UnpooledObjectHasWrongOwner = 1,
      PushingObjectSecondTime = 2,
      PooledObjectHasOwner = 3,
      PooledObjectInPoolMoreThanOnce = 4,
      CreateObjectReturnedNull = 5,
      NewObjectCannotBePooled = 6,
      NonPooledObjectUsedMoreThanOnce = 7,
      AttemptingToPoolOnRestrictedToken = 8,
      ConvertSidToStringSidWReturnedNull = 10, // 0x0000000A
      AttemptingToConstructReferenceCollectionOnStaticObject = 12, // 0x0000000C
      AttemptingToEnlistTwice = 13, // 0x0000000D
      CreateReferenceCollectionReturnedNull = 14, // 0x0000000E
      PooledObjectWithoutPool = 15, // 0x0000000F
      UnexpectedWaitAnyResult = 16, // 0x00000010
      NameValuePairNext = 20, // 0x00000014
      InvalidParserState1 = 21, // 0x00000015
      InvalidParserState2 = 22, // 0x00000016
      InvalidBuffer = 30, // 0x0000001E
      UnimplementedSMIMethod = 40, // 0x00000028
      InvalidSmiCall = 41, // 0x00000029
      SqlDependencyObtainProcessDispatcherFailureObjectHandle = 50, // 0x00000032
      SqlDependencyProcessDispatcherFailureCreateInstance = 51, // 0x00000033
      SqlDependencyProcessDispatcherFailureAppDomain = 52, // 0x00000034
    }
  }
}
