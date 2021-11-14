// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyAuditInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 196608)]
  [ExclusiveTo(typeof (ProtectionPolicyAuditInfo))]
  [Guid(1113241572, 65207, 17660, 179, 187, 195, 196, 215, 236, 190, 187)]
  internal interface IProtectionPolicyAuditInfo
  {
    ProtectionPolicyAuditAction Action { set; get; }

    string DataDescription { set; get; }

    string SourceDescription { set; get; }

    string TargetDescription { set; get; }
  }
}
