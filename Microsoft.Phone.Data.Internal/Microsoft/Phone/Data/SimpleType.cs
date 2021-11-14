// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.SimpleType
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;

namespace Microsoft.Phone.Data
{
  internal sealed class SimpleType
  {
    private string baseType;
    private SimpleType baseSimpleType;
    private string name = "";
    private int length = -1;
    private int minLength = -1;
    private int maxLength = -1;
    private string pattern = "";
    private string ns = "";
    private string maxExclusive = "";
    private string maxInclusive = "";
    private string minExclusive = "";
    private string minInclusive = "";
    internal string enumeration = "";

    internal SimpleType(string baseType) => this.baseType = baseType;

    internal bool IsPlainString() => SimpleType.QualifiedName(this.baseType) == SimpleType.QualifiedName("string") && ADP.IsEmpty(this.name) && (this.length == -1 && this.minLength == -1) && (this.maxLength == -1 && ADP.IsEmpty(this.pattern) && (ADP.IsEmpty(this.maxExclusive) && ADP.IsEmpty(this.maxInclusive))) && (ADP.IsEmpty(this.minExclusive) && ADP.IsEmpty(this.minInclusive)) && ADP.IsEmpty(this.enumeration);

    internal string BaseType => this.baseType;

    internal string Name => this.name;

    internal string Namespace => this.ns;

    internal int Length => this.length;

    internal int MaxLength
    {
      get => this.maxLength;
      set => this.maxLength = value;
    }

    internal SimpleType BaseSimpleType => this.baseSimpleType;

    public string SimpleTypeQualifiedName => this.ns.Length == 0 ? this.name : this.ns + ":" + this.name;

    private static string QualifiedName(string name) => name.IndexOf(":", StringComparison.Ordinal) == -1 ? "xs:" + name : name;

    internal static SimpleType CreateLimitedStringType(int length) => new SimpleType("string")
    {
      maxLength = length
    };

    internal static SimpleType CreateSimpleType(Type type)
    {
      SimpleType simpleType = (SimpleType) null;
      if (type == typeof (char))
      {
        simpleType = new SimpleType("string");
        simpleType.length = 1;
      }
      return simpleType;
    }

    internal string HasConflictingDefinition(SimpleType otherSimpleType)
    {
      if (otherSimpleType == null)
        return nameof (otherSimpleType);
      if (this.MaxLength != otherSimpleType.MaxLength)
        return "MaxLength";
      if (string.Compare(this.BaseType, otherSimpleType.BaseType, StringComparison.Ordinal) != 0)
        return "BaseType";
      return this.BaseSimpleType == null && otherSimpleType.BaseSimpleType != null && this.BaseSimpleType.HasConflictingDefinition(otherSimpleType.BaseSimpleType).Length != 0 ? "BaseSimpleType" : string.Empty;
    }

    internal bool CanHaveMaxLength()
    {
      SimpleType simpleType = this;
      while (simpleType.BaseSimpleType != null)
        simpleType = simpleType.BaseSimpleType;
      return string.Compare(simpleType.BaseType, "string", StringComparison.OrdinalIgnoreCase) == 0;
    }

    internal void ConvertToAnnonymousSimpleType()
    {
      this.name = (string) null;
      this.ns = string.Empty;
      SimpleType simpleType = this;
      while (simpleType.baseSimpleType != null)
        simpleType = simpleType.baseSimpleType;
      this.baseType = simpleType.baseType;
      this.baseSimpleType = simpleType.baseSimpleType;
    }
  }
}
