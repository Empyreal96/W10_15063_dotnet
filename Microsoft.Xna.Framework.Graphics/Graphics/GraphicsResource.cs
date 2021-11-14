// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.GraphicsResource
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public abstract class GraphicsResource : IDisposable
  {
    internal uint pComPtr = uint.MaxValue;
    internal GraphicsDevice _parent;
    internal string _name = string.Empty;
    internal object _tag;
    internal bool _isDisposed;

    internal GraphicsResource()
    {
    }

    public string Name
    {
      get => this._name;
      set => this._name = value;
    }

    public object Tag
    {
      get => this._tag;
      set => this._tag = value;
    }

    public GraphicsDevice GraphicsDevice => this._parent;

    public override string ToString() => !string.IsNullOrEmpty(this._name) ? this._name : base.ToString();

    public bool IsDisposed => this._isDisposed;

    public event EventHandler<EventArgs> Disposing;

    ~GraphicsResource() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      this._isDisposed = true;
      if (!disposing || this.Disposing == null)
        return;
      this.Disposing((object) this, EventArgs.Empty);
    }
  }
}
