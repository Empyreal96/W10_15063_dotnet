// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.OverlayApplicationService
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Windows;

namespace Microsoft.Phone.Shell
{
  public static class OverlayApplicationService
  {
    private static bool _isMaximized;

    static OverlayApplicationService() => OverlayApplicationService.Maximized = OverlayApplicationService._isMaximized;

    public static event EventHandler<VisibleRegionChangedEventArgs> VisibleRegionChanged;

    public static event EventHandler<ShowEventArgs> ShowRequested;

    public static event EventHandler<HideEventArgs> HideRequested;

    public static event EventHandler<MinimizeEventArgs> MinimizeRequested;

    public static bool Maximized
    {
      get => NativeProtectedContentWrapper.IsMaximized;
      set
      {
        if (OverlayApplicationService._isMaximized == value)
          return;
        OverlayApplicationService._isMaximized = value;
        ApplicationHost.Current.RootTask.IsMaximized = OverlayApplicationService._isMaximized;
        NativeProtectedContentWrapper.IsMaximized = OverlayApplicationService._isMaximized;
      }
    }

    public static Rect VisibleRegion
    {
      get
      {
        RECT overlayVisibleRegion = NativeSystemTrayInteropWrapper.GetMinimizedOverlayVisibleRegion();
        double num = (double) Application.Current.Host.Content.ScaleFactor / 100.0;
        return new Rect((double) overlayVisibleRegion.left / num, (double) overlayVisibleRegion.top / num, Application.Current.Host.Content.ActualWidth - (double) (overlayVisibleRegion.right + overlayVisibleRegion.left) / num, Application.Current.Host.Content.ActualHeight - (double) (overlayVisibleRegion.bottom + overlayVisibleRegion.top) / num);
      }
    }

    internal static void OnMinimizedOverlayVisibleRegionChanged()
    {
      VisibleRegionChangedEventArgs e = new VisibleRegionChangedEventArgs();
      EventHandler<VisibleRegionChangedEventArgs> visibleRegionChanged = OverlayApplicationService.VisibleRegionChanged;
      if (visibleRegionChanged == null)
        return;
      visibleRegionChanged((object) null, e);
    }

    internal static void OnRequestOverlayStateChange(OverlayState state)
    {
      switch (state)
      {
        case OverlayState.Show:
          ShowEventArgs e1 = new ShowEventArgs();
          EventHandler<ShowEventArgs> showRequested = OverlayApplicationService.ShowRequested;
          if (showRequested == null)
            break;
          showRequested((object) null, e1);
          break;
        case OverlayState.Hide:
          HideEventArgs e2 = new HideEventArgs();
          EventHandler<HideEventArgs> hideRequested = OverlayApplicationService.HideRequested;
          if (hideRequested == null)
            break;
          hideRequested((object) null, e2);
          break;
        default:
          MinimizeEventArgs e3 = new MinimizeEventArgs();
          EventHandler<MinimizeEventArgs> minimizeRequested = OverlayApplicationService.MinimizeRequested;
          if (minimizeRequested == null)
            break;
          minimizeRequested((object) null, e3);
          break;
      }
    }
  }
}
