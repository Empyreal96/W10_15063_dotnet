// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreProductQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(3624265413, 54358, 20470, 128, 73, 144, 118, 213, 22, 95, 115)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreProductQueryResult))]
  internal interface IStoreProductQueryResult
  {
    IMapView<string, StoreProduct> Products { get; }

    HResult ExtendedError { get; }
  }
}
