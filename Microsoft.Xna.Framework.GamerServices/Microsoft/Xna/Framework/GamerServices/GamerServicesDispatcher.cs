// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerServicesDispatcher
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  public static class GamerServicesDispatcher
  {
    private static IntPtr windowHandle;
    private static bool initialized;
    internal static IGamerServicesProvider _gsp;
    internal static IServiceProvider serviceProvider;

    private static void PlatformInitialize()
    {
    }

    private static void PlatformUpdate()
    {
    }

    public static IntPtr WindowHandle
    {
      get => GamerServicesDispatcher.windowHandle;
      set => GamerServicesDispatcher.windowHandle = value;
    }

    internal static IGamerServicesProvider Gsp => GamerServicesDispatcher._gsp != null ? GamerServicesDispatcher._gsp : throw new InvalidOperationException(FrameworkResources.GamerServicesNotInitialized);

    public static bool IsInitialized => GamerServicesDispatcher.initialized;

    public static void Initialize(IServiceProvider serviceProvider)
    {
      if (GamerServicesDispatcher.IsInitialized)
        throw new InvalidOperationException(FrameworkResources.GamerServicesAlreadyInitialized);
      GamerServicesDispatcher.serviceProvider = serviceProvider;
      Logger.BeginLogEvent(LoggingEvent.GamerServicesInitialize, "XNA: Begin GamerServices Initialization");
      try
      {
        try
        {
          XlastConfiguration.CacheGameAssemblyPath();
        }
        catch (UnauthorizedAccessException ex)
        {
          throw new UnauthorizedAccessException(FrameworkResources.GamerServicesInitializeFromNonUIThread, (Exception) ex);
        }
        IGamerServicesProvider servicesProvider = (IGamerServicesProvider) new GamerServicesProviderWeb();
        try
        {
          servicesProvider.Initialize();
        }
        catch (Exception ex)
        {
          if (XlastConfiguration.Instance == null)
            throw new NotSupportedException(FrameworkResources.ProFeatureNotSupported);
          throw ex;
        }
        servicesProvider.SignedInStatusChanged += new EventHandler<GSSignedInStatusChangedEventArgs>(SignedInGamer.HandlePlayerSignInChanged);
        servicesProvider.WriteLeaderboard += new EventHandler<GSWriteLeaderboardEventArgs>(GamerServicesDispatcher.Gsp_WriteLeaderboard);
        GamerServicesDispatcher._gsp = servicesProvider;
        GamerServicesDispatcher.initialized = true;
      }
      catch (Exception ex)
      {
        GamerServicesDispatcher._gsp = (IGamerServicesProvider) null;
        throw ex;
      }
      finally
      {
        Logger.EndLogEvent(LoggingEvent.GamerServicesInitialize, "XNA: End GamerServices Initialization");
      }
    }

    private static void Gsp_WriteLeaderboard(object sender, GSWriteLeaderboardEventArgs e)
    {
      foreach (Gamer signedInGamer in (GamerCollection<SignedInGamer>) Gamer.SignedInGamers)
        signedInGamer.WriteLeaderboard();
    }

    public static void Update() => GamerServicesDispatcher.Gsp.Update();

    public static event EventHandler<EventArgs> InstallingTitleUpdate;
  }
}
