// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ExpressionNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal abstract class ExpressionNode
  {
    private DataTable _table;

    protected ExpressionNode(DataTable table) => this._table = table;

    internal IFormatProvider FormatProvider => this._table == null ? (IFormatProvider) CultureInfo.CurrentCulture : this._table.FormatProvider;

    internal virtual bool IsSqlColumn => false;

    protected DataTable table => this._table;

    protected void BindTable(DataTable table) => this._table = table;

    internal abstract void Bind(DataTable table, List<DataColumn> list);

    internal abstract object Eval();

    internal abstract object Eval(DataRow row, DataRowVersion version);

    internal abstract object Eval(int[] recordNos);

    internal abstract bool IsConstant();

    internal abstract bool IsTableConstant();

    internal abstract bool HasLocalAggregate();

    internal abstract bool HasRemoteAggregate();

    internal abstract ExpressionNode Optimize();

    internal virtual bool DependsOn(DataColumn column) => false;

    internal static bool IsInteger(StorageType type) => type == StorageType.Int16 || type == StorageType.Int32 || (type == StorageType.Int64 || type == StorageType.UInt16) || (type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.SByte) || type == StorageType.Byte;

    internal static bool IsIntegerSql(StorageType type) => type == StorageType.Int16 || type == StorageType.Int32 || (type == StorageType.Int64 || type == StorageType.UInt16) || (type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.SByte) || type == StorageType.Byte;

    internal static bool IsSigned(StorageType type) => type == StorageType.Int16 || type == StorageType.Int32 || (type == StorageType.Int64 || type == StorageType.SByte) || ExpressionNode.IsFloat(type);

    internal static bool IsSignedSql(StorageType type) => type == StorageType.Int16 || type == StorageType.Int32 || (type == StorageType.Int64 || type == StorageType.SByte) || ExpressionNode.IsFloatSql(type);

    internal static bool IsUnsigned(StorageType type) => type == StorageType.UInt16 || type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.Byte;

    internal static bool IsUnsignedSql(StorageType type) => type == StorageType.UInt16 || type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.Byte;

    internal static bool IsNumeric(StorageType type) => ExpressionNode.IsFloat(type) || ExpressionNode.IsInteger(type);

    internal static bool IsNumericSql(StorageType type) => ExpressionNode.IsFloatSql(type) || ExpressionNode.IsIntegerSql(type);

    internal static bool IsFloat(StorageType type) => type == StorageType.Single || type == StorageType.Double || type == StorageType.Decimal;

    internal static bool IsFloatSql(StorageType type) => type == StorageType.Single || type == StorageType.Double || type == StorageType.Decimal;
  }
}
