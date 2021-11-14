// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidNumericControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidNumericControl : IHidNumericControl
  {
    public extern uint Id { [MethodImpl] get; }

    public extern bool IsGrouped { [MethodImpl] get; }

    public extern ushort UsagePage { [MethodImpl] get; }

    public extern ushort UsageId { [MethodImpl] get; }

    public extern long Value { [MethodImpl] get; [MethodImpl] set; }

    public extern long ScaledValue { [MethodImpl] get; [MethodImpl] set; }

    public extern HidNumericControlDescription ControlDescription { [MethodImpl] get; }
  }
}
