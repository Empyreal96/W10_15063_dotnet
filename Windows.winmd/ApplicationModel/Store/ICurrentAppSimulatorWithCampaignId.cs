// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppSimulatorWithCampaignId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2221378115, 57088, 18034, 164, 63, 178, 91, 20, 65, 207, 207)]
  [ExclusiveTo(typeof (CurrentAppSimulator))]
  internal interface ICurrentAppSimulatorWithCampaignId
  {
    [RemoteAsync]
    IAsyncOperation<string> GetAppPurchaseCampaignIdAsync();
  }
}
