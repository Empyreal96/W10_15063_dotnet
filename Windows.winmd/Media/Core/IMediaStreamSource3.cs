// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSource))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1781147462, 15837, 19935, 161, 33, 148, 4, 94, 207, 148, 64)]
  internal interface IMediaStreamSource3 : IMediaStreamSource, IMediaSource
  {
    IReference<double> MaxSupportedPlaybackRate { set; get; }
  }
}
