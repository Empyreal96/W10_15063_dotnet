// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductLicense))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(909314247, 11215, 19470, 143, 47, 232, 8, 170, 168, 249, 157)]
  internal interface IProductLicense
  {
    string ProductId { get; }

    bool IsActive { get; }

    DateTime ExpirationDate { get; }
  }
}
