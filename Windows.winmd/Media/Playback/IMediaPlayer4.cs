// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(2147704240, 29768, 18288, 175, 207, 42, 87, 69, 9, 20, 197)]
  internal interface IMediaPlayer4
  {
    void SetSurfaceSize(Size size);

    MediaPlayerSurface GetSurface(Compositor compositor);
  }
}
