// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocation
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialLocation : ISpatialLocation
  {
    public extern Vector3 Position { [MethodImpl] get; }

    public extern Quaternion Orientation { [MethodImpl] get; }

    public extern Vector3 AbsoluteLinearVelocity { [MethodImpl] get; }

    public extern Vector3 AbsoluteLinearAcceleration { [MethodImpl] get; }

    public extern Quaternion AbsoluteAngularVelocity { [MethodImpl] get; }

    public extern Quaternion AbsoluteAngularAcceleration { [MethodImpl] get; }
  }
}
