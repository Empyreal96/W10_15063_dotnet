// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidBooleanControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HidBooleanControl : IHidBooleanControl
  {
    public extern uint Id { [MethodImpl] get; }

    public extern ushort UsagePage { [MethodImpl] get; }

    public extern ushort UsageId { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; [MethodImpl] set; }

    public extern HidBooleanControlDescription ControlDescription { [MethodImpl] get; }
  }
}
