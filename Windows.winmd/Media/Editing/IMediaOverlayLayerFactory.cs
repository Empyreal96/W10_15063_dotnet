// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaOverlayLayerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (MediaOverlayLayer))]
  [Guid(2491200627, 41886, 17250, 171, 191, 159, 139, 80, 112, 160, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaOverlayLayerFactory
  {
    MediaOverlayLayer CreateWithCompositorDefinition(
      IVideoCompositorDefinition compositorDefinition);
  }
}
