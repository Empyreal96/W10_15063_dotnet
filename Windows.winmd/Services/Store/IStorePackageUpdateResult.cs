// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePackageUpdateResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StorePackageUpdateResult))]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(3885056749, 25081, 18579, 180, 254, 207, 25, 22, 3, 175, 123)]
  internal interface IStorePackageUpdateResult
  {
    StorePackageUpdateState OverallState { get; }

    IVectorView<StorePackageUpdateStatus> StorePackageUpdateStatuses { get; }
  }
}
