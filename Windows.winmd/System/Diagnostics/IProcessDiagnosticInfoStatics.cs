// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiagnosticInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessDiagnosticInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(792834656, 46239, 17036, 170, 14, 132, 116, 79, 73, 202, 149)]
  internal interface IProcessDiagnosticInfoStatics
  {
    IVectorView<ProcessDiagnosticInfo> GetForProcesses();

    ProcessDiagnosticInfo GetForCurrentProcess();
  }
}
