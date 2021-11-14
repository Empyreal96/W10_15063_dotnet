// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessCpuUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(196813938, 51391, 16954, 168, 16, 181, 89, 174, 67, 84, 226)]
  [ExclusiveTo(typeof (ProcessCpuUsage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProcessCpuUsage
  {
    ProcessCpuUsageReport GetReport();
  }
}
