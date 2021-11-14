// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiskUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(1524075517, 32337, 20051, 191, 170, 90, 110, 225, 170, 187, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessDiskUsage))]
  internal interface IProcessDiskUsage
  {
    ProcessDiskUsageReport GetReport();
  }
}
