// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILoadedImageSurfaceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media
{
  [Guid(582544886, 33965, 16555, 147, 125, 72, 113, 97, 62, 118, 93)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (LoadedImageSurface))]
  internal interface ILoadedImageSurfaceStatics
  {
    [Overload("StartLoadFromUriWithSize")]
    LoadedImageSurface StartLoadFromUri(Uri uri, Size desiredMaxSize);

    [Overload("StartLoadFromUri")]
    LoadedImageSurface StartLoadFromUri(Uri uri);

    [Overload("StartLoadFromStreamWithSize")]
    LoadedImageSurface StartLoadFromStream(
      IRandomAccessStream stream,
      Size desiredMaxSize);

    [Overload("StartLoadFromStream")]
    LoadedImageSurface StartLoadFromStream(IRandomAccessStream stream);
  }
}
