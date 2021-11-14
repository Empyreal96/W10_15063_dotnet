// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemMusicProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemMusicProperties : ISystemMusicProperties
  {
    public extern string AlbumArtist { [MethodImpl] get; }

    public extern string AlbumTitle { [MethodImpl] get; }

    public extern string Artist { [MethodImpl] get; }

    public extern string Composer { [MethodImpl] get; }

    public extern string Conductor { [MethodImpl] get; }

    public extern string DisplayArtist { [MethodImpl] get; }

    public extern string Genre { [MethodImpl] get; }

    public extern string TrackNumber { [MethodImpl] get; }
  }
}
