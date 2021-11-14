// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerDataReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(3344602117, 51201, 16682, 131, 91, 131, 252, 14, 98, 42, 142)]
  [ExclusiveTo(typeof (MediaPlayerDataReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerDataReceivedEventArgs
  {
    ValueSet Data { get; }
  }
}
