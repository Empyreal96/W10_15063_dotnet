// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramMaterialPackageCharacteristics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  public sealed class SmartCardCryptogramMaterialPackageCharacteristics : 
    ISmartCardCryptogramMaterialPackageCharacteristics
  {
    [MethodImpl]
    public extern SmartCardCryptogramMaterialPackageCharacteristics();

    public extern string PackageName { [MethodImpl] get; }

    public extern string StorageKeyName { [MethodImpl] get; }

    public extern DateTime DateImported { [MethodImpl] get; }

    public extern SmartCardCryptogramMaterialPackageFormat PackageFormat { [MethodImpl] get; }
  }
}
