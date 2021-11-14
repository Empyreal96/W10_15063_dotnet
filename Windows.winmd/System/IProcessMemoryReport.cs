// Decompiled with JetBrains decompiler
// Type: Windows.System.IProcessMemoryReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(141755816, 39792, 18306, 135, 65, 58, 152, 43, 108, 229, 228)]
  [ExclusiveTo(typeof (ProcessMemoryReport))]
  internal interface IProcessMemoryReport
  {
    ulong PrivateWorkingSetUsage { get; }

    ulong TotalWorkingSetUsage { get; }
  }
}
