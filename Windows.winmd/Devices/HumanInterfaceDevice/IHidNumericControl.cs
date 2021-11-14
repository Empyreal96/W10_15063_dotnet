// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidNumericControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [Guid(3817476773, 13735, 19317, 137, 200, 251, 31, 40, 177, 8, 35)]
  [ExclusiveTo(typeof (HidNumericControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidNumericControl
  {
    uint Id { get; }

    bool IsGrouped { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    long Value { get; set; }

    long ScaledValue { get; set; }

    HidNumericControlDescription ControlDescription { get; }
  }
}
