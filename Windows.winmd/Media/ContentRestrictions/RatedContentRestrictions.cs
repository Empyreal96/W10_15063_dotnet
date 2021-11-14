// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.RatedContentRestrictions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IRatedContentRestrictionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RatedContentRestrictions : IRatedContentRestrictions
  {
    [MethodImpl]
    public extern RatedContentRestrictions(uint maxAgeRating);

    [MethodImpl]
    public extern RatedContentRestrictions();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContentRestrictionsBrowsePolicy> GetBrowsePolicyAsync();

    [MethodImpl]
    public extern IAsyncOperation<ContentAccessRestrictionLevel> GetRestrictionLevelAsync(
      RatedContentDescription RatedContentDescription);

    [MethodImpl]
    public extern IAsyncOperation<bool> RequestContentAccessAsync(
      RatedContentDescription RatedContentDescription);

    public extern event EventHandler<object> RestrictionsChanged;
  }
}
