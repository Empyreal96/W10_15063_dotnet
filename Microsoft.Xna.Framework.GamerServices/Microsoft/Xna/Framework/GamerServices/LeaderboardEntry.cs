// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardEntry
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class LeaderboardEntry
  {
    private bool isReadOnly;
    private Gamer gamer;
    private long rating;
    internal bool ratingChanged;
    private PropertyDictionary columns;

    internal LeaderboardEntry(bool isReadOnly) => this.isReadOnly = isReadOnly;

    public Gamer Gamer
    {
      get => this.gamer;
      internal set => this.gamer = value;
    }

    public long Rating
    {
      get => this.rating;
      set
      {
        if (this.isReadOnly)
          throw new NotSupportedException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.ReadOnly, (object) typeof (LeaderboardEntry).Name));
        this.rating = value;
        this.Columns.SetValue("Score", value);
        this.ratingChanged = true;
      }
    }

    internal void SetRating(long value)
    {
      this.rating = value;
      if (this.isReadOnly)
        return;
      this.ratingChanged = true;
    }

    public PropertyDictionary Columns
    {
      get => this.columns;
      internal set => this.columns = value;
    }
  }
}
