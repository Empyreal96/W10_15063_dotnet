// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.SystemCpuUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class SystemCpuUsageReport : ISystemCpuUsageReport
  {
    public extern TimeSpan KernelTime { [MethodImpl] get; }

    public extern TimeSpan UserTime { [MethodImpl] get; }

    public extern TimeSpan IdleTime { [MethodImpl] get; }
  }
}
