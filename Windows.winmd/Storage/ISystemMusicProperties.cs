// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemMusicProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemMusicProperties))]
  [Guid(3027863765, 26543, 19395, 141, 57, 91, 137, 2, 32, 38, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMusicProperties
  {
    string AlbumArtist { get; }

    string AlbumTitle { get; }

    string Artist { get; }

    string Composer { get; }

    string Conductor { get; }

    string DisplayArtist { get; }

    string Genre { get; }

    string TrackNumber { get; }
  }
}
