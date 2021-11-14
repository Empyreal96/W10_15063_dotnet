// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.AnidProperty
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Security;
using System.Text;

namespace Microsoft.Phone.Info
{
  [SecuritySafeCritical]
  internal static class AnidProperty
  {
    public static string Get() => AnidProperty.GetUserExtProperty();

    [SecuritySafeCritical]
    private static string GetUserExtProperty()
    {
      string str1 = (string) null;
      StringBuilder stringBuilder = new StringBuilder(256);
      IDCRLMethods.GetANID(stringBuilder, stringBuilder.Capacity);
      string str2 = stringBuilder.ToString();
      if (str2.Length > 0)
        str1 = !str2.StartsWith("@fmt|") ? str2 : str2.Substring(5);
      return str1;
    }
  }
}
