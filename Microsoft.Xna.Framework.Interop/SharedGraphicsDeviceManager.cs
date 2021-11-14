// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.SharedGraphicsDeviceManager
// Assembly: Microsoft.Xna.Framework.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: E258DF81-FBD7-4DF4-930E-981F36DBB495
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI20E9~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using MS.Internal;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Windows;

namespace Microsoft.Xna.Framework
{
  public class SharedGraphicsDeviceManager : 
    IGraphicsDeviceService,
    IDisposable,
    IApplicationService,
    IApplicationLifetimeAware
  {
    public static readonly int DefaultBackBufferWidth = 480;
    public static readonly int DefaultBackBufferHeight = 800;
    private static readonly TimeSpan deviceLostSleepTime = TimeSpan.FromMilliseconds(50.0);
    internal static SharedGraphicsDeviceManager instance;
    private MobileSharedGameWindow gameWindow;
    private GameTimer timer;
    private bool timerStarted;
    private bool isDeviceDirty;
    private bool inDeviceTransition;
    private GraphicsDevice device;
    private GraphicsProfile graphicsProfile;
    private SurfaceFormat backBufferFormat = SurfaceFormat.Bgr565;
    private DepthFormat depthStencilFormat = DepthFormat.Depth24;
    private int backBufferWidth = SharedGraphicsDeviceManager.DefaultBackBufferWidth;
    private int backBufferHeight = SharedGraphicsDeviceManager.DefaultBackBufferHeight;
    private int multiSampleCount;
    private RenderTargetUsage renderTargetUsage;
    private PresentInterval presentationInterval = PresentInterval.One;
    private DisplayOrientation currentWindowOrientation = DisplayOrientation.Portrait;
    private int presentSortOrder = int.MaxValue;
    internal static object syncObject = new object();
    internal object timerSyncObject = new object();
    private EventHandler<EventArgs> deviceCreated;
    private EventHandler<EventArgs> deviceResetting;
    private EventHandler<EventArgs> deviceReset;
    private EventHandler<EventArgs> deviceDisposing;

    public event EventHandler<EventArgs> DeviceCreated
    {
      add => this.deviceCreated += value;
      remove => this.deviceCreated -= value;
    }

    public event EventHandler<EventArgs> DeviceResetting
    {
      add => this.deviceResetting += value;
      remove => this.deviceResetting -= value;
    }

    public event EventHandler<EventArgs> DeviceReset
    {
      add => this.deviceReset += value;
      remove => this.deviceReset -= value;
    }

    public event EventHandler<EventArgs> DeviceDisposing
    {
      add => this.deviceDisposing += value;
      remove => this.deviceDisposing -= value;
    }

    public event EventHandler<EventArgs> Disposed;

    public GraphicsProfile GraphicsProfile
    {
      get => this.graphicsProfile;
      set
      {
        this.graphicsProfile = value;
        this.isDeviceDirty = true;
      }
    }

    public DepthFormat PreferredDepthStencilFormat
    {
      get => this.depthStencilFormat;
      set
      {
        this.depthStencilFormat = value;
        this.isDeviceDirty = true;
      }
    }

    public SurfaceFormat PreferredBackBufferFormat
    {
      get => this.backBufferFormat;
      set
      {
        this.backBufferFormat = value;
        this.isDeviceDirty = true;
      }
    }

    public int PreferredBackBufferWidth
    {
      get => this.backBufferWidth;
      set
      {
        this.backBufferWidth = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof (value), Resources.BackBufferDimMustBePositive);
        this.isDeviceDirty = true;
      }
    }

    public int PreferredBackBufferHeight
    {
      get => this.backBufferHeight;
      set
      {
        this.backBufferHeight = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof (value), Resources.BackBufferDimMustBePositive);
        this.isDeviceDirty = true;
      }
    }

    public bool SynchronizeWithVerticalRetrace
    {
      get => this.presentationInterval == PresentInterval.One;
      set
      {
        this.presentationInterval = value ? PresentInterval.One : PresentInterval.Immediate;
        this.isDeviceDirty = true;
      }
    }

    public PresentInterval PresentationInterval
    {
      get => this.presentationInterval;
      set
      {
        this.presentationInterval = value;
        this.isDeviceDirty = true;
      }
    }

    public int MultiSampleCount
    {
      get => this.multiSampleCount;
      set
      {
        this.multiSampleCount = value;
        this.isDeviceDirty = true;
      }
    }

    public RenderTargetUsage RenderTargetUsage
    {
      get => this.renderTargetUsage;
      set
      {
        this.renderTargetUsage = value;
        this.isDeviceDirty = true;
      }
    }

    public GraphicsDevice GraphicsDevice => this.device;

    public static SharedGraphicsDeviceManager Current => SharedGraphicsDeviceManager.instance;

    public SharedGraphicsDeviceManager()
    {
      lock (SharedGraphicsDeviceManager.syncObject)
      {
        if (ApplicationHost.Current.ApplicationType == ApplicationType.Xna)
          throw new InvalidOperationException(FrameworkResources.DirectRenderingWrongAppType);
        if (SharedGraphicsDeviceManager.instance != null)
          throw new InvalidOperationException(Resources.DirectRenderOnlyOneManager);
      }
    }

    public void ApplyChanges()
    {
      if (this.device != null && !this.isDeviceDirty)
        return;
      this.ChangeDevice(false);
    }

    [SecuritySafeCritical]
    private void Initialize()
    {
      IntPtr zero1 = IntPtr.Zero;
      IntPtr zero2 = IntPtr.Zero;
      IntPtr zero3 = IntPtr.Zero;
      IntPtr zero4 = IntPtr.Zero;
      this.gameWindow = new MobileSharedGameWindow();
      this.timer = new GameTimer();
      this.gameWindow.ClientSizeChanged += new EventHandler<EventArgs>(this.GameWindowClientSizeChanged);
      this.gameWindow.ScreenDeviceNameChanged += new EventHandler<EventArgs>(this.GameWindowScreenDeviceNameChanged);
      this.gameWindow.OrientationChanged += new EventHandler<EventArgs>(this.GameWindowOrientationChanged);
      DirectRendering.Initialize(ref zero3, ref zero1, ref zero2, ref zero4);
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeSharedGraphicsNativeMethods.DirectRendering_Initialize(GraphicsAdapter.pComHandle, zero3, zero1, zero2, zero4));
      this.timer.DrawOrder = this.presentSortOrder;
      this.timer.Draw += new EventHandler<GameTimerEventArgs>(this.OnDraw);
      this.StartTimer();
    }

    private void OnDraw(object sender, GameTimerEventArgs e)
    {
      lock (this.timerSyncObject)
      {
        if (this.device == null || !this.timerStarted || (!this.device.inDirectRenderingMode || this.device.currentRenderTargetCount > 0))
          return;
        this.device.InternalPresent();
      }
    }

    internal void StartTimer()
    {
      lock (this.timerSyncObject)
      {
        if (this.timer == null || this.timerStarted)
          return;
        this.timer.Start();
        this.timerStarted = true;
      }
    }

    internal void StopTimer()
    {
      lock (this.timerSyncObject)
      {
        if (this.timer == null || !this.timerStarted)
          return;
        this.timer.Stop();
        this.timerStarted = false;
      }
    }

    private void GameWindowScreenDeviceNameChanged(object sender, EventArgs e)
    {
      if (this.inDeviceTransition)
        return;
      this.ChangeDevice(false);
    }

    private void GameWindowClientSizeChanged(object sender, EventArgs e)
    {
      if (this.inDeviceTransition || this.device != null && !this.device.inDirectRenderingMode)
        return;
      this.ChangeDevice(false);
    }

    private void GameWindowOrientationChanged(object sender, EventArgs e)
    {
      if (this.inDeviceTransition || this.gameWindow.CurrentOrientation == this.currentWindowOrientation && (this.gameWindow.CurrentOrientation & this.gameWindow.SupportedOrientations) != DisplayOrientation.Default || this.device != null && !this.device.inDirectRenderingMode)
        return;
      this.ChangeDevice(false);
    }

    private void HookDeviceEvents()
    {
      this.device.DeviceResetting += new EventHandler<EventArgs>(this.HandleDeviceResetting);
      this.device.DeviceReset += new EventHandler<EventArgs>(this.HandleDeviceReset);
      this.device.DeviceLost += new EventHandler<EventArgs>(this.HandleDeviceLost);
      this.device.Disposing += new EventHandler<EventArgs>(this.HandleDisposing);
    }

    private bool EnsureDevice() => this.device != null;

    private void CreateDevice(PresentationParameters pp)
    {
      bool flag = false;
      if (this.device != null)
      {
        flag = this.device.inDirectRenderingMode;
        this.device.Dispose();
        this.device = (GraphicsDevice) null;
      }
      try
      {
        this.ValidateGraphicsDeviceInformation(pp);
        this.device = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, this.graphicsProfile, pp, true);
        if (flag)
        {
          this.device.InitializeDeviceState();
          this.device.inDirectRenderingMode = flag;
        }
        this.HookDeviceEvents();
      }
      catch (NoSuitableGraphicsDeviceException ex)
      {
        throw;
      }
      catch (ArgumentException ex)
      {
        throw new NoSuitableGraphicsDeviceException(Resources.Direct3DInvalidCreateParameters, (Exception) ex);
      }
      catch (Exception ex)
      {
        throw new NoSuitableGraphicsDeviceException(Resources.Direct3DCreateError, ex);
      }
      SharedGraphicsDeviceManager.ConfigureTouchInput(pp);
      this.OnDeviceCreated((object) this, EventArgs.Empty);
    }

    internal void ChangeDevice(bool forceCreate)
    {
      this.inDeviceTransition = true;
      string screenDeviceName = this.gameWindow.ScreenDeviceName;
      int clientWidth = this.gameWindow.ClientBounds.Width;
      int clientHeight = this.gameWindow.ClientBounds.Height;
      bool flag1 = false;
      try
      {
        this.gameWindow.BeginScreenDeviceChange();
        flag1 = true;
        PresentationParameters pp;
        this.FindBestDevice(forceCreate, out pp);
        bool flag2 = true;
        if (!forceCreate)
        {
          if (this.device != null)
          {
            try
            {
              PresentationParameters presentationParameters = pp.Clone();
              this.ValidateGraphicsDeviceInformation(pp);
              this.device.Reset(presentationParameters, GraphicsAdapter.DefaultAdapter);
              SharedGraphicsDeviceManager.ConfigureTouchInput(pp);
              flag2 = false;
            }
            catch
            {
            }
          }
        }
        if (flag2)
          this.CreateDevice(pp);
        PresentationParameters presentationParameters1 = this.device.PresentationParameters;
        screenDeviceName = this.device.Adapter.DeviceName;
        if (presentationParameters1.BackBufferWidth != 0)
          clientWidth = presentationParameters1.BackBufferWidth;
        if (presentationParameters1.BackBufferHeight != 0)
          clientHeight = presentationParameters1.BackBufferHeight;
        this.isDeviceDirty = false;
      }
      finally
      {
        if (flag1)
          this.gameWindow.EndScreenDeviceChange(screenDeviceName, clientWidth, clientHeight);
        this.currentWindowOrientation = this.gameWindow.CurrentOrientation;
        this.inDeviceTransition = false;
      }
    }

    private static void ConfigureTouchInput(PresentationParameters pp)
    {
      TouchPanel.DisplayWidth = pp.BackBufferWidth;
      TouchPanel.DisplayHeight = pp.BackBufferHeight;
      TouchPanel.DisplayOrientation = pp.DisplayOrientation;
    }

    private void ValidateGraphicsDeviceInformation(PresentationParameters pp)
    {
      if (pp.BackBufferWidth == 0 || pp.BackBufferHeight == 0)
        throw new NotSupportedException(Resources.ValidateBackBufferDimsFullScreen);
    }

    private void FindBestDevice(bool anySuitableDevice, out PresentationParameters pp)
    {
      int width = this.PreferredBackBufferWidth;
      int height = this.PreferredBackBufferHeight;
      DepthFormat depthStencilFormat = this.PreferredDepthStencilFormat;
      pp = new PresentationParameters();
      if (width == 0)
        width = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
      if (height == 0)
        height = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
      DisplayOrientation displayOrientation = Helpers.ChooseOrientation(this.gameWindow.SupportedOrientations, width, height, true);
      DisplayOrientation orientation = this.gameWindow.CurrentOrientation & displayOrientation;
      if (orientation == DisplayOrientation.Default)
        orientation = (displayOrientation & DisplayOrientation.LandscapeLeft) == DisplayOrientation.Default ? ((displayOrientation & DisplayOrientation.LandscapeRight) == DisplayOrientation.Default ? DisplayOrientation.Portrait : DisplayOrientation.LandscapeRight) : DisplayOrientation.LandscapeLeft;
      if (Helpers.IsLandscape(orientation) != width > height && (displayOrientation & (DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight)) != DisplayOrientation.Default)
      {
        int num = width;
        width = height;
        height = num;
      }
      int num1 = Helpers.MaxDisplayWidth;
      int num2 = Helpers.MaxDisplayHeight;
      if (Helpers.IsLandscape(orientation))
      {
        int num3 = num1;
        num1 = num2;
        num2 = num3;
      }
      if (width > num1)
        width = num1;
      else if (width < 240)
        width = 240;
      if (height > num2)
        height = num2;
      else if (height < 240)
        height = 240;
      pp.BackBufferWidth = width;
      pp.BackBufferHeight = height;
      pp.BackBufferFormat = this.PreferredBackBufferFormat;
      pp.MultiSampleCount = this.multiSampleCount;
      pp.DisplayOrientation = orientation;
      pp.PresentationInterval = this.presentationInterval;
      pp.RenderTargetUsage = this.renderTargetUsage;
      pp.DepthStencilFormat = depthStencilFormat;
      pp.IsFullScreen = PhoneApplicationFrame.Current != null && PhoneApplicationFrame.Current.Content != null && !SystemTray.IsVisible;
      pp.DeviceWindowHandle = this.gameWindow.Handle;
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      if (this.timer != null)
      {
        lock (this.timerSyncObject)
          this.StopTimer();
        this.timer.Dispose();
        this.timer = (GameTimer) null;
      }
      if (this.gameWindow != null)
      {
        this.gameWindow.ClientSizeChanged -= new EventHandler<EventArgs>(this.GameWindowClientSizeChanged);
        this.gameWindow.ScreenDeviceNameChanged -= new EventHandler<EventArgs>(this.GameWindowScreenDeviceNameChanged);
        this.gameWindow.OrientationChanged -= new EventHandler<EventArgs>(this.GameWindowOrientationChanged);
      }
      if (this.device != null)
      {
        this.device.Dispose();
        this.device = (GraphicsDevice) null;
      }
      int num = (int) UnsafeSharedGraphicsNativeMethods.DirectRendering_Uninitialize();
      if (this.Disposed == null)
        return;
      this.Disposed((object) this, EventArgs.Empty);
    }

    private void HandleDisposing(object sender, EventArgs e) => this.OnDeviceDisposing((object) this, EventArgs.Empty);

    private void HandleDeviceLost(object sender, EventArgs e)
    {
    }

    private void HandleDeviceReset(object sender, EventArgs e) => this.OnDeviceReset((object) this, EventArgs.Empty);

    private void HandleDeviceResetting(object sender, EventArgs e) => this.OnDeviceResetting((object) this, EventArgs.Empty);

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    private void OnDeviceCreated(object sender, EventArgs args)
    {
      if (this.deviceCreated == null)
        return;
      this.deviceCreated(sender, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    private void OnDeviceDisposing(object sender, EventArgs args)
    {
      if (this.deviceDisposing == null)
        return;
      this.deviceDisposing(sender, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    private void OnDeviceReset(object sender, EventArgs args)
    {
      if (this.deviceReset == null)
        return;
      this.deviceReset(sender, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    private void OnDeviceResetting(object sender, EventArgs args)
    {
      if (this.deviceResetting == null)
        return;
      this.deviceResetting(sender, args);
    }

    void IDisposable.Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    void IApplicationService.StartService(ApplicationServiceContext context)
    {
    }

    void IApplicationService.StopService()
    {
      this.StopTimer();
      this.Dispose(true);
    }

    void IApplicationLifetimeAware.Starting()
    {
    }

    void IApplicationLifetimeAware.Started()
    {
      lock (SharedGraphicsDeviceManager.syncObject)
      {
        this.Initialize();
        this.ChangeDevice(true);
        SharedGraphicsDeviceManager.instance = this;
        this.StartTimer();
      }
    }

    void IApplicationLifetimeAware.Exiting()
    {
    }

    void IApplicationLifetimeAware.Exited()
    {
    }
  }
}
