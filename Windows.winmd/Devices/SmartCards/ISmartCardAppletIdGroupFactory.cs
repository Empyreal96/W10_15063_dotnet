// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAppletIdGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(2433084237, 19045, 20033, 128, 97, 203, 232, 63, 54, 149, 229)]
  [ExclusiveTo(typeof (SmartCardAppletIdGroup))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  internal interface ISmartCardAppletIdGroupFactory
  {
    SmartCardAppletIdGroup Create(
      string displayName,
      IVector<IBuffer> appletIds,
      SmartCardEmulationCategory emulationCategory,
      SmartCardEmulationType emulationType);
  }
}
