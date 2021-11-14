// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameDispatcher
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Phone.Shell;
using MS.Internal;
using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework
{
  internal sealed class GameDispatcher
  {
    private static readonly GameDispatcher.FrameOrderComparer FrameComparer = new GameDispatcher.FrameOrderComparer();
    private static readonly GameDispatcher.UpdateOrderComparer UpdateComparer = new GameDispatcher.UpdateOrderComparer();
    private static readonly GameDispatcher.DrawOrderComparer DrawComparer = new GameDispatcher.DrawOrderComparer();
    private static readonly TimeSpan MaximumElapsedTime = TimeSpan.FromMilliseconds(500.0);
    private readonly object _timerListsLock = new object();
    private readonly List<GameTimer> _drawTimers;
    private GameTimer[] _drawTimersCopy;
    private volatile bool _drawTimersCopyValid;
    private readonly List<GameTimer> _frameTimers;
    private GameTimer[] _frameTimersCopy;
    private volatile bool _frameTimersCopyValid;
    private readonly List<GameTimer> _updateTimers;
    private readonly GameClock _clock;
    private TimeSpan _elapsedSinceLastRedraw;
    private TimeSpan _totalGameTime;
    private bool _forceElapsedTimeToZero;
    private volatile GameTimer _currentRunningUpdate;
    private volatile bool _currentRunningUpdatePendingRemoval;
    private volatile bool _suppressFrame;
    private static volatile GameDispatcher _dispatcher;
    private static readonly object _dispCreateLock = new object();
    private volatile bool _tickRegistered;
    private volatile bool _suspended;

    private GameDispatcher()
    {
      this._drawTimers = new List<GameTimer>();
      this._frameTimers = new List<GameTimer>();
      this._updateTimers = new List<GameTimer>();
      this._clock = new GameClock();
      this._elapsedSinceLastRedraw = TimeSpan.Zero;
      this._totalGameTime = TimeSpan.Zero;
      this._forceElapsedTimeToZero = true;
      if (PhoneApplicationService.Current == null)
        return;
      PhoneApplicationService.Current.Activated += new EventHandler<ActivatedEventArgs>(this.OnActivated);
      PhoneApplicationService.Current.Deactivated += new EventHandler<DeactivatedEventArgs>(this.OnDeactivated);
    }

    public static GameDispatcher Main
    {
      get
      {
        if (GameDispatcher._dispatcher == null)
        {
          lock (GameDispatcher._dispCreateLock)
          {
            if (GameDispatcher._dispatcher == null)
              GameDispatcher._dispatcher = new GameDispatcher();
          }
        }
        return GameDispatcher._dispatcher;
      }
    }

    internal static bool SkipTickRegisterForDirectRendering { get; set; }

    internal static bool SuppressDraw { get; set; }

    internal TimeSpan CurrentTime => this._totalGameTime;

    internal GameClock GameClock => this._clock;

    public void RegisterTimer(GameTimer timer)
    {
      if (timer == null)
        throw new ArgumentNullException(nameof (timer));
      lock (this._timerListsLock)
      {
        this.InsertOrderedTimer(this._drawTimers, timer, (IComparer<GameTimer>) GameDispatcher.DrawComparer);
        this.InsertOrderedTimer(this._frameTimers, timer, (IComparer<GameTimer>) GameDispatcher.FrameComparer);
        this.InsertOrderedTimer(this._updateTimers, timer, (IComparer<GameTimer>) GameDispatcher.UpdateComparer);
        this._frameTimersCopyValid = false;
        this._drawTimersCopyValid = false;
        if (this._frameTimers.Count <= 0 && this._updateTimers.Count <= 0)
          return;
        this.HookSilverlightTick();
      }
    }

    public void ReregisterFrameAction(GameTimer timer)
    {
      if (timer == null)
        throw new ArgumentNullException(nameof (timer));
      lock (this._timerListsLock)
      {
        this._frameTimers.Remove(timer);
        this.InsertOrderedTimer(this._frameTimers, timer, (IComparer<GameTimer>) GameDispatcher.FrameComparer);
        this._frameTimersCopyValid = false;
      }
    }

    public void ReregisterDraw(GameTimer timer)
    {
      if (timer == null)
        throw new ArgumentNullException(nameof (timer));
      lock (this._timerListsLock)
      {
        this._drawTimers.Remove(timer);
        this.InsertOrderedTimer(this._drawTimers, timer, (IComparer<GameTimer>) GameDispatcher.DrawComparer);
        this._drawTimersCopyValid = false;
      }
    }

    public void UnregisterTimer(GameTimer timer)
    {
      if (timer == null)
        throw new ArgumentNullException(nameof (timer));
      lock (this._timerListsLock)
      {
        this._drawTimers.Remove(timer);
        this._frameTimers.Remove(timer);
        if (this._currentRunningUpdate == null || this._currentRunningUpdate != timer)
          this._updateTimers.Remove(timer);
        else
          this._currentRunningUpdatePendingRemoval = true;
        this._frameTimersCopyValid = false;
        this._drawTimersCopyValid = false;
        if (this._frameTimers.Count != 0 || this._updateTimers.Count != 0)
          return;
        this.UnhookSilverlightTick();
      }
    }

    public void ResetElapsedTime() => this._forceElapsedTimeToZero = true;

    public void SuppressFrame() => this._suppressFrame = true;

    public void RunFrame()
    {
      this._suppressFrame = false;
      lock (this._timerListsLock)
      {
        if (!this._frameTimersCopyValid)
          this._frameTimersCopy = this._frameTimers.ToArray();
        if (!this._drawTimersCopyValid)
          this._drawTimersCopy = this._drawTimers.ToArray();
        this._frameTimersCopyValid = true;
        this._drawTimersCopyValid = true;
        this._clock.UpdateElapsedTime();
        this._clock.AdvanceFrameTime();
        TimeSpan elapsedTime;
        if (!this._forceElapsedTimeToZero)
        {
          elapsedTime = this._clock.ElapsedAdjustedTime;
          if (elapsedTime > GameDispatcher.MaximumElapsedTime)
            elapsedTime = GameDispatcher.MaximumElapsedTime;
          if (elapsedTime < TimeSpan.Zero)
            elapsedTime = TimeSpan.Zero;
        }
        else
        {
          elapsedTime = TimeSpan.Zero;
          this._elapsedSinceLastRedraw = TimeSpan.Zero;
          this._forceElapsedTimeToZero = false;
        }
        this._elapsedSinceLastRedraw += elapsedTime;
        this._totalGameTime += elapsedTime;
        foreach (GameTimer gameTimer in this._frameTimersCopy)
        {
          gameTimer.RaiseFrameAction();
          if (this._suppressFrame)
            return;
        }
        if (!this.AdvanceUpdates(elapsedTime) || GameDispatcher.SuppressDraw)
          return;
        GameTimerEventArgs gameArgs = new GameTimerEventArgs(this._totalGameTime, this._elapsedSinceLastRedraw);
        foreach (GameTimer gameTimer in this._drawTimersCopy)
        {
          if (!this._suppressFrame)
            gameTimer.RaiseDraw(gameArgs);
          else
            break;
        }
        this._elapsedSinceLastRedraw = TimeSpan.Zero;
      }
    }

    private bool AdvanceUpdates(TimeSpan elapsedTime)
    {
      bool flag = false;
      while (!this._suppressFrame && this._updateTimers.Count > 0 && this._updateTimers[0].IsUpdateReady(this._totalGameTime))
      {
        this._currentRunningUpdate = this._updateTimers[0];
        this._currentRunningUpdatePendingRemoval = false;
        this._updateTimers.RemoveAt(0);
        flag |= this._currentRunningUpdate.RaiseUpdate(this._totalGameTime, elapsedTime);
        if (!this._currentRunningUpdatePendingRemoval)
        {
          this.InsertOrderedTimer(this._updateTimers, this._currentRunningUpdate, (IComparer<GameTimer>) GameDispatcher.UpdateComparer);
          this._currentRunningUpdate = (GameTimer) null;
        }
      }
      return flag;
    }

    private void InsertOrderedTimer(
      List<GameTimer> list,
      GameTimer timer,
      IComparer<GameTimer> comparer)
    {
      int index = 0;
      while (index < list.Count && comparer.Compare(list[index], timer) <= 0)
        ++index;
      list.Insert(index, timer);
    }

    private void HookSilverlightTick()
    {
      if (this._tickRegistered || GameDispatcher.SkipTickRegisterForDirectRendering)
        return;
      DirectRendering.GameUpdate += new EventHandler(this.OnTick);
      this._tickRegistered = true;
    }

    private void UnhookSilverlightTick()
    {
      if (!this._tickRegistered)
        return;
      DirectRendering.GameUpdate -= new EventHandler(this.OnTick);
      this._tickRegistered = false;
    }

    private void OnTick(object sender, EventArgs e) => this.RunFrame();

    private void OnActivated(object sender, ActivatedEventArgs e)
    {
      if (this._frameTimers.Count > 0 || this._updateTimers.Count > 0)
        this.HookSilverlightTick();
      if (!this._suspended)
        return;
      this._clock.Resume();
      this.ResetElapsedTime();
      this._suspended = false;
    }

    private void OnDeactivated(object sender, DeactivatedEventArgs e)
    {
      if (!this._suspended)
      {
        this._clock.Suspend();
        this._suspended = true;
      }
      this.UnhookSilverlightTick();
    }

    private sealed class FrameOrderComparer : IComparer<GameTimer>
    {
      public int Compare(GameTimer x, GameTimer y)
      {
        if (x.FrameActionOrder == y.FrameActionOrder)
          return 0;
        return x.FrameActionOrder < y.FrameActionOrder ? -1 : 1;
      }
    }

    private sealed class UpdateOrderComparer : IComparer<GameTimer>
    {
      public int Compare(GameTimer x, GameTimer y)
      {
        if (x.NextUpdate < y.NextUpdate)
          return -1;
        if (x.NextUpdate > y.NextUpdate)
          return 1;
        if (x.UpdateOrder == y.UpdateOrder)
          return 0;
        return x.UpdateOrder < y.UpdateOrder ? -1 : 1;
      }
    }

    private sealed class DrawOrderComparer : IComparer<GameTimer>
    {
      public int Compare(GameTimer x, GameTimer y)
      {
        if (x.DrawOrder == y.DrawOrder)
          return 0;
        return x.DrawOrder < y.DrawOrder ? -1 : 1;
      }
    }
  }
}
