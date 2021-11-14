// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreDispatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class CoreDispatcher : 
    ICoreDispatcher,
    ICoreAcceleratorKeys,
    ICoreDispatcherWithTaskPriority,
    ICoreDispatcher2
  {
    public extern bool HasThreadAccess { [MethodImpl] get; }

    [MethodImpl]
    public extern void ProcessEvents(CoreProcessEventsOption options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RunIdleAsync(IdleDispatchedHandler agileCallback);

    public extern event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated;

    public extern CoreDispatcherPriority CurrentPriority { [MethodImpl] get; [MethodImpl] set; }

    [Overload("ShouldYield")]
    [MethodImpl]
    public extern bool ShouldYield();

    [Overload("ShouldYieldToPriority")]
    [MethodImpl]
    public extern bool ShouldYield(CoreDispatcherPriority priority);

    [MethodImpl]
    public extern void StopProcessEvents();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRunIdleAsync(
      IdleDispatchedHandler agileCallback);
  }
}
