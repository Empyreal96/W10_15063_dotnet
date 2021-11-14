// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.UserExtendedProperties
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Info
{
  public static class UserExtendedProperties
  {
    public static object GetValue(string propertyName) => ExtendedPropertiesHelper.GetValue(propertyName, new GetValueImplDelegate(UserExtendedProperties.GetValueImpl));

    public static bool TryGetValue(string propertyName, out object propertyValue) => ExtendedPropertiesHelper.TryGetValue(propertyName, out propertyValue, new GetValueImplDelegate(UserExtendedProperties.GetValueImpl));

    internal static bool GetValueImpl(string propertyName, out object propertyValue)
    {
      bool flag = false;
      propertyValue = (object) null;
      if (string.Compare(propertyName, "ANID", StringComparison.InvariantCulture) == 0)
      {
        if (!QuirksMode.ShouldAllowANID())
          throw new NotSupportedException();
        propertyValue = (object) AnidProperty.Get();
        flag = true;
      }
      if (string.Compare(propertyName, "ANID2", StringComparison.InvariantCulture) == 0 && QuirksMode.ShouldAllowANID2())
      {
        propertyValue = (object) AnidProperty.Get();
        flag = true;
      }
      return flag;
    }
  }
}
