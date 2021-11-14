// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerRewindReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerRewindReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2668124487, 41920, 16989, 170, 239, 151, 186, 120, 152, 177, 65)]
  internal interface IMediaPlaybackCommandManagerRewindReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
