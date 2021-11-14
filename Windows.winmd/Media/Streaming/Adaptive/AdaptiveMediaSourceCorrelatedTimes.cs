// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCorrelatedTimes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdaptiveMediaSourceCorrelatedTimes : IAdaptiveMediaSourceCorrelatedTimes
  {
    public extern IReference<TimeSpan> Position { [MethodImpl] get; }

    public extern IReference<TimeSpan> PresentationTimeStamp { [MethodImpl] get; }

    public extern IReference<DateTime> ProgramDateTime { [MethodImpl] get; }
  }
}
