// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.PrepareTranscodeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Transcoding
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrepareTranscodeResult : IPrepareTranscodeResult
  {
    public extern bool CanTranscode { [MethodImpl] get; }

    public extern TranscodeFailureReason FailureReason { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<double> TranscodeAsync();
  }
}
