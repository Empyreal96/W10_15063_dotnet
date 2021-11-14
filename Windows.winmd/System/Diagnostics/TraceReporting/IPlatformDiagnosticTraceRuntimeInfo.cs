// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.IPlatformDiagnosticTraceRuntimeInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [Guid(1028480557, 472, 18280, 133, 84, 30, 177, 202, 97, 9, 134)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlatformDiagnosticTraceRuntimeInfo))]
  internal interface IPlatformDiagnosticTraceRuntimeInfo
  {
    long RuntimeFileTime { get; }

    long EtwRuntimeFileTime { get; }
  }
}
