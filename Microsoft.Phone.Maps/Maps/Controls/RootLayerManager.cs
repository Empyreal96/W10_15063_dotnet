// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.RootLayerManager
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Phone.Maps.Controls
{
  internal class RootLayerManager : CollectionManager<MapLayer>
  {
    private Dictionary<MapLayer, MapLayerPanel> mapping;
    private Map map;
    private UIElementCollection collection;
    private IMapModel mapModel;

    public RootLayerManager(Map map, UIElementCollection uiElementCollection, IMapModel mapModel)
    {
      this.map = map;
      this.mapping = new Dictionary<MapLayer, MapLayerPanel>();
      this.collection = uiElementCollection;
      this.mapModel = mapModel;
    }

    protected override void InsertItemInternal(int index, MapLayer obj)
    {
      MapLayerPanel mapLayerPanel = new MapLayerPanel();
      mapLayerPanel.ParentMap = this.map;
      mapLayerPanel.MapModel = this.mapModel;
      mapLayerPanel.Layer = obj;
      this.mapping.Add(obj, mapLayerPanel);
      this.collection.Insert(index, (UIElement) mapLayerPanel);
    }

    protected override void RemoveItemInternal(MapLayer obj)
    {
      MapLayerPanel mapLayerPanel;
      if (!this.mapping.TryGetValue(obj, out mapLayerPanel))
        return;
      this.mapping.Remove(obj);
      this.collection.Remove((UIElement) mapLayerPanel);
      mapLayerPanel.Layer = (MapLayer) null;
    }
  }
}
