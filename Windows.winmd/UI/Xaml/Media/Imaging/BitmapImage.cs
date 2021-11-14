// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.BitmapImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBitmapImageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBitmapImageStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBitmapImageStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBitmapImageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BitmapImage : BitmapSource, IBitmapImage, IBitmapImage2, IBitmapImage3
  {
    [MethodImpl]
    public extern BitmapImage(Uri uriSource);

    [MethodImpl]
    public extern BitmapImage();

    public extern BitmapCreateOptions CreateOptions { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri UriSource { [MethodImpl] get; [MethodImpl] set; }

    public extern int DecodePixelWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern int DecodePixelHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern event DownloadProgressEventHandler DownloadProgress;

    public extern event RoutedEventHandler ImageOpened;

    public extern event ExceptionRoutedEventHandler ImageFailed;

    public extern DecodePixelType DecodePixelType { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAnimatedBitmap { [MethodImpl] get; }

    public extern bool IsPlaying { [MethodImpl] get; }

    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Play();

    [MethodImpl]
    public extern void Stop();

    public static extern DependencyProperty IsAnimatedBitmapProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPlayingProperty { [MethodImpl] get; }

    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    public static extern DependencyProperty DecodePixelTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty CreateOptionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty UriSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty DecodePixelWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty DecodePixelHeightProperty { [MethodImpl] get; }
  }
}
