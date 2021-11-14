// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.InteropDestroyFunctions
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Services;
using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class InteropDestroyFunctions
  {
    static InteropDestroyFunctions()
    {
      InteropDestroyFunctions.Table = new Dictionary<Type, InteropDestroyFunctions.DestroyObject>();
      InteropDestroyFunctions.Table.Add(typeof (AgMapControlManagedAdapter), new InteropDestroyFunctions.DestroyObject(InteropDestroyFunctions.AgMapControlAdapter_Destroy));
      InteropDestroyFunctions.Table.Add(typeof (AgFinderManagedAdapter), new InteropDestroyFunctions.DestroyObject(Shim.AgFinderAdapter_Destroy));
      InteropDestroyFunctions.Table.Add(typeof (AgRouterManagedAdapter), new InteropDestroyFunctions.DestroyObject(Shim.AgRouterAdapter_Destroy));
      InteropDestroyFunctions.Table.Add(typeof (Route), new InteropDestroyFunctions.DestroyObject(Shim.AgRouterAdapter_DestroyRoute));
      InteropDestroyFunctions.Table.Add(typeof (MapRoute), new InteropDestroyFunctions.DestroyObject(Shim.AgMapRoute_Destroy));
      InteropDestroyFunctions.Table.Add(typeof (MapElement), new InteropDestroyFunctions.DestroyObject(Shim.AgMapObject_ReleaseMapObject));
      InteropDestroyFunctions.Table.Add(typeof (AgTileSourceManagedAdapter), new InteropDestroyFunctions.DestroyObject(Shim.AgTileSourceAdapter_Destroy));
      InteropDestroyFunctions.Table.Add(typeof (MOSMapOverlayModel), new InteropDestroyFunctions.DestroyObject(Shim.AgMapOverlayModelAdapter_Destroy));
    }

    public static Dictionary<Type, InteropDestroyFunctions.DestroyObject> Table { get; private set; }

    private static void AgMapControlAdapter_Destroy(IntPtr nativeAdapter)
    {
    }

    public delegate void DestroyObject(IntPtr hObject);
  }
}
