// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.UserAsyncDispatcher
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Security;
using System.Threading;

namespace Microsoft.Xna.Framework
{
  internal static class UserAsyncDispatcher
  {
    internal static readonly object PendingOperationsLock = new object();
    private static Dictionary<uint, PendingOperation> pendingOperations = new Dictionary<uint, PendingOperation>();
    private static bool initialized = false;
    internal static UserAsyncDispatcherFinalizerHelper finalizerHelper;

    internal static void Initialize()
    {
      if (UserAsyncDispatcher.initialized)
        return;
      UserAsyncDispatcher.PlatformSpecificInitialize();
      new Thread(new ThreadStart(UserAsyncDispatcher.AsyncDispatcherThreadFunction))
      {
        IsBackground = true
      }.Start();
      UserAsyncDispatcher.initialized = true;
    }

    [SecuritySafeCritical]
    private static void AsyncDispatcherThreadFunction()
    {
      while (true)
      {
        ManagedCallType managedCallType;
        uint managedCallArgs;
        KernelReturnCode finish = UserAsyncDispatcher.WaitForAsyncOperationToFinish(out managedCallType, out managedCallArgs);
        if (finish != KernelReturnCode.AsyncShutdown)
        {
          Helpers.ThrowExceptionFromResult((uint) finish);
          if (managedCallType == ManagedCallType.AsyncOperationCompleted)
            UserAsyncDispatcher.HandleFinishedOperation(managedCallArgs);
          else
            UserAsyncDispatcher.HandleManagedCallback(managedCallType, managedCallArgs);
        }
        else
          break;
      }
    }

    private static void HandleManagedCallback(ManagedCallType managedCallType, uint managedCallArgs)
    {
      if (managedCallType == ManagedCallType.NoManagedCall || !UserAsyncDispatcher.CallbackGoesToDispatcher(managedCallType))
        return;
      FrameworkDispatcher.AddNewPendingCall(managedCallType, managedCallArgs);
    }

    private static bool CallbackGoesToDispatcher(ManagedCallType managedCallType) => managedCallType == ManagedCallType.Media_ActiveSongChanged || managedCallType == ManagedCallType.Media_PlayStateChanged || managedCallType == ManagedCallType.CaptureBufferReady || managedCallType == ManagedCallType.PlaybackBufferNeeded;

    private static void HandleFinishedOperation(uint finishedHandle)
    {
      PendingOperation pendingOp;
      lock (UserAsyncDispatcher.PendingOperationsLock)
      {
        pendingOp = UserAsyncDispatcher.pendingOperations[finishedHandle];
        if (!pendingOp.Async.IsReusable)
        {
          UserAsyncDispatcher.pendingOperations.Remove(finishedHandle);
          pendingOp.Async.IsCompleted = true;
        }
      }
      pendingOp.Async.AsyncWaitHandle.Set();
      if (pendingOp.Callback == null)
        return;
      ThreadPool.QueueUserWorkItem((WaitCallback) delegate
      {
        pendingOp.Callback((IAsyncResult) pendingOp.Async);
      });
    }

    internal static IAsyncResult AddPendingOperation(
      uint kernelHandle,
      AsyncCallback callback,
      object asyncState)
    {
      return UserAsyncDispatcher.AddPendingOperation(kernelHandle, callback, asyncState, false, (AsyncOperationCleanup) null);
    }

    internal static IAsyncResult AddPendingOperation(
      uint kernelHandle,
      AsyncCallback callback,
      object asyncState,
      bool isReusable,
      AsyncOperationCleanup operationCleanup)
    {
      XOverlappedAsyncResult async = new XOverlappedAsyncResult(asyncState, kernelHandle, isReusable, operationCleanup);
      UserAsyncDispatcher.pendingOperations.Add(kernelHandle, new PendingOperation(async, callback));
      return (IAsyncResult) async;
    }

    internal static bool OperationStillPending(XOverlappedAsyncResult result)
    {
      lock (UserAsyncDispatcher.PendingOperationsLock)
        return UserAsyncDispatcher.pendingOperations.ContainsKey(result.KernelHandle);
    }

    [SecuritySafeCritical]
    private static void PlatformSpecificInitialize()
    {
      Helpers.ThrowExceptionFromResult((uint) UserAsyncDispatcher.KernelAsyncDispatcher_Initialize());
      UserAsyncDispatcher.finalizerHelper = new UserAsyncDispatcherFinalizerHelper();
    }

    [SecuritySafeCritical]
    internal static KernelReturnCode KernelAsyncDispatcher_Initialize() => UserAsyncDispatcherUnsafeNativeMethodsXboxZune.KernelAsyncDispatcher_Initialize();

    [SecuritySafeCritical]
    internal static KernelReturnCode WaitForAsyncOperationToFinish(
      out ManagedCallType managedCallType,
      out uint managedCallArgs)
    {
      return UserAsyncDispatcherUnsafeNativeMethodsXboxZune.WaitForAsyncOperationToFinish(out managedCallType, out managedCallArgs);
    }
  }
}
