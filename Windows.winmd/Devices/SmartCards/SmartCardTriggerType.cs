// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardTriggerType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 65536)]
  public enum SmartCardTriggerType
  {
    EmulatorTransaction,
    EmulatorNearFieldEntry,
    EmulatorNearFieldExit,
    [ContractVersion("Windows.Devices.SmartCards.SmartCardBackgroundTriggerContract", 65536)] EmulatorHostApplicationActivated,
    [ContractVersion("Windows.Devices.SmartCards.SmartCardBackgroundTriggerContract", 65536)] EmulatorAppletIdGroupRegistrationChanged,
    [ContractVersion("Windows.Devices.SmartCards.SmartCardBackgroundTriggerContract", 131072)] ReaderCardAdded,
  }
}
