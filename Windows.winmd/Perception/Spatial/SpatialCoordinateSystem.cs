// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialCoordinateSystem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialCoordinateSystem : ISpatialCoordinateSystem
  {
    [MethodImpl]
    public extern IReference<Matrix4x4> TryGetTransformTo(
      SpatialCoordinateSystem target);
  }
}
