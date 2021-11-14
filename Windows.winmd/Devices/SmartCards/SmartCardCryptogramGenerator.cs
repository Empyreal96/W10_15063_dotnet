// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [Static(typeof (ISmartCardCryptogramGeneratorStatics), 131072, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  public sealed class SmartCardCryptogramGenerator : 
    ISmartCardCryptogramGenerator,
    ISmartCardCryptogramGenerator2
  {
    public extern IVectorView<SmartCardCryptogramMaterialType> SupportedCryptogramMaterialTypes { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramAlgorithm> SupportedCryptogramAlgorithms { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramMaterialPackageFormat> SupportedCryptogramMaterialPackageFormats { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat> SupportedCryptogramMaterialPackageConfirmationResponseFormats { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramStorageKeyCapabilities> SupportedSmartCardCryptogramStorageKeyCapabilities { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> DeleteCryptogramMaterialStorageKeyAsync(
      string storageKeyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> CreateCryptogramMaterialStorageKeyAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      string storageKeyName,
      SmartCardCryptogramStorageKeyAlgorithm algorithm,
      SmartCardCryptogramStorageKeyCapabilities capabilities);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramStorageKeyInfo> RequestCryptogramMaterialStorageKeyInfoAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      string storageKeyName,
      CryptographicPublicKeyBlobType format);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> ImportCryptogramMaterialPackageAsync(
      SmartCardCryptogramMaterialPackageFormat format,
      string storageKeyName,
      string materialPackageName,
      IBuffer cryptogramMaterialPackage);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramMaterialPossessionProof> TryProvePossessionOfCryptogramMaterialPackageAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat,
      string materialPackageName,
      string materialName,
      IBuffer challenge);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> RequestUnlockCryptogramMaterialForUseAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> DeleteCryptogramMaterialPackageAsync(
      string materialPackageName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> ValidateRequestApduAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      IBuffer apduToValidate,
      IIterable<SmartCardCryptogramPlacementStep> cryptogramPlacementSteps);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult> GetAllCryptogramStorageKeyCharacteristicsAsync();

    [RemoteAsync]
    [Overload("GetAllCryptogramMaterialPackageCharacteristicsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult> GetAllCryptogramMaterialPackageCharacteristicsAsync();

    [Overload("GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult> GetAllCryptogramMaterialPackageCharacteristicsAsync(
      string storageKeyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult> GetAllCryptogramMaterialCharacteristicsAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      string materialPackageName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardCryptogramGenerator> GetSmartCardCryptogramGeneratorAsync();
  }
}
