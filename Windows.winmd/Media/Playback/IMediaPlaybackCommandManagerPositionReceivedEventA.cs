// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerPositionReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerPositionReceivedEventArgs))]
  [Guid(1435608916, 54823, 19421, 169, 13, 134, 160, 21, 178, 73, 2)]
  internal interface IMediaPlaybackCommandManagerPositionReceivedEventArgs
  {
    bool Handled { get; set; }

    TimeSpan Position { get; }

    Deferral GetDeferral();
  }
}
