// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IRenderTargetBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RenderTargetBitmap))]
  [Guid(1343090305, 35132, 19466, 143, 236, 70, 120, 172, 113, 117, 137)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRenderTargetBitmap
  {
    int PixelWidth { get; }

    int PixelHeight { get; }

    [Overload("RenderAsync")]
    [RemoteAsync]
    IAsyncAction RenderAsync(UIElement element);

    [Overload("RenderToSizeAsync")]
    [RemoteAsync]
    IAsyncAction RenderAsync(UIElement element, int scaledWidth, int scaledHeight);

    [RemoteAsync]
    IAsyncOperation<IBuffer> GetPixelsAsync();
  }
}
