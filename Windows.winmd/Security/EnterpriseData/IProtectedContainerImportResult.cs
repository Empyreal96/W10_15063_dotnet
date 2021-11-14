// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectedContainerImportResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [ExclusiveTo(typeof (ProtectedContainerImportResult))]
  [Guid(3451355345, 59323, 19738, 147, 57, 52, 220, 65, 20, 159, 155)]
  internal interface IProtectedContainerImportResult
  {
    ProtectedImportExportStatus Status { get; }

    StorageFile File { get; }
  }
}
