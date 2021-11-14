// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(1702643093, 51383, 20457, 159, 76, 77, 113, 2, 125, 52, 126)]
  [ExclusiveTo(typeof (StoreConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IStoreConfigurationStatics2
  {
    IReference<uint> PurchasePromptingPolicy { get; set; }
  }
}
