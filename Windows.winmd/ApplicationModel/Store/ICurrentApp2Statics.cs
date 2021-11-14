// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentApp2Statics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CurrentApp))]
  [Guid(3746459181, 12657, 19155, 134, 20, 44, 97, 36, 67, 115, 203)]
  internal interface ICurrentApp2Statics
  {
    [RemoteAsync]
    IAsyncOperation<string> GetCustomerPurchaseIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    IAsyncOperation<string> GetCustomerCollectionsIdAsync(
      string serviceTicket,
      string publisherUserId);
  }
}
