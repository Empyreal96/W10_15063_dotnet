// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentRestrictions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RatedContentRestrictions))]
  [Guid(1065296843, 47623, 17409, 164, 157, 139, 146, 34, 32, 87, 35)]
  internal interface IRatedContentRestrictions
  {
    [RemoteAsync]
    IAsyncOperation<ContentRestrictionsBrowsePolicy> GetBrowsePolicyAsync();

    IAsyncOperation<ContentAccessRestrictionLevel> GetRestrictionLevelAsync(
      RatedContentDescription RatedContentDescription);

    IAsyncOperation<bool> RequestContentAccessAsync(
      RatedContentDescription RatedContentDescription);

    event EventHandler<object> RestrictionsChanged;
  }
}
