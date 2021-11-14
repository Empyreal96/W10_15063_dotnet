// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StoreLicense : IStoreLicense
  {
    public extern string SkuStoreId { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; }

    public extern DateTime ExpirationDate { [MethodImpl] get; }

    public extern string ExtendedJsonData { [MethodImpl] get; }

    public extern string InAppOfferToken { [MethodImpl] get; }
  }
}
