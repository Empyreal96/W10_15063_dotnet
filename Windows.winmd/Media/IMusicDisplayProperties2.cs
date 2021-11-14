// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMusicDisplayProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(3572834, 38867, 17593, 176, 15, 0, 138, 252, 239, 175, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MusicDisplayProperties))]
  internal interface IMusicDisplayProperties2
  {
    string AlbumTitle { get; set; }

    uint TrackNumber { get; set; }

    IVector<string> Genres { get; }
  }
}
