// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(601383953, 8239, 16818, 140, 91, 168, 163, 179, 51, 128, 11)]
  internal interface IBitmapSource
  {
    int PixelWidth { get; }

    int PixelHeight { get; }

    void SetSource(IRandomAccessStream streamSource);

    [RemoteAsync]
    IAsyncAction SetSourceAsync(IRandomAccessStream streamSource);
  }
}
