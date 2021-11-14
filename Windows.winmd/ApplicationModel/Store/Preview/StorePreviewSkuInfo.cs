// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StorePreviewSkuInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorePreviewSkuInfo : IStorePreviewSkuInfo
  {
    public extern string ProductId { [MethodImpl] get; }

    public extern string SkuId { [MethodImpl] get; }

    public extern string SkuType { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string CustomDeveloperData { [MethodImpl] get; }

    public extern string CurrencyCode { [MethodImpl] get; }

    public extern string FormattedListPrice { [MethodImpl] get; }

    public extern string ExtendedData { [MethodImpl] get; }
  }
}
