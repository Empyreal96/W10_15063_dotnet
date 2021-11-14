// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Headset
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Headset : IHeadset, IGameControllerBatteryInfo
  {
    public extern string CaptureDeviceId { [MethodImpl] get; }

    public extern string RenderDeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();
  }
}
