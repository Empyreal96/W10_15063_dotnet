// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.IThreadPoolTimer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [WebHostHidden]
  [Guid(1498332792, 21994, 19080, 165, 13, 52, 2, 174, 31, 156, 242)]
  [ExclusiveTo(typeof (ThreadPoolTimer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IThreadPoolTimer
  {
    TimeSpan Period { get; }

    TimeSpan Delay { get; }

    void Cancel();
  }
}
