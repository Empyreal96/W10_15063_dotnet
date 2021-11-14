// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppWithCampaignId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (CurrentApp))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(825183440, 14017, 17574, 179, 43, 67, 45, 96, 142, 77, 214)]
  internal interface ICurrentAppWithCampaignId
  {
    [RemoteAsync]
    IAsyncOperation<string> GetAppPurchaseCampaignIdAsync();
  }
}
