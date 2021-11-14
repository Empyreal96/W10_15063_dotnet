// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPlaylistPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(415704986, 44061, 13206, 148, 81, 97, 135, 91, 189, 114, 65)]
  [ExclusiveTo(typeof (PlaylistProperties))]
  internal interface IPlaylistPropertiesStatics
  {
    string Name { get; }

    string AutoDownload { get; }

    string LegacyId { get; }
  }
}
