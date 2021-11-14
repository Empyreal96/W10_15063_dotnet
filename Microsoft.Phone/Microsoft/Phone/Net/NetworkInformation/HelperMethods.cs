// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.HelperMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System.Security;
using System.Windows;

namespace Microsoft.Phone.Net.NetworkInformation
{
  internal static class HelperMethods
  {
    private static bool s_fInitialized;
    private static bool s_fDisableCellular;

    [SecuritySafeCritical]
    internal static bool IsCellularDisabled()
    {
      lock (typeof (HelperMethods))
      {
        if (!HelperMethods.s_fInitialized)
        {
          if (new HostInfo().IsHeadlessHost && Application.Current is HeadlessApplication current3)
            HelperMethods.s_fDisableCellular = current3.DisableCellular;
          HelperMethods.s_fInitialized = true;
        }
      }
      return HelperMethods.s_fDisableCellular;
    }
  }
}
