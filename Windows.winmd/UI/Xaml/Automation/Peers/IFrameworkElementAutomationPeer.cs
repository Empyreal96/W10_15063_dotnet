// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFrameworkElementAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (FrameworkElementAutomationPeer))]
  [WebHostHidden]
  [Guid(3104495489, 49131, 17489, 189, 71, 159, 58, 99, 235, 210, 74)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkElementAutomationPeer
  {
    UIElement Owner { get; }
  }
}
