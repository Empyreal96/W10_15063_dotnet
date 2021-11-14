// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarEraserButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IInkToolbarEraserButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Static(typeof (IInkToolbarEraserButtonStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class InkToolbarEraserButton : 
    InkToolbarToolButton,
    IInkToolbarEraserButton,
    IInkToolbarEraserButton2
  {
    [MethodImpl]
    public extern InkToolbarEraserButton();

    public extern bool IsClearAllVisible { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsClearAllVisibleProperty { [MethodImpl] get; }
  }
}
