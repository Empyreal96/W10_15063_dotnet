// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3042680602, 47756, 20356, 173, 121, 46, 126, 30, 36, 80, 243)]
  [ExclusiveTo(typeof (HolographicCamera))]
  internal interface IHolographicCamera2 : IHolographicCamera
  {
    HolographicCameraViewportParameters LeftViewportParameters { get; }

    HolographicCameraViewportParameters RightViewportParameters { get; }

    HolographicDisplay Display { get; }
  }
}
