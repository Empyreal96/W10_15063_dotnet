// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ITextBlockAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (TextBlockAutomationPeer))]
  [Guid(1992266315, 31904, 19201, 188, 92, 168, 207, 77, 54, 145, 222)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextBlockAutomationPeerFactory
  {
    TextBlockAutomationPeer CreateInstanceWithOwner(
      TextBlock owner,
      object outer,
      out object inner);
  }
}
