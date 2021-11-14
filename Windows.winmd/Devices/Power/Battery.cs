// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.Battery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Power
{
  [Static(typeof (IBatteryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class Battery : IBattery
  {
    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport GetReport();

    public extern event TypedEventHandler<Battery, object> ReportUpdated;

    public static extern Battery AggregateBattery { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Battery> FromIdAsync(string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
