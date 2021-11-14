// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PictureProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPicturePropertiesStatics), 100859904)]
  public static class PictureProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string Description { [MethodImpl] get; }

    public static extern string Width { [MethodImpl] get; }

    public static extern string Height { [MethodImpl] get; }

    public static extern string ThumbnailSmallPath { [MethodImpl] get; }

    public static extern string ThumbnailSmallUrl { [MethodImpl] get; }

    public static extern string ThumbnailLargePath { [MethodImpl] get; }

    public static extern string ThumbnailLargeUrl { [MethodImpl] get; }

    public static extern string ContentUrl { [MethodImpl] get; }

    public static extern string PictureAlbumId { [MethodImpl] get; }

    public static extern string StorageLocation { [MethodImpl] get; }

    public static extern string FilePath { [MethodImpl] get; }

    public static extern string FormatCode { [MethodImpl] get; }

    public static extern string Orientation { [MethodImpl] get; }

    public static extern string Latitude { [MethodImpl] get; }

    public static extern string Longitude { [MethodImpl] get; }

    public static extern string Altitude { [MethodImpl] get; }

    public static extern string Heading { [MethodImpl] get; }

    public static extern string CreationTime { [MethodImpl] get; }

    public static extern string RemoteId { [MethodImpl] get; }

    public static extern string CaptureAppId { [MethodImpl] get; }

    public static extern string Rating { [MethodImpl] get; }

    public static extern string PersistentUniqueId { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }

    public static extern string IsAcquiredItem { [MethodImpl] get; }
  }
}
