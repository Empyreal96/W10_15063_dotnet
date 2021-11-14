// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [ContentProperty(Name = "Storyboard")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class VisualState : DependencyObject, IVisualState, IVisualState2
  {
    [MethodImpl]
    public extern VisualState();

    public extern string Name { [MethodImpl] get; }

    public extern Storyboard Storyboard { [MethodImpl] get; [MethodImpl] set; }

    public extern SetterBaseCollection Setters { [MethodImpl] get; }

    public extern IVector<StateTriggerBase> StateTriggers { [MethodImpl] get; }
  }
}
