// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaBindingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaBindingEventArgs : IMediaBindingEventArgs, IMediaBindingEventArgs2
  {
    public extern event TypedEventHandler<MediaBindingEventArgs, object> Canceled;

    public extern MediaBinder MediaBinder { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();

    [MethodImpl]
    public extern void SetUri(Uri uri);

    [MethodImpl]
    public extern void SetStream(IRandomAccessStream stream, string contentType);

    [MethodImpl]
    public extern void SetStreamReference(IRandomAccessStreamReference stream, string contentType);

    [MethodImpl]
    public extern void SetAdaptiveMediaSource(AdaptiveMediaSource mediaSource);

    [MethodImpl]
    public extern void SetStorageFile(IStorageFile file);
  }
}
