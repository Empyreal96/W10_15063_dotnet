// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreDispatcher2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreDispatcher))]
  [WebHostHidden]
  [Guid(1868456903, 58282, 20142, 176, 224, 220, 243, 33, 202, 75, 47)]
  internal interface ICoreDispatcher2
  {
    [RemoteAsync]
    IAsyncOperation<bool> TryRunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    [RemoteAsync]
    IAsyncOperation<bool> TryRunIdleAsync(IdleDispatchedHandler agileCallback);
  }
}
