// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectedContainerExportResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Security.EnterpriseData
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProtectedContainerExportResult : IProtectedContainerExportResult
  {
    public extern ProtectedImportExportStatus Status { [MethodImpl] get; }

    public extern StorageFile File { [MethodImpl] get; }
  }
}
