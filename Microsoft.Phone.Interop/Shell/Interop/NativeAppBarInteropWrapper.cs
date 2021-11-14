// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeAppBarInteropWrapper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Security;
using System.Windows;
using System.Windows.Media;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  internal class NativeAppBarInteropWrapper : IAppBarInterop
  {
    private static object handlesToReleaseListLock = new object();
    private static List<IntPtr> handlesToReleaseList = new List<IntPtr>();
    private NativeCallbackInteropWrapper mCallbackInterop;
    private NativeListInteropWrapper mListInterop;
    private object handleLock = new object();
    private IntPtr mAppBarHandle = IntPtr.Zero;
    private WeakEventListener<NativeAppBarInteropWrapper> releaseBarWeakEventListener;

    ~NativeAppBarInteropWrapper()
    {
      if (this.releaseBarWeakEventListener != null)
      {
        this.releaseBarWeakEventListener.Detach();
        this.releaseBarWeakEventListener = (WeakEventListener<NativeAppBarInteropWrapper>) null;
      }
      this.ReleaseBar();
    }

    [SecuritySafeCritical]
    public static void ClearVisibleAppBar()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeAppBarInteropWrapper.ClearVisibleAppBar()));
      }
      else
      {
        if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        NativeAppBarMethods.SetVisibleAppBar(ApplicationHost.Current.RootTask.AppChromeHandle, IntPtr.Zero, SafeMenuListenerHandle.None);
        NativeLetterboxWrapper.VisibleAppBar = (NativeAppBarInteropWrapper) null;
      }
    }

    [SecuritySafeCritical]
    public void CreateBar(AppBarCallbackInfo callbacks)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.CreateBar(callbacks)));
      }
      else
      {
        if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        this.mCallbackInterop = new NativeCallbackInteropWrapper(callbacks);
        NativeAppBarMethods.CreateAppBar(ApplicationHost.Current.RootTask.AppChromeHandle, out this.mAppBarHandle);
        this.releaseBarWeakEventListener = new WeakEventListener<NativeAppBarInteropWrapper>(this);
        this.releaseBarWeakEventListener.OnEventAction = (Action<NativeAppBarInteropWrapper>) (instance => instance.ReleaseBar());
        this.releaseBarWeakEventListener.OnDetachAction = (Action<WeakEventListener<NativeAppBarInteropWrapper>>) (weakEventListener =>
        {
          ApplicationHost.Current.RootTask.OnClosing -= new ITask.Closing(weakEventListener.OnEvent);
          ApplicationHost.Current.RootTask.OnHostDehydrating -= new ITask.HostDehydrating(weakEventListener.OnEvent);
        });
        Task rootTask1 = ApplicationHost.Current.RootTask;
        rootTask1.OnClosing = rootTask1.OnClosing + new ITask.Closing(this.releaseBarWeakEventListener.OnEvent);
        Task rootTask2 = ApplicationHost.Current.RootTask;
        rootTask2.OnHostDehydrating = rootTask2.OnHostDehydrating + new ITask.HostDehydrating(this.releaseBarWeakEventListener.OnEvent);
      }
    }

    [SecuritySafeCritical]
    public IListInterop GetListInterop()
    {
      if (this.mListInterop == null)
        this.mListInterop = new NativeListInteropWrapper(this.mAppBarHandle);
      return (IListInterop) this.mListInterop;
    }

    [SecuritySafeCritical]
    public void SetOpacity(double opacity)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetOpacity(opacity)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeAppBarMethods.SetAppBarOpacity(this.mAppBarHandle, (float) opacity);
        }
      }
    }

    [SecuritySafeCritical]
    public void SetBackgroundColor(Color backgroundColor)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetBackgroundColor(backgroundColor)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeAppBarMethods.SetAppBarBackgroundColor(this.mAppBarHandle, NativeInteropHelper.ConvertToWin32Color(backgroundColor));
        }
      }
    }

    [SecuritySafeCritical]
    public void SetForegroundColor(Color foregroundColor)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetForegroundColor(foregroundColor)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeAppBarMethods.SetAppBarForegroundColor(this.mAppBarHandle, NativeInteropHelper.ConvertToWin32Color(foregroundColor));
        }
      }
    }

    [SecuritySafeCritical]
    public void SetMode(ApplicationBarMode mode)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetMode(mode)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeAppBarMethods.SetAppBarMode(this.mAppBarHandle, mode);
        }
      }
    }

    [SecuritySafeCritical]
    public void SetMenuEnabled(bool enabled)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetMenuEnabled(enabled)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeAppBarMethods.SetAppBarMenuEnabled(this.mAppBarHandle, enabled);
        }
      }
    }

    [SecuritySafeCritical]
    public void SetVisibility(bool isVisible)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetVisibility(isVisible)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeAppBarMethods.SetAppBarVisible(this.mAppBarHandle, isVisible);
        }
      }
    }

    [SecuritySafeCritical]
    public Color GetBackgroundColor()
    {
      uint pResult = 0;
      NativeAppBarMethods.GetAppBarBackgroundColor(this.mAppBarHandle, out pResult);
      return NativeInteropHelper.ConvertToSilverlightColor(pResult);
    }

    [SecuritySafeCritical]
    public Color GetForegroundColor()
    {
      uint pRes = 0;
      NativeAppBarMethods.GetAppBarForegroundColor(this.mAppBarHandle, out pRes);
      return NativeInteropHelper.ConvertToSilverlightColor(pRes);
    }

    [SecuritySafeCritical]
    public bool GetVisible()
    {
      bool pResult = false;
      NativeAppBarMethods.GetAppBarVisible(this.mAppBarHandle, out pResult);
      return pResult;
    }

    [SecuritySafeCritical]
    public bool GetMenuEnabled()
    {
      bool pResult = false;
      NativeAppBarMethods.GetAppBarMenuEnabled(this.mAppBarHandle, out pResult);
      return pResult;
    }

    [SecuritySafeCritical]
    public void MakeVisibleAppBar()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.MakeVisibleAppBar()));
      }
      else
      {
        if (!(this.mAppBarHandle != IntPtr.Zero) || ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        NativeAppBarMethods.SetVisibleAppBar(ApplicationHost.Current.RootTask.AppChromeHandle, this.mAppBarHandle, this.mCallbackInterop.MenuListenerHandle);
        NativeLetterboxWrapper.VisibleAppBar = this;
      }
    }

    [SecuritySafeCritical]
    private void ReleaseBar()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        lock (NativeAppBarInteropWrapper.handlesToReleaseListLock)
        {
          if (this.mAppBarHandle != IntPtr.Zero)
          {
            NativeAppBarInteropWrapper.handlesToReleaseList.Add(this.mAppBarHandle);
            lock (this.handleLock)
            {
              this.mAppBarHandle = IntPtr.Zero;
              this.mListInterop.SetAppBarHandle(IntPtr.Zero);
            }
          }
        }
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeAppBarInteropWrapper.ReleaseAppBars()));
      }
      else
      {
        lock (NativeAppBarInteropWrapper.handlesToReleaseListLock)
        {
          if (this.mAppBarHandle != IntPtr.Zero)
            NativeAppBarMethods.ReleaseAppBar(ref this.mAppBarHandle);
        }
        NativeAppBarInteropWrapper.ReleaseAppBars();
      }
    }

    [SecuritySafeCritical]
    private static void ReleaseAppBars()
    {
      lock (NativeAppBarInteropWrapper.handlesToReleaseListLock)
      {
        for (int index = NativeAppBarInteropWrapper.handlesToReleaseList.Count - 1; index >= 0; --index)
        {
          IntPtr handlesToRelease = NativeAppBarInteropWrapper.handlesToReleaseList[index];
          NativeAppBarMethods.ReleaseAppBar(ref handlesToRelease);
          NativeAppBarInteropWrapper.handlesToReleaseList.RemoveAt(index);
        }
      }
    }
  }
}
