// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapLifeTimeV8NoUI
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows.Controls;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapLifeTimeV8NoUI : MapLifetime
  {
    public MapLifeTimeV8NoUI(
      Control mapControl,
      MapCallbacks mapInteropCallbacks,
      Dispatcher dispatcher)
    {
      this.MapModel = (IMapModel) new MapModelNoUI(mapInteropCallbacks, dispatcher);
    }

    protected override void OnEnterVisualTree(Border presentationContainer)
    {
    }

    protected override void OnExitVisualTree()
    {
    }
  }
}
