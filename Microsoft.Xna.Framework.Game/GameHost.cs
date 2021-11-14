// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameHost
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Xna.Framework.GamerServices;
using System;

namespace Microsoft.Xna.Framework
{
  internal abstract class GameHost
  {
    internal abstract GameWindow Window { get; }

    internal event EventHandler<EventArgs> Suspend;

    internal event EventHandler<EventArgs> Resume;

    internal event EventHandler<EventArgs> Activated;

    internal event EventHandler<EventArgs> Deactivated;

    internal event EventHandler<EventArgs> Idle;

    internal event EventHandler<EventArgs> Exiting;

    internal abstract void Run();

    internal abstract void RunOneFrame();

    internal abstract void StartGameLoop();

    internal abstract void Exit();

    protected void OnSuspend()
    {
      if (this.Suspend == null)
        return;
      this.Suspend((object) this, EventArgs.Empty);
    }

    protected void OnResume()
    {
      if (this.Resume == null)
        return;
      this.Resume((object) this, EventArgs.Empty);
    }

    protected void OnActivated()
    {
      if (this.Activated == null)
        return;
      this.Activated((object) this, EventArgs.Empty);
    }

    protected void OnDeactivated()
    {
      if (this.Deactivated == null)
        return;
      this.Deactivated((object) this, EventArgs.Empty);
    }

    protected void OnIdle()
    {
      if (this.Idle == null)
        return;
      this.Idle((object) this, EventArgs.Empty);
    }

    protected void OnExiting()
    {
      Guide.CloseDialog();
      if (this.Exiting == null)
        return;
      this.Exiting((object) this, EventArgs.Empty);
    }

    internal virtual bool ShowMissingRequirementMessage(Exception exception) => false;

    internal virtual void OnPresent()
    {
    }
  }
}
