// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.LikeNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class LikeNode : BinaryNode
  {
    internal const int match_left = 1;
    internal const int match_right = 2;
    internal const int match_middle = 3;
    internal const int match_exact = 4;
    internal const int match_all = 5;
    private int kind;
    private string pattern;

    internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
      : base(table, op, left, right)
    {
    }

    internal override object Eval(DataRow row, DataRowVersion version)
    {
      object obj1 = this.left.Eval(row, version);
      if (obj1 == DBNull.Value || this.left.IsSqlColumn && DataStorage.IsObjectSqlNull(obj1))
        return (object) DBNull.Value;
      string s2_1;
      if (this.pattern == null)
      {
        object obj2 = this.right.Eval(row, version);
        if (!(obj2 is string))
          this.SetTypeMismatchError(this.op, obj1.GetType(), obj2.GetType());
        if (obj2 == DBNull.Value || DataStorage.IsObjectSqlNull(obj2))
          return (object) DBNull.Value;
        s2_1 = this.AnalizePattern((string) SqlConvert.ChangeType2(obj2, StorageType.String, typeof (string), this.FormatProvider));
        if (this.right.IsConstant())
          this.pattern = s2_1;
      }
      else
        s2_1 = this.pattern;
      if (!(obj1 is string))
        this.SetTypeMismatchError(this.op, obj1.GetType(), typeof (string));
      char[] chArray = new char[2]{ ' ', '　' };
      string s1 = ((string) obj1).TrimEnd(chArray);
      switch (this.kind)
      {
        case 1:
          return (object) (this.table.IndexOf(s1, s2_1) == 0);
        case 2:
          string s2_2 = s2_1.TrimEnd(chArray);
          return (object) this.table.IsSuffix(s1, s2_2);
        case 3:
          return (object) (0 <= this.table.IndexOf(s1, s2_1));
        case 4:
          return (object) (this.table.Compare(s1, s2_1) == 0);
        case 5:
          return (object) true;
        default:
          Debug.Assert(false, "Unexpected LIKE kind");
          return (object) DBNull.Value;
      }
    }

    internal string AnalizePattern(string pat)
    {
      int length1 = pat.Length;
      char[] destination = new char[length1 + 1];
      pat.CopyTo(0, destination, 0, length1);
      destination[length1] = char.MinValue;
      char[] chArray1 = new char[length1 + 1];
      int length2 = 0;
      int num1 = 0;
      int index1 = 0;
      while (index1 < length1)
      {
        if (destination[index1] == '*' || destination[index1] == '%')
        {
          while ((destination[index1] == '*' || destination[index1] == '%') && index1 < length1)
            ++index1;
          if (index1 < length1 && length2 > 0 || num1 >= 2)
            throw ExprException.InvalidPattern(pat);
          ++num1;
        }
        else if (destination[index1] == '[')
        {
          int num2 = index1 + 1;
          if (num2 >= length1)
            throw ExprException.InvalidPattern(pat);
          char[] chArray2 = chArray1;
          int index2 = length2++;
          char[] chArray3 = destination;
          int index3 = num2;
          int index4 = index3 + 1;
          int num3 = (int) chArray3[index3];
          chArray2[index2] = (char) num3;
          if (index4 >= length1)
            throw ExprException.InvalidPattern(pat);
          if (destination[index4] != ']')
            throw ExprException.InvalidPattern(pat);
          index1 = index4 + 1;
        }
        else
        {
          chArray1[length2++] = destination[index1];
          ++index1;
        }
      }
      string str = new string(chArray1, 0, length2);
      if (num1 == 0)
      {
        this.kind = 4;
        return str;
      }
      if (length2 > 0)
      {
        if (destination[0] == '*' || destination[0] == '%')
        {
          if (destination[length1 - 1] == '*' || destination[length1 - 1] == '%')
          {
            this.kind = 3;
            return str;
          }
          this.kind = 2;
          return str;
        }
        Debug.Assert(destination[length1 - 1] == '*' || destination[length1 - 1] == '%', "Invalid LIKE pattern formed.. ");
        this.kind = 1;
        return str;
      }
      this.kind = 5;
      return str;
    }
  }
}
