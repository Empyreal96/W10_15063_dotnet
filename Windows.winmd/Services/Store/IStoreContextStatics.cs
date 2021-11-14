// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreContextStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreContext))]
  [Guid(2617699935, 5568, 20082, 147, 48, 214, 25, 28, 235, 209, 156)]
  internal interface IStoreContextStatics
  {
    StoreContext GetDefault();

    StoreContext GetForUser(User user);
  }
}
