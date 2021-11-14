// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerNextReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerNextReceivedEventArgs))]
  [Guid(3780133939, 41648, 17876, 185, 222, 95, 66, 172, 20, 168, 57)]
  internal interface IMediaPlaybackCommandManagerNextReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
