// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IAlbumPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [ExclusiveTo(typeof (AlbumProperties))]
  [Version(100859904)]
  [Guid(2026186012, 50898, 16028, 191, 23, 122, 243, 122, 58, 72, 13)]
  internal interface IAlbumPropertiesStatics
  {
    string Name { get; }

    string Date { get; }

    string ArtistId { get; }

    string ArtistName { get; }

    string MediaId { get; }

    string LegacyId { get; }
  }
}
