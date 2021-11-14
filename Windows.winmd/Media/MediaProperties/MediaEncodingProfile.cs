// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaEncodingProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.MediaProperties
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingProfileStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingProfileStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingProfileStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class MediaEncodingProfile : IMediaEncodingProfile
  {
    [MethodImpl]
    public extern MediaEncodingProfile();

    public extern AudioEncodingProperties Audio { [MethodImpl] set; [MethodImpl] get; }

    public extern VideoEncodingProperties Video { [MethodImpl] set; [MethodImpl] get; }

    public extern ContainerEncodingProperties Container { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern MediaEncodingProfile CreateAlac(
      AudioEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateFlac(
      AudioEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateHevc(
      VideoEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateWav(
      AudioEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateAvi(
      VideoEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateM4a(
      AudioEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateMp3(
      AudioEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateWma(
      AudioEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateMp4(
      VideoEncodingQuality quality);

    [MethodImpl]
    public static extern MediaEncodingProfile CreateWmv(
      VideoEncodingQuality quality);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync(
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync(
      IRandomAccessStream stream);
  }
}
