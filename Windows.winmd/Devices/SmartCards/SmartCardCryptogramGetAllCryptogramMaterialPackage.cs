// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Activatable(262144, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult : 
    ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult
  {
    [MethodImpl]
    public extern SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult();

    public extern SmartCardCryptogramGeneratorOperationStatus OperationStatus { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramMaterialPackageCharacteristics> Characteristics { [MethodImpl] get; }
  }
}
