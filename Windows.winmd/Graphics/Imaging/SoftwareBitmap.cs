// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.SoftwareBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISoftwareBitmapStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (ISoftwareBitmapFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SoftwareBitmap : ISoftwareBitmap, IClosable
  {
    [MethodImpl]
    public extern SoftwareBitmap(BitmapPixelFormat format, int width, int height);

    [MethodImpl]
    public extern SoftwareBitmap(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    public extern BitmapPixelFormat BitmapPixelFormat { [MethodImpl] get; }

    public extern BitmapAlphaMode BitmapAlphaMode { [MethodImpl] get; }

    public extern int PixelWidth { [MethodImpl] get; }

    public extern int PixelHeight { [MethodImpl] get; }

    public extern bool IsReadOnly { [MethodImpl] get; }

    public extern double DpiX { [MethodImpl] set; [MethodImpl] get; }

    public extern double DpiY { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern BitmapBuffer LockBuffer(BitmapBufferAccessMode mode);

    [MethodImpl]
    public extern void CopyTo(SoftwareBitmap bitmap);

    [MethodImpl]
    public extern void CopyFromBuffer(IBuffer buffer);

    [MethodImpl]
    public extern void CopyToBuffer(IBuffer buffer);

    [MethodImpl]
    public extern SoftwareBitmap GetReadOnlyView();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public static extern SoftwareBitmap Copy(SoftwareBitmap source);

    [Overload("Convert")]
    [MethodImpl]
    public static extern SoftwareBitmap Convert(
      SoftwareBitmap source,
      BitmapPixelFormat format);

    [Overload("ConvertWithAlpha")]
    [MethodImpl]
    public static extern SoftwareBitmap Convert(
      SoftwareBitmap source,
      BitmapPixelFormat format,
      BitmapAlphaMode alpha);

    [Overload("CreateCopyFromBuffer")]
    [MethodImpl]
    public static extern SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height);

    [Overload("CreateCopyWithAlphaFromBuffer")]
    [MethodImpl]
    public static extern SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    [Overload("CreateCopyFromSurfaceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface);

    [RemoteAsync]
    [Overload("CreateCopyWithAlphaFromSurfaceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface,
      BitmapAlphaMode alpha);
  }
}
