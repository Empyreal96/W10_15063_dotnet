// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.XmlTreeGen
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  internal sealed class XmlTreeGen
  {
    internal static bool AutoGenerated(DataColumn col)
    {
      if (col.ColumnMapping != MappingType.Hidden || col.DataType != typeof (int))
        return false;
      string str1 = col.Table.TableName + "_Id";
      if (col.ColumnName == str1 || col.ColumnName == str1 + "_0")
        return true;
      string str2 = "";
      foreach (DataRelation parentRelation in (InternalDataCollectionBase) col.Table.ParentRelations)
      {
        if (parentRelation.Nested && parentRelation.ChildColumnsReference.Length == 1 && (parentRelation.ChildColumnsReference[0] == col && parentRelation.ParentColumnsReference.Length == 1))
          str2 = parentRelation.ParentColumnsReference[0].Table.TableName + "_Id";
      }
      return col.ColumnName == str2 || col.ColumnName == str2 + "_0";
    }

    internal static bool AutoGenerated(DataRelation rel)
    {
      string str = rel.ParentTable.TableName + "_" + rel.ChildTable.TableName;
      return rel.RelationName.StartsWith(str, StringComparison.Ordinal) && rel.ExtendedProperties.Count <= 0;
    }

    internal static bool AutoGenerated(UniqueConstraint unique) => unique.ConstraintName.StartsWith("Constraint", StringComparison.Ordinal) && (unique.Key.ColumnsReference.Length == 1 && unique.ExtendedProperties.Count <= 0) && XmlTreeGen.AutoGenerated(unique.Key.ColumnsReference[0]);

    private bool AutoGenerated(ForeignKeyConstraint fk) => XmlTreeGen.AutoGenerated(fk, true);

    internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation)
    {
      DataRelation parentRelation = fk.FindParentRelation();
      return (!checkRelation || parentRelation != null && XmlTreeGen.AutoGenerated(parentRelation) && !(parentRelation.RelationName != fk.ConstraintName)) && (fk.ExtendedProperties.Count <= 0 && fk.AcceptRejectRule == AcceptRejectRule.None && (fk.DeleteRule == Rule.Cascade && fk.DeleteRule == Rule.Cascade) && fk.RelatedColumnsReference.Length == 1) && XmlTreeGen.AutoGenerated(fk.RelatedColumnsReference[0]);
    }
  }
}
