// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IButtonAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ButtonAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1071357769, 62635, 18304, 134, 68, 3, 55, 98, 153, 161, 117)]
  internal interface IButtonAutomationPeerFactory
  {
    ButtonAutomationPeer CreateInstanceWithOwner(
      Button owner,
      object outer,
      out object inner);
  }
}
