// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DisplayModeCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Graphics
{
  public class DisplayModeCollection : IEnumerable<DisplayMode>, IEnumerable
  {
    private List<DisplayMode> _displayModes;

    internal DisplayModeCollection(List<DisplayMode> displayModes) => this._displayModes = displayModes;

    public IEnumerable<DisplayMode> this[SurfaceFormat format]
    {
      get
      {
        List<DisplayMode> displayModeList = new List<DisplayMode>();
        foreach (DisplayMode displayMode in this._displayModes)
        {
          if (displayMode.Format == format)
            displayModeList.Add(displayMode);
        }
        return (IEnumerable<DisplayMode>) displayModeList;
      }
    }

    public IEnumerator<DisplayMode> GetEnumerator() => (IEnumerator<DisplayMode>) this._displayModes.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
