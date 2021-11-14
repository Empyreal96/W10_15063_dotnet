// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorRawCoordinateSystemAdjustedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialAnchorRawCoordinateSystemAdjustedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2716343992, 22215, 12567, 162, 228, 129, 224, 252, 242, 142, 0)]
  internal interface ISpatialAnchorRawCoordinateSystemAdjustedEventArgs
  {
    Matrix4x4 OldRawCoordinateSystemToNewRawCoordinateSystemTransform { get; }
  }
}
