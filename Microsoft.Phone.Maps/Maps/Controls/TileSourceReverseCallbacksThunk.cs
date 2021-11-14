// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.TileSourceReverseCallbacksThunk
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class TileSourceReverseCallbacksThunk
  {
    public static readonly InstanceRegistry<ITileSourceModel> TileSourceInstanceRegistry = new InstanceRegistry<ITileSourceModel>();
    public static readonly TileSourceReverseCallbackDelegates.GetUriCallback GetUriEventHandler = new TileSourceReverseCallbackDelegates.GetUriCallback(TileSourceReverseCallbacksThunk.GetUri);

    private static ITileSourceModel GetTileSourceModel(int tileSourceModelId) => TileSourceReverseCallbacksThunk.TileSourceInstanceRegistry.FindInstance(tileSourceModelId);

    [AllowReversePInvokeCalls]
    private static void GetUri(int tileSourceModelId, int x, int y, int zoomLevel, IntPtr state)
    {
      ITileSourceModel tileSourceModel = TileSourceReverseCallbacksThunk.GetTileSourceModel(tileSourceModelId);
      if (tileSourceModel == null || tileSourceModel.TileSourceCallbacks.GetUriCallbackEventHandler == null)
        return;
      Uri uri = tileSourceModel.TileSourceCallbacks.GetUriCallbackEventHandler(x, y, zoomLevel);
      tileSourceModel.OnGetUriDone(state, uri);
    }
  }
}
