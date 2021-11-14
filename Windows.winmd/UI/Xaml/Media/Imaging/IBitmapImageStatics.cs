// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImageStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (BitmapImage))]
  [Guid(2653430083, 28904, 17276, 159, 164, 44, 191, 41, 92, 255, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IBitmapImageStatics
  {
    DependencyProperty CreateOptionsProperty { get; }

    DependencyProperty UriSourceProperty { get; }

    DependencyProperty DecodePixelWidthProperty { get; }

    DependencyProperty DecodePixelHeightProperty { get; }
  }
}
