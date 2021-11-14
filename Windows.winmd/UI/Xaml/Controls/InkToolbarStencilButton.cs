// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarStencilButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Static(typeof (IInkToolbarStencilButtonStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IInkToolbarStencilButtonFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public class InkToolbarStencilButton : InkToolbarMenuButton, IInkToolbarStencilButton
  {
    [MethodImpl]
    public extern InkToolbarStencilButton();

    public extern InkPresenterRuler Ruler { [MethodImpl] get; }

    public extern InkPresenterProtractor Protractor { [MethodImpl] get; }

    public extern InkToolbarStencilKind SelectedStencil { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRulerItemVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsProtractorItemVisible { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty RulerProperty { [MethodImpl] get; }

    public static extern DependencyProperty ProtractorProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedStencilProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsRulerItemVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsProtractorItemVisibleProperty { [MethodImpl] get; }
  }
}
