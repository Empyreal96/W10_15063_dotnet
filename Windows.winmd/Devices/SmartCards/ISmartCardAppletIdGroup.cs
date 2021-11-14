// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAppletIdGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardAppletIdGroup))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [Guid(2108777958, 25188, 22260, 94, 3, 200, 99, 133, 57, 94, 177)]
  internal interface ISmartCardAppletIdGroup
  {
    string DisplayName { get; set; }

    IVector<IBuffer> AppletIds { get; }

    SmartCardEmulationCategory SmartCardEmulationCategory { get; set; }

    SmartCardEmulationType SmartCardEmulationType { get; set; }

    bool AutomaticEnablement { get; set; }
  }
}
