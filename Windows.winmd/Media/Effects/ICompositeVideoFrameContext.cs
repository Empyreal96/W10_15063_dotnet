// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.ICompositeVideoFrameContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Editing;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CompositeVideoFrameContext))]
  [Guid(1815085643, 62740, 17016, 165, 247, 185, 24, 128, 73, 209, 16)]
  internal interface ICompositeVideoFrameContext
  {
    IVectorView<IDirect3DSurface> SurfacesToOverlay { get; }

    VideoFrame BackgroundFrame { get; }

    VideoFrame OutputFrame { get; }

    MediaOverlay GetOverlayForSurface(IDirect3DSurface surfaceToOverlay);
  }
}
