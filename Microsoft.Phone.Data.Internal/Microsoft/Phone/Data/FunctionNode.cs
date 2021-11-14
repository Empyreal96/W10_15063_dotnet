// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.FunctionNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class FunctionNode : ExpressionNode
  {
    internal readonly string name;
    internal readonly int info = -1;
    internal int argumentCount;
    internal const int initialCapacity = 1;
    internal ExpressionNode[] arguments;
    private static readonly Function[] funcs = new Function[15]
    {
      new Function("Abs", FunctionId.Abs, typeof (object), true, false, 1, typeof (object), (Type) null, (Type) null),
      new Function("IIf", FunctionId.Iif, typeof (object), false, false, 3, typeof (object), typeof (object), typeof (object)),
      new Function("In", FunctionId.In, typeof (bool), false, true, 1, (Type) null, (Type) null, (Type) null),
      new Function("IsNull", FunctionId.IsNull, typeof (object), false, false, 2, typeof (object), typeof (object), (Type) null),
      new Function("Len", FunctionId.Len, typeof (int), true, false, 1, typeof (string), (Type) null, (Type) null),
      new Function("Substring", FunctionId.Substring, typeof (string), true, false, 3, typeof (string), typeof (int), typeof (int)),
      new Function("Trim", FunctionId.Trim, typeof (string), true, false, 1, typeof (string), (Type) null, (Type) null),
      new Function("Convert", FunctionId.Convert, typeof (object), false, true, 1, typeof (object), (Type) null, (Type) null),
      new Function("Max", FunctionId.Max, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null),
      new Function("Min", FunctionId.Min, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null),
      new Function("Sum", FunctionId.Sum, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null),
      new Function("Count", FunctionId.Count, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null),
      new Function("Var", FunctionId.Var, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null),
      new Function("StDev", FunctionId.StDev, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null),
      new Function("Avg", FunctionId.Avg, typeof (object), false, false, 1, (Type) null, (Type) null, (Type) null)
    };

    internal FunctionNode(DataTable table, string name)
      : base(table)
    {
      this.name = name;
      for (int index = 0; index < FunctionNode.funcs.Length; ++index)
      {
        if (string.Compare(FunctionNode.funcs[index].name, name, StringComparison.OrdinalIgnoreCase) == 0)
        {
          this.info = index;
          break;
        }
      }
      if (this.info < 0)
        throw ExprException.UndefinedFunction(this.name);
    }

    internal void AddArgument(ExpressionNode argument)
    {
      if (!FunctionNode.funcs[this.info].IsVariantArgumentList && this.argumentCount >= FunctionNode.funcs[this.info].argumentCount)
        throw ExprException.FunctionArgumentCount(this.name);
      if (this.arguments == null)
        this.arguments = new ExpressionNode[1];
      else if (this.argumentCount == this.arguments.Length)
      {
        ExpressionNode[] expressionNodeArray = new ExpressionNode[this.argumentCount * 2];
        Array.Copy((Array) this.arguments, 0, (Array) expressionNodeArray, 0, this.argumentCount);
        this.arguments = expressionNodeArray;
      }
      this.arguments[this.argumentCount++] = argument;
    }

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
      this.BindTable(table);
      this.Check();
      if (FunctionNode.funcs[this.info].id == FunctionId.Convert)
      {
        if (this.argumentCount != 2)
          throw ExprException.FunctionArgumentCount(this.name);
        this.arguments[0].Bind(table, list);
        if (this.arguments[1].GetType() == typeof (NameNode))
        {
          NameNode nameNode = (NameNode) this.arguments[1];
          this.arguments[1] = (ExpressionNode) new ConstNode(table, ValueType.Str, (object) nameNode.name);
        }
        this.arguments[1].Bind(table, list);
      }
      else
      {
        for (int index = 0; index < this.argumentCount; ++index)
          this.arguments[index].Bind(table, list);
      }
    }

    internal override object Eval() => this.Eval((DataRow) null, DataRowVersion.Default);

    internal override object Eval(DataRow row, DataRowVersion version)
    {
      Debug.Assert(this.info < FunctionNode.funcs.Length && this.info >= 0, "Invalid function info.");
      object[] argumentValues = new object[this.argumentCount];
      Debug.Assert(this.argumentCount == FunctionNode.funcs[this.info].argumentCount || FunctionNode.funcs[this.info].IsVariantArgumentList, "Invalid argument argumentCount.");
      if (FunctionNode.funcs[this.info].id == FunctionId.Convert)
      {
        if (this.argumentCount != 2)
          throw ExprException.FunctionArgumentCount(this.name);
        argumentValues[0] = this.arguments[0].Eval(row, version);
        argumentValues[1] = (object) this.GetDataType(this.arguments[1]);
      }
      else if (FunctionNode.funcs[this.info].id != FunctionId.Iif)
      {
        for (int index = 0; index < this.argumentCount; ++index)
        {
          argumentValues[index] = this.arguments[index].Eval(row, version);
          if (FunctionNode.funcs[this.info].IsValidateArguments)
          {
            if (argumentValues[index] == DBNull.Value || typeof (object) == FunctionNode.funcs[this.info].parameters[index])
              return (object) DBNull.Value;
            if (argumentValues[index].GetType() != FunctionNode.funcs[this.info].parameters[index])
            {
              if (FunctionNode.funcs[this.info].parameters[index] == typeof (int) && ExpressionNode.IsInteger(DataStorage.GetStorageType(argumentValues[index].GetType())))
              {
                argumentValues[index] = (object) Convert.ToInt32(argumentValues[index], this.FormatProvider);
              }
              else
              {
                if (FunctionNode.funcs[this.info].id != FunctionId.Trim && FunctionNode.funcs[this.info].id != FunctionId.Substring && FunctionNode.funcs[this.info].id != FunctionId.Len)
                  throw ExprException.ArgumentType(FunctionNode.funcs[this.info].name, index + 1, FunctionNode.funcs[this.info].parameters[index]);
                if (typeof (string) != argumentValues[index].GetType())
                  throw ExprException.ArgumentType(FunctionNode.funcs[this.info].name, index + 1, FunctionNode.funcs[this.info].parameters[index]);
              }
            }
          }
        }
      }
      return this.EvalFunction(FunctionNode.funcs[this.info].id, argumentValues, row, version);
    }

    internal override object Eval(int[] recordNos) => throw ExprException.ComputeNotAggregate(this.ToString());

    internal override bool IsConstant()
    {
      bool flag = true;
      for (int index = 0; index < this.argumentCount; ++index)
        flag = flag && this.arguments[index].IsConstant();
      Debug.Assert(this.info > -1, "All function nodes should be bound at this point.");
      return flag;
    }

    internal override bool IsTableConstant()
    {
      for (int index = 0; index < this.argumentCount; ++index)
      {
        if (!this.arguments[index].IsTableConstant())
          return false;
      }
      return true;
    }

    internal override bool HasLocalAggregate()
    {
      for (int index = 0; index < this.argumentCount; ++index)
      {
        if (this.arguments[index].HasLocalAggregate())
          return true;
      }
      return false;
    }

    internal override bool HasRemoteAggregate()
    {
      for (int index = 0; index < this.argumentCount; ++index)
      {
        if (this.arguments[index].HasRemoteAggregate())
          return true;
      }
      return false;
    }

    internal override bool DependsOn(DataColumn column)
    {
      for (int index = 0; index < this.argumentCount; ++index)
      {
        if (this.arguments[index].DependsOn(column))
          return true;
      }
      return false;
    }

    internal override ExpressionNode Optimize()
    {
      for (int index = 0; index < this.argumentCount; ++index)
        this.arguments[index] = this.arguments[index].Optimize();
      Debug.Assert(this.info > -1, "Optimizing unbound function ");
      if (FunctionNode.funcs[this.info].id == FunctionId.In)
      {
        if (!this.IsConstant())
          throw ExprException.NonConstantArgument();
      }
      else if (this.IsConstant())
        return (ExpressionNode) new ConstNode(this.table, ValueType.Object, this.Eval(), false);
      return (ExpressionNode) this;
    }

    private Type GetDataType(ExpressionNode node)
    {
      Type type = node.GetType();
      string typeName = (string) null;
      if (type == typeof (NameNode))
        typeName = ((NameNode) node).name;
      if (type == typeof (ConstNode))
        typeName = ((ConstNode) node).val.ToString();
      return (typeName != null ? Type.GetType(typeName) : throw ExprException.ArgumentType(FunctionNode.funcs[this.info].name, 2, typeof (Type))) ?? throw ExprException.InvalidType(typeName);
    }

    private object EvalFunction(
      FunctionId id,
      object[] argumentValues,
      DataRow row,
      DataRowVersion version)
    {
      switch (id)
      {
        case FunctionId.Charindex:
          Debug.Assert(this.argumentCount == 2, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          Debug.Assert(argumentValues[0] is string, "Invalid argument type for " + FunctionNode.funcs[this.info].name);
          Debug.Assert(argumentValues[1] is string, "Invalid argument type for " + FunctionNode.funcs[this.info].name);
          return DataStorage.IsObjectNull(argumentValues[0]) || DataStorage.IsObjectNull(argumentValues[1]) ? (object) DBNull.Value : (object) ((string) argumentValues[1]).IndexOf((string) argumentValues[0], StringComparison.Ordinal);
        case FunctionId.Len:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          Debug.Assert(argumentValues[0] is string, "Invalid argument type for " + FunctionNode.funcs[this.info].name);
          return (object) ((string) argumentValues[0]).Length;
        case FunctionId.Substring:
          Debug.Assert(this.argumentCount == 3, "Invalid argument argumentCount: " + this.argumentCount.ToString(this.FormatProvider));
          Debug.Assert(argumentValues[0] is string, "Invalid first argument " + argumentValues[0].GetType().FullName + " in " + FunctionNode.funcs[this.info].name);
          Debug.Assert(argumentValues[1] is int, "Invalid second argument " + argumentValues[1].GetType().FullName + " in " + FunctionNode.funcs[this.info].name);
          Debug.Assert(argumentValues[2] is int, "Invalid third argument " + argumentValues[2].GetType().FullName + " in " + FunctionNode.funcs[this.info].name);
          int startIndex = (int) argumentValues[1] - 1;
          int length1 = (int) argumentValues[2];
          if (startIndex < 0)
            throw ExprException.FunctionArgumentOutOfRange("index", "Substring");
          if (length1 < 0)
            throw ExprException.FunctionArgumentOutOfRange("length", "Substring");
          if (length1 == 0)
            return (object) "";
          int length2 = ((string) argumentValues[0]).Length;
          if (startIndex > length2)
            return (object) DBNull.Value;
          if (startIndex + length1 > length2)
            length1 = length2 - startIndex;
          return (object) ((string) argumentValues[0]).Substring(startIndex, length1);
        case FunctionId.IsNull:
          Debug.Assert(this.argumentCount == 2, "Invalid argument argumentCount: ");
          return DataStorage.IsObjectNull(argumentValues[0]) ? argumentValues[1] : argumentValues[0];
        case FunctionId.Iif:
          Debug.Assert(this.argumentCount == 3, "Invalid argument argumentCount: " + this.argumentCount.ToString(this.FormatProvider));
          return DataExpression.ToBoolean(this.arguments[0].Eval(row, version)) ? this.arguments[1].Eval(row, version) : this.arguments[2].Eval(row, version);
        case FunctionId.Convert:
          if (this.argumentCount != 2)
            throw ExprException.FunctionArgumentCount(this.name);
          if (argumentValues[0] == DBNull.Value)
            return (object) DBNull.Value;
          Type argumentValue = (Type) argumentValues[1];
          StorageType storageType1 = DataStorage.GetStorageType(argumentValue);
          StorageType storageType2 = DataStorage.GetStorageType(argumentValues[0].GetType());
          if (StorageType.Object == storageType1)
            return argumentValues[0];
          if (storageType1 == StorageType.Guid && storageType2 == StorageType.String)
            return (object) new Guid((string) argumentValues[0]);
          if (!ExpressionNode.IsFloatSql(storageType2) || !ExpressionNode.IsIntegerSql(storageType1))
            return SqlConvert.ChangeType2(argumentValues[0], storageType1, argumentValue, this.FormatProvider);
          if (StorageType.Single == storageType2)
            return SqlConvert.ChangeType2((object) (float) SqlConvert.ChangeType2(argumentValues[0], StorageType.Single, typeof (float), this.FormatProvider), storageType1, argumentValue, this.FormatProvider);
          if (StorageType.Double == storageType2)
            return SqlConvert.ChangeType2((object) (double) SqlConvert.ChangeType2(argumentValues[0], StorageType.Double, typeof (double), this.FormatProvider), storageType1, argumentValue, this.FormatProvider);
          return StorageType.Decimal == storageType2 ? SqlConvert.ChangeType2((object) (Decimal) SqlConvert.ChangeType2(argumentValues[0], StorageType.Decimal, typeof (Decimal), this.FormatProvider), storageType1, argumentValue, this.FormatProvider) : SqlConvert.ChangeType2(argumentValues[0], storageType1, argumentValue, this.FormatProvider);
        case FunctionId.cInt:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          return (object) Convert.ToInt32(argumentValues[0], this.FormatProvider);
        case FunctionId.cBool:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          switch (DataStorage.GetStorageType(argumentValues[0].GetType()))
          {
            case StorageType.Boolean:
              return (object) (bool) argumentValues[0];
            case StorageType.Int32:
              return (object) ((uint) (int) argumentValues[0] > 0U);
            case StorageType.Double:
              return (object) ((double) argumentValues[0] != 0.0);
            case StorageType.String:
              return (object) bool.Parse((string) argumentValues[0]);
            default:
              throw ExprException.DatatypeConvertion(argumentValues[0].GetType(), typeof (bool));
          }
        case FunctionId.cDate:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          return (object) Convert.ToDateTime(argumentValues[0], this.FormatProvider);
        case FunctionId.cDbl:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          return (object) Convert.ToDouble(argumentValues[0], this.FormatProvider);
        case FunctionId.cStr:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          return (object) Convert.ToString(argumentValues[0], this.FormatProvider);
        case FunctionId.Abs:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          StorageType storageType3 = DataStorage.GetStorageType(argumentValues[0].GetType());
          if (ExpressionNode.IsInteger(storageType3))
            return (object) Math.Abs((long) argumentValues[0]);
          if (ExpressionNode.IsNumeric(storageType3))
            return (object) Math.Abs((double) argumentValues[0]);
          throw ExprException.ArgumentTypeInteger(FunctionNode.funcs[this.info].name, 1);
        case FunctionId.In:
          throw ExprException.NYI(FunctionNode.funcs[this.info].name);
        case FunctionId.Trim:
          Debug.Assert(this.argumentCount == 1, "Invalid argument argumentCount for " + FunctionNode.funcs[this.info].name + " : " + this.argumentCount.ToString(this.FormatProvider));
          Debug.Assert(argumentValues[0] is string, "Invalid argument type for " + FunctionNode.funcs[this.info].name);
          return DataStorage.IsObjectNull(argumentValues[0]) ? (object) DBNull.Value : (object) ((string) argumentValues[0]).Trim();
        default:
          throw ExprException.UndefinedFunction(FunctionNode.funcs[this.info].name);
      }
    }

    internal FunctionId Aggregate => this.IsAggregate ? FunctionNode.funcs[this.info].id : FunctionId.none;

    internal bool IsAggregate => FunctionNode.funcs[this.info].id == FunctionId.Sum || FunctionNode.funcs[this.info].id == FunctionId.Avg || (FunctionNode.funcs[this.info].id == FunctionId.Min || FunctionNode.funcs[this.info].id == FunctionId.Max) || (FunctionNode.funcs[this.info].id == FunctionId.Count || FunctionNode.funcs[this.info].id == FunctionId.StDev) || FunctionNode.funcs[this.info].id == FunctionId.Var;

    internal void Check()
    {
      Function func = FunctionNode.funcs[this.info];
      if (this.info < 0)
        throw ExprException.UndefinedFunction(this.name);
      if (FunctionNode.funcs[this.info].IsVariantArgumentList)
      {
        if (this.argumentCount >= FunctionNode.funcs[this.info].argumentCount)
          return;
        if (FunctionNode.funcs[this.info].id == FunctionId.In)
          throw ExprException.InWithoutList();
        throw ExprException.FunctionArgumentCount(this.name);
      }
      if (this.argumentCount != FunctionNode.funcs[this.info].argumentCount)
        throw ExprException.FunctionArgumentCount(this.name);
    }
  }
}
