// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PlaylistProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Static(typeof (IPlaylistPropertiesStatics), 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  public static class PlaylistProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string AutoDownload { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }
  }
}
