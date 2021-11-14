// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.DrawableGameComponent
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework
{
  public class DrawableGameComponent : GameComponent, IDrawable
  {
    private bool initialized;
    private bool visible = true;
    private int drawOrder;
    private IGraphicsDeviceService deviceService;

    public bool Visible
    {
      get => this.visible;
      set
      {
        if (this.visible == value)
          return;
        this.visible = value;
        this.OnVisibleChanged((object) this, EventArgs.Empty);
      }
    }

    public int DrawOrder
    {
      get => this.drawOrder;
      set
      {
        if (this.drawOrder == value)
          return;
        this.drawOrder = value;
        this.OnDrawOrderChanged((object) this, EventArgs.Empty);
      }
    }

    public GraphicsDevice GraphicsDevice => this.deviceService != null ? this.deviceService.GraphicsDevice : throw new InvalidOperationException(Resources.PropertyCannotBeCalledBeforeInitialize);

    public event EventHandler<EventArgs> VisibleChanged;

    public event EventHandler<EventArgs> DrawOrderChanged;

    public DrawableGameComponent(Game game)
      : base(game)
    {
    }

    public override void Initialize()
    {
      base.Initialize();
      if (!this.initialized)
      {
        this.deviceService = this.Game.Services.GetService(typeof (IGraphicsDeviceService)) as IGraphicsDeviceService;
        if (this.deviceService == null)
          throw new InvalidOperationException(Resources.MissingGraphicsDeviceService);
        this.deviceService.DeviceCreated += new EventHandler<EventArgs>(this.DeviceCreated);
        this.deviceService.DeviceResetting += new EventHandler<EventArgs>(this.DeviceResetting);
        this.deviceService.DeviceReset += new EventHandler<EventArgs>(this.DeviceReset);
        this.deviceService.DeviceDisposing += new EventHandler<EventArgs>(this.DeviceDisposing);
        if (this.deviceService.GraphicsDevice != null)
          this.LoadContent();
      }
      this.initialized = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        this.UnloadContent();
        if (this.deviceService != null)
        {
          this.deviceService.DeviceCreated -= new EventHandler<EventArgs>(this.DeviceCreated);
          this.deviceService.DeviceResetting -= new EventHandler<EventArgs>(this.DeviceResetting);
          this.deviceService.DeviceReset -= new EventHandler<EventArgs>(this.DeviceReset);
          this.deviceService.DeviceDisposing -= new EventHandler<EventArgs>(this.DeviceDisposing);
        }
      }
      base.Dispose(disposing);
    }

    private void DeviceResetting(object sender, EventArgs e)
    {
    }

    private void DeviceReset(object sender, EventArgs e)
    {
    }

    private void DeviceCreated(object sender, EventArgs e) => this.LoadContent();

    private void DeviceDisposing(object sender, EventArgs e) => this.UnloadContent();

    public virtual void Draw(GameTime gameTime)
    {
    }

    protected virtual void LoadContent()
    {
    }

    protected virtual void UnloadContent()
    {
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnDrawOrderChanged(object sender, EventArgs args)
    {
      if (this.DrawOrderChanged == null)
        return;
      this.DrawOrderChanged((object) this, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnVisibleChanged(object sender, EventArgs args)
    {
      if (this.VisibleChanged == null)
        return;
      this.VisibleChanged((object) this, args);
    }
  }
}
