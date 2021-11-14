// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsDisplayUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SystemMediaTransportControlsDisplayUpdater : 
    ISystemMediaTransportControlsDisplayUpdater
  {
    public extern MediaPlaybackType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern string AppMediaId { [MethodImpl] get; [MethodImpl] set; }

    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern MusicDisplayProperties MusicProperties { [MethodImpl] get; }

    public extern VideoDisplayProperties VideoProperties { [MethodImpl] get; }

    public extern ImageDisplayProperties ImageProperties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> CopyFromFileAsync(
      MediaPlaybackType type,
      StorageFile source);

    [MethodImpl]
    public extern void ClearAll();

    [MethodImpl]
    public extern void Update();
  }
}
