// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionDepthFrameSourcePropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(1576127650, 504, 19079, 184, 89, 213, 229, 183, 225, 222, 74)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (KnownPerceptionDepthFrameSourceProperties))]
  internal interface IKnownPerceptionDepthFrameSourcePropertiesStatics
  {
    string MinDepth { [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string MaxDepth { [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
