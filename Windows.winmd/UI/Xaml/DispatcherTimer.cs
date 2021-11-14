// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DispatcherTimer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IDispatcherTimerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DispatcherTimer : IDispatcherTimer
  {
    [MethodImpl]
    public extern DispatcherTimer();

    public extern TimeSpan Interval { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern event EventHandler<object> Tick;

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
