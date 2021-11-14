// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileUnprotectOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (FileUnprotectOptions))]
  [ContractVersion(typeof (EnterpriseDataContract), 262144)]
  [Guid(2098402033, 15117, 19928, 161, 248, 30, 197, 56, 34, 226, 243)]
  internal interface IFileUnprotectOptions
  {
    bool Audit { set; get; }
  }
}
