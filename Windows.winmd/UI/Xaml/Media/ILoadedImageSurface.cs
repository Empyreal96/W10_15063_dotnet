// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILoadedImageSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (LoadedImageSurface))]
  [Guid(84706067, 26423, 17850, 133, 49, 51, 9, 79, 235, 239, 85)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ILoadedImageSurface
  {
    Size DecodedPhysicalSize { get; }

    Size DecodedSize { get; }

    Size NaturalSize { get; }

    event TypedEventHandler<LoadedImageSurface, LoadedImageSourceLoadCompletedEventArgs> LoadCompleted;
  }
}
