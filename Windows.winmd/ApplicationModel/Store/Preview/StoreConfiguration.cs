// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  [Static(typeof (IStoreConfigurationStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStoreConfigurationStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoreConfigurationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoreConfigurationStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  public static class StoreConfiguration
  {
    [MethodImpl]
    public static extern string GetStoreWebAccountId();

    [MethodImpl]
    public static extern string GetStoreWebAccountIdForUser(User user);

    [MethodImpl]
    public static extern void SetEnterpriseStoreWebAccountId(string webAccountId);

    [MethodImpl]
    public static extern void SetEnterpriseStoreWebAccountIdForUser(User user, string webAccountId);

    [MethodImpl]
    public static extern string GetEnterpriseStoreWebAccountId();

    [MethodImpl]
    public static extern string GetEnterpriseStoreWebAccountIdForUser(User user);

    [MethodImpl]
    public static extern bool ShouldRestrictToEnterpriseStoreOnly();

    [MethodImpl]
    public static extern bool ShouldRestrictToEnterpriseStoreOnlyForUser(User user);

    [MethodImpl]
    public static extern bool HasStoreWebAccount();

    [MethodImpl]
    public static extern bool HasStoreWebAccountForUser(User user);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStreamReference> GetStoreLogDataAsync(
      StoreLogOptions options);

    [MethodImpl]
    public static extern void SetStoreWebAccountIdForUser(User user, string webAccountId);

    [MethodImpl]
    public static extern bool IsStoreWebAccountIdForUser(User user, string webAccountId);

    [MethodImpl]
    public static extern IReference<uint> GetPurchasePromptingPolicyForUser(User user);

    [MethodImpl]
    public static extern void SetPurchasePromptingPolicyForUser(User user, IReference<uint> value);

    public static extern IReference<uint> PurchasePromptingPolicy { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern void SetSystemConfiguration(
      string catalogHardwareManufacturerId,
      string catalogStoreContentModifierId,
      DateTime systemConfigurationExpiration,
      string catalogHardwareDescriptor);

    [MethodImpl]
    public static extern void SetMobileOperatorConfiguration(
      string mobileOperatorId,
      uint appDownloadLimitInMegabytes,
      uint updateDownloadLimitInMegabytes);

    [MethodImpl]
    public static extern void SetStoreWebAccountId(string webAccountId);

    [MethodImpl]
    public static extern bool IsStoreWebAccountId(string webAccountId);

    public static extern StoreHardwareManufacturerInfo HardwareManufacturerInfo { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<StoreSystemFeature>> FilterUnsupportedSystemFeaturesAsync(
      IIterable<StoreSystemFeature> systemFeatures);
  }
}
