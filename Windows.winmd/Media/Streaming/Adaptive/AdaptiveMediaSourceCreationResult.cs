// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdaptiveMediaSourceCreationResult : 
    IAdaptiveMediaSourceCreationResult,
    IAdaptiveMediaSourceCreationResult2
  {
    public extern AdaptiveMediaSourceCreationStatus Status { [MethodImpl] get; }

    public extern AdaptiveMediaSource MediaSource { [MethodImpl] get; }

    public extern HttpResponseMessage HttpResponseMessage { [MethodImpl] get; }

    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
