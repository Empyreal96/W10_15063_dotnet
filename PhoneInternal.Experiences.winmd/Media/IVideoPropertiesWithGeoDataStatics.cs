// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IVideoPropertiesWithGeoDataStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(4068073165, 20815, 16810, 167, 200, 35, 197, 73, 81, 55, 68)]
  [ExclusiveTo(typeof (VideoProperties))]
  internal interface IVideoPropertiesWithGeoDataStatics
  {
    string Latitude { get; }

    string Longitude { get; }

    string Altitude { get; }

    string Heading { get; }
  }
}
