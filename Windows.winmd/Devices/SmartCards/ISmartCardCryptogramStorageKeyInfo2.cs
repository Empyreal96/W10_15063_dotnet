// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramStorageKeyInfo2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 196608)]
  [ExclusiveTo(typeof (SmartCardCryptogramStorageKeyInfo))]
  [Guid(278777, 63485, 16765, 137, 225, 251, 176, 56, 42, 220, 77)]
  internal interface ISmartCardCryptogramStorageKeyInfo2
  {
    string OperationalRequirements { get; }
  }
}
