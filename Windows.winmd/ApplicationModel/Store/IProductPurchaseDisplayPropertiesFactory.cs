// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductPurchaseDisplayPropertiesFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1867062772, 13014, 19264, 180, 116, 184, 48, 56, 164, 217, 207)]
  [ExclusiveTo(typeof (ProductPurchaseDisplayProperties))]
  internal interface IProductPurchaseDisplayPropertiesFactory
  {
    ProductPurchaseDisplayProperties CreateProductPurchaseDisplayProperties(
      string name);
  }
}
