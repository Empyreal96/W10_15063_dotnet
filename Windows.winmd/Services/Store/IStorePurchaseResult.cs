﻿// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePurchaseResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StorePurchaseResult))]
  [Guid(2916255058, 63850, 17981, 167, 187, 194, 11, 79, 202, 105, 82)]
  [ContractVersion(typeof (StoreContract), 65536)]
  internal interface IStorePurchaseResult
  {
    StorePurchaseStatus Status { get; }

    HResult ExtendedError { get; }
  }
}
