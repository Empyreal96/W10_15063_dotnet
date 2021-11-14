// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IGenrePropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(2593119464, 54190, 12512, 173, 44, 112, 170, 60, 45, 216, 32)]
  [Version(100859904)]
  [ExclusiveTo(typeof (GenreProperties))]
  internal interface IGenrePropertiesStatics
  {
    string Name { get; }

    string Count { get; }

    string LegacyId { get; }
  }
}
