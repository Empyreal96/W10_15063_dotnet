// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.Task
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.Shell;
using MS.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecuritySafeCritical]
  internal class Task : ITask
  {
    private Task.OnTaskStateChange mOnNativeLaunching;
    private Task.OnTaskPaused mOnNativePause;
    private Task.OnTaskResumed mOnNativeResume;
    private Task.OnTaskStateChange mOnNativeRunningInBackground;
    private Task.OnTaskStateChange mOnNativeCancel;
    private Task.OnTaskStateChange mOnNativeClosing;
    private Task.OnTaskNavigateTo mOnNativeNavigateTo;
    private Task.OnTaskNavigateAway mOnNativeNavigateAway;
    private Task.OnTaskStateChange mOnRefresh;
    private Task.OnTaskVisibilityChange mOnNativeShow;
    private Task.OnTaskVisibilityChange mOnNativeHide;
    private Task.OnTaskSystemKeyPressed mOnSystemKeyPressed;
    private Task.OnChildTaskReturnedNative mOnChildTaskReturned;
    private Task.OnVisibleRegionChanged mOnVisibleRegionChange;
    private Task.OnTaskStateChange mOnHostDehydrating;
    private SafeAppChromeHandle mAppChromeHandle;
    private Task.OnTaskOrientationChanged mOnOrientationChanged;
    private Task.OnTaskSipVisibilityChange mOnSipVisibilityChange;
    private Task.OnTaskNavBarVisibilityChange mOnNavBarVisibilityChange;
    private Task.OnTaskObscurityChange mOnObscurityChange;
    private Task.OnTaskLockScreenVisibilityChange mOnLockScreenVisibilityChange;
    private Task.OnTaskApplicationLayerChange mOnApplicationLayerChange;
    private Task.OnRequestOverlayTaskStateChange mOnRequestOverlayStateChange;
    private Task.OnTaskModernActivation mOnModernActivation;
    private uint _taskID;
    private bool _isObscured;
    private bool _pauseOnLock = true;
    private bool _isDetached;
    private bool _isCompleted;
    private bool _isShowing;
    private bool _isNavigatedTo;
    private bool _isFullScreen;
    private bool _isMaximized;
    private Orientations _lastCachedOrientation;
    private NavigationApplicationLayer _appLayer;
    public Dictionary<string, byte[]> State;
    private ITask.ChildTaskReturned _onChildTaskReturned;
    private ChildTaskReturnedEventArgs _pendingChildTaskReturnedEventArgs;

    public uint ID => this._taskID;

    public bool IsObscured => this._isObscured;

    public bool IsVisible => this._isShowing;

    public bool IsNavigatedTo => this._isNavigatedTo;

    public bool PauseOnLock
    {
      get => this._pauseOnLock;
      set
      {
        this.SetPauseOnLock(value);
        this._pauseOnLock = value;
      }
    }

    public bool FullScreen
    {
      get => this._isFullScreen;
      set
      {
        this.SetFullScreen(value);
        this._isFullScreen = value;
      }
    }

    public bool IsMaximized
    {
      get => this._isMaximized;
      set => this._isMaximized = value;
    }

    public NavigationApplicationLayer AppLayer
    {
      get => this._appLayer;
      set => this._appLayer = value;
    }

    public Task(uint taskID)
    {
      this._taskID = taskID;
      this.InitializeCallbacks(this._taskID);
      this.mAppChromeHandle = (SafeAppChromeHandle) null;
    }

    [SecuritySafeCritical]
    ~Task()
    {
    }

    public override void ShowComplete()
    {
    }

    public override void FirstPresentComplete() => TaskNativeMethods.TaskFirstPresentCompleted(this._taskID);

    public override void HideComplete()
    {
    }

    public override ITask.ChildTaskReturned OnChildTaskReturned
    {
      get => this._onChildTaskReturned;
      set
      {
        if (this._onChildTaskReturned == null && this._pendingChildTaskReturnedEventArgs != null)
        {
          this._onChildTaskReturned = value;
          this._onChildTaskReturned(this._pendingChildTaskReturnedEventArgs);
          this._pendingChildTaskReturnedEventArgs = (ChildTaskReturnedEventArgs) null;
        }
        else
          this._onChildTaskReturned = value;
      }
    }

    [SecuritySafeCritical]
    public override void Detach()
    {
      if (this._isDetached)
        return;
      this._isDetached = true;
      TaskNativeMethods.DestroyTaskCallbacks(this._taskID);
    }

    [SecuritySafeCritical]
    public override void ReadyToNavigate()
    {
      if (this._isCompleted)
        return;
      TaskNativeMethods.TaskReadyToNavigate(this._taskID);
    }

    [SecuritySafeCritical]
    public override void Complete(int result)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.Complete(result)));
      }
      else
      {
        if (this._isCompleted)
          return;
        this.mAppChromeHandle = (SafeAppChromeHandle) null;
        this._isCompleted = true;
        if (ApplicationHost.Current.IsHeadless)
        {
          TaskNativeMethods.CompleteTask(this._taskID, IntPtr.Zero, 0U, result);
          ApplicationHost.Current.RemoveTask(this._taskID);
        }
        else
          TaskNativeMethods.RequestCloseTask(this._taskID);
      }
    }

    [SecuritySafeCritical]
    public override void RequestNavigateBack()
    {
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot request to navigate back in a headless host");
      TaskNativeMethods.RequestNavigateBack(this._taskID);
    }

    public void GetInputBufferForTask(byte[] buf)
    {
      uint num = 0;
      int taskId = (int) this._taskID;
      byte[] inputBuffer = buf;
      int length = inputBuffer.Length;
      ref uint local = ref num;
      TaskNativeMethods.GetTaskInputBuffer((uint) taskId, inputBuffer, (uint) length, out local);
    }

    public object UnmarshalTaskInputBuffer(bool fReleaseMarshalData)
    {
      object taskInputObject;
      TaskNativeMethods.UnmarshalTaskInputBuffer(this._taskID, fReleaseMarshalData, out taskInputObject);
      return taskInputObject;
    }

    public uint InputBufferSizeForTask
    {
      get
      {
        uint actualBufSize = 0;
        TaskNativeMethods.GetTaskInputBuffer(this._taskID, (byte[]) null, 0U, out actualBufSize);
        return actualBufSize;
      }
    }

    [SecuritySafeCritical]
    public override void LaunchSession(string taskUri, byte[] parameterData)
    {
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a session in headless host");
      int taskId = (int) this._taskID;
      string taskUri1 = taskUri;
      byte[] parameterData1 = parameterData;
      int length = parameterData1.Length;
      IntPtr zero = IntPtr.Zero;
      TaskNativeMethods.LaunchSession((uint) taskId, taskUri1, parameterData1, (uint) length, zero);
    }

    [SecuritySafeCritical]
    public override void LaunchChildTask(string taskUri, byte[] parameterData)
    {
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a child task in headless host");
      int taskId = (int) this._taskID;
      string taskUri1 = taskUri;
      byte[] parameterData1 = parameterData;
      int length = parameterData1.Length;
      IntPtr zero = IntPtr.Zero;
      TaskNativeMethods.LaunchChildTask((uint) taskId, taskUri1, parameterData1, (uint) length, zero);
    }

    [SecuritySafeCritical]
    public override void LaunchModernChooser(
      string appUri,
      string chooserTargetPackageFullName,
      byte[] parameterData)
    {
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a child task in headless host");
      int taskId = (int) this._taskID;
      string appUri1 = appUri;
      string chooserTargetPackageFamilyName = chooserTargetPackageFullName;
      byte[] parameterData1 = parameterData;
      int length = parameterData1.Length;
      TaskNativeMethods.LaunchModernChooser((uint) taskId, appUri1, chooserTargetPackageFamilyName, parameterData1, (uint) length);
    }

    [SecuritySafeCritical]
    public override void SetSupportedOrientations(Orientations orientations) => TaskNativeMethods.SetSupportedOrientations(this._taskID, orientations);

    [SecuritySafeCritical]
    public override Orientations GetSupportedOrientations()
    {
      Orientations supportedOrientations = Orientations.None;
      TaskNativeMethods.GetSupportedOrientations(this._taskID, out supportedOrientations);
      return supportedOrientations;
    }

    [SecuritySafeCritical]
    public override Orientations GetCurrentOrientation()
    {
      Orientations currentOrientation = Orientations.None;
      if (this._isCompleted)
      {
        currentOrientation = this._lastCachedOrientation;
      }
      else
      {
        TaskNativeMethods.GetCurrentOrientation(this._taskID, out currentOrientation);
        this._lastCachedOrientation = currentOrientation;
      }
      return currentOrientation;
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnLaunching()
    {
      try
      {
        if (this.OnLaunching == null)
          return;
        this.OnLaunching();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnPause(uint reason)
    {
      try
      {
        if (this.OnBeforePause != null)
          this.OnBeforePause(reason);
        if (this.OnPause != null)
          this.OnPause(reason);
        this.SaveTaskState();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnResume([MarshalAs(UnmanagedType.U1)] bool isExecutionContextPreserved)
    {
      try
      {
        this.LoadTaskState();
        if (this.OnResume != null)
          this.OnResume(isExecutionContextPreserved);
        if (this.OnAfterResume == null)
          return;
        this.OnAfterResume(isExecutionContextPreserved);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnModernActivation()
    {
      ITask.ModernActivation modernActivation = this.OnModernActivation;
      if (modernActivation == null)
        return;
      modernActivation();
    }

    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal void FireOnRunningInBackground()
    {
      try
      {
        if (this.OnRunningInBackground != null)
          this.OnRunningInBackground();
        this.SaveTaskState();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnCancel()
    {
      try
      {
        if (this.OnCancel == null)
          return;
        this.OnCancel();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal void FireOnClosing()
    {
      this.mAppChromeHandle = (SafeAppChromeHandle) null;
      this._isCompleted = true;
      try
      {
        if (this.OnClosing == null)
          return;
        this.OnClosing();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnNavigateTo(int direction, [MarshalAs(UnmanagedType.U1)] bool isResumeActivation)
    {
      this._isNavigatedTo = true;
      try
      {
        if (this.OnNavigateTo == null)
          return;
        this.OnNavigateTo((NavigationDirection) direction, isResumeActivation);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnNavigateAway(int direction)
    {
      this._isNavigatedTo = false;
      try
      {
        if (this.OnNavigateAway == null)
          return;
        this.OnNavigateAway((NavigationDirection) direction);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnRefresh()
    {
      try
      {
        if (this.OnRefresh == null)
          return;
        this.OnRefresh();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnShow(int direction)
    {
      this._isShowing = true;
      try
      {
        if (this.OnShow == null)
          return;
        this.OnShow((NavigationDirection) direction);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal void FireOnHide(int direction)
    {
      try
      {
        if (this.OnHide != null && this._isShowing)
          this.OnHide((NavigationDirection) direction);
        this._isShowing = false;
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnChildTaskReturned(IntPtr returnDataPtr, uint returnDataSize)
    {
      try
      {
        byte[] destination;
        if (returnDataPtr != IntPtr.Zero)
        {
          destination = new byte[(int) returnDataSize];
          Marshal.Copy(returnDataPtr, destination, 0, (int) returnDataSize);
        }
        else
          destination = new byte[0];
        ChildTaskReturnedEventArgs args = new ChildTaskReturnedEventArgs();
        args.returnBuffer = destination;
        if (this.OnChildTaskReturned != null)
          this.OnChildTaskReturned(args);
        else
          this._pendingChildTaskReturnedEventArgs = args;
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal void FireOnHostDehydrating()
    {
      try
      {
        if (this.OnHostDehydrating == null)
          return;
        this.OnHostDehydrating();
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnSystemKeyPressed(int systemKeyType, out bool pHandled)
    {
      pHandled = false;
      try
      {
        if (this.OnSystemKeyPressed != null && systemKeyType != 2)
          this.OnSystemKeyPressed((NavigationSystemKey) systemKeyType, out pHandled);
        else if (this.OnStartKeyPress != null && systemKeyType == 2)
        {
          this.OnStartKeyPress();
        }
        else
        {
          if (systemKeyType != 1)
            return;
          this.Complete(0);
        }
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnVisibleRegionChange()
    {
      try
      {
        if (this._appLayer == NavigationApplicationLayer.Overlay)
        {
          if (this.IsMaximized && this.OnVisibleRegionChange != null)
          {
            this.OnVisibleRegionChange();
          }
          else
          {
            if (this.IsMaximized || this.OnMinimizedOverlayVisibleRegionChange == null)
              return;
            this.OnMinimizedOverlayVisibleRegionChange();
          }
        }
        else
        {
          if (this.OnVisibleRegionChange == null)
            return;
          this.OnVisibleRegionChange();
        }
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    internal SafeAppChromeHandle AppChromeHandle
    {
      get
      {
        if (this.mAppChromeHandle == null)
        {
          if (!this._isCompleted)
          {
            try
            {
              TaskNativeMethods.GetTaskAppChromeHandle(this._taskID, out this.mAppChromeHandle);
            }
            catch (ArgumentException ex)
            {
            }
          }
        }
        return this.mAppChromeHandle;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnOrientationChanged(int orientation)
    {
      try
      {
        if (this.OnOrientationChanged == null)
          return;
        this.OnOrientationChanged((Orientations) orientation);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnSipVisibilityChange([MarshalAs(UnmanagedType.U1)] bool isVisible, int height)
    {
      try
      {
        if (this.OnSipVisibilityChange == null)
          return;
        this.OnSipVisibilityChange(isVisible, height);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal void FireOnNavBarVisibilityChange([MarshalAs(UnmanagedType.U1)] bool isVisible, int height)
    {
      try
      {
        if (this.OnNavBarVisibilityChange == null)
          return;
        this.OnNavBarVisibilityChange(isVisible, height);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnObscurityChanged([MarshalAs(UnmanagedType.U1)] bool isObscured)
    {
      try
      {
        if (this._isObscured == isObscured)
          return;
        this._isObscured = isObscured;
        if (this.OnObscurityChange == null)
          return;
        this.OnObscurityChange(isObscured);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnLockScreenVisibilityChanged([MarshalAs(UnmanagedType.U1)] bool isVisible)
    {
      try
      {
        if (this.OnLockScreenVisibilityChange == null)
          return;
        this.OnLockScreenVisibilityChange(isVisible);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [AllowReversePInvokeCalls]
    [SecurityCritical]
    internal void FireOnApplicationLayerChanged(uint appLayer)
    {
      if (this._appLayer == NavigationApplicationLayer.Foreground || this._appLayer == NavigationApplicationLayer.Lock)
        XcpImports.Host_SetBackgroundColorTransparency(appLayer > 0U);
      this._appLayer = (NavigationApplicationLayer) appLayer;
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void FireOnRequestOverlayStateChange(uint state)
    {
      try
      {
        if (this._appLayer != NavigationApplicationLayer.Overlay || this.OnRequestOverlayStateChange == null)
          return;
        this.OnRequestOverlayStateChange(state);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecuritySafeCritical]
    internal void SetPauseOnLock(bool value)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetPauseOnLock(value)));
      }
      else
      {
        if (this._isCompleted)
          return;
        TaskNativeMethods.SetTaskPauseOnLock(this._taskID, value);
      }
    }

    [SecuritySafeCritical]
    internal void SetFullScreen(bool value)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetFullScreen(value)));
      }
      else
      {
        if (this._isCompleted)
          return;
        TaskNativeMethods.SetTaskFullScreen(this._taskID, value);
      }
    }

    [SecuritySafeCritical]
    internal void InitializeCallbacks(uint taskID)
    {
      this.State = new Dictionary<string, byte[]>();
      this.mOnNativeLaunching = new Task.OnTaskStateChange(this.FireOnLaunching);
      this.mOnNativePause = new Task.OnTaskPaused(this.FireOnPause);
      this.mOnNativeResume = new Task.OnTaskResumed(this.FireOnResume);
      this.mOnNativeRunningInBackground = new Task.OnTaskStateChange(this.FireOnRunningInBackground);
      this.mOnNativeCancel = new Task.OnTaskStateChange(this.FireOnCancel);
      this.mOnNativeClosing = new Task.OnTaskStateChange(this.FireOnClosing);
      this.mOnNativeNavigateTo = new Task.OnTaskNavigateTo(this.FireOnNavigateTo);
      this.mOnNativeNavigateAway = new Task.OnTaskNavigateAway(this.FireOnNavigateAway);
      this.mOnRefresh = new Task.OnTaskStateChange(this.FireOnRefresh);
      this.mOnNativeShow = new Task.OnTaskVisibilityChange(this.FireOnShow);
      this.mOnNativeHide = new Task.OnTaskVisibilityChange(this.FireOnHide);
      this.mOnSystemKeyPressed = new Task.OnTaskSystemKeyPressed(this.FireOnSystemKeyPressed);
      this.mOnChildTaskReturned = new Task.OnChildTaskReturnedNative(this.FireOnChildTaskReturned);
      this.mOnHostDehydrating = new Task.OnTaskStateChange(this.FireOnHostDehydrating);
      this.mOnVisibleRegionChange = new Task.OnVisibleRegionChanged(this.FireOnVisibleRegionChange);
      this.mOnOrientationChanged = new Task.OnTaskOrientationChanged(this.FireOnOrientationChanged);
      this.mOnSipVisibilityChange = new Task.OnTaskSipVisibilityChange(this.FireOnSipVisibilityChange);
      this.mOnNavBarVisibilityChange = new Task.OnTaskNavBarVisibilityChange(this.FireOnNavBarVisibilityChange);
      this.mOnObscurityChange = new Task.OnTaskObscurityChange(this.FireOnObscurityChanged);
      this.mOnLockScreenVisibilityChange = new Task.OnTaskLockScreenVisibilityChange(this.FireOnLockScreenVisibilityChanged);
      this.mOnApplicationLayerChange = new Task.OnTaskApplicationLayerChange(this.FireOnApplicationLayerChanged);
      this.mOnRequestOverlayStateChange = new Task.OnRequestOverlayTaskStateChange(this.FireOnRequestOverlayStateChange);
      this.mOnModernActivation = new Task.OnTaskModernActivation(this.FireOnModernActivation);
      TaskNativeMethods.RegisterTaskCallbacks(taskID, ref new TaskCallbacks()
      {
        pfnOnLaunching = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeLaunching),
        pfnOnPause = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativePause),
        pfnOnResume = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeResume),
        pfnOnRunningInBackground = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeRunningInBackground),
        pfnOnCancel = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeCancel),
        pfnOnClosing = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeClosing),
        pfnOnNavigateTo = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeNavigateTo),
        pfnOnNavigateAway = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeNavigateAway),
        pfnOnRefresh = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnRefresh),
        pfnOnShow = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeShow),
        pfnOnHide = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNativeHide),
        pfnOnSystemKeyPressed = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnSystemKeyPressed),
        pfnOnChildTaskReturned = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnChildTaskReturned),
        pfnOnHostDehydrating = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnHostDehydrating),
        pfnOnVisibleRegionChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnVisibleRegionChange),
        pfnOnOrientationChanged = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnOrientationChanged),
        pfnOnSipVisibilityChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnSipVisibilityChange),
        pfnOnNavBarVisibilityChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnNavBarVisibilityChange),
        pfnOnObscurityChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnObscurityChange),
        pfnOnLockScreenVisibilityChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnLockScreenVisibilityChange),
        pfnOnApplicationLayerChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnApplicationLayerChange),
        pfnOnRequestOverlayStateChange = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnRequestOverlayStateChange),
        pfnOnModernActivation = Marshal.GetFunctionPointerForDelegate((Delegate) this.mOnModernActivation)
      });
    }

    [SecuritySafeCritical]
    private void SaveTaskState()
    {
      byte[] numArray = BaseStreamPersister.Serialize((IDictionary<string, byte[]>) this.State, (IEnumerable<Type>) null);
      try
      {
        int taskId = (int) this._taskID;
        byte[] state = numArray;
        int length = state.Length;
        TaskNativeMethods.SetTaskState((uint) taskId, state, (uint) length);
      }
      catch (ArgumentException ex)
      {
        throw new InvalidOperationException("State saving failed. This is most likely due to insufficient State buffer capacity. App requires [" + numArray.Length.ToString() + "] bytes which likely exceeds NavServer limit");
      }
    }

    [SecuritySafeCritical]
    private void LoadTaskState()
    {
      IntPtr zero = IntPtr.Zero;
      uint stateBufferSize = 0;
      TaskNativeMethods.GetTaskState(this._taskID, ref zero, out stateBufferSize);
      byte[] numArray = new byte[(int) stateBufferSize];
      Marshal.Copy(zero, numArray, 0, (int) stateBufferSize);
      BaseStreamPersister.Deserialize(numArray, (IEnumerable<Type>) null, ref this.State);
    }

    internal delegate void OnTaskStateChange();

    internal delegate void OnTaskPaused(uint reason);

    internal delegate void OnTaskResumed([MarshalAs(UnmanagedType.U1)] bool isExecutionContextPreserved);

    internal delegate void OnTaskNavigateTo(int direction, [MarshalAs(UnmanagedType.U1)] bool isResumeActivation);

    internal delegate void OnTaskNavigateAway(int direction);

    internal delegate void OnTaskVisibilityChange(int direction);

    internal delegate void OnTaskSystemKeyPressed(int systemKeyType, out bool pHandled);

    internal delegate void OnChildTaskReturnedNative(IntPtr returnDataPtr, uint returnDataSize);

    internal delegate void OnVisibleRegionChanged();

    internal delegate void OnTaskOrientationChanged(int orientation);

    internal delegate void OnTaskSipVisibilityChange([MarshalAs(UnmanagedType.U1)] bool isVisible, int height);

    internal delegate void OnTaskNavBarVisibilityChange([MarshalAs(UnmanagedType.U1)] bool isVisible, int height);

    internal delegate void OnTaskObscurityChange([MarshalAs(UnmanagedType.U1)] bool isObscured);

    internal delegate void OnTaskLockScreenVisibilityChange([MarshalAs(UnmanagedType.U1)] bool isVisible);

    internal delegate void OnTaskApplicationLayerChange(uint appLayer);

    internal delegate void OnRequestOverlayTaskStateChange(uint reason);

    internal delegate void OnTaskModernActivation();
  }
}
