// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarMenuButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInkToolbarMenuButtonStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarMenuButtonFactory), CompositionType.Protected, 262144, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarMenuButton : ToggleButton, IInkToolbarMenuButton
  {
    public extern InkToolbarMenuKind MenuKind { [MethodImpl] get; }

    public extern bool IsExtensionGlyphShown { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsExtensionGlyphShownProperty { [MethodImpl] get; }
  }
}
