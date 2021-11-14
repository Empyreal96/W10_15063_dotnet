// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Static(typeof (IRenderTargetBitmapStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RenderTargetBitmap : ImageSource, IRenderTargetBitmap
  {
    [MethodImpl]
    public extern RenderTargetBitmap();

    public extern int PixelWidth { [MethodImpl] get; }

    public extern int PixelHeight { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("RenderAsync")]
    [MethodImpl]
    public extern IAsyncAction RenderAsync(UIElement element);

    [Overload("RenderToSizeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenderAsync(
      UIElement element,
      int scaledWidth,
      int scaledHeight);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> GetPixelsAsync();

    public static extern DependencyProperty PixelWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty PixelHeightProperty { [MethodImpl] get; }
  }
}
