// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileProtectionManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 262144)]
  [Guid(1763214490, 25167, 18134, 178, 65, 233, 205, 95, 223, 62, 63)]
  [ExclusiveTo(typeof (FileProtectionManager))]
  internal interface IFileProtectionManagerStatics3
  {
    [Overload("UnprotectAsync")]
    [RemoteAsync]
    IAsyncOperation<FileProtectionInfo> UnprotectAsync(
      IStorageItem target);

    [Overload("UnprotectWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<FileProtectionInfo> UnprotectAsync(
      IStorageItem target,
      FileUnprotectOptions options);
  }
}
