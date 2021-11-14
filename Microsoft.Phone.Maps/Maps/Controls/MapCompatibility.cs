// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapCompatibility
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class MapCompatibility
  {
    public static MapLifetime GetLifetimeManager(
      MapVersion mapVersion,
      Control mapControl,
      MapCallbacks mapInteropCallbacks,
      Dispatcher dispatcher)
    {
      switch (mapVersion)
      {
        case MapVersion.V8:
          return (MapLifetime) new MapLifeTimeV8(mapControl, mapInteropCallbacks, dispatcher);
        case MapVersion.V8NoOp:
          return (MapLifetime) new MapLifeTimeV8NoOp(mapControl, mapInteropCallbacks, dispatcher);
        case MapVersion.V8NoUI:
          return (MapLifetime) new MapLifeTimeV8NoUI(mapControl, mapInteropCallbacks, dispatcher);
        case MapVersion.V8Designer:
          return (MapLifetime) new MapLifeTimeV8NoOp(mapControl, mapInteropCallbacks, dispatcher);
        case MapVersion.V8UnitTest:
          return (MapLifetime) new MapLifeTimeV8UnitTest(mapControl, mapInteropCallbacks, dispatcher);
        default:
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidMapVersionExceptionFormat, (object) mapVersion), nameof (mapVersion));
      }
    }
  }
}
