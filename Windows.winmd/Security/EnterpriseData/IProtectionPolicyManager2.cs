// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectionPolicyManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (ProtectionPolicyManager))]
  [Guid(2885112442, 33845, 16767, 153, 182, 81, 190, 175, 54, 88, 136)]
  [ContractVersion(typeof (EnterpriseDataContract), 196608)]
  internal interface IProtectionPolicyManager2
  {
    bool ShowEnterpriseIndicator { set; get; }
  }
}
