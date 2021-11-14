// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoTrackSupportInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (VideoTrackSupportInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1270166688, 64607, 17677, 143, 240, 119, 141, 89, 4, 134, 222)]
  internal interface IVideoTrackSupportInfo
  {
    MediaDecoderStatus DecoderStatus { get; }

    MediaSourceStatus MediaSourceStatus { get; }
  }
}
