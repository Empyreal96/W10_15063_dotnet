// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IVideoWithGeoData
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [ExclusiveTo(typeof (Video))]
  [Version(100859904)]
  [Guid(3932409218, 61477, 19989, 137, 31, 138, 153, 224, 83, 189, 162)]
  internal interface IVideoWithGeoData : IVideo, IMediaItem
  {
    int Latitude { get; set; }

    int Longitude { get; set; }

    int Heading { get; set; }

    int Altitude { get; set; }
  }
}
