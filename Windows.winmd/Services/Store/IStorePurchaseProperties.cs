// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePurchaseProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StorePurchaseProperties))]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(2204268787, 65415, 17252, 165, 180, 253, 33, 83, 235, 228, 59)]
  internal interface IStorePurchaseProperties
  {
    string Name { get; set; }

    string ExtendedJsonData { get; set; }
  }
}
