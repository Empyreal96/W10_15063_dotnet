// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptText
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnCustomPromptText))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1003011566, 14914, 18851, 171, 221, 7, 178, 237, 234, 117, 45)]
  internal interface IVpnCustomPromptText : IVpnCustomPromptElement
  {
    string Text { set; get; }
  }
}
