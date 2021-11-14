// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreProductResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(3077001075, 15495, 20193, 130, 1, 244, 40, 53, 155, 211, 175)]
  [ExclusiveTo(typeof (StoreProductResult))]
  [ContractVersion(typeof (StoreContract), 65536)]
  internal interface IStoreProductResult
  {
    StoreProduct Product { get; }

    HResult ExtendedError { get; }
  }
}
