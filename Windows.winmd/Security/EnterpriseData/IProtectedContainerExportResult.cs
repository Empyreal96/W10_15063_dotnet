// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectedContainerExportResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (ProtectedContainerExportResult))]
  [Guid(961081237, 63483, 19266, 175, 176, 223, 112, 180, 21, 67, 193)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  internal interface IProtectedContainerExportResult
  {
    ProtectedImportExportStatus Status { get; }

    StorageFile File { get; }
  }
}
