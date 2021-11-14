// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.MobileGameHost
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Phone.Shell;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Security;
using System.Windows;

namespace Microsoft.Xna.Framework
{
  internal class MobileGameHost : GameHost
  {
    private Game game;
    private MobileGameWindow gameWindow;
    private DispatcherTimerWin32 gameLoopTimer;
    internal bool exitCompleted;
    private bool doneRun;
    private bool lastActive;
    private bool isActive = true;
    private bool isPaused;
    private bool isFirstFrame = true;

    internal override GameWindow Window => (GameWindow) this.gameWindow;

    public MobileGameHost(Game game)
    {
      this.game = game;
      this.gameWindow = new MobileGameWindow();
      this.gameWindow.Activated += new EventHandler<EventArgs>(this.GameWindowActivated);
      this.gameWindow.Deactivated += new EventHandler<EventArgs>(this.GameWindowDeactivated);
      if (PhoneApplicationService.Current != null)
      {
        PhoneApplicationService.Current.Activated += new EventHandler<ActivatedEventArgs>(this.OnActivated);
        PhoneApplicationService.Current.Deactivated += new EventHandler<DeactivatedEventArgs>(this.OnDeactivated);
      }
      this.InitializeInput();
    }

    private void OnActivated(object sender, ActivatedEventArgs e)
    {
      Microsoft.Xna.Framework.Input.Touch.Touch.ClearAllTouches();
      if (!this.gameWindow.IsResumePending)
      {
        this.isActive = true;
        this.UpdateActivation();
      }
      if (!this.isPaused)
        return;
      this.isPaused = false;
      if (this.gameLoopTimer == null)
        return;
      this.gameLoopTimer.Start();
    }

    private void OnDeactivated(object sender, DeactivatedEventArgs e)
    {
      this.isActive = false;
      this.isPaused = true;
      this.UpdateActivation();
      Guide.CloseDialog();
      if (this.gameLoopTimer == null)
        return;
      this.gameLoopTimer.Stop();
    }

    private void GameWindowDeactivated(object sender, EventArgs e)
    {
      this.isActive = false;
      this.UpdateActivation();
    }

    private void GameWindowActivated(object sender, EventArgs e)
    {
      this.isActive = true;
      this.UpdateActivation();
    }

    internal override void RunOneFrame()
    {
      try
      {
        this.UpdateActivation();
        this.OnIdle();
      }
      catch (Exception ex)
      {
        this.OnPlatformAssemblyUnhandledException(ex);
      }
    }

    private void gameLoopTimer_Tick(object sender, EventArgs e)
    {
      if (this.exitCompleted)
        return;
      this.gameLoopTimer.Stop();
      this.gameWindow.ApplyPendingOrientationChanges();
      try
      {
        this.RunOneFrame();
        if (this.isPaused)
          return;
        if (this.game.IsFixedTimeStep)
        {
          this.gameLoopTimer.PreferOvershoot = true;
        }
        else
        {
          if (!(this.gameLoopTimer.Interval != this.game.TargetElapsedTime))
            return;
          this.gameLoopTimer.PreferOvershoot = false;
        }
      }
      finally
      {
        if (!this.isPaused && !this.gameLoopTimer.IsEnabled && !this.exitCompleted)
        {
          this.gameLoopTimer.Interval = !this.game.IsFixedTimeStep ? TimeSpan.Zero : this.game.sleepTime;
          this.gameLoopTimer.Start();
        }
      }
    }

    internal override void Run() => throw new InvalidOperationException(Resources.RunNotSupported);

    internal override void StartGameLoop()
    {
      if (this.exitCompleted)
        return;
      if (this.doneRun)
        throw new InvalidOperationException(Resources.NoMultipleRuns);
      this.gameLoopTimer = new DispatcherTimerWin32();
      this.gameLoopTimer.Tick += new EventHandler(this.gameLoopTimer_Tick);
      this.gameLoopTimer.Interval = this.game.TargetElapsedTime;
      this.gameLoopTimer.Start();
    }

    private void UpdateActivation()
    {
      try
      {
        if (!this.isActive)
        {
          if (this.lastActive)
          {
            Keyboard.IsEnabled = false;
            this.OnDeactivated();
          }
          this.lastActive = false;
        }
        else
        {
          if (!this.lastActive)
          {
            Keyboard.IsEnabled = true;
            this.OnActivated();
            this.isFirstFrame = true;
          }
          this.lastActive = true;
        }
      }
      catch (Exception ex)
      {
        this.OnPlatformAssemblyUnhandledException(ex);
      }
    }

    internal override void Exit()
    {
      if (this.exitCompleted)
        return;
      this.exitCompleted = true;
      int exitCode = 0;
      if (this.gameLoopTimer != null)
        this.gameLoopTimer.Stop();
      this.doneRun = true;
      bool flag = !ApplicationHost.Current.Dehydrating;
      try
      {
        this.OnExiting();
        this.OnDeactivated();
      }
      catch (Exception ex)
      {
        flag = true;
        exitCode = -2147467260;
        this.OnPlatformAssemblyUnhandledException(ex);
      }
      finally
      {
        this.TeardownInput();
        if (flag)
          this.gameWindow?.SignalTaskToComplete(exitCode);
      }
    }

    internal override void OnPresent()
    {
      if (!this.isFirstFrame)
        return;
      if (this.game.IsPureXnaApplication)
        ApplicationHost.Current.RootTask.FirstPresentComplete();
      this.isFirstFrame = false;
    }

    private void InitializeInput()
    {
      Keyboard.EnableKeyboardEvents();
      Microsoft.Xna.Framework.Input.Touch.Touch.EnableTouchEvents();
      TouchPanel.GamePageHandle = this.gameWindow.gamePageHandle;
    }

    private void TeardownInput()
    {
      Keyboard.DisableKeyboardEvents();
      Microsoft.Xna.Framework.Input.Touch.Touch.DisableTouchEvents();
      int num = (int) MobileSafeNativeMethods.ShutdownInput();
    }

    [SecuritySafeCritical]
    private void OnPlatformAssemblyUnhandledException(Exception e) => Application.OnPlatformAssemblyUnhandledException(e, true);
  }
}
