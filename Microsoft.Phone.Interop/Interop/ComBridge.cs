// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.ComBridge
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Threading;

namespace Microsoft.Phone.Interop
{
  internal static class ComBridge
  {
    public const uint S_OK = 0;
    private static Dictionary<Guid, List<int>> RegisteredIds = new Dictionary<Guid, List<int>>();
    internal static readonly object _gate = new object();

    [SecurityCritical]
    public static uint RegisterComDllInternal(string dllFileName, Guid clsid)
    {
      lock (ComBridge._gate)
      {
        uint num1 = 0;
        List<int> intList;
        ComBridge.RegisteredIds.TryGetValue(clsid, out intList);
        int managedThreadId = Thread.CurrentThread.ManagedThreadId;
        if (intList != null && intList.Contains(managedThreadId))
          return num1;
        uint num2 = ComBridgeNativeMethods.RegisterComDllInproc(dllFileName, "{" + clsid.ToString().ToUpper(CultureInfo.InvariantCulture) + "}");
        if (num2 == 0U)
        {
          if (intList == null)
            intList = new List<int>();
          intList.Add(managedThreadId);
          ComBridge.RegisteredIds[clsid] = intList;
        }
        return num2;
      }
    }
  }
}
