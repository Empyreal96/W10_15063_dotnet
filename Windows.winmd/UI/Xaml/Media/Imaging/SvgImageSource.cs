// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.SvgImageSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Static(typeof (ISvgImageSourceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ISvgImageSourceFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class SvgImageSource : ImageSource, ISvgImageSource
  {
    [MethodImpl]
    public extern SvgImageSource();

    [MethodImpl]
    public extern SvgImageSource(Uri uriSource);

    public extern Uri UriSource { [MethodImpl] get; [MethodImpl] set; }

    public extern double RasterizePixelWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double RasterizePixelHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<SvgImageSource, SvgImageSourceOpenedEventArgs> Opened;

    public extern event TypedEventHandler<SvgImageSource, SvgImageSourceFailedEventArgs> OpenFailed;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SvgImageSourceLoadStatus> SetSourceAsync(
      IRandomAccessStream streamSource);

    public static extern DependencyProperty UriSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty RasterizePixelWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty RasterizePixelHeightProperty { [MethodImpl] get; }
  }
}
