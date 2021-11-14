// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.CameraIntrinsics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CameraIntrinsics : ICameraIntrinsics, ICameraIntrinsics2
  {
    public extern Vector2 FocalLength { [MethodImpl] get; }

    public extern Vector2 PrincipalPoint { [MethodImpl] get; }

    public extern Vector3 RadialDistortion { [MethodImpl] get; }

    public extern Vector2 TangentialDistortion { [MethodImpl] get; }

    public extern uint ImageWidth { [MethodImpl] get; }

    public extern uint ImageHeight { [MethodImpl] get; }

    [MethodImpl]
    public extern Point ProjectOntoFrame(Vector3 coordinate);

    [MethodImpl]
    public extern Vector2 UnprojectAtUnitDepth(Point pixelCoordinate);

    [MethodImpl]
    public extern void ProjectManyOntoFrame(Vector3[] coordinates, [Out] Point[] results);

    [MethodImpl]
    public extern void UnprojectPixelsAtUnitDepth(Point[] pixelCoordinates, [Out] Vector2[] results);

    public extern Matrix4x4 UndistortedProjectionTransform { [MethodImpl] get; }

    [MethodImpl]
    public extern Point DistortPoint(Point input);

    [MethodImpl]
    public extern void DistortPoints(Point[] inputs, [Out] Point[] results);

    [MethodImpl]
    public extern Point UndistortPoint(Point input);

    [MethodImpl]
    public extern void UndistortPoints(Point[] inputs, [Out] Point[] results);
  }
}
