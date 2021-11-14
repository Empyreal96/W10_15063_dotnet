// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.CompositeVideoFrameContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Editing;

namespace Windows.Media.Effects
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class CompositeVideoFrameContext : ICompositeVideoFrameContext
  {
    public extern IVectorView<IDirect3DSurface> SurfacesToOverlay { [MethodImpl] get; }

    public extern VideoFrame BackgroundFrame { [MethodImpl] get; }

    public extern VideoFrame OutputFrame { [MethodImpl] get; }

    [MethodImpl]
    public extern MediaOverlay GetOverlayForSurface(IDirect3DSurface surfaceToOverlay);
  }
}
