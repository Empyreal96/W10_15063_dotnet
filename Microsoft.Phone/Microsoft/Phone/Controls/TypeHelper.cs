// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.TypeHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Controls
{
  internal static class TypeHelper
  {
    internal static Type GetListItemType(this Type listType) => TypeHelper.FindGenericType(typeof (IList<>), listType)?.GetGenericArguments()[0];

    private static Type FindGenericType(Type definition, Type type)
    {
      for (; type != null && type != typeof (object); type = type.BaseType)
      {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == definition)
          return type;
        if (definition.IsInterface)
        {
          foreach (Type type1 in type.GetInterfaces())
          {
            Type genericType = TypeHelper.FindGenericType(definition, type1);
            if (genericType != null)
              return genericType;
          }
        }
      }
      return (Type) null;
    }
  }
}
