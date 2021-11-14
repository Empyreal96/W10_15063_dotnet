// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarToolButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IInkToolbarToolButtonFactory), CompositionType.Protected, 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInkToolbarToolButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarToolButton : RadioButton, IInkToolbarToolButton
  {
    public extern InkToolbarTool ToolKind { [MethodImpl] get; }

    public extern bool IsExtensionGlyphShown { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsExtensionGlyphShownProperty { [MethodImpl] get; }
  }
}
