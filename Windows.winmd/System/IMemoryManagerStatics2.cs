// Decompiled with JetBrains decompiler
// Type: Windows.System.IMemoryManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1861104927, 28002, 16959, 148, 121, 176, 31, 156, 159, 118, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MemoryManager))]
  internal interface IMemoryManagerStatics2
  {
    AppMemoryReport GetAppMemoryReport();

    ProcessMemoryReport GetProcessMemoryReport();
  }
}
