// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePackageLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(205936404, 5345, 18803, 189, 20, 247, 119, 36, 39, 30, 153)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StorePackageLicense))]
  internal interface IStorePackageLicense : IClosable
  {
    event TypedEventHandler<StorePackageLicense, object> LicenseLost;

    Package Package { get; }

    bool IsValid { get; }

    void ReleaseLicense();
  }
}
