// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMusicDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1807682649, 53408, 19750, 146, 160, 249, 120, 225, 209, 142, 123)]
  [ExclusiveTo(typeof (MusicDisplayProperties))]
  internal interface IMusicDisplayProperties
  {
    string Title { get; set; }

    string AlbumArtist { get; set; }

    string Artist { get; set; }
  }
}
