// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioTrackSupportInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(395046903, 52281, 17574, 185, 81, 74, 86, 83, 240, 115, 250)]
  [ExclusiveTo(typeof (AudioTrackSupportInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioTrackSupportInfo
  {
    MediaDecoderStatus DecoderStatus { get; }

    AudioDecoderDegradation Degradation { get; }

    AudioDecoderDegradationReason DegradationReason { get; }

    MediaSourceStatus MediaSourceStatus { get; }
  }
}
