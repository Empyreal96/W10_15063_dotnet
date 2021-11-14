// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NetworkOperatorTetheringAccessPointConfiguration : 
    INetworkOperatorTetheringAccessPointConfiguration
  {
    [MethodImpl]
    public extern NetworkOperatorTetheringAccessPointConfiguration();

    public extern string Ssid { [MethodImpl] get; [MethodImpl] set; }

    public extern string Passphrase { [MethodImpl] get; [MethodImpl] set; }
  }
}
