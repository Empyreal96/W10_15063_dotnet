// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerAnnotation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationPeerAnnotation))]
  [WebHostHidden]
  [Guid(205873249, 21199, 17402, 130, 248, 7, 241, 55, 53, 30, 90)]
  internal interface IAutomationPeerAnnotation
  {
    AnnotationType Type { get; set; }

    AutomationPeer Peer { get; set; }
  }
}
