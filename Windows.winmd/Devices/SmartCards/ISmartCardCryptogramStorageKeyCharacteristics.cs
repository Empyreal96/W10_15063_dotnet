// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramStorageKeyCharacteristics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [ExclusiveTo(typeof (SmartCardCryptogramStorageKeyCharacteristics))]
  [Guid(2236765294, 17495, 18469, 180, 100, 99, 84, 113, 163, 159, 92)]
  internal interface ISmartCardCryptogramStorageKeyCharacteristics
  {
    string StorageKeyName { get; }

    DateTime DateCreated { get; }

    SmartCardCryptogramStorageKeyAlgorithm Algorithm { get; }

    SmartCardCryptogramStorageKeyCapabilities Capabilities { get; }
  }
}
