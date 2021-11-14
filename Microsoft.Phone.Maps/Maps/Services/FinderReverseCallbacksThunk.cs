// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.FinderReverseCallbacksThunk
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  internal static class FinderReverseCallbacksThunk
  {
    public static readonly InstanceRegistry<IFinderModel> FinderInstanceRegistry = new InstanceRegistry<IFinderModel>();
    public static readonly FinderReverseCallbackDelegates.InvokeProcessDispatchQueueCallback InvokeProcessDispatchQueueEventHandler = new FinderReverseCallbackDelegates.InvokeProcessDispatchQueueCallback(FinderReverseCallbacksThunk.InvokeProcessDispatchQueue);
    public static readonly FinderReverseCallbackDelegates.StatusChangedCallback StatusChangedEventHandler = new FinderReverseCallbackDelegates.StatusChangedCallback(FinderReverseCallbacksThunk.OnStatusChanged);

    private static IFinderModel GetFinderModel(int finderModelId) => FinderReverseCallbacksThunk.FinderInstanceRegistry.FindInstance(finderModelId);

    [AllowReversePInvokeCalls]
    private static void InvokeProcessDispatchQueue(int finderModelId) => FinderReverseCallbacksThunk.GetFinderModel(finderModelId)?.InvokeProcessDispatchQueue();

    [AllowReversePInvokeCalls]
    private static void OnStatusChanged(int finderModelId)
    {
      IFinderModel finderModel = FinderReverseCallbacksThunk.GetFinderModel(finderModelId);
      if (finderModel == null || finderModel.FinderCallbacks.StatusChangedEventHandler == null)
        return;
      finderModel.FinderCallbacks.StatusChangedEventHandler();
    }
  }
}
