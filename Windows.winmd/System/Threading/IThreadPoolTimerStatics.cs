// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.IThreadPoolTimerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [Guid(445291778, 58498, 17947, 184, 199, 142, 250, 209, 204, 229, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ThreadPoolTimer))]
  [WebHostHidden]
  internal interface IThreadPoolTimerStatics
  {
    [Overload("CreatePeriodicTimer")]
    ThreadPoolTimer CreatePeriodicTimer(TimerElapsedHandler handler, TimeSpan period);

    [Overload("CreateTimer")]
    ThreadPoolTimer CreateTimer(TimerElapsedHandler handler, TimeSpan delay);

    [Overload("CreatePeriodicTimerWithCompletion")]
    ThreadPoolTimer CreatePeriodicTimer(
      TimerElapsedHandler handler,
      TimeSpan period,
      TimerDestroyedHandler destroyed);

    [Overload("CreateTimerWithCompletion")]
    ThreadPoolTimer CreateTimer(
      TimerElapsedHandler handler,
      TimeSpan delay,
      TimerDestroyedHandler destroyed);
  }
}
