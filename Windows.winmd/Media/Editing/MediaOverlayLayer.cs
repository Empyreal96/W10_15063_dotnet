// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaOverlayLayer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMediaOverlayLayerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class MediaOverlayLayer : IMediaOverlayLayer
  {
    [MethodImpl]
    public extern MediaOverlayLayer(IVideoCompositorDefinition compositorDefinition);

    [MethodImpl]
    public extern MediaOverlayLayer();

    [MethodImpl]
    public extern MediaOverlayLayer Clone();

    public extern IVector<MediaOverlay> Overlays { [MethodImpl] get; }

    public extern IVideoCompositorDefinition CustomCompositorDefinition { [MethodImpl] get; }
  }
}
