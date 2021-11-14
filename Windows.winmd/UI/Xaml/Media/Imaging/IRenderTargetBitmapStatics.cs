// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IRenderTargetBitmapStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [Guid(4037144558, 49457, 19776, 156, 71, 247, 215, 207, 43, 7, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RenderTargetBitmap))]
  internal interface IRenderTargetBitmapStatics
  {
    DependencyProperty PixelWidthProperty { get; }

    DependencyProperty PixelHeightProperty { get; }
  }
}
