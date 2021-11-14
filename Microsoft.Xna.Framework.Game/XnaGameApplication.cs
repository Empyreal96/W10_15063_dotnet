// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.XnaGameApplication
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Phone.Interop;
using Microsoft.Phone.Shell;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Xna.Framework.GamerServices;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Xna.Framework
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class XnaGameApplication : Application
  {
    private Assembly gameAssembly;
    private Type gameType;
    private Game game;
    private bool firstLaunch;
    private bool firstActivation;
    private IntPtr windowHandle = IntPtr.Zero;
    internal static bool s_IsClosing;

    public XnaGameApplication()
    {
      Logger.BeginLogEvent(LoggingEvent.ApplicationConstruction, "XNA: Begin GameApplication construction");
      this.LetterboxingStrategy = this.LetterboxingStrategyForXNA;
      this.Startup += new StartupEventHandler(this.XnaGameApplication_Startup);
      PhoneApplicationService applicationService = new PhoneApplicationService();
      applicationService.Launching += new EventHandler<LaunchingEventArgs>(this.XnaGameApplication_Launching);
      applicationService.Closing += new EventHandler<Microsoft.Phone.Shell.ClosingEventArgs>(this.XnaGameApplication_Closing);
      applicationService.Activated += new EventHandler<ActivatedEventArgs>(this.XnaGameApplication_Activated);
      this.Exit += new EventHandler(this.XnaGameApplication_Exit);
      this.ApplicationLifetimeObjects.Add((object) applicationService);
      this.UnhandledException += new EventHandler<ApplicationUnhandledExceptionEventArgs>(this.XnaGameApplication_UnhandledException);
      Logger.EndLogEvent(LoggingEvent.ApplicationConstruction, "XNA: End GameApplication construction");
    }

    private void XnaGameApplication_Startup(object sender, StartupEventArgs e)
    {
      Logger.LogEvent(LoggingEvent.ApplicationStartup, "XNA: GameApplication startup, constructing the game and handing off to user code.");
      if (!this.InitializeGame(Deployment.Current.EntryPointAssembly, Deployment.Current.EntryPointType))
        throw new InvalidOperationException(Resources.CannotCreateGameType);
    }

    private void XnaGameApplicationStartGameLoop()
    {
      if (this.game == null)
        return;
      this.game.StartGameLoop();
      this.TestNotifyPageShowComplete();
    }

    private void XnaGameApplicationExit()
    {
      if (this.game == null)
        return;
      this.game.Exit();
    }

    private void XnaGameApplication_Exit(object sender, EventArgs e) => this.XnaGameApplicationExit();

    private void XnaGameApplication_Launching(object sender, LaunchingEventArgs e)
    {
      this.XnaGameApplicationStartGameLoop();
      this.firstLaunch = true;
    }

    private void XnaGameApplication_Closing(object sender, Microsoft.Phone.Shell.ClosingEventArgs e)
    {
      XnaGameApplication.s_IsClosing = true;
      this.XnaGameApplicationExit();
    }

    private void XnaGameApplication_Activated(object sender, ActivatedEventArgs e)
    {
      if (!this.firstLaunch && !this.firstActivation)
        this.XnaGameApplicationStartGameLoop();
      else
        this.TestNotifyPageShowComplete();
      this.firstActivation = true;
    }

    private void XnaGameApplication_UnhandledException(
      object sender,
      ApplicationUnhandledExceptionEventArgs e)
    {
      Guide.CloseDialog();
    }

    [SecuritySafeCritical]
    private bool InitializeGame(string entrypointAssemblyName, string entryPointAssemblyType)
    {
      bool flag = false;
      this.gameAssembly = this.LoadEntryPointAssembly(entrypointAssemblyName);
      if (this.gameAssembly != null)
      {
        this.gameType = this.gameAssembly.GetType(entryPointAssemblyType);
        if (this.gameType != null)
        {
          Type type = Type.GetType("Microsoft.Xna.Framework.Game", false);
          this.game = type == null || this.gameType.IsSubclassOf(type) ? (Game) Activator.CreateInstance(this.gameType) : throw new InvalidOperationException(Resources.GameNotDerivedFromValidGameType);
          if (this.game != null)
          {
            flag = true;
            this.game.IsPureXnaApplication = true;
          }
        }
      }
      return flag;
    }

    [SecuritySafeCritical]
    private Assembly LoadEntryPointAssembly(string assemblyName)
    {
      Assembly assembly1 = Assembly.Load(assemblyName);
      if (assembly1 == null)
      {
        foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
        {
          if (string.Compare(assembly2.GetName().Name, assemblyName, StringComparison.OrdinalIgnoreCase) == 0)
          {
            assembly1 = assembly2;
            break;
          }
        }
      }
      return assembly1;
    }

    [SecuritySafeCritical]
    private void TestNotifyPageShowComplete()
    {
      if (!(ApplicationHost.Current.TestPageCompleteEvent != IntPtr.Zero) || PageNativeMethods.SetEvent(ApplicationHost.Current.TestPageCompleteEvent))
        return;
      Marshal.GetLastWin32Error();
    }
  }
}
