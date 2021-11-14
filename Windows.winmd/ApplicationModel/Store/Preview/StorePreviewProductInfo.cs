// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StorePreviewProductInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class StorePreviewProductInfo : IStorePreviewProductInfo
  {
    public extern string ProductId { [MethodImpl] get; }

    public extern string ProductType { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern IVectorView<StorePreviewSkuInfo> SkuInfoList { [MethodImpl] get; }
  }
}
