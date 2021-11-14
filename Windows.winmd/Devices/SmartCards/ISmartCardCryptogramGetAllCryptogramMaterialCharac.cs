// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(664330281, 54919, 19602, 134, 198, 57, 158, 154, 14, 203, 9)]
  [ExclusiveTo(typeof (SmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  internal interface ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult
  {
    SmartCardCryptogramGeneratorOperationStatus OperationStatus { get; }

    IVectorView<SmartCardCryptogramMaterialCharacteristics> Characteristics { get; }
  }
}
