// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.NetworkInterface
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  public sealed class NetworkInterface : System.Net.NetworkInformation.NetworkInterface
  {
    private static NetworkInterface _singleInstance;
    private static object _sync = new object();

    private NetworkInterface()
    {
    }

    public static NetworkInterfaceType NetworkInterfaceType
    {
      get
      {
        NetworkInterfaceType networkInterfaceType = NetworkInterfaceType.None;
        switch (NativeMethods.NativeGetNetworkType())
        {
          case NativeMethods.NativeNetworkInterfaceType.None:
            networkInterfaceType = NetworkInterfaceType.None;
            break;
          case NativeMethods.NativeNetworkInterfaceType.CellularGsm:
            networkInterfaceType = NetworkInterfaceType.MobileBroadbandGsm;
            break;
          case NativeMethods.NativeNetworkInterfaceType.Other:
            networkInterfaceType = NetworkInterfaceType.Wireless80211;
            break;
          case NativeMethods.NativeNetworkInterfaceType.CellularCdma:
            networkInterfaceType = NetworkInterfaceType.MobileBroadbandCdma;
            break;
          case NativeMethods.NativeNetworkInterfaceType.DesktopPassThru:
            networkInterfaceType = NetworkInterfaceType.Ethernet;
            break;
        }
        return networkInterfaceType;
      }
    }

    public static NetworkInterface GetInternetInterface()
    {
      if (NetworkInterface._singleInstance == null)
      {
        lock (NetworkInterface._sync)
        {
          if (NetworkInterface._singleInstance == null)
            NetworkInterface._singleInstance = new NetworkInterface();
        }
      }
      return NetworkInterface._singleInstance;
    }
  }
}
