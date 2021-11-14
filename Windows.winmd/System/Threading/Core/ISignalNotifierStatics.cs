// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.ISignalNotifierStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [WebHostHidden]
  [Guid(474891622, 33792, 18131, 161, 21, 125, 12, 13, 252, 159, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SignalNotifier))]
  internal interface ISignalNotifierStatics
  {
    [Overload("AttachToEvent")]
    SignalNotifier AttachToEvent(string name, SignalHandler handler);

    [Overload("AttachToEventWithTimeout")]
    SignalNotifier AttachToEvent(
      string name,
      SignalHandler handler,
      TimeSpan timeout);

    [Overload("AttachToSemaphore")]
    SignalNotifier AttachToSemaphore(string name, SignalHandler handler);

    [Overload("AttachToSemaphoreWithTimeout")]
    SignalNotifier AttachToSemaphore(
      string name,
      SignalHandler handler,
      TimeSpan timeout);
  }
}
