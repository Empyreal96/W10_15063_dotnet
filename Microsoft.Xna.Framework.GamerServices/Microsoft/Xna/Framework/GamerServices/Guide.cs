// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.Guide
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Phone.Shell;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace Microsoft.Xna.Framework.GamerServices
{
  public static class Guide
  {
    private static Guide.OnPausingDelegate onPausing;
    private static Guide.OnResumedDelegate onResumed;
    private static NotificationPosition notificationPosition = NotificationPosition.BottomCenter;
    private static bool simulateTrialMode;
    private static bool forceNoTrial;
    private static bool isObscured = false;
    private static object syncObject = new object();

    [SecuritySafeCritical]
    static Guide()
    {
      Guide.onPausing = new Guide.OnPausingDelegate(Guide.CloseDialog);
      Guide.onResumed = new Guide.OnResumedDelegate(Guide.CompleteDialog);
      Helpers.ThrowExceptionFromResult(SafeNativeMethods.RegisterPausingAndResumedHostEventDelegates(Marshal.GetFunctionPointerForDelegate((Delegate) Guide.onPausing), Marshal.GetFunctionPointerForDelegate((Delegate) Guide.onResumed)));
    }

    public static bool IsScreenSaverEnabled
    {
      get => PhoneApplicationService.Current != null && PhoneApplicationService.Current.UserIdleDetectionMode == IdleDetectionMode.Enabled;
      set
      {
        if (PhoneApplicationService.Current == null)
          return;
        if (value)
          PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Enabled;
        else
          PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
      }
    }

    public static bool IsVisible => ActionDialogHelper.ActiveActionDialog != null || Guide.isObscured;

    internal static void OnObscuredChanged(bool obscured) => Guide.isObscured = obscured;

    [AllowReversePInvokeCalls]
    internal static void CloseDialog()
    {
      lock (Guide.syncObject)
      {
        if (ActionDialogHelper.ActiveActionDialog == null)
          return;
        ActionDialogHelper.ActiveActionDialog.Dismiss();
      }
    }

    [AllowReversePInvokeCalls]
    internal static void CompleteDialog()
    {
      lock (Guide.syncObject)
      {
        if (ActionDialogHelper.ActiveActionDialog == null)
          return;
        ActionDialogHelper.ActiveActionDialog.Complete();
      }
    }

    public static IAsyncResult BeginShowMessageBox(
      PlayerIndex player,
      string title,
      string text,
      IEnumerable<string> buttons,
      int focusButton,
      MessageBoxIcon icon,
      AsyncCallback callback,
      object state)
    {
      if (new HostInfo().IsHeadlessHost)
        throw new InvalidOperationException(FrameworkResources.InvalidCall);
      ActionDialogHelper actionDialogHelper = (ActionDialogHelper) null;
      lock (Guide.syncObject)
      {
        if (Guide.IsVisible)
          throw new GuideAlreadyVisibleException(FrameworkResources.GamerServicesGuideAlreadyVisible);
        Logger.BeginLogEvent(LoggingEvent.ShowMessageBox, "XNA: Begin ShowMessageBox");
        int num = Guide.ValidateShowMessageBoxArgs(player, title, text, buttons, focusButton);
        string button2 = (string) null;
        if (title == null)
          title = string.Empty;
        if (text == null)
          text = string.Empty;
        IEnumerator<string> enumerator = buttons.GetEnumerator();
        enumerator.MoveNext();
        string current = enumerator.Current;
        if (num > 1)
        {
          enumerator.MoveNext();
          button2 = enumerator.Current;
        }
        enumerator?.Dispose();
        actionDialogHelper = new ActionDialogHelper(callback, state);
        actionDialogHelper.ShowMessageBoxInput(title, text, current, button2, icon);
      }
      return (IAsyncResult) actionDialogHelper;
    }

    public static IAsyncResult BeginShowMessageBox(
      string title,
      string text,
      IEnumerable<string> buttons,
      int focusButton,
      MessageBoxIcon icon,
      AsyncCallback callback,
      object state)
    {
      return Guide.BeginShowMessageBox(PlayerIndex.One, title, text, buttons, focusButton, icon, callback, state);
    }

    public static int? EndShowMessageBox(IAsyncResult result)
    {
      if (!(result is ActionDialogHelper actionDialogHelper))
        throw new ArgumentNullException(nameof (result));
      if (!actionDialogHelper.IsCompleted)
        actionDialogHelper.AsyncWaitHandle.WaitOne();
      Logger.EndLogEvent(LoggingEvent.ShowMessageBox, "XNA: End ShowMessageBox");
      return actionDialogHelper.ResultButton;
    }

    public static void ShowSignIn(int paneCount, bool onlineOnly)
    {
      if (!GamerServicesDispatcher.IsInitialized)
        throw new InvalidOperationException(FrameworkResources.GamerServicesNotInitialized);
      if (Gamer.SignedInGamers.Count <= 0 || Gamer.SignedInGamers[PlayerIndex.One].IsSignedInToLive)
        return;
      GamerServicesDispatcher.Gsp.InvokeDownloadPrivilegeOptions();
    }

    public static IAsyncResult BeginShowKeyboardInput(
      PlayerIndex player,
      string title,
      string description,
      string defaultText,
      AsyncCallback callback,
      object state)
    {
      return Guide.BeginShowKeyboardInput(player, title, description, defaultText, callback, state, false);
    }

    public static IAsyncResult BeginShowKeyboardInput(
      PlayerIndex player,
      string title,
      string description,
      string defaultText,
      AsyncCallback callback,
      object state,
      bool usePasswordMode)
    {
      if (new HostInfo().IsHeadlessHost)
        throw new InvalidOperationException(FrameworkResources.InvalidCall);
      ActionDialogHelper actionDialogHelper = (ActionDialogHelper) null;
      lock (Guide.syncObject)
      {
        if (Guide.IsVisible)
          throw new GuideAlreadyVisibleException(FrameworkResources.GamerServicesGuideAlreadyVisible);
        if (player != PlayerIndex.One)
          throw new ArgumentOutOfRangeException(nameof (player));
        if (string.IsNullOrEmpty(title))
          title = " ";
        if (string.IsNullOrEmpty(description))
          description = " ";
        if (defaultText == null)
          defaultText = string.Empty;
        if (title.Length >= 256)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringTooLong, (object) 256), nameof (title));
        if (description.Length >= 256)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringTooLong, (object) 256), nameof (description));
        if (defaultText.Length >= 256)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringTooLong, (object) 256), nameof (defaultText));
        actionDialogHelper = new ActionDialogHelper(callback, state);
        actionDialogHelper.ShowTextInput(title, description, defaultText, usePasswordMode);
      }
      return (IAsyncResult) actionDialogHelper;
    }

    public static string EndShowKeyboardInput(IAsyncResult result)
    {
      if (!(result is ActionDialogHelper actionDialogHelper))
        throw new ArgumentNullException(nameof (result));
      if (!actionDialogHelper.IsCompleted)
        actionDialogHelper.AsyncWaitHandle.WaitOne();
      return actionDialogHelper.ResultText;
    }

    public static void ShowMessages(PlayerIndex player) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowFriends(PlayerIndex player) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowPlayers(PlayerIndex player) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowFriendRequest(PlayerIndex player, Gamer gamer) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowPlayerReview(PlayerIndex player, Gamer gamer) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowGamerCard(PlayerIndex player, Gamer gamer)
    {
      if (!GamerServicesDispatcher.IsInitialized)
        throw new InvalidOperationException(FrameworkResources.GamerServicesNotInitialized);
      if (player != PlayerIndex.One)
        throw new ArgumentOutOfRangeException(nameof (player));
      if (gamer == null)
        throw new ArgumentNullException(nameof (gamer));
      SignedInGamer signedInGamer = Gamer.SignedInGamers[PlayerIndex.One];
      if (signedInGamer == null || !signedInGamer.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (gamer != signedInGamer && (signedInGamer.Privileges.AllowProfileViewing == GamerPrivilegeSetting.Blocked || signedInGamer.Privileges.AllowUserCreatedContent == GamerPrivilegeSetting.Blocked))
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
      Logger.BeginLogEvent(LoggingEvent.ShowGamercard, "XNA: Begin ShowGamerCard");
      new GamerCardTask() { GamerTag = gamer.Gamertag }.Show();
      Logger.EndLogEvent(LoggingEvent.ShowGamercard, "XNA: End ShowGamerCard");
    }

    public static void ShowParty(PlayerIndex player) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowPartySessions(PlayerIndex player) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowComposeMessage(
      PlayerIndex player,
      string text,
      IEnumerable<Gamer> recipients)
    {
      throw new NotSupportedException();
    }

    public static NotificationPosition NotificationPosition
    {
      get => Guide.notificationPosition;
      set => Guide.notificationPosition = Guide.notificationPosition != value ? value : throw new NotSupportedException();
    }

    public static void DelayNotifications(TimeSpan delay) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static bool IsTrialMode
    {
      get
      {
        if (SafeNativeMethods.IsDebugMode())
        {
          Thread.Sleep(60);
          return !Guide.forceNoTrial && Guide.simulateTrialMode;
        }
        bool pfIsTrial = true;
        if (SafeNativeMethods.IsTrial(ref pfIsTrial) != 0)
          pfIsTrial = true;
        return pfIsTrial;
      }
    }

    public static bool SimulateTrialMode
    {
      get => Guide.simulateTrialMode;
      set
      {
        if (!value && Guide.simulateTrialMode)
          Guide.forceNoTrial = true;
        Guide.simulateTrialMode = value;
      }
    }

    public static void ShowGameInvite(PlayerIndex player, IEnumerable<Gamer> recipients) => throw new NotSupportedException(FrameworkResources.OnlySupportedForXboxLIVE);

    public static void ShowGameInvite(string sessionId)
    {
      if (!GamerServicesDispatcher.IsInitialized)
        throw new InvalidOperationException(FrameworkResources.GamerServicesNotInitialized);
      if (sessionId == null)
        throw new ArgumentNullException(nameof (sessionId));
      if (sessionId.Length >= 65)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringTooLong, (object) 65), nameof (sessionId));
      SignedInGamer signedInGamer = Gamer.SignedInGamers.Count != 0 ? Gamer.SignedInGamers[PlayerIndex.One] : throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (!signedInGamer.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (signedInGamer.Privileges.AllowCommunication == GamerPrivilegeSetting.Blocked || !signedInGamer.Privileges.AllowOnlineSessions)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
      Logger.BeginLogEvent(LoggingEvent.ShowGameInvite, "XNA: Begin ShowGameInvite");
      new GameInviteTaskNoResult() { SessionId = sessionId }.Show();
      Logger.EndLogEvent(LoggingEvent.ShowGameInvite, "XNA: End ShowGameInvite");
    }

    public static void ShowMarketplace(PlayerIndex player) => new MarketplaceDetailTask()
    {
      ContentType = MarketplaceContentType.Applications
    }.Show();

    private static int ValidateShowMessageBoxArgs(
      PlayerIndex player,
      string title,
      string text,
      IEnumerable<string> buttons,
      int focusButton)
    {
      if (player != PlayerIndex.One)
        throw new ArgumentOutOfRangeException(nameof (player));
      if (string.IsNullOrEmpty(title) || title.Length >= 256)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringNullEmptyOrTooLong, (object) 256), nameof (title));
      if (string.IsNullOrEmpty(text) || text.Length >= 256)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringNullEmptyOrTooLong, (object) 256), nameof (text));
      if (buttons == null)
        throw new ArgumentNullException(nameof (buttons));
      int num = 0;
      foreach (string button in buttons)
      {
        if (string.IsNullOrEmpty(button) || button.Length >= 256)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringCollectionInvalid, (object) 2, (object) 256), nameof (buttons));
        ++num;
      }
      if (num <= 0 || num > 2)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.StringCollectionInvalid, (object) 2, (object) 256), nameof (buttons));
      return focusButton >= 0 && focusButton < num ? num : throw new ArgumentOutOfRangeException(nameof (focusButton));
    }

    private delegate void OnPausingDelegate();

    private delegate void OnResumedDelegate();
  }
}
