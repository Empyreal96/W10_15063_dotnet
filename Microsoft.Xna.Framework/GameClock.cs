// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameClock
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Diagnostics;

namespace Microsoft.Xna.Framework
{
  internal class GameClock
  {
    private long baseRealTime;
    private long lastRealTime;
    private bool lastRealTimeValid;
    private int suspendCount;
    private long suspendStartTime;
    private long timeLostToSuspension;
    private long lastRealTimeCandidate;
    private TimeSpan currentTimeOffset;
    private TimeSpan currentTimeBase;
    private TimeSpan elapsedTime;
    private TimeSpan elapsedAdjustedTime;

    internal TimeSpan CurrentTime => this.currentTimeBase + this.currentTimeOffset;

    internal TimeSpan ElapsedTime => this.elapsedTime;

    internal TimeSpan ElapsedAdjustedTime => this.elapsedAdjustedTime;

    public GameClock() => this.Reset();

    internal void Reset()
    {
      this.currentTimeBase = TimeSpan.Zero;
      this.currentTimeOffset = TimeSpan.Zero;
      this.baseRealTime = GameClock.Counter;
      this.lastRealTimeValid = false;
    }

    internal void UpdateElapsedTime()
    {
      long counter = GameClock.Counter;
      if (!this.lastRealTimeValid)
      {
        this.lastRealTime = counter;
        this.lastRealTimeValid = true;
      }
      try
      {
        this.currentTimeOffset = GameClock.CounterToTimeSpan(counter - this.baseRealTime);
      }
      catch (OverflowException ex1)
      {
        this.currentTimeBase += this.currentTimeOffset;
        this.baseRealTime = this.lastRealTime;
        try
        {
          this.currentTimeOffset = GameClock.CounterToTimeSpan(counter - this.baseRealTime);
        }
        catch (OverflowException ex2)
        {
          this.baseRealTime = counter;
          this.currentTimeOffset = TimeSpan.Zero;
        }
      }
      try
      {
        this.elapsedTime = GameClock.CounterToTimeSpan(counter - this.lastRealTime);
      }
      catch (OverflowException ex)
      {
        this.elapsedTime = TimeSpan.Zero;
      }
      try
      {
        long num = this.lastRealTime + this.timeLostToSuspension;
        this.elapsedAdjustedTime = GameClock.CounterToTimeSpan(counter - num);
      }
      catch (OverflowException ex)
      {
        this.elapsedAdjustedTime = TimeSpan.Zero;
      }
      this.lastRealTimeCandidate = counter;
    }

    internal void AdvanceFrameTime()
    {
      this.lastRealTime = this.lastRealTimeCandidate;
      this.timeLostToSuspension = 0L;
    }

    internal void Suspend()
    {
      ++this.suspendCount;
      if (this.suspendCount != 1)
        return;
      this.suspendStartTime = GameClock.Counter;
    }

    internal void Resume()
    {
      --this.suspendCount;
      if (this.suspendCount > 0)
        return;
      this.timeLostToSuspension += GameClock.Counter - this.suspendStartTime;
      this.suspendStartTime = 0L;
    }

    internal static long Counter => Stopwatch.GetTimestamp();

    internal static long Frequency => (long) Stopwatch.Frequency;

    private static TimeSpan CounterToTimeSpan(long delta)
    {
      long num = 10000000;
      return TimeSpan.FromTicks(checked (delta * num) / GameClock.Frequency);
    }
  }
}
