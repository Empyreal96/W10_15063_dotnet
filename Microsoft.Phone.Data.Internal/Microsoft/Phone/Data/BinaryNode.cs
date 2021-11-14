// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.BinaryNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal class BinaryNode : ExpressionNode
  {
    internal int op;
    internal ExpressionNode left;
    internal ExpressionNode right;

    internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
      : base(table)
    {
      this.op = op;
      this.left = left;
      this.right = right;
    }

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
      this.BindTable(table);
      this.left.Bind(table, list);
      this.right.Bind(table, list);
    }

    internal override object Eval() => this.Eval((DataRow) null, DataRowVersion.Default);

    internal override object Eval(DataRow row, DataRowVersion version) => this.EvalBinaryOp(this.op, this.left, this.right, row, version, (int[]) null);

    internal override object Eval(int[] recordNos) => this.EvalBinaryOp(this.op, this.left, this.right, (DataRow) null, DataRowVersion.Default, recordNos);

    internal override bool IsConstant() => this.left.IsConstant() && this.right.IsConstant();

    internal override bool IsTableConstant() => this.left.IsTableConstant() && this.right.IsTableConstant();

    internal override bool HasLocalAggregate() => this.left.HasLocalAggregate() || this.right.HasLocalAggregate();

    internal override bool HasRemoteAggregate() => this.left.HasRemoteAggregate() || this.right.HasRemoteAggregate();

    internal override bool DependsOn(DataColumn column) => this.left.DependsOn(column) || this.right.DependsOn(column);

    internal override ExpressionNode Optimize()
    {
      this.left = this.left.Optimize();
      if (this.op == 13)
      {
        if (this.right is UnaryNode)
        {
          UnaryNode right = (UnaryNode) this.right;
          if (right.op != 3)
            throw ExprException.InvalidIsSyntax();
          this.op = 39;
          this.right = right.right;
        }
        if (!(this.right is ZeroOpNode))
          throw ExprException.InvalidIsSyntax();
        if (((ZeroOpNode) this.right).op != 32)
          throw ExprException.InvalidIsSyntax();
      }
      else
        this.right = this.right.Optimize();
      if (!this.IsConstant())
        return (ExpressionNode) this;
      object constant = this.Eval();
      if (constant == DBNull.Value)
        return (ExpressionNode) new ZeroOpNode(32);
      if (!(constant is bool flag))
        return (ExpressionNode) new ConstNode(this.table, ValueType.Object, constant, false);
      return flag ? (ExpressionNode) new ZeroOpNode(33) : (ExpressionNode) new ZeroOpNode(34);
    }

    internal void SetTypeMismatchError(int op, Type left, Type right) => throw ExprException.TypeMismatchInBinop(op, left, right);

    private static object Eval(
      ExpressionNode expr,
      DataRow row,
      DataRowVersion version,
      int[] recordNos)
    {
      return recordNos == null ? expr.Eval(row, version) : expr.Eval(recordNos);
    }

    internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op)
    {
      int num = 0;
      try
      {
        switch (resultType)
        {
          case StorageType.Boolean:
            if (op != 7)
            {
              if (op != 12)
                break;
            }
            return Convert.ToInt32((object) DataExpression.ToBoolean(vLeft), this.FormatProvider) - Convert.ToInt32((object) DataExpression.ToBoolean(vRight), this.FormatProvider);
          case StorageType.Char:
            return Convert.ToInt32(vLeft, this.FormatProvider).CompareTo(Convert.ToInt32(vRight, this.FormatProvider));
          case StorageType.SByte:
          case StorageType.Byte:
          case StorageType.Int16:
          case StorageType.UInt16:
          case StorageType.Int32:
            int int32 = Convert.ToInt32(vLeft, this.FormatProvider);
            int32 = int32.CompareTo(Convert.ToInt32(vRight, this.FormatProvider));
            return int32;
          case StorageType.UInt32:
          case StorageType.Int64:
          case StorageType.UInt64:
          case StorageType.Decimal:
            return Decimal.Compare(Convert.ToDecimal(vLeft, this.FormatProvider), Convert.ToDecimal(vRight, this.FormatProvider));
          case StorageType.Single:
            return Convert.ToSingle(vLeft, this.FormatProvider).CompareTo(Convert.ToSingle(vRight, this.FormatProvider));
          case StorageType.Double:
            return Convert.ToDouble(vLeft, this.FormatProvider).CompareTo(Convert.ToDouble(vRight, this.FormatProvider));
          case StorageType.DateTime:
            return DateTime.Compare(Convert.ToDateTime(vLeft, this.FormatProvider), Convert.ToDateTime(vRight, this.FormatProvider));
          case StorageType.String:
            return this.table.Compare(Convert.ToString(vLeft, this.FormatProvider), Convert.ToString(vRight, this.FormatProvider));
          case StorageType.Guid:
            return ((Guid) vLeft).CompareTo((Guid) vRight);
        }
      }
      catch (ArgumentException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
      }
      catch (FormatException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
      }
      catch (InvalidCastException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
      }
      catch (OverflowException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
      }
      catch (EvaluateException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
      }
      this.SetTypeMismatchError(op, vLeft.GetType(), vRight.GetType());
      return num;
    }

    private object EvalBinaryOp(
      int op,
      ExpressionNode left,
      ExpressionNode right,
      DataRow row,
      DataRowVersion version,
      int[] recordNos)
    {
      object vLeft;
      object vRight;
      StorageType storageType1;
      if (op != 27 && op != 26 && (op != 5 && op != 13) && op != 39)
      {
        vLeft = BinaryNode.Eval(left, row, version, recordNos);
        vRight = BinaryNode.Eval(right, row, version, recordNos);
        Type type1 = vLeft.GetType();
        Type type2 = vRight.GetType();
        StorageType storageType2 = DataStorage.GetStorageType(type1);
        StorageType storageType3 = DataStorage.GetStorageType(type2);
        if (vLeft == DBNull.Value || vRight == DBNull.Value)
          return (object) DBNull.Value;
        storageType1 = this.ResultType(storageType2, storageType3, left is ConstNode, right is ConstNode, op);
        if (storageType1 == StorageType.Empty)
          this.SetTypeMismatchError(op, type1, type2);
      }
      else
      {
        vLeft = (object) (DBNull) (vRight = (object) DBNull.Value);
        storageType1 = StorageType.Empty;
      }
      object obj1 = (object) DBNull.Value;
      bool flag1 = false;
      try
      {
        switch (op)
        {
          case 5:
            if (!(right is FunctionNode))
              throw ExprException.InWithoutParentheses();
            vLeft = BinaryNode.Eval(left, row, version, recordNos);
            if (vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft))
              return (object) DBNull.Value;
            obj1 = (object) false;
            FunctionNode functionNode = (FunctionNode) right;
            for (int index = 0; index < functionNode.argumentCount; ++index)
            {
              vRight = functionNode.arguments[index].Eval();
              if (vRight != DBNull.Value && (!right.IsSqlColumn || !DataStorage.IsObjectSqlNull(vRight)))
              {
                Debug.Assert(!DataStorage.IsObjectNull(vLeft) && !DataStorage.IsObjectNull(vRight), "Imposible..");
                storageType1 = DataStorage.GetStorageType(vLeft.GetType());
                if (this.BinaryCompare(vLeft, vRight, storageType1, 7) == 0)
                {
                  obj1 = (object) true;
                  break;
                }
              }
            }
            break;
          case 7:
            return vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft) || (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight)) ? (object) DBNull.Value : (object) (this.BinaryCompare(vLeft, vRight, storageType1, 7) == 0);
          case 8:
            return vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft) || (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight)) ? (object) DBNull.Value : (object) (0 < this.BinaryCompare(vLeft, vRight, storageType1, op));
          case 9:
            return vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft) || (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight)) ? (object) DBNull.Value : (object) (0 > this.BinaryCompare(vLeft, vRight, storageType1, op));
          case 10:
            return vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft) || (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight)) ? (object) DBNull.Value : (object) (0 <= this.BinaryCompare(vLeft, vRight, storageType1, op));
          case 11:
            return vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft) || (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight)) ? (object) DBNull.Value : (object) (0 >= this.BinaryCompare(vLeft, vRight, storageType1, op));
          case 12:
            return vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft) || (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight)) ? (object) DBNull.Value : (object) ((uint) this.BinaryCompare(vLeft, vRight, storageType1, op) > 0U);
          case 13:
            object obj2 = BinaryNode.Eval(left, row, version, recordNos);
            return obj2 == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj2) ? (object) true : (object) false;
          case 15:
            switch (storageType1)
            {
              case StorageType.Char:
              case StorageType.String:
                obj1 = (object) (Convert.ToString(vLeft, this.FormatProvider) + Convert.ToString(vRight, this.FormatProvider));
                break;
              case StorageType.SByte:
                obj1 = (object) Convert.ToSByte((object) ((int) Convert.ToSByte(vLeft, this.FormatProvider) + (int) Convert.ToSByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Byte:
                obj1 = (object) Convert.ToByte((object) ((int) Convert.ToByte(vLeft, this.FormatProvider) + (int) Convert.ToByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int16:
                obj1 = (object) Convert.ToInt16((object) ((int) Convert.ToInt16(vLeft, this.FormatProvider) + (int) Convert.ToInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.UInt16:
                obj1 = (object) Convert.ToUInt16((object) ((int) Convert.ToUInt16(vLeft, this.FormatProvider) + (int) Convert.ToUInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int32:
                obj1 = (object) checked (Convert.ToInt32(vLeft, this.FormatProvider) + Convert.ToInt32(vRight, this.FormatProvider));
                break;
              case StorageType.UInt32:
                obj1 = (object) checked (Convert.ToUInt32(vLeft, this.FormatProvider) + Convert.ToUInt32(vRight, this.FormatProvider));
                break;
              case StorageType.Int64:
                obj1 = (object) checked (Convert.ToInt64(vLeft, this.FormatProvider) + Convert.ToInt64(vRight, this.FormatProvider));
                break;
              case StorageType.UInt64:
                obj1 = (object) checked (Convert.ToUInt64(vLeft, this.FormatProvider) + Convert.ToUInt64(vRight, this.FormatProvider));
                break;
              case StorageType.Single:
                obj1 = (object) (float) ((double) Convert.ToSingle(vLeft, this.FormatProvider) + (double) Convert.ToSingle(vRight, this.FormatProvider));
                break;
              case StorageType.Double:
                obj1 = (object) (Convert.ToDouble(vLeft, this.FormatProvider) + Convert.ToDouble(vRight, this.FormatProvider));
                break;
              case StorageType.Decimal:
                obj1 = (object) (Convert.ToDecimal(vLeft, this.FormatProvider) + Convert.ToDecimal(vRight, this.FormatProvider));
                break;
              case StorageType.DateTime:
                switch (vLeft)
                {
                  case TimeSpan _ when vRight is DateTime dateTime9:
                    obj1 = (object) (dateTime9 + (TimeSpan) vLeft);
                    break;
                  case DateTime _ when vRight is TimeSpan timeSpan5:
                    obj1 = (object) ((DateTime) vLeft + timeSpan5);
                    break;
                  default:
                    flag1 = true;
                    break;
                }
                break;
              case StorageType.TimeSpan:
                obj1 = (object) ((TimeSpan) vLeft + (TimeSpan) vRight);
                break;
              default:
                flag1 = true;
                break;
            }
            break;
          case 16:
            switch (storageType1)
            {
              case StorageType.SByte:
                obj1 = (object) Convert.ToSByte((object) ((int) Convert.ToSByte(vLeft, this.FormatProvider) - (int) Convert.ToSByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Byte:
                obj1 = (object) Convert.ToByte((object) ((int) Convert.ToByte(vLeft, this.FormatProvider) - (int) Convert.ToByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int16:
                obj1 = (object) Convert.ToInt16((object) ((int) Convert.ToInt16(vLeft, this.FormatProvider) - (int) Convert.ToInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.UInt16:
                obj1 = (object) Convert.ToUInt16((object) ((int) Convert.ToUInt16(vLeft, this.FormatProvider) - (int) Convert.ToUInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int32:
                obj1 = (object) checked (Convert.ToInt32(vLeft, this.FormatProvider) - Convert.ToInt32(vRight, this.FormatProvider));
                break;
              case StorageType.UInt32:
                obj1 = (object) checked (Convert.ToUInt32(vLeft, this.FormatProvider) - Convert.ToUInt32(vRight, this.FormatProvider));
                break;
              case StorageType.Int64:
                obj1 = (object) checked (Convert.ToInt64(vLeft, this.FormatProvider) - Convert.ToInt64(vRight, this.FormatProvider));
                break;
              case StorageType.UInt64:
                obj1 = (object) checked (Convert.ToUInt64(vLeft, this.FormatProvider) - Convert.ToUInt64(vRight, this.FormatProvider));
                break;
              case StorageType.Single:
                obj1 = (object) (float) ((double) Convert.ToSingle(vLeft, this.FormatProvider) - (double) Convert.ToSingle(vRight, this.FormatProvider));
                break;
              case StorageType.Double:
                obj1 = (object) (Convert.ToDouble(vLeft, this.FormatProvider) - Convert.ToDouble(vRight, this.FormatProvider));
                break;
              case StorageType.Decimal:
                obj1 = (object) (Convert.ToDecimal(vLeft, this.FormatProvider) - Convert.ToDecimal(vRight, this.FormatProvider));
                break;
              case StorageType.DateTime:
                obj1 = (object) ((DateTime) vLeft - (TimeSpan) vRight);
                break;
              case StorageType.TimeSpan:
                obj1 = !(vLeft is DateTime dateTime10) ? (object) ((TimeSpan) vLeft - (TimeSpan) vRight) : (object) (dateTime10 - (DateTime) vRight);
                break;
              default:
                flag1 = true;
                break;
            }
            break;
          case 17:
            switch (storageType1)
            {
              case StorageType.SByte:
                obj1 = (object) Convert.ToSByte((object) ((int) Convert.ToSByte(vLeft, this.FormatProvider) * (int) Convert.ToSByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Byte:
                obj1 = (object) Convert.ToByte((object) ((int) Convert.ToByte(vLeft, this.FormatProvider) * (int) Convert.ToByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int16:
                obj1 = (object) Convert.ToInt16((object) ((int) Convert.ToInt16(vLeft, this.FormatProvider) * (int) Convert.ToInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.UInt16:
                obj1 = (object) Convert.ToUInt16((object) ((int) Convert.ToUInt16(vLeft, this.FormatProvider) * (int) Convert.ToUInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int32:
                obj1 = (object) checked (Convert.ToInt32(vLeft, this.FormatProvider) * Convert.ToInt32(vRight, this.FormatProvider));
                break;
              case StorageType.UInt32:
                obj1 = (object) checked (Convert.ToUInt32(vLeft, this.FormatProvider) * Convert.ToUInt32(vRight, this.FormatProvider));
                break;
              case StorageType.Int64:
                obj1 = (object) checked (Convert.ToInt64(vLeft, this.FormatProvider) * Convert.ToInt64(vRight, this.FormatProvider));
                break;
              case StorageType.UInt64:
                obj1 = (object) checked (Convert.ToUInt64(vLeft, this.FormatProvider) * Convert.ToUInt64(vRight, this.FormatProvider));
                break;
              case StorageType.Single:
                obj1 = (object) (float) ((double) Convert.ToSingle(vLeft, this.FormatProvider) * (double) Convert.ToSingle(vRight, this.FormatProvider));
                break;
              case StorageType.Double:
                obj1 = (object) (Convert.ToDouble(vLeft, this.FormatProvider) * Convert.ToDouble(vRight, this.FormatProvider));
                break;
              case StorageType.Decimal:
                obj1 = (object) (Convert.ToDecimal(vLeft, this.FormatProvider) * Convert.ToDecimal(vRight, this.FormatProvider));
                break;
              default:
                flag1 = true;
                break;
            }
            break;
          case 18:
            switch (storageType1)
            {
              case StorageType.SByte:
                obj1 = (object) Convert.ToSByte((object) ((int) Convert.ToSByte(vLeft, this.FormatProvider) / (int) Convert.ToSByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Byte:
                obj1 = (object) Convert.ToByte((object) ((int) Convert.ToByte(vLeft, this.FormatProvider) / (int) Convert.ToByte(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int16:
                obj1 = (object) Convert.ToInt16((object) ((int) Convert.ToInt16(vLeft, this.FormatProvider) / (int) Convert.ToInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.UInt16:
                obj1 = (object) Convert.ToUInt16((object) ((int) Convert.ToUInt16(vLeft, this.FormatProvider) / (int) Convert.ToUInt16(vRight, this.FormatProvider)), this.FormatProvider);
                break;
              case StorageType.Int32:
                obj1 = (object) (Convert.ToInt32(vLeft, this.FormatProvider) / Convert.ToInt32(vRight, this.FormatProvider));
                break;
              case StorageType.UInt32:
                obj1 = (object) (Convert.ToUInt32(vLeft, this.FormatProvider) / Convert.ToUInt32(vRight, this.FormatProvider));
                break;
              case StorageType.Int64:
                obj1 = (object) (Convert.ToInt64(vLeft, this.FormatProvider) / Convert.ToInt64(vRight, this.FormatProvider));
                break;
              case StorageType.UInt64:
                obj1 = (object) (Convert.ToUInt64(vLeft, this.FormatProvider) / Convert.ToUInt64(vRight, this.FormatProvider));
                break;
              case StorageType.Single:
                obj1 = (object) (float) ((double) Convert.ToSingle(vLeft, this.FormatProvider) / (double) Convert.ToSingle(vRight, this.FormatProvider));
                break;
              case StorageType.Double:
                double num = Convert.ToDouble(vRight, this.FormatProvider);
                obj1 = (object) (Convert.ToDouble(vLeft, this.FormatProvider) / num);
                break;
              case StorageType.Decimal:
                obj1 = (object) (Convert.ToDecimal(vLeft, this.FormatProvider) / Convert.ToDecimal(vRight, this.FormatProvider));
                break;
              default:
                flag1 = true;
                break;
            }
            break;
          case 20:
            if (ExpressionNode.IsIntegerSql(storageType1))
            {
              obj1 = storageType1 != StorageType.UInt64 ? Convert.ChangeType((object) (Convert.ToInt64(vLeft, this.FormatProvider) % Convert.ToInt64(vRight, this.FormatProvider)), DataStorage.GetTypeStorage(storageType1), this.FormatProvider) : (object) (Convert.ToUInt64(vLeft, this.FormatProvider) % Convert.ToUInt64(vRight, this.FormatProvider));
              break;
            }
            flag1 = true;
            break;
          case 26:
            vLeft = BinaryNode.Eval(left, row, version, recordNos);
            if (vLeft == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(vLeft))
              return (object) DBNull.Value;
            if (!(vLeft is bool))
            {
              vRight = BinaryNode.Eval(right, row, version, recordNos);
              flag1 = true;
              break;
            }
            if (vLeft is bool flag16 && !flag16)
            {
              obj1 = (object) false;
              break;
            }
            vRight = BinaryNode.Eval(right, row, version, recordNos);
            if (vRight == DBNull.Value || right.IsSqlColumn && DataStorage.IsObjectSqlNull(vRight))
              return (object) DBNull.Value;
            if (!(vRight is bool))
            {
              flag1 = true;
              break;
            }
            if (vRight is bool flag17)
            {
              obj1 = (object) flag17;
              break;
            }
            break;
          case 27:
            vLeft = BinaryNode.Eval(left, row, version, recordNos);
            if (vLeft != DBNull.Value && !DataStorage.IsObjectSqlNull(vLeft))
            {
              if (!(vLeft is bool flag18))
              {
                vRight = BinaryNode.Eval(right, row, version, recordNos);
                flag1 = true;
                break;
              }
              if (flag18)
              {
                obj1 = (object) true;
                break;
              }
            }
            vRight = BinaryNode.Eval(right, row, version, recordNos);
            if (vRight == DBNull.Value || DataStorage.IsObjectSqlNull(vRight))
              return vLeft;
            if (vLeft == DBNull.Value || DataStorage.IsObjectSqlNull(vLeft))
              return vRight;
            if (!(vRight is bool flag19))
            {
              flag1 = true;
              break;
            }
            obj1 = (object) flag19;
            break;
          case 39:
            object obj3 = BinaryNode.Eval(left, row, version, recordNos);
            return obj3 == DBNull.Value || left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj3) ? (object) false : (object) true;
          default:
            throw ExprException.UnsupportedOperator(op);
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(DataStorage.GetTypeStorage(storageType1));
      }
      if (flag1)
        this.SetTypeMismatchError(op, vLeft.GetType(), vRight.GetType());
      return obj1;
    }

    private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType)
    {
      switch (storageType)
      {
        case StorageType.Boolean:
          return BinaryNode.DataTypePrecedence.Boolean;
        case StorageType.Char:
          return BinaryNode.DataTypePrecedence.Char;
        case StorageType.SByte:
          return BinaryNode.DataTypePrecedence.SByte;
        case StorageType.Byte:
          return BinaryNode.DataTypePrecedence.Byte;
        case StorageType.Int16:
          return BinaryNode.DataTypePrecedence.Int16;
        case StorageType.UInt16:
          return BinaryNode.DataTypePrecedence.UInt16;
        case StorageType.Int32:
          return BinaryNode.DataTypePrecedence.Int32;
        case StorageType.UInt32:
          return BinaryNode.DataTypePrecedence.UInt32;
        case StorageType.Int64:
          return BinaryNode.DataTypePrecedence.Int64;
        case StorageType.UInt64:
          return BinaryNode.DataTypePrecedence.UInt64;
        case StorageType.Single:
          return BinaryNode.DataTypePrecedence.Single;
        case StorageType.Double:
          return BinaryNode.DataTypePrecedence.Double;
        case StorageType.Decimal:
          return BinaryNode.DataTypePrecedence.Decimal;
        case StorageType.DateTime:
          return BinaryNode.DataTypePrecedence.DateTime;
        case StorageType.TimeSpan:
          return BinaryNode.DataTypePrecedence.TimeSpan;
        case StorageType.String:
          return BinaryNode.DataTypePrecedence.String;
        default:
          return BinaryNode.DataTypePrecedence.Error;
      }
    }

    private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code)
    {
      switch (code)
      {
        case BinaryNode.DataTypePrecedence.Char:
          return StorageType.Char;
        case BinaryNode.DataTypePrecedence.String:
          return StorageType.String;
        case BinaryNode.DataTypePrecedence.Boolean:
          return StorageType.Boolean;
        case BinaryNode.DataTypePrecedence.Error:
          return StorageType.Empty;
        case BinaryNode.DataTypePrecedence.SByte:
          return StorageType.SByte;
        case BinaryNode.DataTypePrecedence.Byte:
          return StorageType.Byte;
        case BinaryNode.DataTypePrecedence.Int16:
          return StorageType.Int16;
        case BinaryNode.DataTypePrecedence.UInt16:
          return StorageType.UInt16;
        case BinaryNode.DataTypePrecedence.Int32:
          return StorageType.Int32;
        case BinaryNode.DataTypePrecedence.UInt32:
          return StorageType.UInt32;
        case BinaryNode.DataTypePrecedence.Int64:
          return StorageType.Int64;
        case BinaryNode.DataTypePrecedence.UInt64:
          return StorageType.UInt64;
        case BinaryNode.DataTypePrecedence.Decimal:
          return StorageType.Decimal;
        case BinaryNode.DataTypePrecedence.Single:
          return StorageType.Single;
        case BinaryNode.DataTypePrecedence.Double:
          return StorageType.Double;
        case BinaryNode.DataTypePrecedence.TimeSpan:
          return StorageType.TimeSpan;
        case BinaryNode.DataTypePrecedence.DateTime:
          return StorageType.DateTime;
        default:
          Debug.Assert(false, "Invalid (unmapped) precedence " + code.ToString());
          goto case BinaryNode.DataTypePrecedence.Error;
      }
    }

    private bool IsMixed(StorageType left, StorageType right)
    {
      if (ExpressionNode.IsSigned(left) && ExpressionNode.IsUnsigned(right))
        return true;
      return ExpressionNode.IsUnsigned(left) && ExpressionNode.IsSigned(right);
    }

    private bool IsMixedSql(StorageType left, StorageType right)
    {
      if (ExpressionNode.IsSignedSql(left) && ExpressionNode.IsUnsignedSql(right))
        return true;
      return ExpressionNode.IsUnsignedSql(left) && ExpressionNode.IsSignedSql(right);
    }

    internal StorageType ResultType(
      StorageType left,
      StorageType right,
      bool lc,
      bool rc,
      int op)
    {
      if (left == StorageType.Guid && right == StorageType.Guid && Operators.IsRelational(op) || left == StorageType.String && right == StorageType.Guid && Operators.IsRelational(op))
        return left;
      if (left == StorageType.Guid && right == StorageType.String && Operators.IsRelational(op))
        return right;
      int precedence1 = (int) this.GetPrecedence(left);
      if (precedence1 == 0)
        return StorageType.Empty;
      int precedence2 = (int) this.GetPrecedence(right);
      if (precedence2 == 0)
        return StorageType.Empty;
      if (Operators.IsLogical(op))
        return left == StorageType.Boolean && right == StorageType.Boolean ? StorageType.Boolean : StorageType.Empty;
      if (op == 15 && (left == StorageType.String || right == StorageType.String))
        return StorageType.String;
      BinaryNode.DataTypePrecedence code = (BinaryNode.DataTypePrecedence) Math.Max(precedence1, precedence2);
      StorageType type = BinaryNode.GetPrecedenceType(code);
      if (Operators.IsArithmetical(op) && type != StorageType.String && type != StorageType.Char && (!ExpressionNode.IsNumeric(left) || !ExpressionNode.IsNumeric(right)))
        return StorageType.Empty;
      if (op == 18 && ExpressionNode.IsInteger(type))
        return StorageType.Double;
      if (this.IsMixed(left, right))
      {
        if (lc && !rc)
          return right;
        if (!lc & rc)
          return left;
        if (ExpressionNode.IsUnsigned(type))
          type = code < BinaryNode.DataTypePrecedence.UInt64 ? BinaryNode.GetPrecedenceType(code + 1) : throw ExprException.AmbiguousBinop(op, DataStorage.GetTypeStorage(left), DataStorage.GetTypeStorage(right));
      }
      return type;
    }

    internal StorageType ResultSqlType(
      StorageType left,
      StorageType right,
      bool lc,
      bool rc,
      int op)
    {
      int precedence1 = (int) this.GetPrecedence(left);
      if (precedence1 == 0)
        return StorageType.Empty;
      int precedence2 = (int) this.GetPrecedence(right);
      if (precedence2 == 0)
        return StorageType.Empty;
      if (Operators.IsLogical(op))
        return left != StorageType.Boolean || right != StorageType.Boolean ? StorageType.Empty : StorageType.Boolean;
      if (op == 15 && (left == StorageType.String || right == StorageType.String))
        return StorageType.String;
      if (precedence1 > 19 && precedence2 < 20 || precedence1 < 20 && precedence2 > 19)
        return StorageType.Empty;
      if (precedence1 > 19)
      {
        if (op == 15 || op == 16)
        {
          if (left == StorageType.TimeSpan)
            return right;
          return right == StorageType.TimeSpan ? left : StorageType.Empty;
        }
        return !Operators.IsRelational(op) ? StorageType.Empty : left;
      }
      BinaryNode.DataTypePrecedence code = (BinaryNode.DataTypePrecedence) Math.Max(precedence1, precedence2);
      BinaryNode.GetPrecedenceType(code);
      StorageType type = BinaryNode.GetPrecedenceType((BinaryNode.DataTypePrecedence) this.SqlResultType((int) code));
      if (Operators.IsArithmetical(op) && type != StorageType.String && type != StorageType.Char && (!ExpressionNode.IsNumericSql(left) || !ExpressionNode.IsNumericSql(right)))
        return StorageType.Empty;
      if (op == 18 && ExpressionNode.IsIntegerSql(type))
        return StorageType.Double;
      if (this.IsMixedSql(left, right) && ExpressionNode.IsUnsignedSql(type))
        type = code < BinaryNode.DataTypePrecedence.UInt64 ? BinaryNode.GetPrecedenceType(code + 1) : throw ExprException.AmbiguousBinop(op, DataStorage.GetTypeStorage(left), DataStorage.GetTypeStorage(right));
      return type;
    }

    private int SqlResultType(int typeCode)
    {
      switch (typeCode)
      {
        case -8:
          return -7;
        case -5:
          return -4;
        case -2:
          return -1;
        case 1:
          return 2;
        case 3:
        case 4:
          return 5;
        case 6:
        case 7:
          return 8;
        case 9:
        case 10:
          return 11;
        case 12:
          return 13;
        case 14:
          return 15;
        case 16:
          return 17;
        case 18:
          return 19;
        case 20:
          return 21;
        case 23:
          return 24;
        default:
          return typeCode;
      }
    }

    private enum DataTypePrecedence
    {
      SqlBinary = -10, // 0xFFFFFFF6
      SqlBytes = -9, // 0xFFFFFFF7
      Char = -8, // 0xFFFFFFF8
      SqlChars = -7, // 0xFFFFFFF9
      SqlXml = -6, // 0xFFFFFFFA
      String = -5, // 0xFFFFFFFB
      SqlString = -4, // 0xFFFFFFFC
      SqlGuid = -3, // 0xFFFFFFFD
      Boolean = -2, // 0xFFFFFFFE
      SqlBoolean = -1, // 0xFFFFFFFF
      Error = 0,
      SByte = 1,
      SqlByte = 2,
      Byte = 3,
      Int16 = 4,
      SqlInt16 = 5,
      UInt16 = 6,
      Int32 = 7,
      SqlInt32 = 8,
      UInt32 = 9,
      Int64 = 10, // 0x0000000A
      SqlInt64 = 11, // 0x0000000B
      UInt64 = 12, // 0x0000000C
      SqlMoney = 13, // 0x0000000D
      Decimal = 14, // 0x0000000E
      SqlDecimal = 15, // 0x0000000F
      Single = 16, // 0x00000010
      SqlSingle = 17, // 0x00000011
      Double = 18, // 0x00000012
      SqlDouble = 19, // 0x00000013
      TimeSpan = 20, // 0x00000014
      DateTime = 23, // 0x00000017
      SqlDateTime = 24, // 0x00000018
    }
  }
}
