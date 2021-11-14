// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.ExtendedPropertiesHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Info
{
  internal static class ExtendedPropertiesHelper
  {
    internal static object GetValue(string propertyName, GetValueImplDelegate getValueImpl)
    {
      if (propertyName == null)
        throw new ArgumentNullException();
      try
      {
        object propertyValue;
        if (getValueImpl(propertyName, out propertyValue))
          return propertyValue;
        throw new ArgumentOutOfRangeException();
      }
      catch (ArgumentOutOfRangeException ex)
      {
        throw ex;
      }
      catch (UnauthorizedAccessException ex)
      {
        throw ex;
      }
      catch (ArgumentException ex)
      {
        if (QuirksMode.ShouldAllowANID2() && (propertyName == "DeviceUniqueId" || propertyName == "ANID2"))
          throw new ArgumentException("Missing PublisherID in the manifest");
        throw new NotSupportedException();
      }
      catch (COMException ex)
      {
        if (-2147023636 == ex.ErrorCode)
          throw new UnauthorizedAccessException();
        throw new NotSupportedException();
      }
      catch
      {
        throw new NotSupportedException();
      }
    }

    internal static bool TryGetValue(
      string propertyName,
      out object propertyValue,
      GetValueImplDelegate getValueImpl)
    {
      propertyValue = (object) null;
      if (propertyName == null)
        throw new ArgumentNullException();
      try
      {
        return getValueImpl(propertyName, out propertyValue);
      }
      catch
      {
        return false;
      }
    }
  }
}
