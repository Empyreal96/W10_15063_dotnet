// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.WhiteBalanceControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WhiteBalanceControl : IWhiteBalanceControl
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern ColorTemperaturePreset Preset { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(ColorTemperaturePreset preset);

    public extern uint Min { [MethodImpl] get; }

    public extern uint Max { [MethodImpl] get; }

    public extern uint Step { [MethodImpl] get; }

    public extern uint Value { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(uint temperature);
  }
}
