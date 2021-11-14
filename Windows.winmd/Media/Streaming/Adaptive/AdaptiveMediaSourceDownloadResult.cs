// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Streaming.Adaptive
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AdaptiveMediaSourceDownloadResult : 
    IAdaptiveMediaSourceDownloadResult,
    IAdaptiveMediaSourceDownloadResult2
  {
    public extern Uri ResourceUri { [MethodImpl] get; [MethodImpl] set; }

    public extern IInputStream InputStream { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer Buffer { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContentType { [MethodImpl] get; [MethodImpl] set; }

    public extern uint ExtendedStatus { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; [MethodImpl] set; }
  }
}
