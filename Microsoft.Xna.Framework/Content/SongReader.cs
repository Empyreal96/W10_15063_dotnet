// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.SongReader
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Xna.Framework.Media;

namespace Microsoft.Xna.Framework.Content
{
  internal class SongReader : ContentTypeReader<Song>
  {
    protected internal override Song Read(ContentReader input, Song existingInstance)
    {
      string referenceName = input.ReadString();
      string absolutePathToReference = input.GetAbsolutePathToReference(referenceName);
      int duration = input.ReadObject<int>();
      return new Song(input.AssetName, absolutePathToReference, duration);
    }
  }
}
