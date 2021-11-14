// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult : 
    ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
  {
    [MethodImpl]
    public extern SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult();

    public extern SmartCardCryptogramGeneratorOperationStatus OperationStatus { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramStorageKeyCharacteristics> Characteristics { [MethodImpl] get; }
  }
}
