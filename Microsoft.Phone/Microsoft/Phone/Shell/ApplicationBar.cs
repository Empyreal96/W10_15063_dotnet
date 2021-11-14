// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBar
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell.Interop;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Microsoft.Phone.Shell
{
  [ContentProperty("Buttons")]
  public sealed class ApplicationBar : IApplicationBar
  {
    internal static readonly int MaxIconButtons = 4;
    internal static readonly int MaxMenuItems = 50;
    private const double DefaultOpacity = 1.0;
    private const double LegacyAppBarDefaultSize = 72.0;
    private const double LegacyAppBarMiniSize = 30.0;
    private readonly double AppBarDefaultSize = 72.0;
    private readonly double AppBarMiniSize = 30.0;
    private bool useLegacyHeight = true;
    private bool mIsVisible;
    private double mOpacity;
    private bool mIsMenuEnabled;
    private bool mReservesSpace;
    private Color mBackgroundColor;
    private Color mForegroundColor;
    private ApplicationBarMode mMode;
    private ApplicationBarItemList<IApplicationBarIconButton> mButtons;
    private ApplicationBarItemList<IApplicationBarMenuItem> mMenuItems;
    private IAppBarInterop mAppBarInterop;
    private AppBarCallbackInfo mCallbacks;

    public event EventHandler<ApplicationBarStateChangedEventArgs> StateChanged;

    private bool ShouldProcessCommands
    {
      get
      {
        Application current = Application.Current;
        IPhoneApplicationFrame applicationFrame = current != null ? current.RootVisual as IPhoneApplicationFrame : (IPhoneApplicationFrame) null;
        IPhoneApplicationPage phoneApplicationPage = applicationFrame != null ? applicationFrame.Content as IPhoneApplicationPage : (IPhoneApplicationPage) null;
        bool flag = phoneApplicationPage != null && phoneApplicationPage.IsBackground;
        return phoneApplicationPage != null && phoneApplicationPage.AppBar == this && !applicationFrame.IsNavigationInProgress && !flag;
      }
    }

    public bool IsVisible
    {
      get => this.mIsVisible;
      set
      {
        if (value == this.mIsVisible)
          return;
        this.mIsVisible = value;
        this.mAppBarInterop.SetVisibility(this.mIsVisible);
        this.UpdateReservesSpace();
      }
    }

    public double Opacity
    {
      get => this.mOpacity;
      set
      {
        if (value > 1.0)
          value = 1.0;
        else if (value < 0.0)
          value = 0.0;
        if (value == this.mOpacity)
          return;
        this.mOpacity = value;
        this.mAppBarInterop.SetOpacity(this.mOpacity);
        this.UpdateReservesSpace();
      }
    }

    public bool IsMenuEnabled
    {
      get => this.mIsMenuEnabled;
      set
      {
        if (value == this.mIsMenuEnabled)
          return;
        this.mIsMenuEnabled = value;
        this.mAppBarInterop.SetMenuEnabled(this.mIsMenuEnabled);
      }
    }

    public Color BackgroundColor
    {
      get => this.mBackgroundColor;
      set
      {
        if (value.Equals(this.mBackgroundColor))
          return;
        this.mBackgroundColor = value;
        this.mAppBarInterop.SetBackgroundColor(this.mBackgroundColor);
        this.UpdateReservesSpace();
      }
    }

    public Color ForegroundColor
    {
      get => this.mForegroundColor;
      set
      {
        if (value.Equals(this.mForegroundColor))
          return;
        this.mForegroundColor = value;
        this.mAppBarInterop.SetForegroundColor(this.mForegroundColor);
      }
    }

    public ApplicationBarMode Mode
    {
      get => this.mMode;
      set
      {
        if (value.Equals((object) this.mMode))
          return;
        this.mMode = value;
        Microsoft.Phone.Shell.Interop.ApplicationBarMode mode = Microsoft.Phone.Shell.Interop.ApplicationBarMode.Default;
        if (value == ApplicationBarMode.Minimized)
          mode = Microsoft.Phone.Shell.Interop.ApplicationBarMode.Mini;
        this.mAppBarInterop.SetMode(mode);
        NativeLetterboxWrapper.UpdateAppBarIsMini(this.AppBarInterop, this.mMode == ApplicationBarMode.Minimized);
      }
    }

    public double DefaultSize => !this.useLegacyHeight || !this.mReservesSpace ? this.AppBarDefaultSize : 72.0;

    public double MiniSize => !this.useLegacyHeight || !this.mReservesSpace ? this.AppBarMiniSize : 30.0;

    public IList Buttons => (IList) this.mButtons;

    public IList MenuItems => (IList) this.mMenuItems;

    public ApplicationBar()
    {
      this.mIsVisible = true;
      this.mOpacity = 1.0;
      this.mReservesSpace = true;
      this.mIsMenuEnabled = true;
      this.mCallbacks = new AppBarCallbackInfo();
      this.mCallbacks.cmdcallback += new AppBarCallbackInfo.CommandCallback(this.OnCommand);
      this.mCallbacks.onentermenu += new AppBarCallbackInfo.EnterMenuCallback(this.OnEnterMenu);
      this.mCallbacks.onexitmenu += new AppBarCallbackInfo.ExitMenuCallback(this.OnExitMenu);
      this.mAppBarInterop = !ApplicationBar.IsInDesignMode() ? (IAppBarInterop) new NativeAppBarInteropWrapper() : (IAppBarInterop) new DesignAppBarWrapper();
      this.mAppBarInterop.CreateBar(this.mCallbacks);
      this.mButtons = new ApplicationBarItemList<IApplicationBarIconButton>(MenuBarItemType.ImageButton);
      this.mButtons.MAX_ITEMS = ApplicationBar.MaxIconButtons;
      IListInterop listInterop = this.mAppBarInterop.GetListInterop();
      this.mMenuItems = new ApplicationBarItemList<IApplicationBarMenuItem>(MenuBarItemType.TextItem);
      this.mMenuItems.MAX_ITEMS = ApplicationBar.MaxMenuItems;
      this.mButtons.AttachToAppBar(listInterop);
      this.mMenuItems.AttachToAppBar(listInterop);
      if (QuirksMode.ShouldUseLegacyChromeHeights())
        return;
      double num = (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
      int height1 = 0;
      int height2 = 0;
      this.useLegacyHeight = false;
      NativeAppBarMethods.GetApplicationBarHeight(Microsoft.Phone.Shell.Interop.ApplicationBarMode.Default, out height1);
      NativeAppBarMethods.GetApplicationBarHeight(Microsoft.Phone.Shell.Interop.ApplicationBarMode.Mini, out height2);
      this.AppBarDefaultSize = Math.Round((double) height1 / num);
      this.AppBarMiniSize = Math.Round((double) height2 / num);
    }

    ~ApplicationBar() => this.Close();

    private void Close()
    {
      if (this.mButtons != null)
        this.mButtons.DetachFromAppBar();
      if (this.mMenuItems == null)
        return;
      this.mMenuItems.DetachFromAppBar();
    }

    private static bool IsInDesignMode() => Application.Current == null || Application.Current.GetType() == typeof (Application) || DesignerProperties.IsInDesignTool;

    internal NativeAppBarInteropWrapper AppBarInterop => this.mAppBarInterop as NativeAppBarInteropWrapper;

    internal void MakeVisibleAppBar()
    {
      this.AppBarInterop.MakeVisibleAppBar();
      NativeLetterboxWrapper.UpdateAppBarReservesSpace(this.AppBarInterop, this.mReservesSpace);
      NativeLetterboxWrapper.UpdateAppBarIsMini(this.AppBarInterop, this.Mode == ApplicationBarMode.Minimized);
    }

    internal void UpdateReservesSpace()
    {
      bool flag = this.mIsVisible && this.mOpacity >= 1.0 && (this.mBackgroundColor.A >= byte.MaxValue || this.mBackgroundColor.A == (byte) 0);
      if (flag == this.mReservesSpace)
        return;
      this.mReservesSpace = flag;
      NativeLetterboxWrapper.UpdateAppBarReservesSpace(this.AppBarInterop, this.mReservesSpace);
    }

    internal void OnCommand(uint idCommand, bool isButton)
    {
      if (!this.ShouldProcessCommands)
        return;
      int id = (int) idCommand;
      (isButton ? this.mButtons.GetItemById(id) : this.mMenuItems.GetItemById(id))?.ClickEvent();
    }

    internal void OnEnterMenu()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.OnEnterMenu()));
      }
      else
      {
        EventHandler<ApplicationBarStateChangedEventArgs> stateChanged = this.StateChanged;
        if (stateChanged == null)
          return;
        stateChanged((object) this, new ApplicationBarStateChangedEventArgs(true));
      }
    }

    internal void OnExitMenu()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.OnExitMenu()));
      }
      else
      {
        EventHandler<ApplicationBarStateChangedEventArgs> stateChanged = this.StateChanged;
        if (stateChanged == null)
          return;
        stateChanged((object) this, new ApplicationBarStateChangedEventArgs(false));
      }
    }
  }
}
