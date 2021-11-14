// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.DrawOrderComparer
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System.Collections.Generic;

namespace Microsoft.Xna.Framework
{
  internal class DrawOrderComparer : IComparer<IDrawable>
  {
    public static readonly DrawOrderComparer Default = new DrawOrderComparer();

    public int Compare(IDrawable x, IDrawable y)
    {
      if (x == null && y == null)
        return 0;
      if (x == null)
        return 1;
      if (y == null)
        return -1;
      if (x.Equals((object) y))
        return 0;
      return x.DrawOrder < y.DrawOrder ? -1 : 1;
    }
  }
}
