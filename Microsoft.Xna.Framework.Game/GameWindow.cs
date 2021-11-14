// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameWindow
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  public abstract class GameWindow
  {
    internal static readonly int DefaultClientWidth = 800;
    internal static readonly int DefaultClientHeight = 600;
    private string title;

    public string Title
    {
      get => this.title;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value), Resources.TitleCannotBeNull);
        if (!(this.title != value))
          return;
        this.title = value;
        this.SetTitle(this.title);
      }
    }

    public abstract IntPtr Handle { get; }

    public abstract bool AllowUserResizing { get; set; }

    internal abstract bool IsMouseVisible { get; set; }

    internal abstract bool IsMinimized { get; }

    public abstract Rectangle ClientBounds { get; }

    public abstract string ScreenDeviceName { get; }

    public abstract DisplayOrientation CurrentOrientation { get; }

    internal event EventHandler<EventArgs> Activated;

    internal event EventHandler<EventArgs> Deactivated;

    internal event EventHandler<EventArgs> Paint;

    public event EventHandler<EventArgs> ScreenDeviceNameChanged;

    public event EventHandler<EventArgs> ClientSizeChanged;

    public event EventHandler<EventArgs> OrientationChanged;

    internal GameWindow() => this.title = string.Empty;

    public abstract void BeginScreenDeviceChange(bool willBeFullScreen);

    public abstract void EndScreenDeviceChange(
      string screenDeviceName,
      int clientWidth,
      int clientHeight);

    public void EndScreenDeviceChange(string screenDeviceName) => this.EndScreenDeviceChange(screenDeviceName, this.ClientBounds.Width, this.ClientBounds.Height);

    protected abstract void SetTitle(string title);

    protected internal abstract void SetSupportedOrientations(DisplayOrientation orientations);

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

    protected void OnPaint()
    {
      if (this.Paint == null)
        return;
      this.Paint((object) this, EventArgs.Empty);
    }

    protected void OnScreenDeviceNameChanged()
    {
      if (this.ScreenDeviceNameChanged == null)
        return;
      this.ScreenDeviceNameChanged((object) this, EventArgs.Empty);
    }

    protected void OnClientSizeChanged()
    {
      if (this.ClientSizeChanged == null)
        return;
      this.ClientSizeChanged((object) this, EventArgs.Empty);
    }

    protected void OnOrientationChanged()
    {
      if (this.OrientationChanged == null)
        return;
      this.OrientationChanged((object) this, EventArgs.Empty);
    }
  }
}
