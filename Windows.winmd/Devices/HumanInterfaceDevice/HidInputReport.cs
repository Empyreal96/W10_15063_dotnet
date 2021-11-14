// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidInputReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HidInputReport : IHidInputReport
  {
    public extern ushort Id { [MethodImpl] get; }

    public extern IBuffer Data { [MethodImpl] get; }

    public extern IVectorView<HidBooleanControl> ActivatedBooleanControls { [MethodImpl] get; }

    public extern IVectorView<HidBooleanControl> TransitionedBooleanControls { [MethodImpl] get; }

    [MethodImpl]
    public extern HidBooleanControl GetBooleanControl(
      ushort usagePage,
      ushort usageId);

    [MethodImpl]
    public extern HidBooleanControl GetBooleanControlByDescription(
      HidBooleanControlDescription controlDescription);

    [MethodImpl]
    public extern HidNumericControl GetNumericControl(
      ushort usagePage,
      ushort usageId);

    [MethodImpl]
    public extern HidNumericControl GetNumericControlByDescription(
      HidNumericControlDescription controlDescription);
  }
}
