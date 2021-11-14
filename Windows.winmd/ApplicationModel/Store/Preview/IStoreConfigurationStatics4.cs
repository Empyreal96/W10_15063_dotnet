// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(553604818, 20195, 19696, 155, 18, 85, 44, 3, 49, 15, 117)]
  [ExclusiveTo(typeof (StoreConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IStoreConfigurationStatics4
  {
    string GetStoreWebAccountId();

    string GetStoreWebAccountIdForUser(User user);

    void SetEnterpriseStoreWebAccountId(string webAccountId);

    void SetEnterpriseStoreWebAccountIdForUser(User user, string webAccountId);

    string GetEnterpriseStoreWebAccountId();

    string GetEnterpriseStoreWebAccountIdForUser(User user);

    bool ShouldRestrictToEnterpriseStoreOnly();

    bool ShouldRestrictToEnterpriseStoreOnlyForUser(User user);
  }
}
