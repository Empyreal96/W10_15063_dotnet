// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerInteractionSourcePose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialPointerInteractionSourcePose))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2802860807, 11307, 19770, 146, 167, 128, 206, 215, 196, 160, 208)]
  internal interface ISpatialPointerInteractionSourcePose
  {
    Vector3 Position { get; }

    Vector3 ForwardDirection { get; }

    Vector3 UpDirection { get; }
  }
}
