// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapLayerManager
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapLayerManager : CollectionManager<MapOverlay>
  {
    private UIElementCollection collection;
    private IMapModel mapModel;

    public MapLayerManager(UIElementCollection uiElementCollection) => this.collection = uiElementCollection;

    public Map ParentMap { get; set; }

    public IMapModel MapModel
    {
      get => this.mapModel;
      set
      {
        this.mapModel = value;
        foreach (MapOverlayPresenter overlayPresenter in (PresentationFrameworkCollection<UIElement>) this.collection)
          overlayPresenter.Model.MapModel = this.MapModel;
      }
    }

    protected override void InsertItemInternal(int index, MapOverlay obj)
    {
      obj.SetupPresenter(this.ParentMap, this.MapModel);
      this.collection.Insert(index, (UIElement) obj.Presenter);
    }

    protected override void RemoveItemInternal(MapOverlay obj)
    {
      this.collection.Remove((UIElement) obj.Presenter);
      obj.ClearPresenter();
    }
  }
}
