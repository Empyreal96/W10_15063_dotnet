// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomTextBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3668231114, 36643, 19766, 145, 241, 118, 217, 55, 130, 121, 66)]
  [ExclusiveTo(typeof (VpnCustomTextBox))]
  internal interface IVpnCustomTextBox : IVpnCustomPrompt
  {
    string DisplayText { set; get; }
  }
}
