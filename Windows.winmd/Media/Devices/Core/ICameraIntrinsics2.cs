// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.ICameraIntrinsics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [Guid(215655495, 1944, 19277, 131, 159, 197, 236, 65, 77, 178, 122)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CameraIntrinsics))]
  internal interface ICameraIntrinsics2
  {
    Matrix4x4 UndistortedProjectionTransform { get; }

    Point DistortPoint(Point input);

    void DistortPoints(Point[] inputs, [Out] Point[] results);

    Point UndistortPoint(Point input);

    void UndistortPoints(Point[] inputs, [Out] Point[] results);
  }
}
