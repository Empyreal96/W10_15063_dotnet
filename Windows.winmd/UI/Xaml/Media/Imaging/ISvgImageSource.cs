// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(65130179, 3240, 19022, 141, 124, 200, 8, 160, 131, 133, 134)]
  [ExclusiveTo(typeof (SvgImageSource))]
  internal interface ISvgImageSource
  {
    Uri UriSource { get; set; }

    double RasterizePixelWidth { get; set; }

    double RasterizePixelHeight { get; set; }

    event TypedEventHandler<SvgImageSource, SvgImageSourceOpenedEventArgs> Opened;

    event TypedEventHandler<SvgImageSource, SvgImageSourceFailedEventArgs> OpenFailed;

    [RemoteAsync]
    IAsyncOperation<SvgImageSourceLoadStatus> SetSourceAsync(
      IRandomAccessStream streamSource);
  }
}
