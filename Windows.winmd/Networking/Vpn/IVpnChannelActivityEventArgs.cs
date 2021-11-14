// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelActivityEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnChannelActivityEventArgs))]
  [Guid(2741799154, 45020, 18293, 133, 93, 212, 172, 10, 53, 252, 85)]
  internal interface IVpnChannelActivityEventArgs
  {
    VpnChannelActivityEventType Type { get; }
  }
}
