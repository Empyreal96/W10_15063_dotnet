// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductPurchaseDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProductPurchaseDisplayProperties))]
  [Guid(3607852064, 48274, 16411, 168, 9, 201, 178, 229, 219, 189, 175)]
  internal interface IProductPurchaseDisplayProperties
  {
    string Name { get; set; }

    string Description { get; set; }

    Uri Image { get; set; }
  }
}
