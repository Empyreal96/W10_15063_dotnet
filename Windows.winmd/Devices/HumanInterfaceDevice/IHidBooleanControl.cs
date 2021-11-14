// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidBooleanControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [Guid(1380840586, 13973, 16524, 187, 162, 226, 235, 90, 191, 188, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HidBooleanControl))]
  internal interface IHidBooleanControl
  {
    uint Id { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    bool IsActive { get; set; }

    HidBooleanControlDescription ControlDescription { get; }
  }
}
