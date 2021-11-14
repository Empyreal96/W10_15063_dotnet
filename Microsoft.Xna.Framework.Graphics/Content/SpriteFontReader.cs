// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.SpriteFontReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Content
{
  internal class SpriteFontReader : ContentTypeReader<SpriteFont>
  {
    protected internal override SpriteFont Read(
      ContentReader input,
      SpriteFont existingInstance)
    {
      Texture2D texture = input.ReadObject<Texture2D>();
      List<Rectangle> rectangleList1 = input.ReadObject<List<Rectangle>>();
      List<Rectangle> rectangleList2 = input.ReadObject<List<Rectangle>>();
      List<char> charList = input.ReadObject<List<char>>();
      int num1 = input.ReadInt32();
      float num2 = input.ReadSingle();
      List<Vector3> vector3List = input.ReadObject<List<Vector3>>();
      char? nullable = new char?();
      if (input.ReadBoolean())
        nullable = new char?(input.ReadChar());
      List<Rectangle> glyphs = rectangleList1;
      List<Rectangle> cropping = rectangleList2;
      List<char> charMap = charList;
      int lineSpacing = num1;
      double num3 = (double) num2;
      List<Vector3> kerning = vector3List;
      char? defaultCharacter = nullable;
      return new SpriteFont(texture, glyphs, cropping, charMap, lineSpacing, (float) num3, kerning, defaultCharacter);
    }
  }
}
