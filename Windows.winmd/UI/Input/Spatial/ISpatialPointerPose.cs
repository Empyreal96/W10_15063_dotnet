// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerPose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.People;

namespace Windows.UI.Input.Spatial
{
  [Guid(1767089198, 49534, 13693, 151, 161, 114, 105, 208, 237, 45, 16)]
  [ExclusiveTo(typeof (SpatialPointerPose))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialPointerPose
  {
    PerceptionTimestamp Timestamp { get; }

    HeadPose Head { get; }
  }
}
