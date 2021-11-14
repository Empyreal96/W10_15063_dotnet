// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.ICameraIntrinsicsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [Guid(3235759238, 8498, 18996, 166, 89, 155, 254, 42, 5, 87, 18)]
  [ExclusiveTo(typeof (CameraIntrinsics))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICameraIntrinsicsFactory
  {
    CameraIntrinsics Create(
      Vector2 focalLength,
      Vector2 principalPoint,
      Vector3 radialDistortion,
      Vector2 tangentialDistortion,
      uint imageWidth,
      uint imageHeight);
  }
}
