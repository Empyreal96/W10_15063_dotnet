// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductListing))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1168627373, 51024, 19868, 148, 124, 176, 13, 203, 249, 233, 194)]
  internal interface IProductListing
  {
    string ProductId { get; }

    string FormattedPrice { get; }

    string Name { get; }
  }
}
