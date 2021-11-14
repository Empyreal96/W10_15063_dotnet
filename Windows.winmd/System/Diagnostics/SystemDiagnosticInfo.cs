// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.SystemDiagnosticInfo
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
  [Static(typeof (ISystemDiagnosticInfoStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class SystemDiagnosticInfo : ISystemDiagnosticInfo
  {
    public extern SystemMemoryUsage MemoryUsage { [MethodImpl] get; }

    public extern SystemCpuUsage CpuUsage { [MethodImpl] get; }

    [MethodImpl]
    public static extern SystemDiagnosticInfo GetForCurrentSystem();
  }
}
