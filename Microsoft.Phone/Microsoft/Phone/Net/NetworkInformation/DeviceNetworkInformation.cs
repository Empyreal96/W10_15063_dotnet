// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.DeviceNetworkInformation
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Net;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  public static class DeviceNetworkInformation
  {
    private static InternalNetworkChange s_NetworkChange;
    private static IntPtr s_hResourceMgrNetworkBandwidth = IntPtr.Zero;

    public static bool IsCellularDataRoamingEnabled
    {
      [SecuritySafeCritical] get => WwanUtils.IsRoamingEnabled();
    }

    public static bool IsWiFiEnabled
    {
      [SecuritySafeCritical] get => ConnectionMgrUtils.IsWiFiEnabled();
    }

    public static bool IsCellularDataEnabled
    {
      [SecuritySafeCritical] get => ConnectionMgrUtils.IsCellularDataEnabled();
    }

    public static string CellularMobileOperator
    {
      [SecuritySafeCritical] get => ConnectionMgrUtils.GetMobileOperatorName();
    }

    public static bool IsNetworkAvailable
    {
      [SecuritySafeCritical] get => ConnectionMgrUtils.IsNetworkAvailable();
    }

    public static void ResolveHostNameAsync(
      DnsEndPoint endPoint,
      NetworkInterfaceInfo networkInterface,
      NameResolutionCallback callback,
      object context)
    {
      if (endPoint == null)
        throw new ArgumentNullException(nameof (endPoint));
      if (networkInterface == null)
        throw new ArgumentNullException(nameof (networkInterface));
      if (callback == null)
        throw new ArgumentNullException(nameof (callback));
      if ((networkInterface.InterfaceType == NetworkInterfaceType.MobileBroadbandGsm || networkInterface.InterfaceType == NetworkInterfaceType.MobileBroadbandCdma) && HelperMethods.IsCellularDisabled())
        throw new InvalidOperationException(string.Empty);
      new NameResolution(endPoint).BeginResolveHostNameAsyncOnInterface(networkInterface, callback, context);
    }

    public static void ResolveHostNameAsync(
      DnsEndPoint endPoint,
      NameResolutionCallback callback,
      object context)
    {
      if (endPoint == null)
        throw new ArgumentNullException(nameof (endPoint));
      if (callback == null)
        throw new ArgumentNullException(nameof (callback));
      new NameResolution(endPoint).BeginResolveHostNameAsync(callback, context);
    }

    public static event EventHandler<NetworkNotificationEventArgs> NetworkAvailabilityChanged
    {
      add
      {
        if (DeviceNetworkInformation.s_NetworkChange == null)
          DeviceNetworkInformation.s_NetworkChange = new InternalNetworkChange();
        DeviceNetworkInformation.s_NetworkChange.AddNetworkAvailabilityChanged(value);
      }
      remove => DeviceNetworkInformation.s_NetworkChange.RemoveNetworkAvailabilityChanged(value);
    }
  }
}
