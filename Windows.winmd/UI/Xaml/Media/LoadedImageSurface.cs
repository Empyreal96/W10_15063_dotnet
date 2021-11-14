// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LoadedImageSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILoadedImageSurfaceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public sealed class LoadedImageSurface : ILoadedImageSurface, IClosable, ICompositionSurface
  {
    public extern Size DecodedPhysicalSize { [MethodImpl] get; }

    public extern Size DecodedSize { [MethodImpl] get; }

    public extern Size NaturalSize { [MethodImpl] get; }

    public extern event TypedEventHandler<LoadedImageSurface, LoadedImageSourceLoadCompletedEventArgs> LoadCompleted;

    [MethodImpl]
    public extern void Close();

    [Overload("StartLoadFromUriWithSize")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromUri(
      Uri uri,
      Size desiredMaxSize);

    [Overload("StartLoadFromUri")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromUri(Uri uri);

    [Overload("StartLoadFromStreamWithSize")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromStream(
      IRandomAccessStream stream,
      Size desiredMaxSize);

    [Overload("StartLoadFromStream")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromStream(
      IRandomAccessStream stream);
  }
}
