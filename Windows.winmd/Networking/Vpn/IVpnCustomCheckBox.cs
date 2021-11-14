// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomCheckBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnCustomCheckBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1132955475, 965, 20065, 147, 215, 169, 87, 113, 76, 66, 130)]
  internal interface IVpnCustomCheckBox : IVpnCustomPrompt
  {
    bool InitialCheckState { set; get; }

    bool Checked { get; }
  }
}
