// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [Guid(2356996183, 42983, 18589, 185, 214, 54, 128, 97, 81, 80, 18)]
  [ExclusiveTo(typeof (SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult))]
  internal interface ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
  {
    SmartCardCryptogramGeneratorOperationStatus OperationStatus { get; }

    IVectorView<SmartCardCryptogramStorageKeyCharacteristics> Characteristics { get; }
  }
}
