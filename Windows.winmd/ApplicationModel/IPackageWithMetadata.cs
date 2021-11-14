// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageWithMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (Package))]
  [Guid(2509543296, 7657, 16626, 180, 82, 13, 233, 241, 145, 0, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageWithMetadata
  {
    DateTime InstallDate { get; }

    string GetThumbnailToken();

    [Deprecated("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void Launch(string parameters);
  }
}
