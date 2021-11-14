// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ITextBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(32555111, 38507, 16688, 184, 114, 70, 158, 66, 189, 74, 127)]
  [ExclusiveTo(typeof (TextBoxAutomationPeer))]
  [WebHostHidden]
  internal interface ITextBoxAutomationPeerFactory
  {
    TextBoxAutomationPeer CreateInstanceWithOwner(
      TextBox owner,
      object outer,
      out object inner);
  }
}
