// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionColorFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception
{
  [Guid(4267840841, 11455, 20372, 152, 97, 248, 23, 234, 49, 119, 71)]
  [ExclusiveTo(typeof (PerceptionColorFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionColorFrame : IClosable
  {
    VideoFrame VideoFrame { [Deprecated("PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
