// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraViewportParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (HolographicCameraViewportParameters))]
  [Guid(2160980983, 33834, 16865, 147, 237, 86, 146, 171, 31, 187, 16)]
  internal interface IHolographicCameraViewportParameters
  {
    Vector2[] HiddenAreaMesh { get; }

    Vector2[] VisibleAreaMesh { get; }
  }
}
