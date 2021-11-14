// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileProtectionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (FileProtectionInfo))]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Guid(1323918470, 5246, 19920, 143, 175, 82, 83, 237, 145, 173, 12)]
  internal interface IFileProtectionInfo
  {
    FileProtectionStatus Status { get; }

    bool IsRoamable { get; }

    string Identity { get; }
  }
}
