// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionParameters2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectConnectionParameters))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2872774590, 43650, 17588, 136, 200, 227, 5, 107, 137, 128, 29)]
  internal interface IWiFiDirectConnectionParameters2
  {
    IVector<WiFiDirectConfigurationMethod> PreferenceOrderedConfigurationMethods { get; }

    WiFiDirectPairingProcedure PreferredPairingProcedure { get; set; }
  }
}
