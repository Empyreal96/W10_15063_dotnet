// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GraphicsDeviceManager
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework
{
  public class GraphicsDeviceManager : IGraphicsDeviceService, IDisposable, IGraphicsDeviceManager
  {
    public static readonly int DefaultBackBufferWidth = 800;
    public static readonly int DefaultBackBufferHeight = 480;
    private static readonly TimeSpan deviceLostSleepTime = TimeSpan.FromMilliseconds(50.0);
    private Game game;
    private bool isReallyFullScreen;
    private bool isDeviceDirty;
    private bool inDeviceTransition;
    private GraphicsDevice device;
    private bool synchronizeWithVerticalRetrace = true;
    private bool isFullScreen;
    private GraphicsProfile graphicsProfile;
    private SurfaceFormat backBufferFormat = SurfaceFormat.Bgr565;
    private DepthFormat depthStencilFormat = DepthFormat.Depth24;
    private int backBufferWidth = GraphicsDeviceManager.DefaultBackBufferWidth;
    private int backBufferHeight = GraphicsDeviceManager.DefaultBackBufferHeight;
    private bool allowMultiSampling;
    private DisplayOrientation supportedOrientations;
    private DisplayOrientation currentWindowOrientation;
    private int resizedBackBufferWidth;
    private int resizedBackBufferHeight;
    private bool useResizedBackBuffer;
    private EventHandler<EventArgs> deviceCreated;
    private EventHandler<EventArgs> deviceResetting;
    private EventHandler<EventArgs> deviceReset;
    private EventHandler<EventArgs> deviceDisposing;
    private bool beginDrawOk;

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
        this.useResizedBackBuffer = false;
        this.isDeviceDirty = true;
      }
    }

    public int PreferredBackBufferHeight
    {
      get => this.backBufferHeight;
      set
      {
        this.backBufferHeight = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof (value), Resources.BackBufferDimMustBePositive);
        this.useResizedBackBuffer = false;
        this.isDeviceDirty = true;
      }
    }

    public bool IsFullScreen
    {
      get => this.isFullScreen;
      set
      {
        this.isFullScreen = value;
        this.isDeviceDirty = true;
      }
    }

    public bool SynchronizeWithVerticalRetrace
    {
      get => this.synchronizeWithVerticalRetrace;
      set
      {
        this.synchronizeWithVerticalRetrace = value;
        this.isDeviceDirty = true;
      }
    }

    public bool PreferMultiSampling
    {
      get => this.allowMultiSampling;
      set
      {
        this.allowMultiSampling = value;
        this.isDeviceDirty = true;
      }
    }

    public DisplayOrientation SupportedOrientations
    {
      get => this.supportedOrientations;
      set
      {
        this.supportedOrientations = value;
        this.isDeviceDirty = true;
      }
    }

    public GraphicsDevice GraphicsDevice => this.device;

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

    public event EventHandler<PreparingDeviceSettingsEventArgs> PreparingDeviceSettings;

    public event EventHandler<EventArgs> Disposed;

    public GraphicsDeviceManager(Game game)
    {
      this.game = game != null ? game : throw new ArgumentNullException(nameof (game), Resources.GameCannotBeNull);
      if (game.Services.GetService(typeof (IGraphicsDeviceManager)) != null)
        throw new ArgumentException(Resources.GraphicsDeviceManagerAlreadyPresent);
      game.Services.AddService(typeof (IGraphicsDeviceManager), (object) this);
      game.Services.AddService(typeof (IGraphicsDeviceService), (object) this);
      game.Window.ClientSizeChanged += new EventHandler<EventArgs>(this.GameWindowClientSizeChanged);
      game.Window.ScreenDeviceNameChanged += new EventHandler<EventArgs>(this.GameWindowScreenDeviceNameChanged);
      game.Window.OrientationChanged += new EventHandler<EventArgs>(this.GameWindowOrientationChanged);
      this.graphicsProfile = this.ReadDefaultGraphicsProfile();
    }

    public void ApplyChanges()
    {
      if (this.device != null && !this.isDeviceDirty)
        return;
      this.ChangeDevice(false);
    }

    public void ToggleFullScreen()
    {
      this.IsFullScreen = !this.IsFullScreen;
      this.ChangeDevice(false);
    }

    private void GameWindowScreenDeviceNameChanged(object sender, EventArgs e)
    {
      if (this.inDeviceTransition)
        return;
      this.ChangeDevice(false);
    }

    private void GameWindowClientSizeChanged(object sender, EventArgs e)
    {
      if (this.inDeviceTransition || this.game.Window.ClientBounds.Height == 0 && this.game.Window.ClientBounds.Width == 0)
        return;
      this.resizedBackBufferWidth = this.game.Window.ClientBounds.Width;
      this.resizedBackBufferHeight = this.game.Window.ClientBounds.Height;
      this.useResizedBackBuffer = true;
      this.ChangeDevice(false);
    }

    private void GameWindowOrientationChanged(object sender, EventArgs e)
    {
      if (this.inDeviceTransition || this.game.Window.ClientBounds.Height == 0 && this.game.Window.ClientBounds.Width == 0 || this.game.Window.CurrentOrientation == this.currentWindowOrientation)
        return;
      this.ChangeDevice(false);
    }

    private bool EnsureDevice() => this.device != null && this.EnsureDevicePlatform();

    private void CreateDevice(GraphicsDeviceInformation newInfo)
    {
      if (this.device != null)
      {
        this.device.Dispose();
        this.device = (GraphicsDevice) null;
      }
      this.OnPreparingDeviceSettings((object) this, new PreparingDeviceSettingsEventArgs(newInfo));
      this.MassagePresentParameters(newInfo.PresentationParameters);
      try
      {
        this.ValidateGraphicsDeviceInformation(newInfo);
        this.device = new GraphicsDevice(newInfo.Adapter, newInfo.GraphicsProfile, newInfo.PresentationParameters);
        this.device.DeviceResetting += new EventHandler<EventArgs>(this.HandleDeviceResetting);
        this.device.DeviceReset += new EventHandler<EventArgs>(this.HandleDeviceReset);
        this.device.DeviceLost += new EventHandler<EventArgs>(this.HandleDeviceLost);
        this.device.Disposing += new EventHandler<EventArgs>(this.HandleDisposing);
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
      GraphicsDeviceManager.ConfigureTouchInput(newInfo.PresentationParameters);
      this.OnDeviceCreated((object) this, EventArgs.Empty);
    }

    private void ChangeDevice(bool forceCreate)
    {
      if (this.game == null)
        throw new InvalidOperationException(Resources.GraphicsComponentNotAttachedToGame);
      this.inDeviceTransition = true;
      string screenDeviceName = this.game.Window.ScreenDeviceName;
      int clientWidth = this.game.Window.ClientBounds.Width;
      int clientHeight = this.game.Window.ClientBounds.Height;
      bool flag1 = false;
      try
      {
        this.game.Window.SetSupportedOrientations(Helpers.ChooseOrientation(this.supportedOrientations, this.PreferredBackBufferWidth, this.PreferredBackBufferHeight, true));
        bool isFullScreen = this.IsFullScreen;
        this.game.Window.BeginScreenDeviceChange(isFullScreen);
        flag1 = true;
        GraphicsDeviceInformation bestDevice = this.FindBestDevice(forceCreate);
        if (bestDevice.PresentationParameters.IsFullScreen != isFullScreen)
        {
          this.game.Window.BeginScreenDeviceChange(bestDevice.PresentationParameters.IsFullScreen);
          flag1 = true;
        }
        bool flag2 = true;
        if (!forceCreate && this.device != null)
        {
          this.OnPreparingDeviceSettings((object) this, new PreparingDeviceSettingsEventArgs(bestDevice));
          if (this.CanResetDevice(bestDevice))
          {
            try
            {
              GraphicsDeviceInformation deviceInformation = bestDevice.Clone();
              this.MassagePresentParameters(bestDevice.PresentationParameters);
              this.ValidateGraphicsDeviceInformation(bestDevice);
              this.device.Reset(deviceInformation.PresentationParameters, deviceInformation.Adapter);
              GraphicsDeviceManager.ConfigureTouchInput(deviceInformation.PresentationParameters);
              flag2 = false;
            }
            catch
            {
            }
          }
        }
        if (flag2)
          this.CreateDevice(bestDevice);
        PresentationParameters presentationParameters = this.device.PresentationParameters;
        screenDeviceName = this.device.Adapter.DeviceName;
        this.isReallyFullScreen = presentationParameters.IsFullScreen;
        if (presentationParameters.BackBufferWidth != 0)
          clientWidth = presentationParameters.BackBufferWidth;
        if (presentationParameters.BackBufferHeight != 0)
          clientHeight = presentationParameters.BackBufferHeight;
        this.isDeviceDirty = false;
      }
      finally
      {
        if (flag1)
          this.game.Window.EndScreenDeviceChange(screenDeviceName, clientWidth, clientHeight);
        this.currentWindowOrientation = this.game.Window.CurrentOrientation;
        this.inDeviceTransition = false;
      }
    }

    private void MassagePresentParameters(PresentationParameters pp)
    {
      int backBufferWidth = pp.BackBufferWidth;
      int backBufferHeight = pp.BackBufferHeight;
      int num = pp.IsFullScreen ? 1 : 0;
    }

    private static void ConfigureTouchInput(PresentationParameters pp)
    {
      TouchPanel.DisplayWidth = pp.BackBufferWidth;
      TouchPanel.DisplayHeight = pp.BackBufferHeight;
      TouchPanel.DisplayOrientation = pp.DisplayOrientation;
    }

    protected virtual GraphicsDeviceInformation FindBestDevice(
      bool anySuitableDevice)
    {
      return this.FindBestPlatformDevice(anySuitableDevice);
    }

    protected virtual bool CanResetDevice(GraphicsDeviceInformation newDeviceInfo) => this.device.GraphicsProfile == newDeviceInfo.GraphicsProfile;

    protected virtual void RankDevices(List<GraphicsDeviceInformation> foundDevices) => this.RankDevicesPlatform(foundDevices);

    private void HandleDisposing(object sender, EventArgs e) => this.OnDeviceDisposing((object) this, EventArgs.Empty);

    private void HandleDeviceLost(object sender, EventArgs e)
    {
    }

    private void HandleDeviceReset(object sender, EventArgs e) => this.OnDeviceReset((object) this, EventArgs.Empty);

    private void HandleDeviceResetting(object sender, EventArgs e) => this.OnDeviceResetting((object) this, EventArgs.Empty);

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnDeviceCreated(object sender, EventArgs args)
    {
      if (this.deviceCreated == null)
        return;
      this.deviceCreated(sender, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnDeviceDisposing(object sender, EventArgs args)
    {
      if (this.deviceDisposing == null)
        return;
      this.deviceDisposing(sender, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnDeviceReset(object sender, EventArgs args)
    {
      if (this.deviceReset == null)
        return;
      this.deviceReset(sender, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnDeviceResetting(object sender, EventArgs args)
    {
      if (this.deviceResetting == null)
        return;
      this.deviceResetting(sender, args);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      if (this.game != null)
      {
        if (this.game.Services.GetService(typeof (IGraphicsDeviceService)) == this)
          this.game.Services.RemoveService(typeof (IGraphicsDeviceService));
        this.game.Window.ClientSizeChanged -= new EventHandler<EventArgs>(this.GameWindowClientSizeChanged);
        this.game.Window.ScreenDeviceNameChanged -= new EventHandler<EventArgs>(this.GameWindowScreenDeviceNameChanged);
        this.game.Window.OrientationChanged -= new EventHandler<EventArgs>(this.GameWindowOrientationChanged);
      }
      if (this.device != null)
      {
        this.device.Dispose();
        this.device = (GraphicsDevice) null;
      }
      if (this.Disposed == null)
        return;
      this.Disposed((object) this, EventArgs.Empty);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnPreparingDeviceSettings(
      object sender,
      PreparingDeviceSettingsEventArgs args)
    {
      if (this.PreparingDeviceSettings == null)
        return;
      this.PreparingDeviceSettings(sender, args);
    }

    void IDisposable.Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    void IGraphicsDeviceManager.CreateDevice() => this.ChangeDevice(true);

    bool IGraphicsDeviceManager.BeginDraw()
    {
      if (!this.EnsureDevice())
        return false;
      this.beginDrawOk = true;
      return true;
    }

    void IGraphicsDeviceManager.EndDraw()
    {
      if (!this.beginDrawOk)
        return;
      if (this.device == null)
        return;
      try
      {
        this.device.Present();
        this.game.Host.OnPresent();
      }
      catch (DeviceLostException ex)
      {
      }
      catch (DeviceNotResetException ex)
      {
      }
    }

    private GraphicsProfile ReadDefaultGraphicsProfile() => GraphicsProfile.Reach;

    private bool EnsureDevicePlatform() => true;

    private void RankDevicesPlatform(List<GraphicsDeviceInformation> foundDevices)
    {
    }

    private GraphicsDeviceInformation FindBestPlatformDevice(
      bool anySuitableDevice)
    {
      List<GraphicsDeviceInformation> foundDevices = new List<GraphicsDeviceInformation>();
      this.AddDevice(foundDevices, this.PreferredBackBufferWidth, this.PreferredBackBufferHeight, this.PreferredDepthStencilFormat, this.PreferMultiSampling ? 2 : 0);
      this.RankDevices(foundDevices);
      return foundDevices.Count != 0 ? foundDevices[0] : throw new NoSuitableGraphicsDeviceException(Resources.NoCompatibleDevicesAfterRanking);
    }

    private void AddDevice(
      List<GraphicsDeviceInformation> foundDevices,
      int backBufferWidth,
      int backBufferHeight,
      DepthFormat depthStencilFormat,
      int multiSampleCount)
    {
      PresentationParameters presentationParameters = new PresentationParameters();
      if (backBufferWidth == 0)
        backBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
      if (backBufferHeight == 0)
        backBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
      DisplayOrientation displayOrientation = Helpers.ChooseOrientation(this.supportedOrientations, backBufferWidth, backBufferHeight, true);
      DisplayOrientation orientation = this.game.Window.CurrentOrientation & displayOrientation;
      if (orientation == DisplayOrientation.Default)
        orientation = (displayOrientation & DisplayOrientation.LandscapeLeft) == DisplayOrientation.Default ? ((displayOrientation & DisplayOrientation.LandscapeRight) == DisplayOrientation.Default ? DisplayOrientation.Portrait : DisplayOrientation.LandscapeRight) : DisplayOrientation.LandscapeLeft;
      if (Helpers.IsLandscape(orientation) != backBufferWidth > backBufferHeight && (displayOrientation & (DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight)) != DisplayOrientation.Default && (displayOrientation & DisplayOrientation.Portrait) != DisplayOrientation.Default)
      {
        int num = backBufferWidth;
        backBufferWidth = backBufferHeight;
        backBufferHeight = num;
      }
      int num1 = Helpers.MaxDisplayWidth;
      int num2 = Helpers.MaxDisplayHeight;
      if (Helpers.IsLandscape(orientation))
      {
        int num3 = num1;
        num1 = num2;
        num2 = num3;
      }
      if (backBufferWidth > num1)
        backBufferWidth = num1;
      else if (backBufferWidth < 240)
        backBufferWidth = 240;
      if (backBufferHeight > num2)
        backBufferHeight = num2;
      else if (backBufferHeight < 240)
        backBufferHeight = 240;
      presentationParameters.BackBufferWidth = backBufferWidth;
      presentationParameters.BackBufferHeight = backBufferHeight;
      presentationParameters.BackBufferFormat = this.PreferredBackBufferFormat;
      presentationParameters.MultiSampleCount = multiSampleCount;
      presentationParameters.DisplayOrientation = orientation;
      presentationParameters.PresentationInterval = this.SynchronizeWithVerticalRetrace ? PresentInterval.Default : PresentInterval.Immediate;
      presentationParameters.DepthStencilFormat = depthStencilFormat;
      presentationParameters.IsFullScreen = this.IsFullScreen;
      GraphicsDeviceInformation deviceInformation = new GraphicsDeviceInformation()
      {
        Adapter = GraphicsAdapter.DefaultAdapter,
        GraphicsProfile = this.graphicsProfile,
        PresentationParameters = presentationParameters
      };
      deviceInformation.PresentationParameters.DeviceWindowHandle = this.game.Window.Handle;
      foundDevices.Add(deviceInformation);
    }

    private void ValidateGraphicsDeviceInformation(GraphicsDeviceInformation devInfo)
    {
      PresentationParameters presentationParameters = devInfo.PresentationParameters;
      if (presentationParameters.BackBufferWidth == 0 || presentationParameters.BackBufferHeight == 0)
        throw new NotSupportedException(Resources.ValidateBackBufferDimsFullScreen);
    }
  }
}
