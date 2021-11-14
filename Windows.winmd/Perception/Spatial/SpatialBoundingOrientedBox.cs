// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialBoundingOrientedBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public struct SpatialBoundingOrientedBox
  {
    public Vector3 Center;
    public Vector3 Extents;
    public Quaternion Orientation;
  }
}
