// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreRequestHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(1827005945, 41161, 19244, 150, 166, 161, 113, 198, 48, 3, 141)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreRequestHelper))]
  internal interface IStoreRequestHelperStatics
  {
    [RemoteAsync]
    IAsyncOperation<StoreSendRequestResult> SendRequestAsync(
      StoreContext context,
      uint requestKind,
      string parametersAsJson);
  }
}
