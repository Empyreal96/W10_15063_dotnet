// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemMemoryUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (SystemMemoryUsage))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(402638229, 5890, 18895, 170, 39, 47, 10, 50, 89, 20, 4)]
  internal interface ISystemMemoryUsage
  {
    SystemMemoryUsageReport GetReport();
  }
}
