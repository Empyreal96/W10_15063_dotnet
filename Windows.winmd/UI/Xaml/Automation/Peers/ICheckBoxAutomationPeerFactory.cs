// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ICheckBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3076290397, 60303, 17647, 162, 124, 226, 106, 199, 222, 131, 51)]
  [ExclusiveTo(typeof (CheckBoxAutomationPeer))]
  internal interface ICheckBoxAutomationPeerFactory
  {
    CheckBoxAutomationPeer CreateInstanceWithOwner(
      CheckBox owner,
      object outer,
      out object inner);
  }
}
