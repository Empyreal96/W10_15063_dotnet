// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameTime
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  public class GameTime
  {
    private TimeSpan totalGameTime;
    private TimeSpan elapsedGameTime;
    private bool isRunningSlowly;

    public GameTime()
    {
    }

    public GameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly)
    {
      this.totalGameTime = totalGameTime;
      this.elapsedGameTime = elapsedGameTime;
      this.isRunningSlowly = isRunningSlowly;
    }

    public GameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime)
      : this(totalGameTime, elapsedGameTime, false)
    {
    }

    public TimeSpan TotalGameTime
    {
      get => this.totalGameTime;
      internal set => this.totalGameTime = value;
    }

    public TimeSpan ElapsedGameTime
    {
      get => this.elapsedGameTime;
      internal set => this.elapsedGameTime = value;
    }

    public bool IsRunningSlowly
    {
      get => this.isRunningSlowly;
      internal set => this.isRunningSlowly = value;
    }
  }
}
