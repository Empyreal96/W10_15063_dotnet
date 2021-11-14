// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramGeneratorOperationStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  public enum SmartCardCryptogramGeneratorOperationStatus
  {
    Success,
    AuthorizationFailed,
    AuthorizationCanceled,
    AuthorizationRequired,
    CryptogramMaterialPackageStorageKeyExists,
    NoCryptogramMaterialPackageStorageKey,
    NoCryptogramMaterialPackage,
    UnsupportedCryptogramMaterialPackage,
    UnknownCryptogramMaterialName,
    InvalidCryptogramMaterialUsage,
    ApduResponseNotSent,
    OtherError,
    [ContractVersion("Windows.Devices.SmartCards.SmartCardEmulatorContract", 262144)] ValidationFailed,
  }
}
