// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectAdvertisement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectAdvertisement : IWiFiDirectAdvertisement, IWiFiDirectAdvertisement2
  {
    public extern IVector<WiFiDirectInformationElement> InformationElements { [MethodImpl] get; [MethodImpl] set; }

    public extern WiFiDirectAdvertisementListenStateDiscoverability ListenStateDiscoverability { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAutonomousGroupOwnerEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern WiFiDirectLegacySettings LegacySettings { [MethodImpl] get; }

    public extern IVector<WiFiDirectConfigurationMethod> SupportedConfigurationMethods { [MethodImpl] get; }
  }
}
