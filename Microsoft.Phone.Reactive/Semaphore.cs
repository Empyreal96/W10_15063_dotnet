// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Semaphore
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  internal sealed class Semaphore : IDisposable
  {
    private readonly int m_maximumCount;
    private int m_currentCount;
    private bool m_disposed;
    private object m_lockObject;

    public Semaphore(int initialCount, int maximumCount)
    {
      if (initialCount < 0)
        throw new ArgumentOutOfRangeException(nameof (initialCount), "Non-negative number required.");
      if (maximumCount < 1)
        throw new ArgumentOutOfRangeException(nameof (maximumCount), "Positive number required.");
      this.m_currentCount = initialCount <= maximumCount ? initialCount : throw new ArgumentException("Initial count must be smaller than maximum");
      this.m_maximumCount = maximumCount;
      this.m_lockObject = new object();
    }

    public void Dispose()
    {
      this.m_disposed = true;
      this.m_lockObject = (object) null;
    }

    public int Release() => this.Release(1);

    public int Release(int releaseCount)
    {
      if (releaseCount < 1)
        throw new ArgumentOutOfRangeException(nameof (releaseCount), "Positive number required.");
      if (this.m_disposed)
        throw new ObjectDisposedException(nameof (Semaphore));
      lock (this.m_lockObject)
      {
        if (releaseCount + this.m_currentCount > this.m_maximumCount)
          throw new ArgumentOutOfRangeException(nameof (releaseCount), "Amount of releases would overflow maximum");
        this.m_currentCount += releaseCount;
        Monitor.PulseAll(this.m_lockObject);
      }
      return releaseCount;
    }

    public bool WaitOne() => this.WaitOne(-1);

    public bool WaitOne(int millisecondsTimeout)
    {
      if (this.m_disposed)
        throw new ObjectDisposedException(nameof (Semaphore));
      lock (this.m_lockObject)
      {
        while (this.m_currentCount == 0)
        {
          if (!Monitor.Wait(this.m_lockObject, millisecondsTimeout))
            return false;
        }
        --this.m_currentCount;
        return true;
      }
    }

    public bool WaitOne(TimeSpan timeout) => this.WaitOne((int) timeout.TotalMilliseconds);

    public void Close() => this.Dispose();
  }
}
