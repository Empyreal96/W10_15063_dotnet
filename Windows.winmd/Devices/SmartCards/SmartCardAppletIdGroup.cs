// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardAppletIdGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Static(typeof (ISmartCardAppletIdGroupStatics), 65536, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [Activatable(typeof (ISmartCardAppletIdGroupFactory), 65536, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  public sealed class SmartCardAppletIdGroup : ISmartCardAppletIdGroup
  {
    [MethodImpl]
    public extern SmartCardAppletIdGroup(
      string displayName,
      IVector<IBuffer> appletIds,
      SmartCardEmulationCategory emulationCategory,
      SmartCardEmulationType emulationType);

    [MethodImpl]
    public extern SmartCardAppletIdGroup();

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<IBuffer> AppletIds { [MethodImpl] get; }

    public extern SmartCardEmulationCategory SmartCardEmulationCategory { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardEmulationType SmartCardEmulationType { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutomaticEnablement { [MethodImpl] get; [MethodImpl] set; }

    public static extern ushort MaxAppletIds { [MethodImpl] get; }
  }
}
