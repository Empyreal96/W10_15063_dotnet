// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerCloseAlarm
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CashDrawerCloseAlarm : ICashDrawerCloseAlarm
  {
    public extern TimeSpan AlarmTimeout { [MethodImpl] set; [MethodImpl] get; }

    public extern uint BeepFrequency { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan BeepDuration { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan BeepDelay { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<CashDrawerCloseAlarm, object> AlarmTimeoutExpired;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> StartAsync();
  }
}
