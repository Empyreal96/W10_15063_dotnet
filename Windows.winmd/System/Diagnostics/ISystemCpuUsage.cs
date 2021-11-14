// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemCpuUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(1614263212, 726, 16948, 131, 98, 127, 227, 173, 200, 31, 95)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SystemCpuUsage))]
  internal interface ISystemCpuUsage
  {
    SystemCpuUsageReport GetReport();
  }
}
