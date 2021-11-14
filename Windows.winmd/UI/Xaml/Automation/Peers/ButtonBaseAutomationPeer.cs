// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IButtonBaseAutomationPeerFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class ButtonBaseAutomationPeer : FrameworkElementAutomationPeer, IButtonBaseAutomationPeer
  {
    [MethodImpl]
    protected extern ButtonBaseAutomationPeer(ButtonBase owner);
  }
}
