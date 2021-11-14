// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Game
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Microsoft.Xna.Framework
{
  public class Game : IDisposable
  {
    private readonly TimeSpan maximumElapsedTime = TimeSpan.FromMilliseconds(500.0);
    private IGraphicsDeviceManager graphicsDeviceManager;
    private IGraphicsDeviceService graphicsDeviceService;
    private GameHost host;
    private bool isActive;
    private bool exitRequested;
    private TimeSpan inactiveSleepTime;
    private bool isMouseVisible;
    private bool inRun;
    private bool endRunRequired;
    private GameTime gameTime = new GameTime();
    private GameClock clock;
    private TimeSpan totalGameTime;
    private TimeSpan targetElapsedTime;
    private TimeSpan accumulatedElapsedGameTime;
    private TimeSpan lastFrameElapsedGameTime;
    internal TimeSpan sleepTime = TimeSpan.Zero;
    private MobileGameWindow mobileGameWindow;
    private static bool showReceived;
    private bool isFixedTimeStep = true;
    private bool drawRunningSlowly;
    private int updatesSinceRunningSlowly1 = int.MaxValue;
    private int updatesSinceRunningSlowly2 = int.MaxValue;
    private bool doneFirstUpdate;
    private bool doneFirstDraw;
    private bool forceElapsedTimeToZero;
    private bool suppressDraw;
    private GameComponentCollection gameComponents;
    private List<IUpdateable> updateableComponents = new List<IUpdateable>();
    private List<IUpdateable> currentlyUpdatingComponents = new List<IUpdateable>();
    private List<IDrawable> drawableComponents = new List<IDrawable>();
    private List<IDrawable> currentlyDrawingComponents = new List<IDrawable>();
    private List<IGameComponent> notYetInitialized = new List<IGameComponent>();
    private GameServiceContainer gameServices = new GameServiceContainer();
    private ContentManager content;
    private LaunchParameters launchParameters;

    static Game()
    {
      Task rootTask1 = ApplicationHost.Current.RootTask;
      rootTask1.OnShow = rootTask1.OnShow + new ITask.Show(Game.HostOnShow);
      Task rootTask2 = ApplicationHost.Current.RootTask;
      rootTask2.OnHide = rootTask2.OnHide + new ITask.Hide(Game.HostOnHide);
    }

    internal bool IsPureXnaApplication { get; set; }

    public LaunchParameters LaunchParameters => this.launchParameters;

    public GameComponentCollection Components => this.gameComponents;

    public GameServiceContainer Services => this.gameServices;

    public TimeSpan InactiveSleepTime
    {
      get => this.inactiveSleepTime;
      set => this.inactiveSleepTime = !(value < TimeSpan.Zero) ? value : throw new ArgumentOutOfRangeException(nameof (value), Resources.InactiveSleepTimeCannotBeZero);
    }

    public bool IsMouseVisible
    {
      get => this.isMouseVisible;
      set
      {
        this.isMouseVisible = value;
        if (this.Window == null)
          return;
        this.Window.IsMouseVisible = value;
      }
    }

    public TimeSpan TargetElapsedTime
    {
      get => this.targetElapsedTime;
      set
      {
        if (value <= TimeSpan.Zero)
          throw new ArgumentOutOfRangeException(nameof (value), Resources.TargetElaspedCannotBeZero);
        if (value < TimeSpan.FromMilliseconds(5.0))
          value = TimeSpan.FromMilliseconds(5.0);
        this.targetElapsedTime = value;
      }
    }

    public bool IsFixedTimeStep
    {
      get => this.isFixedTimeStep;
      set => this.isFixedTimeStep = value;
    }

    public GameWindow Window => this.host != null ? this.host.Window : (GameWindow) null;

    internal GameHost Host => this.host;

    public bool IsActive
    {
      get
      {
        bool flag = false;
        return this.isActive && !flag;
      }
    }

    public GraphicsDevice GraphicsDevice
    {
      get
      {
        graphicsDeviceService = this.graphicsDeviceService;
        return graphicsDeviceService != null || this.Services.GetService(typeof (IGraphicsDeviceService)) is IGraphicsDeviceService graphicsDeviceService ? graphicsDeviceService.GraphicsDevice : throw new InvalidOperationException(Resources.NoGraphicsDeviceService);
      }
    }

    public ContentManager Content
    {
      get => this.content;
      set => this.content = value != null ? value : throw new ArgumentNullException();
    }

    internal bool IsActiveIgnoringGuide => this.isActive;

    public event EventHandler<EventArgs> Activated;

    public event EventHandler<EventArgs> Deactivated;

    public event EventHandler<EventArgs> Exiting;

    public event EventHandler<EventArgs> Disposed;

    public Game()
    {
      FrameworkDispatcher.Update();
      this.EnsureHost();
      this.launchParameters = new LaunchParameters();
      this.gameComponents = new GameComponentCollection();
      this.gameComponents.ComponentAdded += new EventHandler<GameComponentCollectionEventArgs>(this.GameComponentAdded);
      this.gameComponents.ComponentRemoved += new EventHandler<GameComponentCollectionEventArgs>(this.GameComponentRemoved);
      this.content = new ContentManager((IServiceProvider) this.gameServices);
      this.host.Window.Paint += new EventHandler<EventArgs>(this.Paint);
      this.clock = new GameClock();
      this.totalGameTime = TimeSpan.Zero;
      this.accumulatedElapsedGameTime = TimeSpan.Zero;
      this.lastFrameElapsedGameTime = TimeSpan.Zero;
      this.targetElapsedTime = TimeSpan.FromTicks(166667L);
      this.inactiveSleepTime = TimeSpan.FromMilliseconds(20.0);
      this.mobileGameWindow = this.host.Window as MobileGameWindow;
      this.IsPureXnaApplication = false;
    }

    public void Run() => this.RunGame(true);

    internal void StartGameLoop() => this.RunGame(false);

    private void RunGame(bool useBlockingRun)
    {
      try
      {
        this.graphicsDeviceManager = this.Services.GetService(typeof (IGraphicsDeviceManager)) as IGraphicsDeviceManager;
        if (this.graphicsDeviceManager != null)
          this.graphicsDeviceManager.CreateDevice();
        this.Initialize();
        this.inRun = true;
        this.BeginRun();
        this.gameTime.ElapsedGameTime = TimeSpan.Zero;
        this.gameTime.TotalGameTime = this.totalGameTime;
        this.gameTime.IsRunningSlowly = false;
        this.Update(this.gameTime);
        this.doneFirstUpdate = true;
        if (useBlockingRun)
        {
          if (this.host != null)
            this.host.Run();
          this.EndRun();
        }
        else
        {
          if (this.host != null)
            this.host.StartGameLoop();
          this.endRunRequired = true;
        }
      }
      catch (NoSuitableGraphicsDeviceException ex)
      {
        if (this.ShowMissingRequirementMessage((Exception) ex))
          return;
        throw;
      }
      catch (NoAudioHardwareException ex)
      {
        if (this.ShowMissingRequirementMessage((Exception) ex))
          return;
        throw;
      }
      finally
      {
        if (!this.endRunRequired)
          this.inRun = false;
      }
    }

    public void RunOneFrame()
    {
      if (this.host == null)
        return;
      this.host.RunOneFrame();
    }

    public void Tick()
    {
      if (this.exitRequested && !((MobileGameHost) this.host).exitCompleted)
      {
        this.host.Exit();
        if (this.inRun && this.endRunRequired)
        {
          this.EndRun();
          this.inRun = false;
        }
      }
      if (this.ShouldExit)
        return;
      if (!this.isActive)
        Thread.Sleep((int) this.inactiveSleepTime.TotalMilliseconds);
      this.clock.UpdateElapsedTime();
      bool flag = true;
      TimeSpan timeSpan1 = this.clock.ElapsedAdjustedTime;
      if (timeSpan1 < TimeSpan.Zero)
        timeSpan1 = TimeSpan.Zero;
      if (this.forceElapsedTimeToZero)
      {
        timeSpan1 = TimeSpan.Zero;
        this.forceElapsedTimeToZero = false;
      }
      if (timeSpan1 > this.maximumElapsedTime)
        timeSpan1 = this.maximumElapsedTime;
      if (this.isFixedTimeStep)
      {
        if (Math.Abs(timeSpan1.Ticks - this.targetElapsedTime.Ticks) < this.targetElapsedTime.Ticks >> 6)
          timeSpan1 = this.targetElapsedTime;
        TimeSpan timeSpan2 = this.accumulatedElapsedGameTime + timeSpan1;
        long num = timeSpan2.Ticks / this.targetElapsedTime.Ticks;
        this.lastFrameElapsedGameTime = TimeSpan.Zero;
        if (num == 0L)
        {
          this.sleepTime = this.targetElapsedTime - this.accumulatedElapsedGameTime;
          return;
        }
        this.clock.AdvanceFrameTime();
        this.accumulatedElapsedGameTime = timeSpan2;
        this.sleepTime = TimeSpan.Zero;
        TimeSpan targetElapsedTime = this.targetElapsedTime;
        if (num > 1L)
        {
          this.updatesSinceRunningSlowly2 = this.updatesSinceRunningSlowly1;
          this.updatesSinceRunningSlowly1 = 0;
        }
        else
        {
          if (this.updatesSinceRunningSlowly1 < int.MaxValue)
            ++this.updatesSinceRunningSlowly1;
          if (this.updatesSinceRunningSlowly2 < int.MaxValue)
            ++this.updatesSinceRunningSlowly2;
        }
        this.drawRunningSlowly = this.updatesSinceRunningSlowly2 < 20;
        while (num > 0L && !this.ShouldExit)
        {
          --num;
          try
          {
            this.gameTime.ElapsedGameTime = targetElapsedTime;
            this.gameTime.TotalGameTime = this.totalGameTime;
            this.gameTime.IsRunningSlowly = this.drawRunningSlowly;
            this.Update(this.gameTime);
            GamePad.backButtonPressed = false;
            flag &= this.suppressDraw;
            this.suppressDraw = false;
          }
          finally
          {
            this.accumulatedElapsedGameTime -= targetElapsedTime;
            this.lastFrameElapsedGameTime += targetElapsedTime;
            this.totalGameTime += targetElapsedTime;
          }
        }
      }
      else
      {
        this.clock.AdvanceFrameTime();
        TimeSpan timeSpan2 = timeSpan1;
        this.drawRunningSlowly = false;
        this.updatesSinceRunningSlowly1 = int.MaxValue;
        this.updatesSinceRunningSlowly2 = int.MaxValue;
        if (!this.ShouldExit)
        {
          try
          {
            this.gameTime.ElapsedGameTime = this.lastFrameElapsedGameTime = timeSpan2;
            this.gameTime.TotalGameTime = this.totalGameTime;
            this.gameTime.IsRunningSlowly = false;
            this.Update(this.gameTime);
            flag &= this.suppressDraw;
            this.suppressDraw = false;
          }
          finally
          {
            this.totalGameTime += timeSpan2;
          }
        }
      }
      GamePad.backButtonPressed = false;
      if (flag)
        return;
      this.DrawFrame();
    }

    public void SuppressDraw() => this.suppressDraw = true;

    public void Exit()
    {
      this.exitRequested = true;
      if (this.IsPureXnaApplication)
      {
        if (this.mobileGameWindow.TaskThreadId == -1 || this.mobileGameWindow.TaskThreadId != Thread.CurrentThread.ManagedThreadId)
          return;
        this.host.Exit();
        if (!this.inRun || !this.endRunRequired)
          return;
        this.EndRun();
        this.inRun = false;
      }
      else
      {
        if (!QuirksMode.ShouldAllowGameExitInNonXnaApps() || XnaGameApplication.s_IsClosing)
          return;
        ApplicationHost.Current.RootTask.Complete(0);
      }
    }

    protected virtual void BeginRun()
    {
    }

    protected virtual void EndRun()
    {
    }

    protected virtual void Update(GameTime gameTime)
    {
      Logger.BeginLogEvent(LoggingEvent.Update, "");
      for (int index = 0; index < this.updateableComponents.Count; ++index)
        this.currentlyUpdatingComponents.Add(this.updateableComponents[index]);
      for (int index = 0; index < this.currentlyUpdatingComponents.Count; ++index)
      {
        IUpdateable updatingComponent = this.currentlyUpdatingComponents[index];
        if (updatingComponent.Enabled)
          updatingComponent.Update(gameTime);
      }
      this.currentlyUpdatingComponents.Clear();
      FrameworkDispatcher.Update();
      this.doneFirstUpdate = true;
      Logger.EndLogEvent(LoggingEvent.Update, "");
    }

    protected virtual bool BeginDraw()
    {
      if (this.graphicsDeviceManager != null && !this.graphicsDeviceManager.BeginDraw())
        return false;
      Logger.BeginLogEvent(LoggingEvent.Draw, "");
      return true;
    }

    protected virtual void Draw(GameTime gameTime)
    {
      for (int index = 0; index < this.drawableComponents.Count; ++index)
        this.currentlyDrawingComponents.Add(this.drawableComponents[index]);
      for (int index = 0; index < this.currentlyDrawingComponents.Count; ++index)
      {
        IDrawable drawingComponent = this.currentlyDrawingComponents[index];
        if (drawingComponent.Visible)
          drawingComponent.Draw(gameTime);
      }
      this.currentlyDrawingComponents.Clear();
    }

    protected virtual void EndDraw()
    {
      if (this.graphicsDeviceManager != null)
        this.graphicsDeviceManager.EndDraw();
      Logger.EndLogEvent(LoggingEvent.Draw, "");
    }

    private void Paint(object sender, EventArgs e)
    {
      if (!this.doneFirstDraw)
        return;
      this.DrawFrame();
    }

    protected virtual void Initialize()
    {
      this.HookDeviceEvents();
      while (this.notYetInitialized.Count != 0)
      {
        this.notYetInitialized[0].Initialize();
        this.notYetInitialized.RemoveAt(0);
      }
      if (this.graphicsDeviceService == null || this.graphicsDeviceService.GraphicsDevice == null)
        return;
      this.LoadContent();
    }

    public void ResetElapsedTime()
    {
      this.forceElapsedTimeToZero = true;
      this.drawRunningSlowly = false;
      this.updatesSinceRunningSlowly1 = int.MaxValue;
      this.updatesSinceRunningSlowly2 = int.MaxValue;
    }

    private void DrawFrame()
    {
      try
      {
        if (this.ShouldExit || !this.doneFirstUpdate || (this.Window.IsMinimized || !Game.showReceived) || !this.BeginDraw())
          return;
        this.gameTime.TotalGameTime = this.totalGameTime;
        this.gameTime.ElapsedGameTime = this.lastFrameElapsedGameTime;
        this.gameTime.IsRunningSlowly = this.drawRunningSlowly;
        this.Draw(this.gameTime);
        this.EndDraw();
        this.doneFirstDraw = true;
      }
      finally
      {
        this.lastFrameElapsedGameTime = TimeSpan.Zero;
      }
    }

    private void GameComponentRemoved(object sender, GameComponentCollectionEventArgs e)
    {
      if (!this.inRun)
        this.notYetInitialized.Remove(e.GameComponent);
      if (e.GameComponent is IUpdateable gameComponent1)
      {
        this.updateableComponents.Remove(gameComponent1);
        gameComponent1.UpdateOrderChanged -= new EventHandler<EventArgs>(this.UpdateableUpdateOrderChanged);
      }
      if (!(e.GameComponent is IDrawable gameComponent2))
        return;
      this.drawableComponents.Remove(gameComponent2);
      gameComponent2.DrawOrderChanged -= new EventHandler<EventArgs>(this.DrawableDrawOrderChanged);
    }

    private void GameComponentAdded(object sender, GameComponentCollectionEventArgs e)
    {
      if (this.inRun)
        e.GameComponent.Initialize();
      else
        this.notYetInitialized.Add(e.GameComponent);
      if (e.GameComponent is IUpdateable gameComponent1)
      {
        int num = this.updateableComponents.BinarySearch(gameComponent1, (IComparer<IUpdateable>) UpdateOrderComparer.Default);
        if (num < 0)
        {
          int index = ~num;
          while (index < this.updateableComponents.Count && this.updateableComponents[index].UpdateOrder == gameComponent1.UpdateOrder)
            ++index;
          this.updateableComponents.Insert(index, gameComponent1);
          gameComponent1.UpdateOrderChanged += new EventHandler<EventArgs>(this.UpdateableUpdateOrderChanged);
        }
      }
      if (!(e.GameComponent is IDrawable gameComponent2))
        return;
      int num1 = this.drawableComponents.BinarySearch(gameComponent2, (IComparer<IDrawable>) DrawOrderComparer.Default);
      if (num1 >= 0)
        return;
      int index1 = ~num1;
      while (index1 < this.drawableComponents.Count && this.drawableComponents[index1].DrawOrder == gameComponent2.DrawOrder)
        ++index1;
      this.drawableComponents.Insert(index1, gameComponent2);
      gameComponent2.DrawOrderChanged += new EventHandler<EventArgs>(this.DrawableDrawOrderChanged);
    }

    private void DrawableDrawOrderChanged(object sender, EventArgs e)
    {
      IDrawable drawable = sender as IDrawable;
      this.drawableComponents.Remove(drawable);
      int num = this.drawableComponents.BinarySearch(drawable, (IComparer<IDrawable>) DrawOrderComparer.Default);
      if (num >= 0)
        return;
      int index = ~num;
      while (index < this.drawableComponents.Count && this.drawableComponents[index].DrawOrder == drawable.DrawOrder)
        ++index;
      this.drawableComponents.Insert(index, drawable);
    }

    private void UpdateableUpdateOrderChanged(object sender, EventArgs e)
    {
      IUpdateable updateable = sender as IUpdateable;
      this.updateableComponents.Remove(updateable);
      int num = this.updateableComponents.BinarySearch(updateable, (IComparer<IUpdateable>) UpdateOrderComparer.Default);
      if (num >= 0)
        return;
      int index = ~num;
      while (index < this.updateableComponents.Count && this.updateableComponents[index].UpdateOrder == updateable.UpdateOrder)
        ++index;
      this.updateableComponents.Insert(index, updateable);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnActivated(object sender, EventArgs args)
    {
      if (this.Activated == null)
        return;
      this.Activated((object) this, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnDeactivated(object sender, EventArgs args)
    {
      if (this.Deactivated == null)
        return;
      this.Deactivated((object) this, args);
    }

    [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
    protected virtual void OnExiting(object sender, EventArgs args)
    {
      if (this.Exiting == null)
        return;
      this.Exiting((object) null, args);
    }

    private void EnsureHost()
    {
      if (this.host != null)
        return;
      this.host = (GameHost) new MobileGameHost(this);
      this.host.Activated += new EventHandler<EventArgs>(this.HostActivated);
      this.host.Deactivated += new EventHandler<EventArgs>(this.HostDeactivated);
      this.host.Suspend += new EventHandler<EventArgs>(this.HostSuspend);
      this.host.Resume += new EventHandler<EventArgs>(this.HostResume);
      this.host.Idle += new EventHandler<EventArgs>(this.HostIdle);
      this.host.Exiting += new EventHandler<EventArgs>(this.HostExiting);
    }

    private void HostSuspend(object sender, EventArgs e) => this.clock.Suspend();

    private void HostResume(object sender, EventArgs e) => this.clock.Resume();

    private void HostExiting(object sender, EventArgs e) => this.OnExiting((object) this, EventArgs.Empty);

    private void HostIdle(object sender, EventArgs e) => this.Tick();

    private void HostDeactivated(object sender, EventArgs e)
    {
      if (!this.isActive)
        return;
      this.isActive = false;
      this.OnDeactivated((object) this, EventArgs.Empty);
    }

    private void HostActivated(object sender, EventArgs e)
    {
      if (this.isActive)
        return;
      this.isActive = true;
      this.OnActivated((object) this, EventArgs.Empty);
    }

    private static void HostOnShow(NavigationDirection direction) => Game.showReceived = true;

    private static void HostOnHide(NavigationDirection direction) => Game.showReceived = false;

    private void HookDeviceEvents()
    {
      this.graphicsDeviceService = this.Services.GetService(typeof (IGraphicsDeviceService)) as IGraphicsDeviceService;
      if (this.graphicsDeviceService == null)
        return;
      this.graphicsDeviceService.DeviceCreated += new EventHandler<EventArgs>(this.DeviceCreated);
      this.graphicsDeviceService.DeviceResetting += new EventHandler<EventArgs>(this.DeviceResetting);
      this.graphicsDeviceService.DeviceReset += new EventHandler<EventArgs>(this.DeviceReset);
      this.graphicsDeviceService.DeviceDisposing += new EventHandler<EventArgs>(this.DeviceDisposing);
    }

    private void UnhookDeviceEvents()
    {
      if (this.graphicsDeviceService == null)
        return;
      this.graphicsDeviceService.DeviceCreated -= new EventHandler<EventArgs>(this.DeviceCreated);
      this.graphicsDeviceService.DeviceResetting -= new EventHandler<EventArgs>(this.DeviceResetting);
      this.graphicsDeviceService.DeviceReset -= new EventHandler<EventArgs>(this.DeviceReset);
      this.graphicsDeviceService.DeviceDisposing -= new EventHandler<EventArgs>(this.DeviceDisposing);
    }

    private void DeviceResetting(object sender, EventArgs e)
    {
    }

    private void DeviceReset(object sender, EventArgs e)
    {
    }

    private void DeviceCreated(object sender, EventArgs e) => this.LoadContent();

    private void DeviceDisposing(object sender, EventArgs e)
    {
      this.content.Unload();
      this.UnloadContent();
    }

    protected virtual void LoadContent()
    {
    }

    protected virtual void UnloadContent()
    {
    }

    private bool ShouldExit => this.exitRequested;

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~Game() => this.Dispose(false);

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      lock (this)
      {
        IGameComponent[] array = new IGameComponent[this.gameComponents.Count];
        this.gameComponents.CopyTo(array, 0);
        for (int index = 0; index < array.Length; ++index)
        {
          if (array[index] is IDisposable disposable3)
            disposable3.Dispose();
        }
        if (this.graphicsDeviceManager is IDisposable graphicsDeviceManager2)
          graphicsDeviceManager2.Dispose();
        this.UnhookDeviceEvents();
        if (this.mobileGameWindow != null)
          this.mobileGameWindow.Cleanup();
        if (this.Disposed == null)
          return;
        this.Disposed((object) this, EventArgs.Empty);
      }
    }

    protected virtual bool ShowMissingRequirementMessage(Exception exception) => this.host != null && this.host.ShowMissingRequirementMessage(exception);
  }
}
