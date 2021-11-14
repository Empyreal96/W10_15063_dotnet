// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.PlatformInteropMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecurityCritical]
  internal static class PlatformInteropMethods
  {
    internal const int ERROR_SUCCESS = 0;
    internal const int ERROR_OPERATION_ABORTED = 995;
    internal const int ERROR_RESOLUTION_FAILED = 13014;
    private const string Platform_Interop_DLL = "PlatformInterop.dll";

    [DllImport("PlatformInterop.dll", EntryPoint = "RegisterNetworkNotification", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern int RegisterForNetworkNotification(IntPtr funcPtr);

    [DllImport("PlatformInterop.dll", EntryPoint = "UnregisterNetworkNotification", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern int UnregisterForNetworkNotification();

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern int ResolveHostName(
      [In] string lpHostName,
      NameResolution.NativeCallback callbackFunction,
      [In] ushort uAddrFamily,
      [In] ushort uDstPort,
      [In] string lpInterfaceName,
      [In] bool IsCellularDisabled);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int GetMobileOperatorName(
      [Out] StringBuilder operatorName,
      [In] uint cchOperatorName);
  }
}
