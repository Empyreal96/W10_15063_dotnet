// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataExpression
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class DataExpression : IFilter
  {
    internal string originalExpression;
    private bool parsed;
    private bool bound;
    private ExpressionNode expr;
    private DataTable table;
    private readonly StorageType _storageType;
    private readonly Type _dataType;
    private DataColumn[] dependency = DataTable.zeroColumns;

    internal DataExpression(DataTable table, string expression)
      : this(table, expression, (Type) null)
    {
    }

    internal DataExpression(DataTable table, string expression, Type type)
    {
      ExpressionParser expressionParser = new ExpressionParser(table);
      expressionParser.LoadExpression(expression);
      this.originalExpression = expression;
      this.expr = (ExpressionNode) null;
      if (expression == null)
        return;
      this._storageType = DataStorage.GetStorageType(type);
      this._dataType = type;
      this.expr = expressionParser.Parse();
      this.parsed = true;
      if (this.expr != null && table != null)
        this.Bind(table);
      else
        this.bound = false;
    }

    internal string Expression => this.originalExpression == null ? "" : this.originalExpression;

    internal ExpressionNode ExpressionNode => this.expr;

    internal bool HasValue => this.expr != null;

    internal void Bind(DataTable table)
    {
      this.table = table;
      if (table == null || this.expr == null)
        return;
      Debug.Assert(this.parsed, "Invalid calling order: Bind() before Parse()");
      List<DataColumn> list = new List<DataColumn>();
      this.expr.Bind(table, list);
      this.expr = this.expr.Optimize();
      this.table = table;
      this.bound = true;
      this.dependency = list.ToArray();
    }

    internal bool DependsOn(DataColumn column) => this.expr != null && this.expr.DependsOn(column);

    internal object Evaluate() => this.Evaluate((DataRow) null, DataRowVersion.Default);

    internal object Evaluate(DataRow row, DataRowVersion version)
    {
      if (!this.bound)
        this.Bind(this.table);
      object obj;
      if (this.expr != null)
      {
        obj = this.expr.Eval(row, version);
        if (obj != DBNull.Value || StorageType.Uri < this._storageType)
        {
          try
          {
            if (StorageType.Object != this._storageType)
              obj = SqlConvert.ChangeType2(obj, this._storageType, this._dataType, this.table.FormatProvider);
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
            {
              throw;
            }
            else
            {
              ExceptionBuilder.TraceExceptionForCapture(ex);
              throw ExprException.DatavalueConvertion(obj, this._dataType, ex);
            }
          }
        }
      }
      else
        obj = (object) null;
      return obj;
    }

    internal object Evaluate(DataRow[] rows) => this.Evaluate(rows, DataRowVersion.Default);

    internal object Evaluate(DataRow[] rows, DataRowVersion version)
    {
      if (!this.bound)
        this.Bind(this.table);
      if (this.expr == null)
        return (object) DBNull.Value;
      List<int> intList = new List<int>();
      foreach (DataRow row in rows)
      {
        if (row.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || row.oldRecord != -1))
          intList.Add(row.GetRecordFromVersion(version));
      }
      return this.expr.Eval(intList.ToArray());
    }

    public bool Invoke(DataRow row, DataRowVersion version)
    {
      if (this.expr == null)
        return true;
      if (row == null)
        throw ExprException.InvokeArgument();
      object obj = this.expr.Eval(row, version);
      try
      {
        return DataExpression.ToBoolean(obj);
      }
      catch (EvaluateException ex)
      {
        throw ExprException.FilterConvertion(this.Expression);
      }
    }

    internal DataColumn[] GetDependency()
    {
      Debug.Assert(this.dependency != null, "GetDependencies: null, we should have created an empty list");
      return this.dependency;
    }

    internal bool IsTableAggregate() => this.expr != null && this.expr.IsTableConstant();

    internal static bool IsUnknown(object value) => DataStorage.IsObjectNull(value);

    internal bool HasLocalAggregate() => this.expr != null && this.expr.HasLocalAggregate();

    internal bool HasRemoteAggregate() => this.expr != null && this.expr.HasRemoteAggregate();

    internal static bool ToBoolean(object value)
    {
      if (DataExpression.IsUnknown(value))
        return false;
      switch (value)
      {
        case bool flag:
          return flag;
        case string _:
          try
          {
            return bool.Parse((string) value);
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
            {
              throw;
            }
            else
            {
              ExceptionBuilder.TraceExceptionForCapture(ex);
              throw ExprException.DatavalueConvertion(value, typeof (bool), ex);
            }
          }
        default:
          throw ExprException.DatavalueConvertion(value, typeof (bool), (Exception) null);
      }
    }
  }
}
