// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Image
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;
using Windows.Media.PlayTo;
using Windows.UI.Composition;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IImageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class Image : FrameworkElement, IImage, IImage2, IImage3
  {
    [MethodImpl]
    public extern Image();

    public extern ImageSource Source { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness NineGrid { [MethodImpl] get; [MethodImpl] set; }

    public extern PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern event ExceptionRoutedEventHandler ImageFailed;

    public extern event RoutedEventHandler ImageOpened;

    [MethodImpl]
    public extern CastingSource GetAsCastingSource();

    [MethodImpl]
    public extern CompositionBrush GetAlphaMask();

    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty NineGridProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
