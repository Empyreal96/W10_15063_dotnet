// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISettingsFlyoutAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (SettingsFlyoutAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4182205117, 35348, 16612, 148, 167, 63, 51, 201, 34, 233, 69)]
  [WebHostHidden]
  internal interface ISettingsFlyoutAutomationPeerFactory
  {
    SettingsFlyoutAutomationPeer CreateInstanceWithOwner(
      SettingsFlyout owner,
      object outer,
      out object inner);
  }
}
