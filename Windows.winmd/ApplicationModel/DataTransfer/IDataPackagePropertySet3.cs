// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(2659712411, 20997, 16411, 135, 74, 69, 86, 83, 189, 57, 232)]
  [ExclusiveTo(typeof (DataPackagePropertySet))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataPackagePropertySet3
  {
    string EnterpriseId { get; set; }
  }
}
