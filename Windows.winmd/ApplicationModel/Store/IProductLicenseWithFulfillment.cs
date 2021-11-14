// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductLicenseWithFulfillment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductLicense))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4233321610, 63079, 16627, 186, 60, 4, 90, 99, 171, 179, 172)]
  internal interface IProductLicenseWithFulfillment : IProductLicense
  {
    bool IsConsumable { get; }
  }
}
