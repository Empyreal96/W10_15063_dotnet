// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.GenreEnumerator
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Media
{
  internal class GenreEnumerator : MediaLibraryEnumerator<Genre>
  {
    internal static GenreEnumerator Empty = new GenreEnumerator();
    protected GenreCollection collection;

    internal GenreEnumerator()
    {
    }

    internal GenreEnumerator(GenreCollection collection, uint handle)
      : base(handle)
    {
      this.collection = collection;
    }

    protected override Genre CreateItemInstance(uint handleItem) => new Genre(handleItem);
  }
}
