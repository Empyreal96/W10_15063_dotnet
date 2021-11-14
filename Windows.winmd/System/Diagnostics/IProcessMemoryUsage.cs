// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessMemoryUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4111147675, 33404, 17079, 176, 124, 14, 50, 98, 126, 107, 62)]
  [ExclusiveTo(typeof (ProcessMemoryUsage))]
  internal interface IProcessMemoryUsage
  {
    ProcessMemoryUsageReport GetReport();
  }
}
