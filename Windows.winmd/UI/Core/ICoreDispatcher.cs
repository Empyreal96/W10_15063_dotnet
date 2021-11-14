// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreDispatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreDispatcher))]
  [Guid(1624977320, 46853, 20446, 167, 214, 235, 187, 24, 145, 211, 158)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICoreDispatcher : ICoreAcceleratorKeys
  {
    bool HasThreadAccess { get; }

    void ProcessEvents(CoreProcessEventsOption options);

    [RemoteAsync]
    IAsyncAction RunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    [RemoteAsync]
    IAsyncAction RunIdleAsync(IdleDispatchedHandler agileCallback);
  }
}
