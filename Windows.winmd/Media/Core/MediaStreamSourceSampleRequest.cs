// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceSampleRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaStreamSourceSampleRequest : IMediaStreamSourceSampleRequest
  {
    public extern IMediaStreamDescriptor StreamDescriptor { [MethodImpl] get; }

    [MethodImpl]
    public extern MediaStreamSourceSampleRequestDeferral GetDeferral();

    public extern MediaStreamSample Sample { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportSampleProgress(uint progress);
  }
}
