// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardCryptogramGenerator))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [Guid(3818870907, 60883, 20041, 181, 148, 15, 245, 228, 208, 199, 111)]
  internal interface ISmartCardCryptogramGenerator
  {
    IVectorView<SmartCardCryptogramMaterialType> SupportedCryptogramMaterialTypes { get; }

    IVectorView<SmartCardCryptogramAlgorithm> SupportedCryptogramAlgorithms { get; }

    IVectorView<SmartCardCryptogramMaterialPackageFormat> SupportedCryptogramMaterialPackageFormats { get; }

    IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat> SupportedCryptogramMaterialPackageConfirmationResponseFormats { get; }

    IVectorView<SmartCardCryptogramStorageKeyCapabilities> SupportedSmartCardCryptogramStorageKeyCapabilities { get; }

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> DeleteCryptogramMaterialStorageKeyAsync(
      string storageKeyName);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> CreateCryptogramMaterialStorageKeyAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      string storageKeyName,
      SmartCardCryptogramStorageKeyAlgorithm algorithm,
      SmartCardCryptogramStorageKeyCapabilities capabilities);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramStorageKeyInfo> RequestCryptogramMaterialStorageKeyInfoAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      string storageKeyName,
      CryptographicPublicKeyBlobType format);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> ImportCryptogramMaterialPackageAsync(
      SmartCardCryptogramMaterialPackageFormat format,
      string storageKeyName,
      string materialPackageName,
      IBuffer cryptogramMaterialPackage);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramMaterialPossessionProof> TryProvePossessionOfCryptogramMaterialPackageAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat,
      string materialPackageName,
      string materialName,
      IBuffer challenge);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> RequestUnlockCryptogramMaterialForUseAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> DeleteCryptogramMaterialPackageAsync(
      string materialPackageName);
  }
}
