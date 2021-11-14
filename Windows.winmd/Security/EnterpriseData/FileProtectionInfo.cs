// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.FileProtectionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class FileProtectionInfo : IFileProtectionInfo
  {
    public extern FileProtectionStatus Status { [MethodImpl] get; }

    public extern bool IsRoamable { [MethodImpl] get; }

    public extern string Identity { [MethodImpl] get; }
  }
}
