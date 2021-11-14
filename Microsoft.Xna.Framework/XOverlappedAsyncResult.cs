// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.XOverlappedAsyncResult
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;
using System.Threading;

namespace Microsoft.Xna.Framework
{
  internal class XOverlappedAsyncResult : IAsyncResult
  {
    private object asyncState;
    private EventWaitHandle asyncWaitHandle;
    private bool isCompleted;
    private uint kernelHandle;
    private bool endHasBeenCalled;
    private bool isReusable;
    private AsyncOperationCleanup kernelHandleCleanup;

    object IAsyncResult.AsyncState => this.asyncState;

    WaitHandle IAsyncResult.AsyncWaitHandle => (WaitHandle) this.asyncWaitHandle;

    bool IAsyncResult.CompletedSynchronously => false;

    bool IAsyncResult.IsCompleted => this.isCompleted;

    internal EventWaitHandle AsyncWaitHandle => this.asyncWaitHandle;

    internal bool IsCompleted
    {
      set => this.isCompleted = value;
    }

    internal uint KernelHandle => this.kernelHandle;

    internal bool IsReusable => this.isReusable;

    internal XOverlappedAsyncResult(
      object asyncState,
      uint kernelHandle,
      bool isReusable,
      AsyncOperationCleanup kernelHandleCleanup)
    {
      this.asyncState = asyncState;
      this.kernelHandle = kernelHandle;
      this.isReusable = isReusable;
      this.kernelHandleCleanup = kernelHandleCleanup;
      if (isReusable)
        this.asyncWaitHandle = (EventWaitHandle) new AutoResetEvent(false);
      else
        this.asyncWaitHandle = (EventWaitHandle) new ManualResetEvent(false);
    }

    [SecuritySafeCritical]
    ~XOverlappedAsyncResult()
    {
      if (this.kernelHandleCleanup == null || UserAsyncDispatcher.OperationStillPending(this))
        return;
      this.kernelHandleCleanup(this.kernelHandle);
    }

    internal static XOverlappedAsyncResult PrepareForEndFunction(
      IAsyncResult result)
    {
      if (result == null)
        throw new ArgumentNullException(nameof (result));
      if (!(result is XOverlappedAsyncResult xoverlappedAsyncResult))
        throw new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
      xoverlappedAsyncResult.endHasBeenCalled = !xoverlappedAsyncResult.endHasBeenCalled ? true : throw new InvalidOperationException(FrameworkResources.CannotEndTwice);
      xoverlappedAsyncResult.AsyncWaitHandle.WaitOne();
      GC.SuppressFinalize((object) xoverlappedAsyncResult);
      return xoverlappedAsyncResult;
    }
  }
}
