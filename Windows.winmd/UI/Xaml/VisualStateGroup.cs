// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualStateGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "States")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VisualStateGroup : DependencyObject, IVisualStateGroup
  {
    [MethodImpl]
    public extern VisualStateGroup();

    public extern string Name { [MethodImpl] get; }

    public extern IVector<VisualTransition> Transitions { [MethodImpl] get; }

    public extern IVector<VisualState> States { [MethodImpl] get; }

    public extern VisualState CurrentState { [MethodImpl] get; }

    public extern event VisualStateChangedEventHandler CurrentStateChanged;

    public extern event VisualStateChangedEventHandler CurrentStateChanging;
  }
}
