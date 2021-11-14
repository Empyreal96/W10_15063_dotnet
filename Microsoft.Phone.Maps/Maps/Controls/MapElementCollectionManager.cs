// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapElementCollectionManager
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapElementCollectionManager : CollectionManager<MapElement>
  {
    private readonly IMapModel mapModel;

    public MapElementCollectionManager(IMapModel mapModel) => this.mapModel = mapModel;

    protected override void InsertItemInternal(int index, MapElement item)
    {
      for (int index1 = index; index1 < this.Count; ++index1)
        this.RemoveMapElement(this[index1]);
      this.AddMapElement(item);
      for (int index1 = index; index1 < this.Count; ++index1)
        this.AddMapElement(this[index1]);
    }

    protected override void RemoveItemInternal(MapElement item) => this.RemoveMapElement(item);

    private void AddMapElement(MapElement mapElement) => this.mapModel.AddMapElement(mapElement);

    private void RemoveMapElement(MapElement mapElement) => this.mapModel.RemoveMapElement(mapElement);
  }
}
