// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [Guid(833565297, 58292, 17453, 163, 65, 76, 2, 38, 178, 114, 91)]
  [ExclusiveTo(typeof (BitmapImage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapImage
  {
    BitmapCreateOptions CreateOptions { get; set; }

    Uri UriSource { get; set; }

    int DecodePixelWidth { get; set; }

    int DecodePixelHeight { get; set; }

    event DownloadProgressEventHandler DownloadProgress;

    event RoutedEventHandler ImageOpened;

    event ExceptionRoutedEventHandler ImageFailed;
  }
}
