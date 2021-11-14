// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapLayerPanel
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapLayerPanel : Canvas
  {
    public static readonly DependencyProperty LayerProperty = DependencyProperty.Register(nameof (Layer), typeof (MapLayer), typeof (MapLayerPanel), new PropertyMetadata(new PropertyChangedCallback(MapLayerPanel.OnLayerChanged)));
    private MapLayerManager layerManager;
    private IMapModel mapModel;

    public MapLayerPanel() => this.layerManager = new MapLayerManager(this.Children);

    public MapLayer Layer
    {
      get => (MapLayer) this.GetValue(MapLayerPanel.LayerProperty);
      set => this.SetValue(MapLayerPanel.LayerProperty, (object) value);
    }

    internal Map ParentMap
    {
      get => this.layerManager.ParentMap;
      set => this.layerManager.ParentMap = value;
    }

    internal IMapModel MapModel
    {
      get => this.mapModel;
      set
      {
        this.layerManager.MapModel = value;
        this.mapModel = value;
      }
    }

    private static void OnLayerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      MapLayerPanel mapLayerPanel = (MapLayerPanel) d;
      if (e.OldValue is MapLayer oldValue)
      {
        // ISSUE: method pointer
        oldValue.CollectionChanged -= new NotifyCollectionChangedEventHandler((object) mapLayerPanel.layerManager, __methodptr(CollectionChanged));
        mapLayerPanel.layerManager.Clear();
      }
      if (!(e.NewValue is MapLayer newValue))
        return;
      mapLayerPanel.layerManager.AddRange((IEnumerable<MapOverlay>) newValue);
      // ISSUE: method pointer
      newValue.CollectionChanged += new NotifyCollectionChangedEventHandler((object) mapLayerPanel.layerManager, __methodptr(CollectionChanged));
    }
  }
}
