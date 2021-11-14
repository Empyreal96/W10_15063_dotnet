// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IFileUnprotectOptionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [ExclusiveTo(typeof (FileUnprotectOptions))]
  [ContractVersion(typeof (EnterpriseDataContract), 262144)]
  [Guid(1370403740, 55948, 19519, 155, 251, 203, 115, 167, 204, 224, 221)]
  internal interface IFileUnprotectOptionsFactory
  {
    FileUnprotectOptions Create(bool audit);
  }
}
