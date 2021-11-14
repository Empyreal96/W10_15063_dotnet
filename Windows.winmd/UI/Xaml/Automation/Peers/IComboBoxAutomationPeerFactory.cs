// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IComboBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(160324365, 7056, 16569, 155, 227, 178, 50, 103, 235, 19, 207)]
  [ExclusiveTo(typeof (ComboBoxAutomationPeer))]
  internal interface IComboBoxAutomationPeerFactory
  {
    ComboBoxAutomationPeer CreateInstanceWithOwner(
      ComboBox owner,
      object outer,
      out object inner);
  }
}
