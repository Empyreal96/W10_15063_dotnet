﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductListing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProductListing : IProductListing, IProductListingWithMetadata, IProductListing2
  {
    public extern string ProductId { [MethodImpl] get; }

    public extern string FormattedPrice { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern IIterable<string> Keywords { [MethodImpl] get; }

    public extern ProductType ProductType { [MethodImpl] get; }

    public extern string Tag { [MethodImpl] get; }

    public extern Uri ImageUri { [MethodImpl] get; }

    public extern string FormattedBasePrice { [MethodImpl] get; }

    public extern DateTime SaleEndDate { [MethodImpl] get; }

    public extern bool IsOnSale { [MethodImpl] get; }

    public extern string CurrencyCode { [MethodImpl] get; }
  }
}
