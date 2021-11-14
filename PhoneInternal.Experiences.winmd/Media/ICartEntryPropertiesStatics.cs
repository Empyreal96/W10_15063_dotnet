// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.ICartEntryPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(3904233572, 19772, 20447, 134, 230, 9, 152, 104, 221, 137, 45)]
  [ExclusiveTo(typeof (CartEntryProperties))]
  internal interface ICartEntryPropertiesStatics
  {
    string Name { get; }

    string MediaId { get; }

    string DownloadInstanceId { get; }

    string DownloadLicenseType { get; }

    string EncodingType { get; }

    string OfferId { get; }

    string AttemptCount { get; }

    string LastError { get; }

    string LegacyId { get; }
  }
}
