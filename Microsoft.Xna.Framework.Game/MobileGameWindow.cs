// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.MobileGameWindow
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Reflection;
using System.Threading;

namespace Microsoft.Xna.Framework
{
  internal class MobileGameWindow : GameWindow
  {
    private ISysTrayInterop systemTray;
    private DisplayMode currentDisplayMode;
    private string defaultAdapterName;
    internal uint gamePageHandle = uint.MaxValue;
    private int gamePageWidth = 480;
    private int gamePageHeight = 800;
    private RECT lastKnownVisibleRegionRect;
    private Rectangle clientBounds;
    private Orientations lastKnownNavOrientation;
    private DisplayOrientation currentOrientation;
    private Orientations supportedOrientations;
    private object pendingOrientationChangeLock = new object();
    private bool havePendingOrientationChange;
    private Orientations pendingOrientationChange;
    private bool gotBoundsAndOrientation;
    internal IntPtr handle = IntPtr.Zero;

    internal int TaskThreadId { get; private set; }

    public override IntPtr Handle => this.handle;

    public override bool AllowUserResizing
    {
      get => false;
      set
      {
      }
    }

    internal override bool IsMouseVisible
    {
      get => false;
      set
      {
      }
    }

    public override Rectangle ClientBounds
    {
      get
      {
        if (!QuirksMode.ShouldXnaUseMangoDisplaySize())
          return this.clientBounds;
        double left = (double) this.clientBounds.Left;
        float top = (float) this.clientBounds.Top;
        float width = (float) this.clientBounds.Width;
        float height = (float) this.clientBounds.Height;
        Vector2 vector2 = new Vector2(480f * width / (float) this.gamePageWidth, 800f * height / (float) this.gamePageHeight);
        double x = (double) vector2.X;
        return new Rectangle((int) (left * x / (double) width), (int) ((double) top * (double) vector2.Y / (double) height), (int) vector2.X, (int) vector2.Y);
      }
    }

    public override DisplayOrientation CurrentOrientation => this.currentOrientation;

    internal override bool IsMinimized => false;

    public override string ScreenDeviceName => this.defaultAdapterName;

    internal bool IsResumePending { get; private set; }

    public MobileGameWindow()
    {
      IntPtr zero = IntPtr.Zero;
      ApplicationHost current = ApplicationHost.Current;
      this.systemTray = (ISysTrayInterop) new NativeSystemTrayInteropWrapper();
      this.systemTray.CreateSystemTray();
      this.systemTray.MakeVisibleSysTray();
      this.currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      this.defaultAdapterName = GraphicsAdapter.DefaultAdapter.DeviceName;
      this.Title = MobileGameWindow.GetDefaultTitleName();
      this.TaskThreadId = -1;
      this.gamePageHandle = MobileSafeNativeMethods.CreatePageHandle((int) current.HostWnd);
      if (this.gamePageHandle == uint.MaxValue)
        throw new InvalidOperationException(FrameworkResources.UnexpectedError);
      int left = 0;
      int top = 0;
      Helpers.ThrowExceptionFromResult(MobileSafeNativeMethods.GamePage_GetClientBounds(this.gamePageHandle, ref left, ref top, ref this.gamePageWidth, ref this.gamePageHeight, true));
      this.clientBounds = new Rectangle(left, top, this.gamePageWidth, this.gamePageHeight);
      this.handle = new IntPtr((long) this.gamePageHandle);
      ITask rootTask = (ITask) current.RootTask;
      this.TaskThreadId = Thread.CurrentThread.ManagedThreadId;
      rootTask.OnCancel += new ITask.Cancel(this.OnCancelRequest);
      rootTask.OnResume += new ITask.Resume(this.OnResumePageRequest);
      ChooserListener.Initialize();
      rootTask.ReadyToNavigate();
      if (!current.Rehydrated)
      {
        this.IsResumePending = false;
        rootTask.OnSystemKeyPressed += new ITask.SystemKeyPressed(this.OnSystemKeyPressed);
        rootTask.OnVisibleRegionChange += new ITask.VisibleRegionChanged(this.OnVisibleRegionChange);
        rootTask.OnOrientationChanged += new ITask.OrientationChanged(this.OnUIOrientationChange);
        rootTask.OnObscurityChange += new ITask.ObscurityChanged(this.OnObscurityChangeEventHandler);
      }
      else
        this.IsResumePending = true;
    }

    private void OnObscurityChangeEventHandler(bool isObscured)
    {
      Guide.OnObscuredChanged(isObscured);
      if (isObscured)
        this.OnDeactivated();
      else
        this.OnActivated();
    }

    private void OnSystemKeyPressed(NavigationSystemKey systemKeyType, out bool handled)
    {
      handled = false;
      if (systemKeyType != NavigationSystemKey.Back)
        return;
      handled = true;
      GamePad.backButtonPressed = true;
    }

    protected override void SetTitle(string title)
    {
    }

    public override void BeginScreenDeviceChange(bool willBeFullScreen)
    {
      this.systemTray.SetSystemTrayVisible(!willBeFullScreen);
      if (this.gamePageHandle == uint.MaxValue)
        return;
      this.OnClientOrOrientationChanged();
    }

    public override void EndScreenDeviceChange(
      string screenDeviceName,
      int clientWidth,
      int clientHeight)
    {
      this.currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      this.defaultAdapterName = GraphicsAdapter.DefaultAdapter.DeviceName;
    }

    private void OnCancelRequest()
    {
      Guide.CloseDialog();
      this.SignalTaskToComplete(-2147467260);
    }

    private void OnResumePageRequest(bool isExecutionContextPreserved)
    {
      Task rootTask;
      (rootTask = ApplicationHost.Current.RootTask).OnSystemKeyPressed += new ITask.SystemKeyPressed(this.OnSystemKeyPressed);
      rootTask.OnVisibleRegionChange += new ITask.VisibleRegionChanged(this.OnVisibleRegionChange);
      rootTask.OnOrientationChanged += new ITask.OrientationChanged(this.OnUIOrientationChange);
      rootTask.OnObscurityChange += new ITask.ObscurityChanged(this.OnObscurityChangeEventHandler);
      this.IsResumePending = false;
      this.OnActivated();
    }

    public void SignalTaskToComplete(int exitCode)
    {
      this.Cleanup();
      if (XnaGameApplication.s_IsClosing)
        return;
      ApplicationHost.Current.RootTask.Complete(exitCode);
    }

    private void OnVisibleRegionChange() => this.OnClientOrOrientationChanged();

    private void OnUIOrientationChange(Orientations orientation)
    {
      if (this.supportedOrientations != Orientations.None && (orientation & this.supportedOrientations) == Orientations.None)
        return;
      this.lastKnownNavOrientation = orientation;
      this.OnClientOrOrientationChanged();
    }

    protected internal override void SetSupportedOrientations(DisplayOrientation orientations)
    {
      Orientations orientations1 = Orientations.None;
      if ((orientations & DisplayOrientation.Portrait) != DisplayOrientation.Default)
        orientations1 |= Orientations.PortraitUp;
      if ((orientations & DisplayOrientation.LandscapeLeft) != DisplayOrientation.Default)
        orientations1 |= Orientations.LandscapeLeft;
      if ((orientations & DisplayOrientation.LandscapeRight) != DisplayOrientation.Default)
        orientations1 |= Orientations.LandscapeRight;
      lock (this.pendingOrientationChangeLock)
      {
        this.pendingOrientationChange = orientations1;
        this.havePendingOrientationChange = true;
      }
      if (this.TaskThreadId != Thread.CurrentThread.ManagedThreadId)
        return;
      this.ApplyPendingOrientationChanges();
    }

    internal void ApplyPendingOrientationChanges()
    {
      bool flag = false;
      Orientations orientation = Orientations.None;
      lock (this.pendingOrientationChangeLock)
      {
        if (this.havePendingOrientationChange)
        {
          this.supportedOrientations = this.pendingOrientationChange;
          ApplicationHost.Current.RootTask.SetSupportedOrientations(this.pendingOrientationChange);
          this.havePendingOrientationChange = false;
          orientation = this.pendingOrientationChange;
          flag = true;
        }
      }
      if (!flag)
        return;
      if (this.lastKnownNavOrientation == Orientations.None)
        this.lastKnownNavOrientation = ApplicationHost.Current.RootTask.GetCurrentOrientation();
      if ((orientation & this.lastKnownNavOrientation) != Orientations.None)
        return;
      if ((orientation & (Orientations.PortraitUp | Orientations.PortraitDown)) != Orientations.None)
        orientation = Orientations.PortraitUp;
      else if ((orientation & Orientations.LandscapeLeft) != Orientations.None)
        orientation = Orientations.LandscapeLeft;
      else if ((orientation & Orientations.LandscapeRight) != Orientations.None)
        orientation = Orientations.LandscapeRight;
      this.OnUIOrientationChange(orientation);
    }

    private void OnClientOrOrientationChanged()
    {
      if (this.TaskThreadId == Thread.CurrentThread.ManagedThreadId)
        this.lastKnownVisibleRegionRect = NativeSystemTrayInteropWrapper.GetVisibleRegion(this.lastKnownNavOrientation);
      Orientations knownNavOrientation = this.lastKnownNavOrientation;
      Rectangle clientBounds = this.GetClientBounds(knownNavOrientation);
      DisplayOrientation displayOrientation = (knownNavOrientation & (Orientations.PortraitUp | Orientations.PortraitDown)) == Orientations.None ? ((knownNavOrientation & Orientations.LandscapeLeft) == Orientations.None ? ((knownNavOrientation & Orientations.LandscapeRight) == Orientations.None ? DisplayOrientation.Default : DisplayOrientation.LandscapeRight) : DisplayOrientation.LandscapeLeft) : DisplayOrientation.Portrait;
      bool flag1 = clientBounds != this.clientBounds;
      bool flag2 = displayOrientation != this.currentOrientation;
      this.currentOrientation = displayOrientation;
      this.clientBounds = clientBounds;
      MobileSafeNativeMethods.GamePage_SetClientBounds(this.gamePageHandle, this.clientBounds.Left, this.clientBounds.Top, this.clientBounds.Width, this.clientBounds.Height);
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
      visibleRegionRect.left = 0;
      visibleRegionRect.right = 0;
      visibleRegionRect.bottom = 0;
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

    public void Cleanup()
    {
      MobileSafeNativeMethods.GamePage_ReleaseHandle(this.gamePageHandle);
      this.handle = IntPtr.Zero;
    }

    private static string GetAssemblyTitle(Assembly assembly)
    {
      if (assembly == null)
        return (string) null;
      AssemblyTitleAttribute[] customAttributes = (AssemblyTitleAttribute[]) assembly.GetCustomAttributes(typeof (AssemblyTitleAttribute), true);
      return customAttributes != null && customAttributes.Length != 0 ? customAttributes[0].Title : (string) null;
    }

    private static string GetDefaultTitleName() => Resources.DefaultTitleName;
  }
}
