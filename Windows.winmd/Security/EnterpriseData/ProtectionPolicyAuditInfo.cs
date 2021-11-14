// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [Activatable(typeof (IProtectionPolicyAuditInfoFactory), 196608, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [ContractVersion(typeof (EnterpriseDataContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProtectionPolicyAuditInfo : IProtectionPolicyAuditInfo
  {
    [MethodImpl]
    public extern ProtectionPolicyAuditInfo(
      ProtectionPolicyAuditAction action,
      string dataDescription,
      string sourceDescription,
      string targetDescription);

    [MethodImpl]
    public extern ProtectionPolicyAuditInfo(
      ProtectionPolicyAuditAction action,
      string dataDescription);

    public extern ProtectionPolicyAuditAction Action { [MethodImpl] set; [MethodImpl] get; }

    public extern string DataDescription { [MethodImpl] set; [MethodImpl] get; }

    public extern string SourceDescription { [MethodImpl] set; [MethodImpl] get; }

    public extern string TargetDescription { [MethodImpl] set; [MethodImpl] get; }
  }
}
