// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IComboBoxItemDataAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ComboBoxItemDataAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(346608886, 18074, 16826, 157, 147, 68, 161, 165, 93, 168, 114)]
  internal interface IComboBoxItemDataAutomationPeerFactory
  {
    ComboBoxItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ComboBoxAutomationPeer parent,
      object outer,
      out object inner);
  }
}
