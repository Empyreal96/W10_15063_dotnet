// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRichTextBlockAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(540585569, 5001, 18042, 174, 214, 55, 51, 77, 169, 98, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichTextBlockAutomationPeer))]
  internal interface IRichTextBlockAutomationPeerFactory
  {
    RichTextBlockAutomationPeer CreateInstanceWithOwner(
      RichTextBlock owner,
      object outer,
      out object inner);
  }
}
