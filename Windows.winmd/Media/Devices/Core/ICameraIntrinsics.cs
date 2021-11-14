// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.ICameraIntrinsics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(178711858, 25993, 18906, 175, 222, 89, 66, 112, 202, 10, 172)]
  [ExclusiveTo(typeof (CameraIntrinsics))]
  internal interface ICameraIntrinsics
  {
    Vector2 FocalLength { get; }

    Vector2 PrincipalPoint { get; }

    Vector3 RadialDistortion { get; }

    Vector2 TangentialDistortion { get; }

    uint ImageWidth { get; }

    uint ImageHeight { get; }

    Point ProjectOntoFrame(Vector3 coordinate);

    Vector2 UnprojectAtUnitDepth(Point pixelCoordinate);

    void ProjectManyOntoFrame(Vector3[] coordinates, [Out] Point[] results);

    void UnprojectPixelsAtUnitDepth(Point[] pixelCoordinates, [Out] Vector2[] results);
  }
}
