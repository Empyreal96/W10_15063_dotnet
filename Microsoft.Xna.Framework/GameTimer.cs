// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameTimer
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  public sealed class GameTimer : IDisposable
  {
    private const int DefaultOrder = 0;
    private static readonly TimeSpan DefaultUpdateInterval = TimeSpan.FromTicks(333333L);
    private static readonly TimeSpan VariableStepIncrement = TimeSpan.FromTicks(1L);
    private static readonly TimeSpan MaximumUpdateInterval = TimeSpan.FromDays(30.0);
    private readonly GameTimerEventArgs _updateArgs;
    private bool _enabled;
    private TimeSpan _nextUpdate;
    private int _drawOrder;
    private int _frameActionOrder;
    private int _updateOrder;
    private TimeSpan _updateInterval;
    private bool _isVariableStep;

    public event EventHandler<GameTimerEventArgs> Draw;

    public event EventHandler<EventArgs> FrameAction;

    public event EventHandler<GameTimerEventArgs> Update;

    internal TimeSpan NextUpdate => this._nextUpdate;

    public int DrawOrder
    {
      get => this._drawOrder;
      set
      {
        if (this._drawOrder == value)
          return;
        this._drawOrder = value;
        if (!this._enabled)
          return;
        GameDispatcher.Main.ReregisterDraw(this);
      }
    }

    public int FrameActionOrder
    {
      get => this._frameActionOrder;
      set
      {
        if (this._frameActionOrder == value)
          return;
        this._frameActionOrder = value;
        if (!this._enabled)
          return;
        GameDispatcher.Main.ReregisterFrameAction(this);
      }
    }

    public int UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    public TimeSpan UpdateInterval
    {
      get => this._updateInterval;
      set
      {
        if (value < TimeSpan.Zero)
          throw new ArgumentOutOfRangeException(nameof (value), FrameworkResources.TargetElapsedNegative);
        if (value > GameTimer.MaximumUpdateInterval)
          throw new ArgumentOutOfRangeException(nameof (value), FrameworkResources.TargetElapsedTooLarge);
        this._isVariableStep = value == TimeSpan.Zero;
        this._updateInterval = value;
      }
    }

    public GameTimer()
    {
      this._updateArgs = new GameTimerEventArgs();
      this._updateInterval = GameTimer.DefaultUpdateInterval;
      this._drawOrder = 0;
      this._frameActionOrder = 0;
      this._updateOrder = 0;
    }

    public static void SuppressFrame() => GameDispatcher.Main.SuppressFrame();

    public static void ResetElapsedTime() => GameDispatcher.Main.ResetElapsedTime();

    public void Start()
    {
      if (this._enabled)
        return;
      this.Reset();
      GameDispatcher.Main.RegisterTimer(this);
      this._enabled = true;
    }

    public void Stop()
    {
      if (!this._enabled)
        return;
      this._enabled = false;
      GameDispatcher.Main.UnregisterTimer(this);
    }

    internal void Reset() => this._nextUpdate = GameDispatcher.Main.CurrentTime + this._updateInterval;

    internal void RaiseFrameAction()
    {
      EventHandler<EventArgs> frameAction = this.FrameAction;
      if (!this._enabled || frameAction == null)
        return;
      frameAction((object) this, EventArgs.Empty);
    }

    internal bool IsUpdateReady(TimeSpan totalTime) => totalTime >= this._nextUpdate;

    internal bool RaiseUpdate(TimeSpan totalTime, TimeSpan elapsedTime)
    {
      if (this._isVariableStep)
      {
        this._updateArgs.TotalTime = totalTime;
        this._updateArgs.ElapsedTime = elapsedTime;
        this._nextUpdate = totalTime + GameTimer.VariableStepIncrement;
      }
      else
      {
        this._updateArgs.TotalTime = this._nextUpdate;
        this._updateArgs.ElapsedTime = this._updateInterval;
        this._nextUpdate += this._updateInterval;
      }
      EventHandler<GameTimerEventArgs> update = this.Update;
      if (!this._enabled || update == null)
        return false;
      update((object) this, this._updateArgs);
      return true;
    }

    internal void RaiseDraw(GameTimerEventArgs gameArgs)
    {
      EventHandler<GameTimerEventArgs> draw = this.Draw;
      if (!this._enabled || draw == null)
        return;
      draw((object) this, gameArgs);
    }

    public void Dispose() => this.Stop();
  }
}
