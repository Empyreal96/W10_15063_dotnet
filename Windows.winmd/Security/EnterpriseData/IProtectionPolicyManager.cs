// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (ProtectionPolicyManager))]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Guid(3580902936, 41101, 18406, 162, 64, 153, 52, 215, 22, 94, 181)]
  internal interface IProtectionPolicyManager
  {
    string Identity { set; get; }
  }
}
