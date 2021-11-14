// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.TypesResolver
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Navigation;

namespace Microsoft.Phone.Shell
{
  internal static class TypesResolver
  {
    internal static IEnumerable<Type> GetKnownTypes(
      IEnumerable<IJournalEntry> entryList)
    {
      if (entryList == null || entryList.Count<IJournalEntry>() == 0)
        return (IEnumerable<Type>) null;
      List<Type> typeList = new List<Type>();
      typeList.Add(typeof (JournalEntryData));
      foreach (IJournalEntry entry in entryList)
        typeList.AddRange(TypesResolver.GetKnownTypes(entry.JournalEntryData.State));
      return (IEnumerable<Type>) typeList;
    }

    internal static IEnumerable<Type> GetKnownTypes(
      IDictionary<string, object> dictionary)
    {
      return BaseTypesResolver.GetKnownTypes(dictionary);
    }

    internal static List<string> GetKnownTypesNames(IEnumerable<Type> knownTypes) => BaseTypesResolver.GetKnownTypesNames(knownTypes);

    internal static IEnumerable<Type> GetKnownTypes(List<string> knownTypeNames) => BaseTypesResolver.GetKnownTypes(knownTypeNames);
  }
}
