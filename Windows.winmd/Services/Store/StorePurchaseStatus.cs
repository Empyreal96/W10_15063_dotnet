// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StorePurchaseStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  public enum StorePurchaseStatus
  {
    Succeeded,
    AlreadyPurchased,
    NotPurchased,
    NetworkError,
    ServerError,
  }
}
