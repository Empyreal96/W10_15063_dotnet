// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemDiagnosticInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SystemDiagnosticInfo))]
  [Guid(2727411205, 57331, 16511, 154, 27, 11, 43, 49, 124, 168, 0)]
  internal interface ISystemDiagnosticInfo
  {
    SystemMemoryUsage MemoryUsage { get; }

    SystemCpuUsage CpuUsage { get; }
  }
}
