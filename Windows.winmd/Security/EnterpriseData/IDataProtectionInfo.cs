// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IDataProtectionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Guid(2216734913, 24113, 17413, 149, 64, 63, 148, 58, 240, 203, 38)]
  [ExclusiveTo(typeof (DataProtectionInfo))]
  internal interface IDataProtectionInfo
  {
    DataProtectionStatus Status { get; }

    string Identity { get; }
  }
}
