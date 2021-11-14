// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialLocation))]
  [Guid(495047325, 9377, 14293, 143, 161, 57, 180, 249, 173, 103, 226)]
  internal interface ISpatialLocation
  {
    Vector3 Position { get; }

    Quaternion Orientation { get; }

    Vector3 AbsoluteLinearVelocity { get; }

    Vector3 AbsoluteLinearAcceleration { get; }

    Quaternion AbsoluteAngularVelocity { get; }

    Quaternion AbsoluteAngularAcceleration { get; }
  }
}
