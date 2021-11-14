// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramGenerator2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardCryptogramGenerator))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [Guid(1897310772, 23917, 19274, 150, 163, 239, 164, 125, 42, 126, 37)]
  internal interface ISmartCardCryptogramGenerator2
  {
    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> ValidateRequestApduAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      IBuffer apduToValidate,
      IIterable<SmartCardCryptogramPlacementStep> cryptogramPlacementSteps);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult> GetAllCryptogramStorageKeyCharacteristicsAsync();

    [RemoteAsync]
    [Overload("GetAllCryptogramMaterialPackageCharacteristicsAsync")]
    IAsyncOperation<SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult> GetAllCryptogramMaterialPackageCharacteristicsAsync();

    [RemoteAsync]
    [Overload("GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync")]
    IAsyncOperation<SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult> GetAllCryptogramMaterialPackageCharacteristicsAsync(
      string storageKeyName);

    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult> GetAllCryptogramMaterialCharacteristicsAsync(
      SmartCardUnlockPromptingBehavior promptingBehavior,
      string materialPackageName);
  }
}
