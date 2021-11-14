// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptTextInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3386547317, 37180, 18389, 136, 186, 72, 252, 72, 147, 2, 53)]
  [ExclusiveTo(typeof (VpnCustomPromptTextInput))]
  internal interface IVpnCustomPromptTextInput : IVpnCustomPromptElement
  {
    string PlaceholderText { set; get; }

    bool IsTextHidden { set; get; }

    string Text { get; }
  }
}
