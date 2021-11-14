// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.RouterReverseCallbacksThunk
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  internal static class RouterReverseCallbacksThunk
  {
    public static readonly InstanceRegistry<IRouterModel> RouterInstanceRegistry = new InstanceRegistry<IRouterModel>();
    public static readonly RouterReverseCallbackDelegates.InvokeProcessDispatchQueueCallback InvokeProcessDispatchQueueEventHandler = new RouterReverseCallbackDelegates.InvokeProcessDispatchQueueCallback(RouterReverseCallbacksThunk.InvokeProcessDispatchQueue);
    public static readonly RouterReverseCallbackDelegates.StatusChangedCallback StatusChangedEventHandler = new RouterReverseCallbackDelegates.StatusChangedCallback(RouterReverseCallbacksThunk.OnStatusChanged);

    private static IRouterModel GetRouterModel(int routerModelId) => RouterReverseCallbacksThunk.RouterInstanceRegistry.FindInstance(routerModelId);

    [AllowReversePInvokeCalls]
    private static void InvokeProcessDispatchQueue(int routerModelId) => RouterReverseCallbacksThunk.GetRouterModel(routerModelId)?.InvokeProcessDispatchQueue();

    [AllowReversePInvokeCalls]
    private static void OnStatusChanged(int routerModelId)
    {
      IRouterModel routerModel = RouterReverseCallbacksThunk.GetRouterModel(routerModelId);
      if (routerModel == null || routerModel.RouterCallbacks.StatusChangedEventHandler == null)
        return;
      routerModel.RouterCallbacks.StatusChangedEventHandler();
    }
  }
}
