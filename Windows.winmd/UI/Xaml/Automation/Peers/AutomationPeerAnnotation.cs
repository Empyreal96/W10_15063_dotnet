// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IAutomationPeerAnnotationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAutomationPeerAnnotationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class AutomationPeerAnnotation : DependencyObject, IAutomationPeerAnnotation
  {
    [MethodImpl]
    public extern AutomationPeerAnnotation(AnnotationType type);

    [MethodImpl]
    public extern AutomationPeerAnnotation(AnnotationType type, AutomationPeer peer);

    [MethodImpl]
    public extern AutomationPeerAnnotation();

    public extern AnnotationType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern AutomationPeer Peer { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty PeerProperty { [MethodImpl] get; }
  }
}
