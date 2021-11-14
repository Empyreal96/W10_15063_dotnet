// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRichTextBlockOverflowAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3177100899, 11284, 18021, 173, 239, 242, 176, 51, 148, 123, 235)]
  [ExclusiveTo(typeof (RichTextBlockOverflowAutomationPeer))]
  [WebHostHidden]
  internal interface IRichTextBlockOverflowAutomationPeerFactory
  {
    RichTextBlockOverflowAutomationPeer CreateInstanceWithOwner(
      RichTextBlockOverflow owner,
      object outer,
      out object inner);
  }
}
