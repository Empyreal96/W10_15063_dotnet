// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaComposition2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaComposition))]
  [Guid(2778616690, 9062, 18732, 190, 200, 230, 223, 186, 109, 2, 129)]
  internal interface IMediaComposition2
  {
    IVector<MediaOverlayLayer> OverlayLayers { get; }
  }
}
