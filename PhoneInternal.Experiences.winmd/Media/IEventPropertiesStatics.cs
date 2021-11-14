// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IEventPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [ExclusiveTo(typeof (EventProperties))]
  [Guid(2028596562, 10838, 13313, 190, 39, 100, 134, 144, 143, 32, 251)]
  [Version(100859904)]
  internal interface IEventPropertiesStatics
  {
    string Name { get; }

    string PictureAlbumId { get; }

    string DateStart { get; }

    string Count { get; }

    string IsChanged { get; }

    string IsLoose { get; }

    string LegacyId { get; }
  }
}
