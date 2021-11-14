// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ExceptionBuilder
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Data;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal static class ExceptionBuilder
  {
    private static void TraceException(string trace, Exception e)
    {
    }

    internal static void TraceExceptionAsReturnValue(Exception e) => ExceptionBuilder.TraceException("<comm.ADP.TraceException|ERR|THROW> Message='%ls'", e);

    internal static void TraceExceptionForCapture(Exception e) => ExceptionBuilder.TraceException("<comm.ADP.TraceException|ERR|CATCH> Message='%ls'", e);

    internal static void TraceExceptionWithoutRethrow(Exception e) => ExceptionBuilder.TraceException("<comm.ADP.TraceException|ERR|CATCH> Message='%ls'", e);

    internal static ArgumentException _Argument(string error)
    {
      ArgumentException argumentException = new ArgumentException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    internal static ArgumentException _Argument(string paramName, string error)
    {
      ArgumentException argumentException = new ArgumentException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    internal static ArgumentException _Argument(
      string error,
      Exception innerException)
    {
      ArgumentException argumentException = new ArgumentException(error, innerException);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    private static ArgumentNullException _ArgumentNull(
      string paramName,
      string msg)
    {
      ArgumentNullException argumentNullException = new ArgumentNullException(paramName, msg);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) argumentNullException);
      return argumentNullException;
    }

    internal static ArgumentOutOfRangeException _ArgumentOutOfRange(
      string paramName,
      string msg)
    {
      ArgumentOutOfRangeException ofRangeException = new ArgumentOutOfRangeException(paramName, msg);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) ofRangeException);
      return ofRangeException;
    }

    private static IndexOutOfRangeException _IndexOutOfRange(string error)
    {
      IndexOutOfRangeException ofRangeException = new IndexOutOfRangeException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) ofRangeException);
      return ofRangeException;
    }

    private static InvalidOperationException _InvalidOperation(string error)
    {
      InvalidOperationException operationException = new InvalidOperationException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) operationException);
      return operationException;
    }

    private static ArgumentException _InvalidEnumArgumentException(string error)
    {
      ArgumentException argumentException = new ArgumentException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) argumentException);
      return argumentException;
    }

    private static ArgumentException _InvalidEnumArgumentException<T>(T value) => ExceptionBuilder._InvalidEnumArgumentException(Res.GetString("ADP_InvalidEnumerationValue", (object) typeof (T).Name, (object) value.ToString()));

    private static DataException _Data(string error)
    {
      DataException dataException = new DataException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) dataException);
      return dataException;
    }

    private static DataException _Data(string error, Exception innerException)
    {
      DataException dataException = new DataException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) dataException);
      return dataException;
    }

    private static ConstraintException _Constraint(string error)
    {
      ConstraintException constraintException = new ConstraintException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) constraintException);
      return constraintException;
    }

    private static InvalidConstraintException _InvalidConstraint(
      string error)
    {
      InvalidConstraintException constraintException = new InvalidConstraintException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) constraintException);
      return constraintException;
    }

    private static DeletedRowInaccessibleException _DeletedRowInaccessible(
      string error)
    {
      DeletedRowInaccessibleException inaccessibleException = new DeletedRowInaccessibleException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) inaccessibleException);
      return inaccessibleException;
    }

    private static DuplicateNameException _DuplicateName(string error)
    {
      DuplicateNameException duplicateNameException = new DuplicateNameException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) duplicateNameException);
      return duplicateNameException;
    }

    private static InRowChangingEventException _InRowChangingEvent(
      string error)
    {
      InRowChangingEventException changingEventException = new InRowChangingEventException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) changingEventException);
      return changingEventException;
    }

    private static MissingPrimaryKeyException _MissingPrimaryKey(
      string error)
    {
      MissingPrimaryKeyException primaryKeyException = new MissingPrimaryKeyException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) primaryKeyException);
      return primaryKeyException;
    }

    private static NoNullAllowedException _NoNullAllowed(string error)
    {
      NoNullAllowedException allowedException = new NoNullAllowedException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) allowedException);
      return allowedException;
    }

    private static ReadOnlyException _ReadOnly(string error)
    {
      ReadOnlyException readOnlyException = new ReadOnlyException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) readOnlyException);
      return readOnlyException;
    }

    private static RowNotInTableException _RowNotInTable(string error)
    {
      RowNotInTableException inTableException = new RowNotInTableException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) inTableException);
      return inTableException;
    }

    private static VersionNotFoundException _VersionNotFound(string error)
    {
      VersionNotFoundException notFoundException = new VersionNotFoundException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) notFoundException);
      return notFoundException;
    }

    public static Exception ArgumentNull(string paramName) => (Exception) ExceptionBuilder._ArgumentNull(paramName, Res.GetString("Data_ArgumentNull", (object) paramName));

    public static Exception ArgumentOutOfRange(string paramName) => (Exception) ExceptionBuilder._ArgumentOutOfRange(paramName, Res.GetString("Data_ArgumentOutOfRange", (object) paramName));

    public static Exception BadObjectPropertyAccess(string error) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataConstraint_BadObjectPropertyAccess", (object) error));

    public static Exception ArgumentContainsNull(string paramName) => (Exception) ExceptionBuilder._Argument(paramName, Res.GetString("Data_ArgumentContainsNull", (object) paramName));

    public static Exception CannotModifyCollection() => (Exception) ExceptionBuilder._Argument(Res.GetString("Data_CannotModifyCollection"));

    public static Exception CaseInsensitiveNameConflict(string name) => (Exception) ExceptionBuilder._Argument(Res.GetString("Data_CaseInsensitiveNameConflict", (object) name));

    public static Exception NamespaceNameConflict(string name) => (Exception) ExceptionBuilder._Argument(Res.GetString("Data_NamespaceNameConflict", (object) name));

    public static Exception InvalidOffsetLength() => (Exception) ExceptionBuilder._Argument(Res.GetString("Data_InvalidOffsetLength"));

    public static Exception ColumnNotInTheTable(string column, string table) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_NotInTheTable", (object) column, (object) table));

    public static Exception ColumnNotInAnyTable() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_NotInAnyTable"));

    public static Exception ColumnOutOfRange(int index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataColumns_OutOfRange", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception ColumnOutOfRange(string column) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataColumns_OutOfRange", (object) column));

    public static Exception CannotAddColumn1(string column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_Add1", (object) column));

    public static Exception CannotAddColumn2(string column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_Add2", (object) column));

    public static Exception CannotAddColumn3() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_Add3"));

    public static Exception CannotAddColumn4(string column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_Add4", (object) column));

    public static Exception CannotAddDuplicate(string column) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataColumns_AddDuplicate", (object) column));

    public static Exception CannotAddDuplicate2(string table) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataColumns_AddDuplicate2", (object) table));

    public static Exception CannotAddDuplicate3(string table) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataColumns_AddDuplicate3", (object) table));

    public static Exception CannotRemoveColumn() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_Remove"));

    public static Exception CannotRemovePrimaryKey() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_RemovePrimaryKey"));

    public static Exception CannotRemoveChildKey(string relation) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_RemoveChildKey", (object) relation));

    public static Exception CannotRemoveConstraint(string constraint, string table) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_RemoveConstraint", (object) constraint, (object) table));

    public static Exception CannotRemoveExpression(string column, string expression) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_RemoveExpression", (object) column, (object) expression));

    public static Exception ColumnNotInTheUnderlyingTable(string column, string table) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_NotInTheUnderlyingTable", (object) column, (object) table));

    public static Exception InvalidOrdinal(string name, int ordinal) => (Exception) ExceptionBuilder._ArgumentOutOfRange(name, Res.GetString("DataColumn_OrdinalExceedMaximun", (object) ordinal.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception AddPrimaryKeyConstraint() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_AddPrimaryKeyConstraint"));

    public static Exception NoConstraintName() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_NoName"));

    public static Exception ConstraintViolation(string constraint) => (Exception) ExceptionBuilder._Constraint(Res.GetString("DataConstraint_Violation", (object) constraint));

    public static Exception ConstraintNotInTheTable(string constraint) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_NotInTheTable", (object) constraint));

    public static string KeysToString(object[] keys)
    {
      string str = string.Empty;
      for (int index = 0; index < keys.Length; ++index)
        str = str + keys[index].ToString() + (index < keys.Length - 1 ? ", " : string.Empty);
      return str;
    }

    public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values)
    {
      if (columns.Length <= 1)
      {
        // ISSUE: reference to a compiler-generated method
        return Res.GetString("DataConstraint_ViolationValue", (object) columns[0].ColumnName, (object) values[0].ToString());
      }
      string str = string.Empty;
      for (int index = 0; index < columns.Length; ++index)
        str = str + columns[index].ColumnName + (index < columns.Length - 1 ? ", " : "");
      // ISSUE: reference to a compiler-generated method
      return Res.GetString("DataConstraint_ViolationValue", (object) str, (object) ExceptionBuilder.KeysToString(values));
    }

    public static Exception ConstraintViolation(DataColumn[] columns, object[] values) => (Exception) ExceptionBuilder._Constraint(ExceptionBuilder.UniqueConstraintViolationText(columns, values));

    public static Exception ConstraintOutOfRange(int index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataConstraint_OutOfRange", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception DuplicateConstraint(string constraint) => (Exception) ExceptionBuilder._Data(Res.GetString("DataConstraint_Duplicate", (object) constraint));

    public static Exception DuplicateConstraintName(string constraint) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataConstraint_DuplicateName", (object) constraint));

    public static Exception NeededForForeignKeyConstraint(
      UniqueConstraint key,
      ForeignKeyConstraint fk)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_NeededForForeignKeyConstraint", (object) key.ConstraintName, (object) fk.ConstraintName));
    }

    public static Exception UniqueConstraintViolation() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_UniqueViolation"));

    public static Exception ConstraintForeignTable() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_ForeignTable"));

    public static Exception ConstraintParentValues() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_ParentValues"));

    public static Exception ConstraintAddFailed(DataTable table) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataConstraint_AddFailed", (object) table.TableName));

    public static Exception ConstraintRemoveFailed() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_RemoveFailed"));

    public static Exception FailedCascadeDelete(string constraint) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataConstraint_CascadeDelete", (object) constraint));

    public static Exception FailedCascadeUpdate(string constraint) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataConstraint_CascadeUpdate", (object) constraint));

    public static Exception FailedClearParentTable(
      string table,
      string constraint,
      string childTable)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataConstraint_ClearParentTable", (object) table, (object) constraint, (object) childTable));
    }

    public static Exception ForeignKeyViolation(string constraint, object[] keys) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataConstraint_ForeignKeyViolation", (object) constraint, (object) ExceptionBuilder.KeysToString(keys)));

    public static Exception RemoveParentRow(ForeignKeyConstraint constraint) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataConstraint_RemoveParentRow", (object) constraint.ConstraintName));

    public static string MaxLengthViolationText(string columnName) => Res.GetString("DataColumn_ExceedMaxLength", (object) columnName);

    public static string NotAllowDBNullViolationText(string columnName) => Res.GetString("DataColumn_NotAllowDBNull", (object) columnName);

    public static Exception CantAddConstraintToMultipleNestedTable(string tableName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataConstraint_CantAddConstraintToMultipleNestedTable", (object) tableName));

    public static Exception AutoIncrementAndExpression() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_AutoIncrementAndExpression"));

    public static Exception AutoIncrementAndDefaultValue() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_AutoIncrementAndDefaultValue"));

    public static Exception AutoIncrementSeed() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_AutoIncrementSeed"));

    public static Exception CantChangeDataType() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_ChangeDataType"));

    public static Exception NullDataType() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_NullDataType"));

    public static Exception ColumnNameRequired() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_NameRequired"));

    public static Exception DefaultValueAndAutoIncrement() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_DefaultValueAndAutoIncrement"));

    public static Exception DefaultValueDataType(
      string column,
      Type defaultType,
      Type columnType)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return column.Length == 0 ? (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_DefaultValueDataType1", (object) defaultType.FullName, (object) columnType.FullName)) : (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_DefaultValueDataType", (object) column, (object) defaultType.FullName, (object) columnType.FullName));
    }

    public static Exception DefaultValueColumnDataType(
      string column,
      Type defaultType,
      Type columnType)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_DefaultValueColumnDataType", (object) column, (object) defaultType.FullName, (object) columnType.FullName));
    }

    public static Exception ExpressionAndUnique() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_ExpressionAndUnique"));

    public static Exception ExpressionAndReadOnly() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_ExpressionAndReadOnly"));

    public static Exception ExpressionAndConstraint(
      DataColumn column,
      Constraint constraint)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_ExpressionAndConstraint", (object) column.ColumnName, (object) constraint.ConstraintName));
    }

    public static Exception ExpressionInConstraint(DataColumn column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_ExpressionInConstraint", (object) column.ColumnName));

    public static Exception ExpressionCircular() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_ExpressionCircular"));

    public static Exception NonUniqueValues(string column) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataColumn_NonUniqueValues", (object) column));

    public static Exception NullKeyValues(string column) => (Exception) ExceptionBuilder._Data(Res.GetString("DataColumn_NullKeyValues", (object) column));

    public static Exception NullValues(string column) => (Exception) ExceptionBuilder._NoNullAllowed(Res.GetString("DataColumn_NullValues", (object) column));

    public static Exception ReadOnlyAndExpression() => (Exception) ExceptionBuilder._ReadOnly(Res.GetString("DataColumn_ReadOnlyAndExpression"));

    public static Exception ReadOnly(string column) => (Exception) ExceptionBuilder._ReadOnly(Res.GetString("DataColumn_ReadOnly", (object) column));

    public static Exception UniqueAndExpression() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_UniqueAndExpression"));

    public static Exception SetFailed(
      object value,
      DataColumn column,
      Type type,
      Exception innerException)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._Argument(innerException.Message + Res.GetString("DataColumn_SetFailed", (object) value.ToString(), (object) column.ColumnName, (object) type.Name), innerException);
    }

    public static Exception CannotSetToNull(DataColumn column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_CannotSetToNull", (object) column.ColumnName));

    public static Exception LongerThanMaxLength(DataColumn column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_LongerThanMaxLength", (object) column.ColumnName));

    public static Exception CannotSetMaxLength(DataColumn column, int value) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_CannotSetMaxLength", (object) column.ColumnName, (object) value.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception CannotSetMaxLength2(DataColumn column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_CannotSetMaxLength2", (object) column.ColumnName));

    public static Exception CannotSetSimpleContentType(string columnName, Type type) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_CannotSimpleContentType", (object) columnName, (object) type));

    public static Exception CannotSetSimpleContent(string columnName, Type type) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_CannotSimpleContent", (object) columnName, (object) type));

    public static Exception CannotChangeNamespace(string columnName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_CannotChangeNamespace", (object) columnName));

    public static Exception HasToBeStringType(DataColumn column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_HasToBeStringType", (object) column.ColumnName));

    public static Exception AutoIncrementCannotSetIfHasData(string typeName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_AutoIncrementCannotSetIfHasData", (object) typeName));

    public static Exception INullableUDTwithoutStaticNull(string typeName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_INullableUDTwithoutStaticNull", (object) typeName));

    public static Exception IComparableNotImplemented(string typeName) => (Exception) ExceptionBuilder._Data(Res.GetString("DataStorage_IComparableNotDefined", (object) typeName));

    public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataColumn_UDTImplementsIChangeTrackingButnotIRevertible", (object) typeName));

    public static Exception SetAddedAndModifiedCalledOnnonUnchanged() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataColumn_SetAddedAndModifiedCalledOnNonUnchanged"));

    public static Exception InvalidDataColumnMapping(Type type) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumn_InvalidDataColumnMapping", (object) type.AssemblyQualifiedName));

    public static Exception CannotSetDateTimeModeForNonDateTimeColumns() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataColumn_CannotSetDateTimeModeForNonDateTimeColumns"));

    public static Exception InvalidDateTimeMode(DataSetDateTime mode) => (Exception) ExceptionBuilder._Argument(Res.GetString("ADP_InvalidEnumerationValue", (object) mode.GetType().FullName, (object) Convert.ToString((object) mode, (IFormatProvider) null)));

    public static Exception CantChangeDateTimeMode(
      DataSetDateTime oldValue,
      DataSetDateTime newValue)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataColumn_DateTimeMode", (object) oldValue.ToString(), (object) newValue.ToString()));
    }

    public static Exception ColumnTypeNotSupported() => (Exception) ADP.NotSupported(Res.GetString("DataColumn_NullableTypesNotSupported"));

    public static Exception SetFailed(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_SetFailed", (object) name));

    public static Exception SetDataSetFailed() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_SetDataSetFailed"));

    public static Exception SetRowStateFilter() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_SetRowStateFilter"));

    public static Exception CanNotSetDataSet() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotSetDataSet"));

    public static Exception CanNotUseDataViewManager() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotUseDataViewManager"));

    public static Exception CanNotSetTable() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotSetTable"));

    public static Exception CanNotUse() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotUse"));

    public static Exception CanNotBindTable() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotBindTable"));

    public static Exception SetTable() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_SetTable"));

    public static Exception SetIListObject() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataView_SetIListObject"));

    public static Exception AddNewNotAllowNull() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_AddNewNotAllowNull"));

    public static Exception NotOpen() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_NotOpen"));

    public static Exception CreateChildView() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataView_CreateChildView"));

    public static Exception CanNotDelete() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotDelete"));

    public static Exception CanNotEdit() => (Exception) ExceptionBuilder._Data(Res.GetString("DataView_CanNotEdit"));

    public static Exception GetElementIndex(int index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataView_GetElementIndex", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception AddExternalObject() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataView_AddExternalObject"));

    public static Exception CanNotClear() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataView_CanNotClear"));

    public static Exception InsertExternalObject() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataView_InsertExternalObject"));

    public static Exception RemoveExternalObject() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataView_RemoveExternalObject"));

    public static Exception PropertyNotFound(string property, string table) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataROWView_PropertyNotFound", (object) property, (object) table));

    public static Exception ColumnToSortIsOutOfRange(string column) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataColumns_OutOfRange", (object) column));

    public static Exception KeyTableMismatch() => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataKey_TableMismatch"));

    public static Exception KeyNoColumns() => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataKey_NoColumns"));

    public static Exception KeyTooManyColumns(int cols) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataKey_TooManyColumns", (object) cols.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception KeyDuplicateColumns(string columnName) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataKey_DuplicateColumns", (object) columnName));

    public static Exception RelationDataSetMismatch() => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_DataSetMismatch"));

    public static Exception NoRelationName() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_NoName"));

    public static Exception ColumnsTypeMismatch() => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_ColumnsTypeMismatch"));

    public static Exception KeyLengthMismatch() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_KeyLengthMismatch"));

    public static Exception KeyLengthZero() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_KeyZeroLength"));

    public static Exception ForeignRelation() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_ForeignDataSet"));

    public static Exception KeyColumnsIdentical() => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_KeyColumnsIdentical"));

    public static Exception RelationForeignTable(string t1, string t2) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_ForeignTable", (object) t1, (object) t2));

    public static Exception GetParentRowTableMismatch(string t1, string t2) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_GetParentRowTableMismatch", (object) t1, (object) t2));

    public static Exception SetParentRowTableMismatch(string t1, string t2) => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_SetParentRowTableMismatch", (object) t1, (object) t2));

    public static Exception RelationForeignRow() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_ForeignRow"));

    public static Exception RelationNestedReadOnly() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_RelationNestedReadOnly"));

    public static Exception TableCantBeNestedInTwoTables(string tableName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_TableCantBeNestedInTwoTables", (object) tableName));

    public static Exception LoopInNestedRelations(string tableName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_LoopInNestedRelations", (object) tableName));

    public static Exception RelationDoesNotExist() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_DoesNotExist"));

    public static Exception ParentRowNotInTheDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRow_ParentRowNotInTheDataSet"));

    public static Exception ParentOrChildColumnsDoNotHaveDataSet() => (Exception) ExceptionBuilder._InvalidConstraint(Res.GetString("DataRelation_ParentOrChildColumnsDoNotHaveDataSet"));

    public static Exception InValidNestedRelation(string childTableName) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataRelation_InValidNestedRelation", (object) childTableName));

    public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataRelation_InValidNamespaceInNestedRelation", (object) childTableName));

    public static Exception RowNotInTheDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRow_NotInTheDataSet"));

    public static Exception RowNotInTheTable() => (Exception) ExceptionBuilder._RowNotInTable(Res.GetString("DataRow_NotInTheTable"));

    public static Exception EditInRowChanging() => (Exception) ExceptionBuilder._InRowChangingEvent(Res.GetString("DataRow_EditInRowChanging"));

    public static Exception EndEditInRowChanging() => (Exception) ExceptionBuilder._InRowChangingEvent(Res.GetString("DataRow_EndEditInRowChanging"));

    public static Exception BeginEditInRowChanging() => (Exception) ExceptionBuilder._InRowChangingEvent(Res.GetString("DataRow_BeginEditInRowChanging"));

    public static Exception CancelEditInRowChanging() => (Exception) ExceptionBuilder._InRowChangingEvent(Res.GetString("DataRow_CancelEditInRowChanging"));

    public static Exception DeleteInRowDeleting() => (Exception) ExceptionBuilder._InRowChangingEvent(Res.GetString("DataRow_DeleteInRowDeleting"));

    public static Exception ValueArrayLength() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRow_ValuesArrayLength"));

    public static Exception NoCurrentData() => (Exception) ExceptionBuilder._VersionNotFound(Res.GetString("DataRow_NoCurrentData"));

    public static Exception NoOriginalData() => (Exception) ExceptionBuilder._VersionNotFound(Res.GetString("DataRow_NoOriginalData"));

    public static Exception NoProposedData() => (Exception) ExceptionBuilder._VersionNotFound(Res.GetString("DataRow_NoProposedData"));

    public static Exception RowRemovedFromTheTable() => (Exception) ExceptionBuilder._RowNotInTable(Res.GetString("DataRow_RemovedFromTheTable"));

    public static Exception DeletedRowInaccessible() => (Exception) ExceptionBuilder._DeletedRowInaccessible(Res.GetString("DataRow_DeletedRowInaccessible"));

    public static Exception RowAlreadyDeleted() => (Exception) ExceptionBuilder._DeletedRowInaccessible(Res.GetString("DataRow_AlreadyDeleted"));

    public static Exception RowEmpty() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRow_Empty"));

    public static Exception InvalidRowVersion() => (Exception) ExceptionBuilder._Data(Res.GetString("DataRow_InvalidVersion"));

    public static Exception RowOutOfRange() => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataRow_RowOutOfRange"));

    public static Exception RowOutOfRange(int index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataRow_OutOfRange", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception RowInsertOutOfRange(int index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataRow_RowInsertOutOfRange", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception RowInsertTwice(int index, string tableName) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataRow_RowInsertTwice", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) tableName));

    public static Exception RowInsertMissing(string tableName) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataRow_RowInsertMissing", (object) tableName));

    public static Exception RowAlreadyRemoved() => (Exception) ExceptionBuilder._Data(Res.GetString("DataRow_AlreadyRemoved"));

    public static Exception MultipleParents() => (Exception) ExceptionBuilder._Data(Res.GetString("DataRow_MultipleParents"));

    public static Exception InvalidRowState(DataRowState state) => (Exception) ExceptionBuilder._InvalidEnumArgumentException<DataRowState>(state);

    internal static Exception SetDataSetNameToEmpty() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataSet_SetNameToEmpty"));

    internal static Exception SetDataSetNameConflicting(string name) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataSet_SetDataSetNameConflicting", (object) name));

    public static Exception DataSetUnsupportedSchema(string ns) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataSet_UnsupportedSchema", (object) ns));

    public static Exception MergeMissingDefinition(string obj) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataMerge_MissingDefinition", (object) obj));

    public static Exception TablesInDifferentSets() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_TablesInDifferentSets"));

    public static Exception RelationAlreadyExists() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_AlreadyExists"));

    public static Exception RowAlreadyInOtherCollection() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRow_AlreadyInOtherCollection"));

    public static Exception RowAlreadyInTheCollection() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRow_AlreadyInTheCollection"));

    public static Exception TableMissingPrimaryKey() => (Exception) ExceptionBuilder._MissingPrimaryKey(Res.GetString("DataTable_MissingPrimaryKey"));

    public static Exception RecordStateRange() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataIndex_RecordStateRange"));

    public static Exception IndexKeyLength(int length, int keyLength) => length == 0 ? (Exception) ExceptionBuilder._Argument(Res.GetString("DataIndex_FindWithoutSortOrder")) : (Exception) ExceptionBuilder._Argument(Res.GetString("DataIndex_KeyLength", (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) keyLength.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception RemovePrimaryKey(DataTable table) => table.TableName.Length == 0 ? (Exception) ExceptionBuilder._Argument(Res.GetString("DataKey_RemovePrimaryKey")) : (Exception) ExceptionBuilder._Argument(Res.GetString("DataKey_RemovePrimaryKey1", (object) table.TableName));

    public static Exception RelationAlreadyInOtherDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_AlreadyInOtherDataSet"));

    public static Exception RelationAlreadyInTheDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_AlreadyInTheDataSet"));

    public static Exception RelationNotInTheDataSet(string relation) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_NotInTheDataSet", (object) relation));

    public static Exception RelationOutOfRange(object index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataRelation_OutOfRange", (object) index.ToString()));

    public static Exception DuplicateRelation(string relation) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataRelation_DuplicateName", (object) relation));

    public static Exception RelationTableNull() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_TableNull"));

    public static Exception RelationDataSetNull() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_TableNull"));

    public static Exception RelationTableWasRemoved() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_TableWasRemoved"));

    public static Exception ParentTableMismatch() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_ParentTableMismatch"));

    public static Exception ChildTableMismatch() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_ChildTableMismatch"));

    public static Exception EnforceConstraint() => (Exception) ExceptionBuilder._Constraint(Res.GetString("Data_EnforceConstraints"));

    public static Exception CaseLocaleMismatch() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataRelation_CaseLocaleMismatch"));

    public static Exception CannotChangeCaseLocale() => ExceptionBuilder.CannotChangeCaseLocale((Exception) null);

    public static Exception CannotChangeCaseLocale(Exception innerException) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataSet_CannotChangeCaseLocale"), innerException);

    public static Exception CannotChangeSchemaSerializationMode() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataSet_CannotChangeSchemaSerializationMode"));

    public static Exception InvalidSchemaSerializationMode(Type enumType, string mode) => (Exception) ExceptionBuilder._InvalidEnumArgumentException(Res.GetString("ADP_InvalidEnumerationValue", (object) enumType.Name, (object) mode));

    public static Exception TableForeignPrimaryKey() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_ForeignPrimaryKey"));

    public static Exception TableCannotAddToSimpleContent() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_CannotAddToSimpleContent"));

    public static Exception NoTableName() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_NoName"));

    public static Exception MultipleTextOnlyColumns() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_MultipleSimpleContentColumns"));

    public static Exception InvalidSortString(string sort) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_InvalidSortString", (object) sort));

    public static Exception DuplicateTableName(string table) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataTable_DuplicateName", (object) table));

    public static Exception DuplicateTableName2(string table, string ns) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataTable_DuplicateName2", (object) table, (object) ns));

    public static Exception SelfnestedDatasetConflictingName(string table) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataTable_SelfnestedDatasetConflictingName", (object) table));

    public static Exception DatasetConflictingName(string table) => (Exception) ExceptionBuilder._DuplicateName(Res.GetString("DataTable_DatasetConflictingName", (object) table));

    public static Exception TableAlreadyInOtherDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_AlreadyInOtherDataSet"));

    public static Exception TableAlreadyInTheDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_AlreadyInTheDataSet"));

    public static Exception TableOutOfRange(int index) => (Exception) ExceptionBuilder._IndexOutOfRange(Res.GetString("DataTable_OutOfRange", (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception TableNotInTheDataSet(string table) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_NotInTheDataSet", (object) table));

    public static Exception TableInRelation() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_InRelation"));

    public static Exception TableInConstraint(DataTable table, Constraint constraint) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_InConstraint", (object) table.TableName, (object) constraint.ConstraintName));

    public static Exception CanNotSerializeDataTableHierarchy() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataTable_CanNotSerializeDataTableHierarchy"));

    public static Exception CanNotSerializeDataTableWithEmptyName() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataTable_CanNotSerializeDataTableWithEmptyName"));

    public static Exception TableNotFound(string tableName) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTable_TableNotFound", (object) tableName));

    public static Exception AggregateException(AggregateType aggregateType, Type type) => (Exception) ExceptionBuilder._Data(Res.GetString("DataStorage_AggregateException", (object) aggregateType.ToString(), (object) type.Name));

    public static Exception InvalidStorageType(TypeCode typecode) => (Exception) ExceptionBuilder._Data(Res.GetString("DataStorage_InvalidStorageType", (object) typecode.ToString()));

    public static Exception RangeArgument(int min, int max) => (Exception) ExceptionBuilder._Argument(Res.GetString("Range_Argument", (object) min.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) max.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception NullRange() => (Exception) ExceptionBuilder._Data(Res.GetString("Range_NullRange"));

    public static Exception NegativeMinimumCapacity() => (Exception) ExceptionBuilder._Argument(Res.GetString("RecordManager_MinimumCapacity"));

    public static Exception ProblematicChars(char charValue) => (Exception) ExceptionBuilder._Argument(Res.GetString("DataStorage_ProblematicChars", (object) ("0x" + ((ushort) charValue).ToString("X", (IFormatProvider) CultureInfo.InvariantCulture))));

    public static Exception StorageSetFailed() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataStorage_SetInvalidDataType"));

    public static Exception SimpleTypeNotSupported() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_SimpleTypeNotSupported"));

    public static Exception MissingAttribute(string attribute) => ExceptionBuilder.MissingAttribute(string.Empty, attribute);

    public static Exception MissingAttribute(string element, string attribute) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MissingAttribute", (object) element, (object) attribute));

    public static Exception InvalidAttributeValue(string name, string value) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_ValueOutOfRange", (object) name, (object) value));

    public static Exception ElementTypeNotFound(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_ElementTypeNotFound", (object) name));

    public static Exception RelationParentNameMissing(string rel) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_RelationParentNameMissing", (object) rel));

    public static Exception RelationChildNameMissing(string rel) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_RelationChildNameMissing", (object) rel));

    public static Exception RelationTableKeyMissing(string rel) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_RelationTableKeyMissing", (object) rel));

    public static Exception RelationChildKeyMissing(string rel) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_RelationChildKeyMissing", (object) rel));

    public static Exception UndefinedDatatype(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_UndefinedDatatype", (object) name));

    public static Exception DatatypeNotDefined() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_DatatypeNotDefined"));

    public static Exception MismatchKeyLength() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MismatchKeyLength"));

    public static Exception InvalidField(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_InvalidField", (object) name));

    public static Exception InvalidSelector(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_InvalidSelector", (object) name));

    public static Exception CircularComplexType(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_CircularComplexType", (object) name));

    public static Exception CannotInstantiateAbstract(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_CannotInstantiateAbstract", (object) name));

    public static Exception InvalidKey(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_InvalidKey", (object) name));

    public static Exception DiffgramMissingTable(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MissingTable", (object) name));

    public static Exception DiffgramMissingSQL() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MissingSQL"));

    public static Exception DuplicateConstraintRead(string str) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_DuplicateConstraint", (object) str));

    public static Exception ColumnTypeConflict(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_ColumnConflict", (object) name));

    public static Exception CannotConvert(string name, string type) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_CannotConvert", (object) name, (object) type));

    public static Exception MissingRefer(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MissingRefer", (object) "refer", (object) "keyref", (object) name));

    public static Exception InvalidPrefix(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_InvalidPrefix", (object) name));

    public static Exception CanNotDeserializeObjectType() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("Xml_CanNotDeserializeObjectType"));

    public static Exception IsDataSetAttributeMissingInSchema() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_IsDataSetAttributeMissingInSchema"));

    public static Exception TooManyIsDataSetAtributeInSchema() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_TooManyIsDataSetAtributeInSchema"));

    public static Exception NestedCircular(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_NestedCircular", (object) name));

    public static Exception MultipleParentRows(string tableQName) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MultipleParentRows", (object) tableQName));

    public static Exception PolymorphismNotSupported(string typeName) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("Xml_PolymorphismNotSupported", (object) typeName));

    public static Exception DataTableInferenceNotSupported() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("Xml_DataTableInferenceNotSupported"));

    public static Exception DuplicateDeclaration(string name) => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_MergeDuplicateDeclaration", (object) name));

    public static Exception FoundEntity() => (Exception) ExceptionBuilder._Data(Res.GetString("Xml_FoundEntity"));

    public static Exception MergeFailed(string name) => (Exception) ExceptionBuilder._Data(name);

    public static DataException ConvertFailed(Type type1, Type type2) => ExceptionBuilder.ConvertFailed(type1, type2, (Exception) null);

    public static DataException ConvertFailed(
      Type type1,
      Type type2,
      Exception innerExeption)
    {
      // ISSUE: reference to a compiler-generated method
      return ExceptionBuilder._Data(Res.GetString("SqlConvert_ConvertFailed", (object) type1.FullName, (object) type2.FullName), innerExeption);
    }

    public static Exception InvalidDataTableReader(string tableName) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataTableReader_InvalidDataTableReader", (object) tableName));

    public static Exception DataTableReaderSchemaIsInvalid(string tableName) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("DataTableReader_SchemaInvalidDataTableReader", (object) tableName));

    public static Exception CannotCreateDataReaderOnEmptyDataSet() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTableReader_CannotCreateDataReaderOnEmptyDataSet"));

    public static Exception DataTableReaderArgumentIsEmpty() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTableReader_DataTableReaderArgumentIsEmpty"));

    public static Exception ArgumentContainsNullValue() => (Exception) ExceptionBuilder._Argument(Res.GetString("DataTableReader_ArgumentContainsNullValue"));

    public static Exception InvalidCurrentRowInDataTableReader() => (Exception) ExceptionBuilder._DeletedRowInaccessible(Res.GetString("DataTableReader_InvalidRowInDataTableReader"));

    public static Exception EmptyDataTableReader(string tableName) => (Exception) ExceptionBuilder._DeletedRowInaccessible(Res.GetString("DataTableReader_DataTableCleared", (object) tableName));

    internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(
      string stName,
      string errorStr)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExceptionBuilder._Argument(Res.GetString("NamedSimpleType_InvalidDuplicateNamedSimpleTypeDelaration", (object) stName, (object) errorStr));
    }

    internal static Exception InternalRBTreeError(RBTreeError internalError) => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("RbTree_InvalidState", (object) (int) internalError));

    public static Exception EnumeratorModified() => (Exception) ExceptionBuilder._InvalidOperation(Res.GetString("RbTree_EnumerationBroken"));

    public static Exception XdrSchemaNotSupported() => (Exception) new NotSupportedException(Res.GetString("DataSet_XdrSchemaNotSupported"));
  }
}
