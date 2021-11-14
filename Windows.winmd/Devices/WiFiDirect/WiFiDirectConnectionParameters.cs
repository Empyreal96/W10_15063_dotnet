// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConnectionParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Static(typeof (IWiFiDirectConnectionParametersStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WiFiDirectConnectionParameters : 
    IWiFiDirectConnectionParameters,
    IWiFiDirectConnectionParameters2,
    IDevicePairingSettings
  {
    [MethodImpl]
    public extern WiFiDirectConnectionParameters();

    public extern short GroupOwnerIntent { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<WiFiDirectConfigurationMethod> PreferenceOrderedConfigurationMethods { [MethodImpl] get; }

    public extern WiFiDirectPairingProcedure PreferredPairingProcedure { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern DevicePairingKinds GetDevicePairingKinds(
      WiFiDirectConfigurationMethod configurationMethod);
  }
}
