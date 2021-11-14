// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IPasswordBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(2889711326, 56484, 18460, 181, 32, 74, 155, 63, 59, 23, 156)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PasswordBoxAutomationPeer))]
  internal interface IPasswordBoxAutomationPeerFactory
  {
    PasswordBoxAutomationPeer CreateInstanceWithOwner(
      PasswordBox owner,
      object outer,
      out object inner);
  }
}
