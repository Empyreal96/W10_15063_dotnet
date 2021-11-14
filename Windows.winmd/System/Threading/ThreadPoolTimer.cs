// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.ThreadPoolTimer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [Static(typeof (IThreadPoolTimerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class ThreadPoolTimer : IThreadPoolTimer
  {
    public extern TimeSpan Period { [MethodImpl] get; }

    public extern TimeSpan Delay { [MethodImpl] get; }

    [MethodImpl]
    public extern void Cancel();

    [Overload("CreatePeriodicTimer")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreatePeriodicTimer(
      TimerElapsedHandler handler,
      TimeSpan period);

    [Overload("CreateTimer")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreateTimer(
      TimerElapsedHandler handler,
      TimeSpan delay);

    [Overload("CreatePeriodicTimerWithCompletion")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreatePeriodicTimer(
      TimerElapsedHandler handler,
      TimeSpan period,
      TimerDestroyedHandler destroyed);

    [Overload("CreateTimerWithCompletion")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreateTimer(
      TimerElapsedHandler handler,
      TimeSpan delay,
      TimerDestroyedHandler destroyed);
  }
}
