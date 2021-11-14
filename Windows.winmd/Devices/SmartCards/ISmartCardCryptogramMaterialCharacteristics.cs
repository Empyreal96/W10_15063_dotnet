// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramMaterialCharacteristics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [Guid(4238001612, 49623, 16723, 146, 59, 162, 212, 60, 108, 141, 73)]
  [ExclusiveTo(typeof (SmartCardCryptogramMaterialCharacteristics))]
  internal interface ISmartCardCryptogramMaterialCharacteristics
  {
    string MaterialName { get; }

    IVectorView<SmartCardCryptogramAlgorithm> AllowedAlgorithms { get; }

    IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat> AllowedProofOfPossessionAlgorithms { get; }

    IVectorView<SmartCardCryptogramAlgorithm> AllowedValidations { get; }

    SmartCardCryptogramMaterialType MaterialType { get; }

    SmartCardCryptogramMaterialProtectionMethod ProtectionMethod { get; }

    int ProtectionVersion { get; }

    int MaterialLength { get; }
  }
}
