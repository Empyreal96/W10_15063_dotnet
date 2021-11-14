// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPictureAlbumPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(3167225924, 27122, 12657, 144, 45, 255, 64, 118, 109, 79, 189)]
  [ExclusiveTo(typeof (PictureAlbumProperties))]
  internal interface IPictureAlbumPropertiesStatics
  {
    string Name { get; }

    string ParentPictureAlbumId { get; }

    string CoverPictureId { get; }

    string CoverImagePath { get; }

    string CoverImageUrl { get; }

    string RemoteId { get; }

    string CreationTime { get; }

    string RequiresAuthentication { get; }

    string PictureAlbumType { get; }

    string RevisionStamp { get; }

    string LastModifiedTime { get; }

    string LegacyId { get; }
  }
}
