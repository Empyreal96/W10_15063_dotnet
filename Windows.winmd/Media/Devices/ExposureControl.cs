// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ExposureControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ExposureControl : IExposureControl
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern bool Auto { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetAutoAsync(bool value);

    public extern TimeSpan Min { [MethodImpl] get; }

    public extern TimeSpan Max { [MethodImpl] get; }

    public extern TimeSpan Step { [MethodImpl] get; }

    public extern TimeSpan Value { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(TimeSpan shutterDuration);
  }
}
