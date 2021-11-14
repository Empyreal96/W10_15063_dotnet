// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.BaseTypesResolver
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Shell
{
  internal static class BaseTypesResolver
  {
    internal static IEnumerable<Type> GetKnownTypes(
      IDictionary<string, object> dictionary)
    {
      if (dictionary == null)
        return (IEnumerable<Type>) null;
      List<Type> typeList = new List<Type>();
      foreach (object obj in (IEnumerable<object>) dictionary.Values)
      {
        if (obj != null)
        {
          Type type = obj.GetType();
          if (!typeList.Contains(type))
            typeList.Add(type);
        }
      }
      return (IEnumerable<Type>) typeList;
    }

    internal static List<string> GetKnownTypesNames(IEnumerable<Type> knownTypes)
    {
      if (knownTypes == null)
        return (List<string>) null;
      List<string> stringList = new List<string>();
      foreach (Type knownType in knownTypes)
      {
        if (!stringList.Contains(knownType.AssemblyQualifiedName))
          stringList.Add(knownType.AssemblyQualifiedName);
      }
      return stringList;
    }

    internal static IEnumerable<Type> GetKnownTypes(List<string> knownTypeNames)
    {
      foreach (string knownTypeName in knownTypeNames)
        yield return Type.GetType(knownTypeName);
    }
  }
}
