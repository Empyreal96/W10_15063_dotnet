// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePurchasePropertiesFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(2808673694, 65277, 18591, 154, 23, 34, 165, 147, 230, 139, 157)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StorePurchaseProperties))]
  internal interface IStorePurchasePropertiesFactory
  {
    StorePurchaseProperties Create(string name);
  }
}
