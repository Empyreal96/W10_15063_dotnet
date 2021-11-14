// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IMusicProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (MusicProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3163204450, 26348, 16794, 188, 93, 202, 101, 164, 203, 70, 218)]
  internal interface IMusicProperties : IStorageItemExtraProperties
  {
    string Album { get; set; }

    string Artist { get; set; }

    IVector<string> Genre { get; }

    uint TrackNumber { get; set; }

    string Title { get; set; }

    uint Rating { get; set; }

    TimeSpan Duration { get; }

    uint Bitrate { get; }

    string AlbumArtist { get; set; }

    IVector<string> Composers { get; }

    IVector<string> Conductors { get; }

    string Subtitle { get; set; }

    IVector<string> Producers { get; }

    string Publisher { get; set; }

    IVector<string> Writers { get; }

    uint Year { get; set; }
  }
}
