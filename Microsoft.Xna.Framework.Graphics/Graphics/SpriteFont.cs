// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.SpriteFont
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class SpriteFont
  {
    private Texture2D textureValue;
    private List<Rectangle> glyphData;
    private List<Rectangle> croppingData;
    private List<char> characterMap;
    private List<Vector3> kerning;
    private int lineSpacing;
    private float spacing;
    private char? defaultCharacter;
    private ReadOnlyCollection<char> characters;

    public int LineSpacing
    {
      get => this.lineSpacing;
      set => this.lineSpacing = value;
    }

    public float Spacing
    {
      get => this.spacing;
      set => this.spacing = value;
    }

    public char? DefaultCharacter
    {
      get => this.defaultCharacter;
      set
      {
        if (value.HasValue && !this.characterMap.Contains(value.Value))
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.CharacterNotInFont, (object) value.Value, (object) (int) value.Value));
        this.defaultCharacter = value;
      }
    }

    public ReadOnlyCollection<char> Characters
    {
      get
      {
        if (this.characters == null)
          this.characters = new ReadOnlyCollection<char>((IList<char>) this.characterMap);
        return this.characters;
      }
    }

    internal SpriteFont(
      Texture2D texture,
      List<Rectangle> glyphs,
      List<Rectangle> cropping,
      List<char> charMap,
      int lineSpacing,
      float spacing,
      List<Vector3> kerning,
      char? defaultCharacter)
    {
      this.textureValue = texture;
      this.glyphData = glyphs;
      this.croppingData = cropping;
      this.characterMap = charMap;
      this.lineSpacing = lineSpacing;
      this.spacing = spacing;
      this.kerning = kerning;
      this.defaultCharacter = defaultCharacter;
    }

    public Vector2 MeasureString(string text)
    {
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      return this.InternalMeasure(ref text1);
    }

    public Vector2 MeasureString(StringBuilder text)
    {
      SpriteFont.StringProxy text1 = text != null ? new SpriteFont.StringProxy(text) : throw new ArgumentNullException(nameof (text));
      return this.InternalMeasure(ref text1);
    }

    private Vector2 InternalMeasure(ref SpriteFont.StringProxy text)
    {
      if (text.Length == 0)
        return Vector2.Zero;
      Vector2 zero = Vector2.Zero;
      zero.Y = (float) this.lineSpacing;
      float val2 = 0.0f;
      int num = 0;
      float val1 = 0.0f;
      bool flag = true;
      for (int index = 0; index < text.Length; ++index)
      {
        if (text[index] != '\r')
        {
          if (text[index] == '\n')
          {
            zero.X += Math.Max(val1, 0.0f);
            val1 = 0.0f;
            val2 = Math.Max(zero.X, val2);
            zero = Vector2.Zero;
            zero.Y = (float) this.lineSpacing;
            flag = true;
            ++num;
          }
          else
          {
            Vector3 vector3 = this.kerning[this.GetIndexForCharacter(text[index])];
            if (flag)
              vector3.X = Math.Max(vector3.X, 0.0f);
            else
              zero.X += this.spacing + val1;
            zero.X += vector3.X + vector3.Y;
            val1 = vector3.Z;
            Rectangle rectangle = this.croppingData[this.GetIndexForCharacter(text[index])];
            zero.Y = Math.Max(zero.Y, (float) rectangle.Height);
            flag = false;
          }
        }
      }
      zero.X += Math.Max(val1, 0.0f);
      zero.Y += (float) (num * this.lineSpacing);
      zero.X = Math.Max(zero.X, val2);
      return zero;
    }

    internal void InternalDraw(
      ref SpriteFont.StringProxy text,
      SpriteBatch spriteBatch,
      Vector2 textblockPosition,
      Color color,
      float rotation,
      Vector2 origin,
      ref Vector2 scale,
      SpriteEffects spriteEffects,
      float depth)
    {
      Matrix result1;
      Matrix.CreateRotationZ(rotation, out result1);
      Matrix result2;
      Matrix.CreateTranslation(-origin.X * scale.X, -origin.Y * scale.Y, 0.0f, out result2);
      ref Matrix local1 = ref result2;
      ref Matrix local2 = ref result1;
      Matrix.Multiply(ref local1, ref local2, out local2);
      int num1 = 1;
      float num2 = 0.0f;
      Vector2 vector2 = new Vector2();
      bool flag = true;
      if ((spriteEffects & SpriteEffects.FlipHorizontally) == SpriteEffects.FlipHorizontally)
      {
        num2 = this.InternalMeasure(ref text).X * scale.X;
        num1 = -1;
      }
      vector2.Y = (spriteEffects & SpriteEffects.FlipVertically) != SpriteEffects.FlipVertically ? 0.0f : (this.InternalMeasure(ref text).Y - (float) this.lineSpacing) * scale.Y;
      vector2.X = num2;
      for (int index = 0; index < text.Length; ++index)
      {
        char character = text[index];
        switch (character)
        {
          case '\n':
            flag = true;
            vector2.X = num2;
            if ((spriteEffects & SpriteEffects.FlipVertically) == SpriteEffects.FlipVertically)
            {
              vector2.Y -= (float) this.lineSpacing * scale.Y;
              continue;
            }
            vector2.Y += (float) this.lineSpacing * scale.Y;
            continue;
          case '\r':
            continue;
          default:
            int indexForCharacter = this.GetIndexForCharacter(character);
            Vector3 vector3 = this.kerning[indexForCharacter];
            if (flag)
              vector3.X = Math.Max(vector3.X, 0.0f);
            else
              vector2.X += this.spacing * scale.X * (float) num1;
            vector2.X += vector3.X * scale.X * (float) num1;
            Rectangle rectangle1 = this.glyphData[indexForCharacter];
            Rectangle rectangle2 = this.croppingData[indexForCharacter];
            if ((spriteEffects & SpriteEffects.FlipVertically) == SpriteEffects.FlipVertically)
              rectangle2.Y = this.lineSpacing - rectangle1.Height - rectangle2.Y;
            if ((spriteEffects & SpriteEffects.FlipHorizontally) == SpriteEffects.FlipHorizontally)
              rectangle2.X -= rectangle2.Width;
            Vector2 result3 = vector2;
            result3.X += (float) rectangle2.X * scale.X;
            result3.Y += (float) rectangle2.Y * scale.Y;
            Vector2.Transform(ref result3, ref result1, out result3);
            result3 += textblockPosition;
            spriteBatch.Draw(this.textureValue, result3, new Rectangle?(rectangle1), color, rotation, Vector2.Zero, scale, spriteEffects, depth);
            flag = false;
            vector2.X += (vector3.Y + vector3.Z) * scale.X * (float) num1;
            continue;
        }
      }
    }

    private int GetIndexForCharacter(char character)
    {
      int num1 = 0;
      int num2 = this.characterMap.Count - 1;
      while (num1 <= num2)
      {
        int index = num1 + (num2 - num1 >> 1);
        char character1 = this.characterMap[index];
        if ((int) character1 == (int) character)
          return index;
        if ((int) character1 < (int) character)
          num1 = index + 1;
        else
          num2 = index - 1;
      }
      char character2 = this.defaultCharacter.HasValue ? this.defaultCharacter.Value : throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.CharacterNotInFont, (object) character, (object) (int) character), nameof (character));
      if ((int) character != (int) character2)
        return this.GetIndexForCharacter(character2);
    }

    internal struct StringProxy
    {
      private string textString;
      private StringBuilder textBuilder;
      public readonly int Length;

      public StringProxy(string text)
      {
        this.textString = text;
        this.textBuilder = (StringBuilder) null;
        this.Length = text.Length;
      }

      public StringProxy(StringBuilder text)
      {
        this.textBuilder = text;
        this.textString = (string) null;
        this.Length = text.Length;
      }

      public char this[int index] => this.textString != null ? this.textString[index] : this.textBuilder[index];
    }
  }
}
