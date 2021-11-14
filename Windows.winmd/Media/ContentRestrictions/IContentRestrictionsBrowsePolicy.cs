// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IContentRestrictionsBrowsePolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [Guid(2348888996, 17454, 17946, 135, 87, 250, 210, 245, 189, 55, 228)]
  [ExclusiveTo(typeof (ContentRestrictionsBrowsePolicy))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentRestrictionsBrowsePolicy
  {
    string GeographicRegion { get; }

    IReference<uint> MaxBrowsableAgeRating { get; }

    IReference<uint> PreferredAgeRating { get; }
  }
}
