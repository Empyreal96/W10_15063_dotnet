// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreConsumableResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(3932007282, 27136, 16466, 190, 91, 191, 218, 180, 67, 51, 82)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreConsumableResult))]
  internal interface IStoreConsumableResult
  {
    StoreConsumableStatus Status { get; }

    Guid TrackingId { get; }

    uint BalanceRemaining { get; }

    HResult ExtendedError { get; }
  }
}
