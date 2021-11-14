// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileProtectionManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [Guid(2211620677, 1155, 16811, 178, 213, 188, 127, 35, 215, 78, 187)]
  [ContractVersion(typeof (EnterpriseDataContract), 131072)]
  [ExclusiveTo(typeof (FileProtectionManager))]
  internal interface IFileProtectionManagerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsContainerAsync(IStorageFile file);

    [Overload("LoadFileFromContainerWithTargetAndNameCollisionOptionAsync")]
    [RemoteAsync]
    [DefaultOverload]
    IAsyncOperation<ProtectedContainerImportResult> LoadFileFromContainerAsync(
      IStorageFile containerFile,
      IStorageItem target,
      NameCollisionOption collisionOption);

    [Overload("SaveFileAsContainerWithSharingAsync")]
    [RemoteAsync]
    [DefaultOverload]
    IAsyncOperation<ProtectedContainerExportResult> SaveFileAsContainerAsync(
      IStorageFile protectedFile,
      IIterable<string> sharedWithIdentities);
  }
}
