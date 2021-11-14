// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IArtistPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(1528609404, 27936, 13155, 174, 248, 37, 114, 62, 255, 214, 27)]
  [Version(100859904)]
  [ExclusiveTo(typeof (ArtistProperties))]
  internal interface IArtistPropertiesStatics
  {
    string Name { get; }

    string MediaId { get; }

    string LegacyId { get; }
  }
}
