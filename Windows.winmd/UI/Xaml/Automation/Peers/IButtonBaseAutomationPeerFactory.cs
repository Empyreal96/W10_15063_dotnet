// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IButtonBaseAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ButtonBaseAutomationPeer))]
  [Guid(2315520286, 59058, 19552, 167, 89, 193, 60, 164, 81, 101, 237)]
  internal interface IButtonBaseAutomationPeerFactory
  {
    ButtonBaseAutomationPeer CreateInstanceWithOwner(
      ButtonBase owner,
      object outer,
      out object inner);
  }
}
