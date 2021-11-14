// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelActivityStateChangedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnChannelActivityStateChangedArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1031079269, 64960, 19390, 162, 59, 69, 255, 252, 109, 151, 161)]
  internal interface IVpnChannelActivityStateChangedArgs
  {
    VpnChannelActivityEventType ActivityState { get; }
  }
}
