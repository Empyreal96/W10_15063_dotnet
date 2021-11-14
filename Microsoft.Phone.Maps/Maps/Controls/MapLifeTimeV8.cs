﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapLifeTimeV8
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapLifeTimeV8 : MapLifetime
  {
    public MapLifeTimeV8(
      Control mapControl,
      MapCallbacks mapInteropCallbacks,
      Dispatcher dispatcher)
    {
      this.MapModel = (IMapModel) new MOSMapModel(mapInteropCallbacks, dispatcher);
    }

    public override void OnAfterLoaded()
    {
    }

    protected override void OnEnterVisualTree(Border presentationContainer) => presentationContainer.Child = (UIElement) this.MapModel.Presentation;

    protected override void OnExitVisualTree()
    {
    }
  }
}
