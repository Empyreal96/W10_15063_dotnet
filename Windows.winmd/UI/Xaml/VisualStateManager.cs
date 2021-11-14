// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualStateManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IVisualStateManagerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IVisualStateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class VisualStateManager : 
    DependencyObject,
    IVisualStateManager,
    IVisualStateManagerOverrides,
    IVisualStateManagerProtected
  {
    [MethodImpl]
    public extern VisualStateManager();

    [MethodImpl]
    extern bool IVisualStateManagerOverrides.GoToStateCore(
      Control control,
      FrameworkElement templateRoot,
      string stateName,
      VisualStateGroup group,
      VisualState state,
      bool useTransitions);

    [MethodImpl]
    extern void IVisualStateManagerProtected.RaiseCurrentStateChanging(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);

    [MethodImpl]
    extern void IVisualStateManagerProtected.RaiseCurrentStateChanged(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);

    [MethodImpl]
    public static extern IVector<VisualStateGroup> GetVisualStateGroups(
      FrameworkElement obj);

    public static extern DependencyProperty CustomVisualStateManagerProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern VisualStateManager GetCustomVisualStateManager(
      FrameworkElement obj);

    [MethodImpl]
    public static extern void SetCustomVisualStateManager(
      FrameworkElement obj,
      VisualStateManager value);

    [MethodImpl]
    public static extern bool GoToState(Control control, string stateName, bool useTransitions);
  }
}
