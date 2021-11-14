// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpace
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1132518310, 24184, 17231, 128, 124, 52, 51, 209, 239, 232, 183)]
  [ExclusiveTo(typeof (HolographicSpace))]
  internal interface IHolographicSpace
  {
    HolographicAdapterId PrimaryAdapterId { get; }

    void SetDirect3D11Device(IDirect3DDevice value);

    event TypedEventHandler<HolographicSpace, HolographicSpaceCameraAddedEventArgs> CameraAdded;

    event TypedEventHandler<HolographicSpace, HolographicSpaceCameraRemovedEventArgs> CameraRemoved;

    HolographicFrame CreateNextFrame();
  }
}
