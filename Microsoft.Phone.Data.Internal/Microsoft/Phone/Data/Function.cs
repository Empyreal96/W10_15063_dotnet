// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Function
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  internal sealed class Function
  {
    internal readonly string name;
    internal readonly FunctionId id;
    internal readonly Type result;
    internal readonly bool IsValidateArguments;
    internal readonly bool IsVariantArgumentList;
    internal readonly int argumentCount;
    internal readonly Type[] parameters = new Type[3];
    internal static string[] FunctionName = new string[38]
    {
      "Unknown",
      "Ascii",
      "Char",
      "CharIndex",
      "Difference",
      "Len",
      "Lower",
      "LTrim",
      "Patindex",
      "Replicate",
      "Reverse",
      "Right",
      "RTrim",
      "Soundex",
      "Space",
      "Str",
      "Stuff",
      "Substring",
      "Upper",
      "IsNull",
      "Iif",
      "Convert",
      "cInt",
      "cBool",
      "cDate",
      "cDbl",
      "cStr",
      "Abs",
      "Acos",
      "In",
      "Trim",
      "Sum",
      "Avg",
      "Min",
      "Max",
      "Count",
      "StDev",
      "Var"
    };

    internal Function()
    {
      this.name = (string) null;
      this.id = FunctionId.none;
      this.result = (Type) null;
      this.IsValidateArguments = false;
      this.argumentCount = 0;
    }

    internal Function(
      string name,
      FunctionId id,
      Type result,
      bool IsValidateArguments,
      bool IsVariantArgumentList,
      int argumentCount,
      Type a1,
      Type a2,
      Type a3)
    {
      this.name = name;
      this.id = id;
      this.result = result;
      this.IsValidateArguments = IsValidateArguments;
      this.IsVariantArgumentList = IsVariantArgumentList;
      this.argumentCount = argumentCount;
      if (a1 != null)
        this.parameters[0] = a1;
      if (a2 != null)
        this.parameters[1] = a2;
      if (a3 == null)
        return;
      this.parameters[2] = a3;
    }
  }
}
