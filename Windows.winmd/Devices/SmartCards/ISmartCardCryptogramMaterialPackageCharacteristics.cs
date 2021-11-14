// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramMaterialPackageCharacteristics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(4290088479, 1682, 19527, 147, 207, 52, 217, 31, 157, 205, 0)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [ExclusiveTo(typeof (SmartCardCryptogramMaterialPackageCharacteristics))]
  internal interface ISmartCardCryptogramMaterialPackageCharacteristics
  {
    string PackageName { get; }

    string StorageKeyName { get; }

    DateTime DateImported { get; }

    SmartCardCryptogramMaterialPackageFormat PackageFormat { get; }
  }
}
