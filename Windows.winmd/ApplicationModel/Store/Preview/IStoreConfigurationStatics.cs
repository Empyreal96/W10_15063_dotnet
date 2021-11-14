// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(1922006976, 34344, 17132, 132, 162, 7, 120, 14, 180, 77, 139)]
  [ExclusiveTo(typeof (StoreConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStoreConfigurationStatics
  {
    void SetSystemConfiguration(
      string catalogHardwareManufacturerId,
      string catalogStoreContentModifierId,
      DateTime systemConfigurationExpiration,
      string catalogHardwareDescriptor);

    void SetMobileOperatorConfiguration(
      string mobileOperatorId,
      uint appDownloadLimitInMegabytes,
      uint updateDownloadLimitInMegabytes);

    void SetStoreWebAccountId(string webAccountId);

    bool IsStoreWebAccountId(string webAccountId);

    StoreHardwareManufacturerInfo HardwareManufacturerInfo { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<StoreSystemFeature>> FilterUnsupportedSystemFeaturesAsync(
      IIterable<StoreSystemFeature> systemFeatures);
  }
}
