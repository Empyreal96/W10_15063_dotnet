// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PictureAlbumProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPictureAlbumPropertiesStatics), 100859904)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public static class PictureAlbumProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string ParentPictureAlbumId { [MethodImpl] get; }

    public static extern string CoverPictureId { [MethodImpl] get; }

    public static extern string CoverImagePath { [MethodImpl] get; }

    public static extern string CoverImageUrl { [MethodImpl] get; }

    public static extern string RemoteId { [MethodImpl] get; }

    public static extern string CreationTime { [MethodImpl] get; }

    public static extern string RequiresAuthentication { [MethodImpl] get; }

    public static extern string PictureAlbumType { [MethodImpl] get; }

    public static extern string RevisionStamp { [MethodImpl] get; }

    public static extern string LastModifiedTime { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }
  }
}
