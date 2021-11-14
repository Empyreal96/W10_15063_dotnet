// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameComponent
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework
{
  public class GameComponent : IGameComponent, IUpdateable, IDisposable
  {
    private bool enabled = true;
    private int updateOrder;
    private Game game;

    public bool Enabled
    {
      get => this.enabled;
      set
      {
        if (this.enabled == value)
          return;
        this.enabled = value;
        this.OnEnabledChanged((object) this, EventArgs.Empty);
      }
    }

    public int UpdateOrder
    {
      get => this.updateOrder;
      set
      {
        if (this.updateOrder == value)
          return;
        this.updateOrder = value;
        this.OnUpdateOrderChanged((object) this, EventArgs.Empty);
      }
    }

    public Game Game => this.game;

    public event EventHandler<EventArgs> EnabledChanged;

    public event EventHandler<EventArgs> UpdateOrderChanged;

    public event EventHandler<EventArgs> Disposed;

    public GameComponent(Game game) => this.game = game;

    public virtual void Initialize()
    {
    }

    public virtual void Update(GameTime gameTime)
    {
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~GameComponent() => this.Dispose(false);

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      lock (this)
      {
        if (this.Game != null)
          this.Game.Components.Remove((IGameComponent) this);
        if (this.Disposed == null)
          return;
        this.Disposed((object) this, EventArgs.Empty);
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
    {
      if (this.UpdateOrderChanged == null)
        return;
      this.UpdateOrderChanged((object) this, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnEnabledChanged(object sender, EventArgs args)
    {
      if (this.EnabledChanged == null)
        return;
      this.EnabledChanged((object) this, args);
    }
  }
}
