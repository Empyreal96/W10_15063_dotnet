// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerAnnotationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationPeerAnnotation))]
  [Guid(4120658846, 50779, 17357, 144, 9, 3, 252, 2, 51, 99, 167)]
  [WebHostHidden]
  internal interface IAutomationPeerAnnotationFactory
  {
    AutomationPeerAnnotation CreateInstance(AnnotationType type);

    AutomationPeerAnnotation CreateWithPeerParameter(
      AnnotationType type,
      AutomationPeer peer);
  }
}
