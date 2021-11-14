// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.FileUnprotectOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [Activatable(typeof (IFileUnprotectOptionsFactory), 262144, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [ContractVersion(typeof (EnterpriseDataContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FileUnprotectOptions : IFileUnprotectOptions
  {
    [MethodImpl]
    public extern FileUnprotectOptions(bool audit);

    public extern bool Audit { [MethodImpl] set; [MethodImpl] get; }
  }
}
