// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [ExclusiveTo(typeof (SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult))]
  [Guid(1315605084, 38771, 18116, 163, 47, 177, 229, 67, 21, 158, 4)]
  internal interface ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult
  {
    SmartCardCryptogramGeneratorOperationStatus OperationStatus { get; }

    IVectorView<SmartCardCryptogramMaterialPackageCharacteristics> Characteristics { get; }
  }
}
