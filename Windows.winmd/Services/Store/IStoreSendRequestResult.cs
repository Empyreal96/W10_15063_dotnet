// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreSendRequestResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(3342515808, 33394, 17666, 138, 105, 110, 117, 21, 58, 66, 153)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreSendRequestResult))]
  internal interface IStoreSendRequestResult
  {
    string Response { get; }

    HResult ExtendedError { get; }
  }
}
