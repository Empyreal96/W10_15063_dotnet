﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbConnectionStringBuilderUtil
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Phone.Data.Common
{
  internal static class DbConnectionStringBuilderUtil
  {
    internal static string ConvertToString(object value)
    {
      try
      {
        return ((IConvertible) value).ToString((IFormatProvider) CultureInfo.InvariantCulture);
      }
      catch (InvalidCastException ex)
      {
        throw ADP.ConvertFailed(value.GetType(), typeof (string), (Exception) ex);
      }
    }
  }
}