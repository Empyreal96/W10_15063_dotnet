// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidFeatureReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HidFeatureReport : IHidFeatureReport
  {
    public extern ushort Id { [MethodImpl] get; }

    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }

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
