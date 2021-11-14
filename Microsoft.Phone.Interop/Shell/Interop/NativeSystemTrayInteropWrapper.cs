// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeSystemTrayInteropWrapper
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
  internal class NativeSystemTrayInteropWrapper : ISysTrayInterop
  {
    private static object handlesToReleaseListLock = new object();
    private static List<IntPtr> handlesToReleaseList = new List<IntPtr>();
    private object handleLock = new object();
    private IntPtr mSysTrayHandle = IntPtr.Zero;
    private WeakEventListener<NativeSystemTrayInteropWrapper> releaseTrayWeakEventListener;
    private static bool _progressIndicatorIsVisible = false;
    private static bool _progressIndicatorIsIndeterminate = false;
    private static string _progressIndicatorText = "";
    private static float _progressIndicatorValue = 0.0f;

    ~NativeSystemTrayInteropWrapper()
    {
      if (this.releaseTrayWeakEventListener != null)
      {
        this.releaseTrayWeakEventListener.Detach();
        this.releaseTrayWeakEventListener = (WeakEventListener<NativeSystemTrayInteropWrapper>) null;
      }
      this.ReleaseTray();
    }

    [SecuritySafeCritical]
    public static void ClearVisibleSystemTray()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeSystemTrayInteropWrapper.ClearVisibleSystemTray()));
      }
      else
      {
        if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        NativeSystemTrayMethods.SetVisibleSysTray(ApplicationHost.Current.RootTask.AppChromeHandle, IntPtr.Zero);
        NativeLetterboxWrapper.VisibleSysTray = (NativeSystemTrayInteropWrapper) null;
      }
    }

    [SecuritySafeCritical]
    public static RECT GetVisibleRegion(Orientations orientation)
    {
      RECT rcVisibleRegion = new RECT();
      RECT rcClientRegion = new RECT();
      if (!Deployment.Current.Dispatcher.CheckAccess())
        throw new UnauthorizedAccessException("NativeSystemTrayInteropWrapper.GetVisibleRegions() can be called on UI thread only.");
      if (ApplicationHost.Current.RootTask.AppChromeHandle != null)
        NativeSystemTrayMethods.GetVisibleRegion(ApplicationHost.Current.RootTask.AppChromeHandle, orientation, out rcVisibleRegion, out rcClientRegion);
      return rcVisibleRegion;
    }

    [SecuritySafeCritical]
    public static RECT GetMinimizedOverlayVisibleRegion()
    {
      RECT rcClientRegion = new RECT();
      if (!Deployment.Current.Dispatcher.CheckAccess())
        throw new UnauthorizedAccessException("NativeSystemTrayInteropWrapper.GetMinimizedOverlayVisibleRegion() can be called on UI thread only.");
      if (ApplicationHost.Current.RootTask.AppChromeHandle != null)
        NativeSystemTrayMethods.GetMinimizedOverlayVisibleRegion(ApplicationHost.Current.RootTask.AppChromeHandle, out rcClientRegion);
      return rcClientRegion;
    }

    [SecuritySafeCritical]
    public void CreateSystemTray()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.CreateSystemTray()));
      }
      else
      {
        if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
          return;
        NativeSystemTrayMethods.CreateSystemTray(ApplicationHost.Current.RootTask.AppChromeHandle, out this.mSysTrayHandle);
        this.releaseTrayWeakEventListener = new WeakEventListener<NativeSystemTrayInteropWrapper>(this);
        this.releaseTrayWeakEventListener.OnEventAction = (Action<NativeSystemTrayInteropWrapper>) (instance => instance.ReleaseTray());
        this.releaseTrayWeakEventListener.OnDetachAction = (Action<WeakEventListener<NativeSystemTrayInteropWrapper>>) (weakEventListener =>
        {
          ApplicationHost.Current.RootTask.OnClosing -= new ITask.Closing(weakEventListener.OnEvent);
          ApplicationHost.Current.RootTask.OnHostDehydrating -= new ITask.HostDehydrating(weakEventListener.OnEvent);
        });
        Task rootTask1 = ApplicationHost.Current.RootTask;
        rootTask1.OnClosing = rootTask1.OnClosing + new ITask.Closing(this.releaseTrayWeakEventListener.OnEvent);
        Task rootTask2 = ApplicationHost.Current.RootTask;
        rootTask2.OnHostDehydrating = rootTask2.OnHostDehydrating + new ITask.HostDehydrating(this.releaseTrayWeakEventListener.OnEvent);
      }
    }

    [SecuritySafeCritical]
    public void SetSystemTrayOpacity(float opacity)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetSystemTrayOpacity(opacity)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mSysTrayHandle != IntPtr.Zero))
            return;
          NativeSystemTrayMethods.SetSysTrayOpacity(this.mSysTrayHandle, opacity);
        }
      }
    }

    [SecuritySafeCritical]
    public void SetSystemTrayForegroundColor(Color foregroundColor)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetSystemTrayForegroundColor(foregroundColor)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mSysTrayHandle != IntPtr.Zero))
            return;
          NativeSystemTrayMethods.SetSysTrayUseDefaultForegroundColor(this.mSysTrayHandle, false);
          NativeSystemTrayMethods.SetSysTrayForegroundColor(this.mSysTrayHandle, NativeInteropHelper.ConvertToWin32Color(foregroundColor));
        }
      }
    }

    [SecuritySafeCritical]
    public void SetSystemTrayBackgroundColor(Color backgroundColor)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetSystemTrayBackgroundColor(backgroundColor)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mSysTrayHandle != IntPtr.Zero))
            return;
          NativeSystemTrayMethods.SetSysTrayUseDefaultBackgroundColor(this.mSysTrayHandle, false);
          NativeSystemTrayMethods.SetSysTrayBackgroundColor(this.mSysTrayHandle, NativeInteropHelper.ConvertToWin32Color(backgroundColor));
        }
      }
    }

    [SecuritySafeCritical]
    public void SetSystemTrayVisible(bool isVisible)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetSystemTrayVisible(isVisible)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mSysTrayHandle != IntPtr.Zero))
            return;
          NativeSystemTrayMethods.SetSysTrayVisible(this.mSysTrayHandle, isVisible);
        }
      }
    }

    [SecuritySafeCritical]
    public void MakeVisibleSysTray()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.MakeVisibleSysTray()));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mSysTrayHandle != IntPtr.Zero) || ApplicationHost.Current.RootTask.AppChromeHandle == null)
            return;
          NativeSystemTrayMethods.SetVisibleSysTray(ApplicationHost.Current.RootTask.AppChromeHandle, this.mSysTrayHandle);
          NativeLetterboxWrapper.VisibleSysTray = this;
        }
      }
    }

    public static bool ProgressIndicatorIsVisible
    {
      get => NativeSystemTrayInteropWrapper._progressIndicatorIsVisible;
      set
      {
        NativeSystemTrayInteropWrapper._progressIndicatorIsVisible = value;
        if (!Deployment.Current.Dispatcher.CheckAccess())
        {
          Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeSystemTrayInteropWrapper.ProgressIndicatorIsVisible = value));
        }
        else
        {
          if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
            return;
          NativeSystemTrayMethods.SetProgressIndicatorIsVisible(ApplicationHost.Current.RootTask.AppChromeHandle, NativeSystemTrayInteropWrapper._progressIndicatorIsVisible);
        }
      }
    }

    public static bool ProgressIndicatorIsIndeterminate
    {
      get => NativeSystemTrayInteropWrapper._progressIndicatorIsIndeterminate;
      set
      {
        NativeSystemTrayInteropWrapper._progressIndicatorIsIndeterminate = value;
        if (!Deployment.Current.Dispatcher.CheckAccess())
        {
          Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeSystemTrayInteropWrapper.ProgressIndicatorIsIndeterminate = value));
        }
        else
        {
          if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
            return;
          NativeSystemTrayMethods.SetProgressIndicatorIsIndeterminate(ApplicationHost.Current.RootTask.AppChromeHandle, NativeSystemTrayInteropWrapper._progressIndicatorIsIndeterminate);
        }
      }
    }

    public static string ProgressIndicatorText
    {
      get => NativeSystemTrayInteropWrapper._progressIndicatorText;
      set
      {
        NativeSystemTrayInteropWrapper._progressIndicatorText = value;
        if (!Deployment.Current.Dispatcher.CheckAccess())
        {
          Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeSystemTrayInteropWrapper.ProgressIndicatorText = value));
        }
        else
        {
          if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
            return;
          NativeSystemTrayMethods.SetProgressIndicatorText(ApplicationHost.Current.RootTask.AppChromeHandle, NativeSystemTrayInteropWrapper._progressIndicatorText);
        }
      }
    }

    public static float ProgressIndicatorValue
    {
      get => NativeSystemTrayInteropWrapper._progressIndicatorValue;
      set
      {
        NativeSystemTrayInteropWrapper._progressIndicatorValue = value;
        if (!Deployment.Current.Dispatcher.CheckAccess())
        {
          Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeSystemTrayInteropWrapper.ProgressIndicatorValue = value));
        }
        else
        {
          if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
            return;
          NativeSystemTrayMethods.SetProgressIndicatorPosition(ApplicationHost.Current.RootTask.AppChromeHandle, NativeSystemTrayInteropWrapper._progressIndicatorValue);
        }
      }
    }

    [SecuritySafeCritical]
    private void ReleaseTray()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        lock (NativeSystemTrayInteropWrapper.handlesToReleaseListLock)
        {
          if (this.mSysTrayHandle != IntPtr.Zero)
          {
            NativeSystemTrayInteropWrapper.handlesToReleaseList.Add(this.mSysTrayHandle);
            lock (this.handleLock)
              this.mSysTrayHandle = IntPtr.Zero;
          }
        }
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => NativeSystemTrayInteropWrapper.ReleaseSystemTrays()));
      }
      else
      {
        lock (NativeSystemTrayInteropWrapper.handlesToReleaseListLock)
        {
          if (this.mSysTrayHandle != IntPtr.Zero)
            NativeSystemTrayMethods.ReleaseSystemTray(ref this.mSysTrayHandle);
        }
        NativeSystemTrayInteropWrapper.ReleaseSystemTrays();
      }
    }

    [SecuritySafeCritical]
    private static void ReleaseSystemTrays()
    {
      lock (NativeSystemTrayInteropWrapper.handlesToReleaseListLock)
      {
        for (int index = NativeSystemTrayInteropWrapper.handlesToReleaseList.Count - 1; index >= 0; --index)
        {
          IntPtr handlesToRelease = NativeSystemTrayInteropWrapper.handlesToReleaseList[index];
          NativeSystemTrayMethods.ReleaseSystemTray(ref handlesToRelease);
          NativeSystemTrayInteropWrapper.handlesToReleaseList.RemoveAt(index);
        }
      }
    }
  }
}
