// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Package
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IPackageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Package : 
    IPackage,
    IPackage2,
    IPackage3,
    IPackageWithMetadata,
    IPackage4,
    IPackage5
  {
    public extern PackageId Id { [MethodImpl] get; }

    public extern StorageFolder InstalledLocation { [MethodImpl] get; }

    public extern bool IsFramework { [MethodImpl] get; }

    public extern IVectorView<Package> Dependencies { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string PublisherDisplayName { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern Uri Logo { [MethodImpl] get; }

    public extern bool IsResourcePackage { [MethodImpl] get; }

    public extern bool IsBundle { [MethodImpl] get; }

    public extern bool IsDevelopmentMode { [MethodImpl] get; }

    public extern PackageStatus Status { [MethodImpl] get; }

    public extern DateTime InstalledDate { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppListEntry>> GetAppListEntriesAsync();

    public extern DateTime InstallDate { [MethodImpl] get; }

    [MethodImpl]
    public extern string GetThumbnailToken();

    [Deprecated("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Launch(string parameters);

    public extern PackageSignatureKind SignatureKind { [MethodImpl] get; }

    public extern bool IsOptional { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> VerifyContentIntegrityAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<PackageContentGroup>> GetContentGroupsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageContentGroup> GetContentGroupAsync(
      string name);

    [Overload("StageContentGroupsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names);

    [Overload("StageContentGroupsWithPriorityAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names,
      bool moveToHeadOfQueue);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SetInUseAsync(bool inUse);

    public static extern Package Current { [MethodImpl] get; }
  }
}
