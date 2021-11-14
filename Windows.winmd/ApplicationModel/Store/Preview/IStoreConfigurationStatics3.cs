// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(1833301372, 61764, 19637, 157, 63, 78, 176, 94, 48, 182, 211)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (StoreConfiguration))]
  internal interface IStoreConfigurationStatics3
  {
    bool HasStoreWebAccount();

    bool HasStoreWebAccountForUser(User user);

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamReference> GetStoreLogDataAsync(
      StoreLogOptions options);

    void SetStoreWebAccountIdForUser(User user, string webAccountId);

    bool IsStoreWebAccountIdForUser(User user, string webAccountId);

    IReference<uint> GetPurchasePromptingPolicyForUser(User user);

    void SetPurchasePromptingPolicyForUser(User user, IReference<uint> value);
  }
}
