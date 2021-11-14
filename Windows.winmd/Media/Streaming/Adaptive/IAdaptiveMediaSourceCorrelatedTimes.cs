// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceCorrelatedTimes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(84969351, 57394, 18657, 171, 141, 0, 43, 11, 48, 81, 223)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceCorrelatedTimes))]
  internal interface IAdaptiveMediaSourceCorrelatedTimes
  {
    IReference<TimeSpan> Position { get; }

    IReference<TimeSpan> PresentationTimeStamp { get; }

    IReference<DateTime> ProgramDateTime { get; }
  }
}
