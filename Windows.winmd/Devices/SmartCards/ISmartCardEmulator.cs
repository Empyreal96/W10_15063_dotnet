// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [Guid(3753445042, 34654, 18405, 128, 119, 232, 191, 241, 177, 198, 251)]
  [ExclusiveTo(typeof (SmartCardEmulator))]
  internal interface ISmartCardEmulator
  {
    SmartCardEmulatorEnablementPolicy EnablementPolicy { get; }
  }
}
