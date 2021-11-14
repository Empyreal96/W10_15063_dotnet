// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnTask
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices.LIVEn;
using System;
using System.Threading;

namespace GamerServices.Platforms.Web
{
  internal abstract class LIVEnTask : IAsyncResult
  {
    protected EventWaitHandle asyncWaitHandle;
    protected ILIVEnService webService;
    private Exception exception;
    protected bool endHasBeenCalled;

    public object AsyncState { get; protected set; }

    public WaitHandle AsyncWaitHandle => (WaitHandle) this.asyncWaitHandle;

    public bool CompletedSynchronously => false;

    public bool IsCompleted { get; protected set; }

    public AsyncCallback Callback { get; private set; }

    internal LIVEnTask() => this.asyncWaitHandle = (EventWaitHandle) new ManualResetEvent(false);

    public virtual void BeginProcess(
      ILIVEnService webService,
      AsyncCallback callback,
      object asyncState)
    {
      this.AsyncState = asyncState;
      this.Callback = callback;
      this.webService = webService;
      this.asyncWaitHandle.Reset();
      ThreadPool.QueueUserWorkItem(new WaitCallback(LIVEnTask.ThreadMain), (object) this);
    }

    public virtual void EndProcessWithCheck()
    {
      if (this.endHasBeenCalled)
        throw new InvalidOperationException(FrameworkResources.CannotEndTwice);
      this.EndProcess();
    }

    public virtual void EndProcess()
    {
      this.endHasBeenCalled = true;
      this.PrepareForEndProcess();
      if (this.exception != null)
        throw this.exception;
    }

    private static void ThreadMain(object state)
    {
      LIVEnTask livEnTask = state as LIVEnTask;
      try
      {
        livEnTask.Do();
      }
      catch (Exception ex)
      {
        livEnTask.exception = ex;
      }
      livEnTask.IsCompleted = true;
      livEnTask.asyncWaitHandle.Set();
      if (livEnTask.Callback == null)
        return;
      livEnTask.Callback((IAsyncResult) livEnTask);
    }

    public void PrepareForEndProcess() => this.asyncWaitHandle.WaitOne();

    public abstract void Do();
  }
}
