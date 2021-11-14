// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomEditBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnCustomEditBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(805493152, 53183, 19467, 143, 60, 102, 245, 3, 194, 11, 57)]
  internal interface IVpnCustomEditBox : IVpnCustomPrompt
  {
    string DefaultText { set; get; }

    bool NoEcho { set; get; }

    string Text { get; }
  }
}
