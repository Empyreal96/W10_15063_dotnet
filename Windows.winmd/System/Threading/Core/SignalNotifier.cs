// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.SignalNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [Static(typeof (ISignalNotifierStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SignalNotifier : ISignalNotifier
  {
    [MethodImpl]
    public extern void Enable();

    [MethodImpl]
    public extern void Terminate();

    [Overload("AttachToEvent")]
    [MethodImpl]
    public static extern SignalNotifier AttachToEvent(
      string name,
      SignalHandler handler);

    [Overload("AttachToEventWithTimeout")]
    [MethodImpl]
    public static extern SignalNotifier AttachToEvent(
      string name,
      SignalHandler handler,
      TimeSpan timeout);

    [Overload("AttachToSemaphore")]
    [MethodImpl]
    public static extern SignalNotifier AttachToSemaphore(
      string name,
      SignalHandler handler);

    [Overload("AttachToSemaphoreWithTimeout")]
    [MethodImpl]
    public static extern SignalNotifier AttachToSemaphore(
      string name,
      SignalHandler handler,
      TimeSpan timeout);
  }
}
