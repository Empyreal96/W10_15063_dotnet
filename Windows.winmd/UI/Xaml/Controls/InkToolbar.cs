// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IInkToolbarStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Children")]
  [Composable(typeof (IInkToolbarFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInkToolbarStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class InkToolbar : Control, IInkToolbar, IInkToolbar2
  {
    [MethodImpl]
    public extern InkToolbar();

    public extern InkToolbarInitialControls InitialControls { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObjectCollection Children { [MethodImpl] get; }

    public extern InkToolbarToolButton ActiveTool { [MethodImpl] get; [MethodImpl] set; }

    public extern InkDrawingAttributes InkDrawingAttributes { [MethodImpl] get; }

    public extern bool IsRulerButtonChecked { [MethodImpl] get; [MethodImpl] set; }

    public extern InkCanvas TargetInkCanvas { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<InkToolbar, object> ActiveToolChanged;

    public extern event TypedEventHandler<InkToolbar, object> InkDrawingAttributesChanged;

    public extern event TypedEventHandler<InkToolbar, object> EraseAllClicked;

    public extern event TypedEventHandler<InkToolbar, object> IsRulerButtonCheckedChanged;

    [MethodImpl]
    public extern InkToolbarToolButton GetToolButton(InkToolbarTool tool);

    [MethodImpl]
    public extern InkToolbarToggleButton GetToggleButton(InkToolbarToggle tool);

    public extern bool IsStencilButtonChecked { [MethodImpl] get; [MethodImpl] set; }

    public extern InkToolbarButtonFlyoutPlacement ButtonFlyoutPlacement { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<InkToolbar, InkToolbarIsStencilButtonCheckedChangedEventArgs> IsStencilButtonCheckedChanged;

    [MethodImpl]
    public extern InkToolbarMenuButton GetMenuButton(InkToolbarMenuKind menu);

    public static extern DependencyProperty IsStencilButtonCheckedProperty { [MethodImpl] get; }

    public static extern DependencyProperty ButtonFlyoutPlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty InitialControlsProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }

    public static extern DependencyProperty ActiveToolProperty { [MethodImpl] get; }

    public static extern DependencyProperty InkDrawingAttributesProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsRulerButtonCheckedProperty { [MethodImpl] get; }

    public static extern DependencyProperty TargetInkCanvasProperty { [MethodImpl] get; }
  }
}
