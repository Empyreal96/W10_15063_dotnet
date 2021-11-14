// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoom
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (ISemanticZoomStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "ZoomedInView")]
  public sealed class SemanticZoom : Control, ISemanticZoom
  {
    [MethodImpl]
    public extern SemanticZoom();

    public extern ISemanticZoomInformation ZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    public extern ISemanticZoomInformation ZoomedOutView { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomedInViewActive { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanChangeViews { [MethodImpl] get; [MethodImpl] set; }

    public extern event SemanticZoomViewChangedEventHandler ViewChangeStarted;

    public extern event SemanticZoomViewChangedEventHandler ViewChangeCompleted;

    [MethodImpl]
    public extern void ToggleActiveView();

    public extern bool IsZoomOutButtonEnabled { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ZoomedInViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomedOutViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsZoomedInViewActiveProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanChangeViewsProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsZoomOutButtonEnabledProperty { [MethodImpl] get; }
  }
}
