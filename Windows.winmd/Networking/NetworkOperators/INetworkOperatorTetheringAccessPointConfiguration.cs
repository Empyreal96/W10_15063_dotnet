// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringAccessPointConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(197919364, 16686, 16445, 172, 198, 183, 87, 227, 71, 116, 164)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringAccessPointConfiguration))]
  internal interface INetworkOperatorTetheringAccessPointConfiguration
  {
    string Ssid { get; set; }

    string Passphrase { get; set; }
  }
}
