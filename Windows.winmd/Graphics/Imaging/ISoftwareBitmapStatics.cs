// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ISoftwareBitmapStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3741550043, 26415, 19101, 128, 110, 194, 68, 47, 52, 62, 134)]
  [ExclusiveTo(typeof (SoftwareBitmap))]
  internal interface ISoftwareBitmapStatics
  {
    SoftwareBitmap Copy(SoftwareBitmap source);

    [Overload("Convert")]
    SoftwareBitmap Convert(SoftwareBitmap source, BitmapPixelFormat format);

    [Overload("ConvertWithAlpha")]
    SoftwareBitmap Convert(
      SoftwareBitmap source,
      BitmapPixelFormat format,
      BitmapAlphaMode alpha);

    [Overload("CreateCopyFromBuffer")]
    SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height);

    [Overload("CreateCopyWithAlphaFromBuffer")]
    SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    [RemoteAsync]
    [Overload("CreateCopyFromSurfaceAsync")]
    IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface);

    [Overload("CreateCopyWithAlphaFromSurfaceAsync")]
    [RemoteAsync]
    IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface,
      BitmapAlphaMode alpha);
  }
}
