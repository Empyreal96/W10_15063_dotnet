// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.IPrepareTranscodeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Transcoding
{
  [ExclusiveTo(typeof (PrepareTranscodeResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(99769806, 39247, 18996, 157, 104, 151, 204, 206, 23, 48, 214)]
  internal interface IPrepareTranscodeResult
  {
    bool CanTranscode { get; }

    TranscodeFailureReason FailureReason { get; }

    [RemoteAsync]
    IAsyncActionWithProgress<double> TranscodeAsync();
  }
}
