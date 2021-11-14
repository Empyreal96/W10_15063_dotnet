// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.MobileSharedGameWindow
// Assembly: Microsoft.Xna.Framework.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: E258DF81-FBD7-4DF4-930E-981F36DBB495
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI20E9~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Threading;
using System.Windows.Navigation;

namespace Microsoft.Xna.Framework
{
  internal class MobileSharedGameWindow
  {
    private bool isInitialized;
    private DisplayMode currentDisplayMode;
    private string defaultAdapterName;
    private bool firstNavigate;
    private int gamePageWidth = 480;
    private int gamePageHeight = 800;
    private RECT lastKnownVisibleRegionRect;
    private bool isSipVisible;
    private PhoneApplicationFrame frame;
    private Rectangle clientBounds;
    private int taskThreadId;
    private Orientations lastKnownNavOrientation;
    private DisplayOrientation currentOrientation;
    private bool gotBoundsAndOrientation;
    internal IntPtr handle = IntPtr.Zero;
    internal uint gamePageHandle = uint.MaxValue;

    internal event EventHandler<EventArgs> Activated;

    internal event EventHandler<EventArgs> Deactivated;

    public event EventHandler<EventArgs> ScreenDeviceNameChanged;

    public event EventHandler<EventArgs> ClientSizeChanged;

    public event EventHandler<EventArgs> OrientationChanged;

    protected void OnActivated()
    {
      if (this.Activated == null)
        return;
      this.Activated((object) this, EventArgs.Empty);
    }

    protected void OnDeactivated()
    {
      if (this.Deactivated == null)
        return;
      this.Deactivated((object) this, EventArgs.Empty);
    }

    protected void OnScreenDeviceNameChanged()
    {
      if (this.ScreenDeviceNameChanged == null)
        return;
      this.ScreenDeviceNameChanged((object) this, EventArgs.Empty);
    }

    protected void OnClientSizeChanged()
    {
      if (this.ClientSizeChanged == null)
        return;
      this.ClientSizeChanged((object) this, EventArgs.Empty);
    }

    protected void OnOrientationChanged()
    {
      if (this.OrientationChanged == null)
        return;
      this.OrientationChanged((object) this, EventArgs.Empty);
    }

    public IntPtr Handle => this.handle;

    public Rectangle ClientBounds => this.clientBounds;

    public DisplayOrientation CurrentOrientation => this.currentOrientation;

    public string ScreenDeviceName => this.defaultAdapterName;

    internal bool IsResumePending { get; private set; }

    internal DisplayOrientation SupportedOrientations => this.frame == null || this.frame.Content == null ? DisplayOrientation.Portrait : this.ConvertToDisplayOrientation((this.frame.Content as PhoneApplicationPage).SupportedOrientations);

    public MobileSharedGameWindow()
    {
      IntPtr zero = IntPtr.Zero;
      ApplicationHost current = ApplicationHost.Current;
      this.currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      this.defaultAdapterName = GraphicsAdapter.DefaultAdapter.DeviceName;
      this.gamePageHandle = UnsafeSharedGraphicsNativeMethods.CreatePageHandle((int) current.HostWnd);
      if (this.gamePageHandle == uint.MaxValue)
        throw new InvalidOperationException(FrameworkResources.UnexpectedError);
      int left = 0;
      int top = 0;
      Helpers.ThrowExceptionFromResult(UnsafeSharedGraphicsNativeMethods.GamePage_GetClientBounds(this.gamePageHandle, ref left, ref top, ref this.gamePageWidth, ref this.gamePageHeight, true));
      this.clientBounds = new Rectangle(left, top, this.gamePageWidth, this.gamePageHeight);
      this.taskThreadId = Thread.CurrentThread.ManagedThreadId;
      this.handle = new IntPtr((long) this.gamePageHandle);
      this.frame = PhoneApplicationFrame.Current;
      this.frame.Navigated += new NavigatedEventHandler(this.Navigated);
      this.firstNavigate = true;
    }

    public void BeginScreenDeviceChange()
    {
      if (this.gamePageHandle == uint.MaxValue)
        return;
      this.OnClientOrOrientationChanged(false);
    }

    public void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
    {
      this.currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      this.defaultAdapterName = GraphicsAdapter.DefaultAdapter.DeviceName;
    }

    public void Cleanup()
    {
      UnsafeSharedGraphicsNativeMethods.GamePage_ReleaseHandle(this.gamePageHandle);
      this.handle = IntPtr.Zero;
    }

    private void Navigated(object sender, NavigationEventArgs e)
    {
      this.UnhookPageEvents();
      if (e.Content == null)
        return;
      this.Initialize();
      this.HookPageEvents();
      if (this.firstNavigate || e.IsNavigationInitiator || e.NavigationMode != NavigationMode.New)
      {
        this.OnClientOrOrientationChanged(true);
        this.firstNavigate = false;
      }
      Keyboard.IsEnabled = true;
    }

    private void OnVisibleRegionChange()
    {
      if (this.taskThreadId == Thread.CurrentThread.ManagedThreadId)
        this.lastKnownVisibleRegionRect = NativeSystemTrayInteropWrapper.GetVisibleRegion(ApplicationHost.Current.RootTask.GetCurrentOrientation());
      this.OnClientOrOrientationChanged(false);
    }

    private void OnUIOrientationChange(Orientations orientation) => this.OnClientOrOrientationChanged(false);

    private void OnCancelRequest()
    {
      Guide.CloseDialog();
      this.Cleanup();
    }

    private void OnResumePageRequest(bool isExecutionContextPreserved)
    {
      this.HookPageEvents();
      this.IsResumePending = false;
      this.OnActivated();
    }

    private void OnObscurityChangeEventHandler(bool isObscured)
    {
      Guide.OnObscuredChanged(isObscured);
      if (isObscured)
      {
        Keyboard.IsEnabled = false;
        this.OnDeactivated();
      }
      else
      {
        Keyboard.IsEnabled = true;
        this.OnActivated();
      }
    }

    private void OnLockStateChangeEventHandler(bool isVisible)
    {
      Guide.OnObscuredChanged(isVisible);
      if (isVisible)
      {
        Keyboard.IsEnabled = false;
        GameDispatcher.SuppressDraw = true;
        if (SharedGraphicsDeviceManager.Current != null)
          SharedGraphicsDeviceManager.Current.StopTimer();
        this.OnDeactivated();
      }
      else
      {
        Keyboard.IsEnabled = true;
        GameDispatcher.SuppressDraw = false;
        if (SharedGraphicsDeviceManager.Current != null)
          SharedGraphicsDeviceManager.Current.StartTimer();
        this.OnActivated();
      }
    }

    private void OnSipVisibilityChange(bool sipVisible, int sipHeight) => this.isSipVisible = sipVisible;

    private void Initialize()
    {
      if (this.isInitialized)
        return;
      ApplicationHost current = ApplicationHost.Current;
      Task rootTask;
      (rootTask = current.RootTask).OnCancel += new ITask.Cancel(this.OnCancelRequest);
      rootTask.OnResume += new ITask.Resume(this.OnResumePageRequest);
      this.IsResumePending = current.Rehydrated;
      this.isInitialized = true;
    }

    private void HookPageEvents()
    {
      ITask rootTask = (ITask) ApplicationHost.Current.RootTask;
      if (this.isInitialized && this.gamePageHandle != uint.MaxValue)
      {
        rootTask.OnVisibleRegionChange += new ITask.VisibleRegionChanged(this.OnVisibleRegionChange);
        rootTask.OnOrientationChanged += new ITask.OrientationChanged(this.OnUIOrientationChange);
        rootTask.OnSipVisibilityChange += new ITask.SipVisibilityChange(this.OnSipVisibilityChange);
        rootTask.OnObscurityChange += new ITask.ObscurityChanged(this.OnObscurityChangeEventHandler);
        rootTask.OnLockScreenVisibilityChange += new ITask.LockScreenVisibilityChanged(this.OnLockStateChangeEventHandler);
      }
      this.OnVisibleRegionChange();
    }

    private void UnhookPageEvents()
    {
      ITask rootTask = (ITask) ApplicationHost.Current.RootTask;
      if (!this.isInitialized || this.gamePageHandle == uint.MaxValue)
        return;
      rootTask.OnVisibleRegionChange -= new ITask.VisibleRegionChanged(this.OnVisibleRegionChange);
      rootTask.OnOrientationChanged -= new ITask.OrientationChanged(this.OnUIOrientationChange);
      rootTask.OnSipVisibilityChange -= new ITask.SipVisibilityChange(this.OnSipVisibilityChange);
      rootTask.OnObscurityChange -= new ITask.ObscurityChanged(this.OnObscurityChangeEventHandler);
      rootTask.OnLockScreenVisibilityChange -= new ITask.LockScreenVisibilityChanged(this.OnLockStateChangeEventHandler);
    }

    private DisplayOrientation ConvertToDisplayOrientation(
      SupportedPageOrientation orientation)
    {
      DisplayOrientation displayOrientation = DisplayOrientation.Default;
      if (orientation == SupportedPageOrientation.PortraitOrLandscape)
        displayOrientation = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight | DisplayOrientation.Portrait;
      if (orientation == SupportedPageOrientation.Portrait)
        displayOrientation = DisplayOrientation.Portrait;
      if (orientation == SupportedPageOrientation.Landscape)
        displayOrientation = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
      return displayOrientation;
    }

    private void OnClientOrOrientationChanged(bool forceUpdate)
    {
      if (this.taskThreadId == Thread.CurrentThread.ManagedThreadId)
        this.lastKnownNavOrientation = ApplicationHost.Current.RootTask.GetCurrentOrientation();
      Orientations knownNavOrientation = this.lastKnownNavOrientation;
      Rectangle clientBounds = this.GetClientBounds(knownNavOrientation);
      DisplayOrientation displayOrientation = (knownNavOrientation & (Orientations.PortraitUp | Orientations.PortraitDown)) == Orientations.None ? ((knownNavOrientation & Orientations.LandscapeLeft) == Orientations.None ? ((knownNavOrientation & Orientations.LandscapeRight) == Orientations.None ? DisplayOrientation.Portrait : DisplayOrientation.LandscapeRight) : DisplayOrientation.LandscapeLeft) : DisplayOrientation.Portrait;
      bool flag1 = clientBounds != this.clientBounds;
      bool flag2 = displayOrientation != this.currentOrientation;
      if (forceUpdate)
      {
        flag1 = true;
        flag2 = true;
      }
      this.currentOrientation = displayOrientation;
      if (!this.isSipVisible)
      {
        this.clientBounds = clientBounds;
        UnsafeSharedGraphicsNativeMethods.GamePage_SetClientBounds(this.gamePageHandle, this.clientBounds.Left, this.clientBounds.Top, this.clientBounds.Width, this.clientBounds.Height);
      }
      if (this.gotBoundsAndOrientation)
      {
        if (flag1)
          this.OnClientSizeChanged();
        if (!flag2)
          return;
        this.OnOrientationChanged();
      }
      else
        this.gotBoundsAndOrientation = true;
    }

    private Rectangle GetClientBounds(Orientations orientation)
    {
      RECT visibleRegionRect = this.lastKnownVisibleRegionRect;
      int num1 = this.gamePageHeight - visibleRegionRect.top - visibleRegionRect.bottom;
      int num2 = this.gamePageWidth - visibleRegionRect.left - visibleRegionRect.right;
      Point point = new Point(visibleRegionRect.left, visibleRegionRect.top);
      if (visibleRegionRect.top < 0 || visibleRegionRect.left < 0 || (visibleRegionRect.right < 0 || visibleRegionRect.bottom < 0) || (num1 <= 0 || num2 <= 0 || (num1 > this.gamePageHeight || num2 > this.gamePageWidth)))
      {
        num1 = this.gamePageHeight;
        num2 = this.gamePageWidth;
        point.X = 0;
        point.Y = 0;
      }
      return new Rectangle()
      {
        Height = num1,
        Width = num2,
        Location = point
      };
    }
  }
}
