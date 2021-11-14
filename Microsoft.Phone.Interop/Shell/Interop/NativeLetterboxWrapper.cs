// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeLetterboxWrapper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace Microsoft.Phone.Shell.Interop
{
  internal static class NativeLetterboxWrapper
  {
    private const uint LegacyAppBarDefaultHeight = 72;
    private const uint LegacyAppBarMiniHeight = 30;
    private const uint LegacySysTrayPortraitHeight = 32;
    private const uint LegacySysTrayLandscapeHeight = 72;
    private static bool _letterboxHeightsInitialized;
    private static uint _appBarMiniLetterboxHeight;
    private static uint _appBarDefaultLetterboxHeight;
    private static uint _sysTrayPortraitLetterboxHeight;
    private static uint _sysTrayLandscapeLetterboxHeight;
    private static uint _aspectRatioLetterboxHeight;
    private static double _logicalAspectRatioLetterboxHeight;
    private static double _logicalLetterboxHeight;
    private static NativeAppBarInteropWrapper _visibleAppBar;
    private static NativeSystemTrayInteropWrapper _visibleSysTray;
    private static bool _applyAppBarLetterbox;
    private static bool _applySysTrayLetterbox;
    private static bool _isAppBarMini;
    private static bool _isSysTrayLandscape;

    internal static NativeAppBarInteropWrapper VisibleAppBar
    {
      set
      {
        if (value == NativeLetterboxWrapper._visibleAppBar)
          return;
        NativeLetterboxWrapper._visibleAppBar = value;
        NativeLetterboxWrapper.UpdateLetterboxing();
      }
    }

    internal static NativeSystemTrayInteropWrapper VisibleSysTray
    {
      set
      {
        if (value == NativeLetterboxWrapper._visibleSysTray)
          return;
        NativeLetterboxWrapper._visibleSysTray = value;
        NativeLetterboxWrapper.UpdateLetterboxing();
      }
    }

    private static bool ApplyAppBarLetterbox => NativeLetterboxWrapper._visibleAppBar != null && NativeLetterboxWrapper._applyAppBarLetterbox;

    private static bool ApplySysTrayLetterbox => NativeLetterboxWrapper._visibleSysTray != null && NativeLetterboxWrapper._applySysTrayLetterbox;

    internal static void UpdateAppBarReservesSpace(
      NativeAppBarInteropWrapper appBar,
      bool reservesSpace)
    {
      if (appBar != NativeLetterboxWrapper._visibleAppBar)
        return;
      NativeLetterboxWrapper._applyAppBarLetterbox = reservesSpace;
      NativeLetterboxWrapper.UpdateLetterboxing();
    }

    internal static void UpdateAppBarIsMini(NativeAppBarInteropWrapper appBar, bool isMini)
    {
      if (appBar != NativeLetterboxWrapper._visibleAppBar)
        return;
      NativeLetterboxWrapper._isAppBarMini = isMini;
      NativeLetterboxWrapper.UpdateLetterboxing();
    }

    internal static void UpdateSysTrayReservesSpace(
      NativeSystemTrayInteropWrapper sysTray,
      bool reservesSpace)
    {
      if (sysTray != NativeLetterboxWrapper._visibleSysTray)
        return;
      NativeLetterboxWrapper._applySysTrayLetterbox = reservesSpace;
      NativeLetterboxWrapper.UpdateLetterboxing();
    }

    internal static void UpdateSysTrayIsLandscape(
      NativeSystemTrayInteropWrapper sysTray,
      bool isLandscape)
    {
      if (sysTray != NativeLetterboxWrapper._visibleSysTray)
        return;
      NativeLetterboxWrapper._isSysTrayLandscape = isLandscape;
      NativeLetterboxWrapper.UpdateLetterboxing();
    }

    internal static void InitializeLetterboxHeights()
    {
      double num1 = (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
      int height = 0;
      uint num2 = (uint) Math.Round(30.0 * num1);
      NativeAppBarMethods.GetApplicationBarHeight(ApplicationBarMode.Mini, out height);
      NativeLetterboxWrapper._appBarMiniLetterboxHeight = (long) height <= (long) num2 ? (uint) ((ulong) num2 - (ulong) height) : 0U;
      uint num3 = (uint) Math.Round(72.0 * num1);
      NativeAppBarMethods.GetApplicationBarHeight(ApplicationBarMode.Default, out height);
      NativeLetterboxWrapper._appBarDefaultLetterboxHeight = (long) height <= (long) num3 ? (uint) ((ulong) num3 - (ulong) height) : 0U;
      uint num4 = (uint) Math.Round(32.0 * num1);
      NativeSystemTrayMethods.GetSystemTrayHeight(Orientations.PortraitUp, out height);
      NativeLetterboxWrapper._sysTrayPortraitLetterboxHeight = (long) height <= (long) num4 ? (uint) ((ulong) num4 - (ulong) height) : 0U;
      uint num5 = (uint) Math.Round(72.0 * num1);
      NativeSystemTrayMethods.GetSystemTrayHeight(Orientations.LandscapeLeft, out height);
      NativeLetterboxWrapper._sysTrayLandscapeLetterboxHeight = (long) height <= (long) num5 ? (uint) ((ulong) num5 - (ulong) height) : 0U;
      NativeLetterboxWrapper._aspectRatioLetterboxHeight = 0U;
      if (QuirksMode.ShouldUseBottomLetterboxForUserManagedNavBar())
        NativeLetterboxWrapper._aspectRatioLetterboxHeight = NativeLetterboxWrapper.GetAspectRatioLetterboxHeight();
      NativeLetterboxWrapper._logicalAspectRatioLetterboxHeight = (double) NativeLetterboxWrapper._aspectRatioLetterboxHeight / num1;
      NativeLetterboxWrapper._letterboxHeightsInitialized = true;
    }

    [DllImport("PlatformInterop.dll")]
    internal static extern uint GetAspectRatioLetterboxHeight();

    internal static void UpdateLetterboxing()
    {
      if (!QuirksMode.ShouldUseLegacyChromeHeights())
        return;
      if (!NativeLetterboxWrapper._letterboxHeightsInitialized)
        NativeLetterboxWrapper.InitializeLetterboxHeights();
      uint ratioLetterboxHeight = NativeLetterboxWrapper._aspectRatioLetterboxHeight;
      if (NativeLetterboxWrapper.ApplyAppBarLetterbox)
      {
        if (NativeLetterboxWrapper._isAppBarMini)
          ratioLetterboxHeight += NativeLetterboxWrapper._appBarMiniLetterboxHeight;
        else
          ratioLetterboxHeight += NativeLetterboxWrapper._appBarDefaultLetterboxHeight;
      }
      if (NativeLetterboxWrapper.ApplySysTrayLetterbox)
      {
        if (NativeLetterboxWrapper._isSysTrayLandscape)
          ratioLetterboxHeight += NativeLetterboxWrapper._sysTrayLandscapeLetterboxHeight;
        else
          ratioLetterboxHeight += NativeLetterboxWrapper._sysTrayPortraitLetterboxHeight;
      }
      if (ApplicationHost.Current.RootTask.AppChromeHandle == null)
        return;
      NativeLetterboxWrapper.SetBottomLetterboxHeight(ApplicationHost.Current.RootTask.AppChromeHandle, ratioLetterboxHeight);
      NativeLetterboxWrapper._logicalLetterboxHeight = (double) ratioLetterboxHeight * 100.0 / (double) Application.Current.Host.Content.ActualScaleFactor;
    }

    internal static double BottomLetterboxHeight
    {
      get
      {
        if (!NativeLetterboxWrapper._letterboxHeightsInitialized)
          NativeLetterboxWrapper.UpdateLetterboxing();
        return NativeLetterboxWrapper._logicalLetterboxHeight;
      }
    }

    internal static double BottomAspectRatioLetterboxHeight
    {
      get
      {
        if (!NativeLetterboxWrapper._letterboxHeightsInitialized)
          NativeLetterboxWrapper.UpdateLetterboxing();
        return NativeLetterboxWrapper._logicalAspectRatioLetterboxHeight;
      }
    }

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetBottomLetterboxHeight(
      SafeAppChromeHandle pAppChrome,
      uint bottomHeight);
  }
}
