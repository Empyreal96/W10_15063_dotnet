// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraRenderingParameters2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (HolographicCameraRenderingParameters))]
  [Guid(638742755, 46742, 17972, 148, 214, 190, 6, 129, 100, 53, 153)]
  internal interface IHolographicCameraRenderingParameters2 : IHolographicCameraRenderingParameters
  {
    HolographicReprojectionMode ReprojectionMode { get; set; }

    void CommitDirect3D11DepthBuffer(IDirect3DSurface value);
  }
}
