// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramMaterialCharacteristics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  public sealed class SmartCardCryptogramMaterialCharacteristics : 
    ISmartCardCryptogramMaterialCharacteristics
  {
    [MethodImpl]
    public extern SmartCardCryptogramMaterialCharacteristics();

    public extern string MaterialName { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramAlgorithm> AllowedAlgorithms { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat> AllowedProofOfPossessionAlgorithms { [MethodImpl] get; }

    public extern IVectorView<SmartCardCryptogramAlgorithm> AllowedValidations { [MethodImpl] get; }

    public extern SmartCardCryptogramMaterialType MaterialType { [MethodImpl] get; }

    public extern SmartCardCryptogramMaterialProtectionMethod ProtectionMethod { [MethodImpl] get; }

    public extern int ProtectionVersion { [MethodImpl] get; }

    public extern int MaterialLength { [MethodImpl] get; }
  }
}
