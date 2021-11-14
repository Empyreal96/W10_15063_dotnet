// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.TileSourceCollectionManager
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

namespace Microsoft.Phone.Maps.Controls
{
  internal class TileSourceCollectionManager : CollectionManager<TileSource>
  {
    private readonly IMapModel mapModel;

    public TileSourceCollectionManager(IMapModel mapModel) => this.mapModel = mapModel;

    protected override void InsertItemInternal(int index, TileSource item)
    {
      for (int index1 = index; index1 < this.Count; ++index1)
        this.RemoveTileSource(this[index1]);
      this.AddTileSource(item);
      for (int index1 = index; index1 < this.Count; ++index1)
        this.AddTileSource(this[index1]);
    }

    protected override void RemoveItemInternal(TileSource item) => this.RemoveTileSource(item);

    private void AddTileSource(TileSource tileSource) => this.mapModel.AddTileSource(tileSource.TileSourceModel);

    private void RemoveTileSource(TileSource tileSource) => this.mapModel.RemoveTileSource(tileSource.TileSourceModel);
  }
}
