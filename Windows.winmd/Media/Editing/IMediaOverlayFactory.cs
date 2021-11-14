// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaOverlayFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Editing
{
  [Guid(3045360266, 24968, 20367, 162, 224, 170, 85, 45, 89, 142, 24)]
  [ExclusiveTo(typeof (MediaOverlay))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaOverlayFactory
  {
    MediaOverlay Create(MediaClip clip);

    MediaOverlay CreateWithPositionAndOpacity(
      MediaClip clip,
      Rect position,
      double opacity);
  }
}
