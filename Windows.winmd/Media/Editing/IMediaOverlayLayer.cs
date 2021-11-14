// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaOverlayLayer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (MediaOverlayLayer))]
  [Guid(2799286871, 61146, 18118, 187, 229, 227, 152, 200, 65, 104, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaOverlayLayer
  {
    MediaOverlayLayer Clone();

    IVector<MediaOverlay> Overlays { get; }

    IVideoCompositorDefinition CustomCompositorDefinition { get; }
  }
}
