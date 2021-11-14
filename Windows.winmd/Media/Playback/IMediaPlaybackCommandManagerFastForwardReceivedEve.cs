// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerFastForwardReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerFastForwardReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(821060825, 46225, 19722, 188, 33, 48, 152, 189, 19, 50, 233)]
  internal interface IMediaPlaybackCommandManagerFastForwardReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
