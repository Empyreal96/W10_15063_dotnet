// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.SystemNotificationInterop
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Networking.Voip;
using Microsoft.Phone.NetworkOperators;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.Scheduler
{
  internal class SystemNotificationInterop
  {
    private const string MEDIASOCIALAPIS_DLL = "MediaSocialApis.dll";
    private const string BNS_CLIENT_DLL = "PlatformInterop.dll";
    private const int BNS_MAX_TITLE_LEN = 64;
    private const int BNS_MAX_CONTENT_LEN = 256;
    private const int BNS_MAX_NAME_LEN = 256;
    private const int BNS_MAX_SOUND_URL_LEN = 128;
    private const int BNS_MAX_PATH = 260;
    private const int BNS_MAX_LAUNCH_CONTEXT_LEN = 128;
    private const int BNS_MAX_STR_LEN = 1024;
    private const int BNS_MAX_APP_BASE_URI_LEN = 256;
    private const int BNS_BACKGROUND_SERVICE_ID = 4;
    private const int BNS_AGENT_NOTRUN_RESULT = -1;
    private const int BNS_MAX_PUSH_CHANNEL_NAME_LEN = 256;
    internal const string NOTIFICATION_ID_SERIALIZATION_NAME = "id";
    internal const string FRIENDLY_NAME_SERIALIZATION_NAME = "name";
    internal const string NOTIFICATION_STATE_SERIALIZATION_NAME = "state";
    internal const string NOTIFICATION_TYPE_SERIALIZATION_NAME = "type";
    internal const string NOTIFICATION_CONTENT_SERIALIZATION_NAME = "content";
    internal const string NOTIFICATION_LAST_SCHEDULED_TIME_SERIALIZATION_NAME = "lastScheduledTime";
    internal const string NOTIFICATION_END_TIME_SERIALIZATION_NAME = "endTime";
    internal const string NOTIFICATION_LAST_EXIT_REASON_SERIALIZATION_NAME = "lastExitReason";
    internal const string NOTIFICATION_PUSH_CHANNEL_NAME_SERIALIZATION_NAME = "pushChannelName";
    internal const string NOTIFICATION_PUSH_RAW_MESSAGE_SERIALIZATION_NAME = "pushRawMessage";
    internal const string NOTIFICATION_NABSYNC_HEADER_SERIALIZATION_NAME = "nabSyncHeader";
    internal const string NOTIFICATION_NABSYNC_BODY_SERIALIZATION_NAME = "nabSyncBody";
    internal const string NOTIFICATION_NABSYNC_DIGEST_SERIALIZATION_NAME = "nabSyncDigest";
    internal const string NOTIFICATION_APPCONTRACT_CONTRACTOPERATIONID = "contractOperationId";
    internal const string NOTIFICATION_IS_SOCIAL_APPCONTRACT_SERIALIZATION_NAME = "isSocialAppContract";
    private const int MAX_ERROR_MESSAGE_LENGTH = 1024;
    private const int S_OK = 0;
    private const int S_FALSE = 1;
    private const int E_OUTOFMEMORY = -2147024882;
    private const int E_INVALIDARG = -2147024809;
    private const int E_HANDLE = -2147024890;
    private const int E_NOTIMPL = -2147467263;
    private const int E_UNEXPECTED = -2147418113;
    private const int E_EM_UNEXPECTED_TERMINATION = -2147220978;
    private const int E_ABORT = -2147467260;
    private const int E_AIM_AGENT_CALLS_ABORT = -2147220721;
    private const int E_AGENT_EXCEEDED_MEMORY_QUOTA = -2147220982;
    private const int E_AGENT_EXCEEDED_RUNTIME = -2147220983;
    private const int E_AGENT_RESOURCES_SEIZED = -2147220981;
    private const int RPC_S_SERVER_UNAVAILABLE = -2147023174;
    private const int RPC_S_SERVER_TOO_BUSY = -2147023173;
    private const int E_BNS_SYSTEM_SPOT_FULL = -2130444030;
    private const int E_BNS_DUPLICATE_ITEM = -2130443775;
    private const int E_BNS_ITEM_NOT_FOUND = -2130443774;

    [DllImport("MediaSocialApis.dll")]
    private static extern int SetSocialContractId(Guid contractId);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSICreateNotification(
      ref SystemNotificationInterop.BNS_NOTIFICATION bnsNotification);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSIDeleteNotification(Guid notificationID);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSIGetNotificationCount(ref uint notificationCount);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSIGetNotificationByID(
      Guid notificationID,
      ref SystemNotificationInterop.BNS_NOTIFICATION bnsNotification);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSIGetNotificationByIndex(
      uint index,
      ref SystemNotificationInterop.BNS_NOTIFICATION bnsNotification);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSILaunchNotification(
      ref SystemNotificationInterop.BNS_NOTIFICATION bnsNotification);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSILaunchImmediateNotification(
      ref SystemNotificationInterop.BNS_NOTIFICATION bnsNotification);

    [DllImport("PlatformInterop.dll")]
    private static extern int BNSIUpdateNotification(
      ref SystemNotificationInterop.BNS_NOTIFICATION bnsNotification);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    private static extern int BNSILoadErrorMessage(
      int hr,
      [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder messagePointer,
      uint cchMessage);

    private static ScheduledAction CreateManagedNotificationFromNative(
      SystemNotificationInterop.BNS_NOTIFICATION nativeNotification)
    {
      ScheduledAction scheduledAction;
      switch (nativeNotification.notificationType)
      {
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_TIMEBASED_ALARM:
          scheduledAction = (ScheduledAction) new Alarm(nativeNotification.szFriendlyName);
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_TIMEBASED_REMINDER:
          scheduledAction = (ScheduledAction) new Reminder(nativeNotification.szFriendlyName);
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_PERIODIC_TASK:
          scheduledAction = (ScheduledAction) new PeriodicTask(nativeNotification.szFriendlyName);
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_ONIDLE_TASK:
          scheduledAction = (ScheduledAction) new ResourceIntensiveTask(nativeNotification.szFriendlyName);
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_KEEPALIVE_TASK:
          scheduledAction = (ScheduledAction) new VoipKeepAliveTask(nativeNotification.szFriendlyName);
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_INCOMINGCALL_TASK:
          scheduledAction = (ScheduledAction) new VoipHttpIncomingCallTask(nativeNotification.szFriendlyName, nativeNotification.szPushChannel);
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_NABSYNC_TASK:
          scheduledAction = (ScheduledAction) new IncomingMobileNetworkMessageTask(nativeNotification.szFriendlyName);
          break;
        default:
          throw new NotSupportedException();
      }
      scheduledAction.ID = nativeNotification.notificationID;
      if (scheduledAction.Type == ScheduledActionType.Reminder)
        ((ScheduledNotification) scheduledAction).Title = nativeNotification.szTitle;
      if (scheduledAction.Type == ScheduledActionType.Alarm || scheduledAction.Type == ScheduledActionType.Reminder)
        ((ScheduledNotification) scheduledAction).Content = nativeNotification.szContent;
      if (scheduledAction.Type == ScheduledActionType.PeriodicTask || scheduledAction.Type == ScheduledActionType.OnIdleTask || (scheduledAction.Type == ScheduledActionType.VoipHttpIncomingCallTask || scheduledAction.Type == ScheduledActionType.VoipKeepAliveTask))
      {
        ((ScheduledTask) scheduledAction).Description = nativeNotification.szContent;
        ((ScheduledTask) scheduledAction).LastScheduledTime = nativeNotification.lastScheduledTime.ToDateTime();
        ((ScheduledTask) scheduledAction).LastExitReason = SystemNotificationInterop.HRESULTToAgentExitReason(nativeNotification.lastResult);
      }
      switch (nativeNotification.state)
      {
        case SystemNotificationInterop.BNS_NOTIFICATION_STATE.BNS_NOTIFICATION_STATE_SCHEDULED:
          scheduledAction.Status = ScheduledActionStatus.Scheduled;
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_STATE.BNS_NOTIFICATION_STATE_DISABLED:
          scheduledAction.Status = ScheduledActionStatus.Disabled;
          break;
        default:
          scheduledAction.Status = ScheduledActionStatus.Completed;
          break;
      }
      if (scheduledAction is ScheduledNotification)
      {
        ScheduledNotification scheduledNotification = scheduledAction as ScheduledNotification;
        switch (nativeNotification.recurringType)
        {
          case SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_NONE:
            scheduledNotification.RecurrenceType = RecurrenceInterval.None;
            break;
          case SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_DAILY:
            scheduledNotification.RecurrenceType = RecurrenceInterval.Daily;
            break;
          case SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_WEEKLY:
            scheduledNotification.RecurrenceType = RecurrenceInterval.Weekly;
            break;
          case SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_MONTHLY:
            scheduledNotification.RecurrenceType = RecurrenceInterval.Monthly;
            break;
          case SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_ENDOFMONTH:
            scheduledNotification.RecurrenceType = RecurrenceInterval.EndOfMonth;
            break;
          case SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_YEARLY:
            scheduledNotification.RecurrenceType = RecurrenceInterval.Yearly;
            break;
          default:
            throw new NotSupportedException();
        }
      }
      scheduledAction.BeginTimeInternal = nativeNotification.startTime.ToDateTime();
      scheduledAction.ExpirationTimeInternal = nativeNotification.endTime.ToDateTime();
      if (scheduledAction.Type == ScheduledActionType.Alarm)
        (scheduledAction as Alarm).Sound = string.IsNullOrEmpty(nativeNotification.szSound) ? (Uri) null : new Uri(nativeNotification.szSound, UriKind.Relative);
      if (scheduledAction.Type == ScheduledActionType.Reminder)
        (scheduledAction as Reminder).NavigationUri = string.IsNullOrEmpty(nativeNotification.szLaunchingContext) ? (Uri) null : new Uri(nativeNotification.szLaunchingContext, UriKind.Relative);
      if (scheduledAction.Type == ScheduledActionType.VoipKeepAliveTask)
        (scheduledAction as VoipKeepAliveTask).Interval = TimeSpan.FromSeconds((double) nativeNotification.dwRecurringIntervalInSeconds);
      return scheduledAction;
    }

    private static SystemNotificationInterop.BNS_NOTIFICATION CreateNativeNotificationFromManaged(
      ScheduledAction ScheduledAction)
    {
      SystemNotificationInterop.BNS_NOTIFICATION empty = SystemNotificationInterop.BNS_NOTIFICATION.Empty;
      empty.notificationID = ScheduledAction.ID;
      empty.szFriendlyName = ScheduledAction.Name;
      switch (ScheduledAction.Type)
      {
        case ScheduledActionType.Alarm:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_TIMEBASED_ALARM;
          Alarm alarm1 = (Alarm) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) alarm1.Content, 256);
          empty.szContent = string.IsNullOrEmpty(alarm1.Content) ? string.Empty : alarm1.Content;
          break;
        case ScheduledActionType.Reminder:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_TIMEBASED_REMINDER;
          Reminder reminder1 = (Reminder) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) reminder1.Title, 64);
          empty.szTitle = string.IsNullOrEmpty(reminder1.Title) ? string.Empty : reminder1.Title;
          SystemNotificationInterop.CheckStringArgumentLength((object) reminder1.Content, 256);
          empty.szContent = string.IsNullOrEmpty(reminder1.Content) ? string.Empty : reminder1.Content;
          break;
        case ScheduledActionType.PeriodicTask:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_PERIODIC_TASK;
          PeriodicTask periodicTask = (PeriodicTask) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) periodicTask.Description, 256);
          if (string.IsNullOrEmpty(periodicTask.Description))
            throw new ArgumentOutOfRangeException("Description");
          empty.szContent = string.IsNullOrEmpty(periodicTask.Description) ? string.Empty : periodicTask.Description;
          break;
        case ScheduledActionType.OnIdleTask:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_ONIDLE_TASK;
          ResourceIntensiveTask resourceIntensiveTask = (ResourceIntensiveTask) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) resourceIntensiveTask.Description, 256);
          empty.szContent = string.IsNullOrEmpty(resourceIntensiveTask.Description) ? string.Empty : resourceIntensiveTask.Description;
          break;
        case ScheduledActionType.VoipKeepAliveTask:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_KEEPALIVE_TASK;
          VoipKeepAliveTask voipKeepAliveTask = (VoipKeepAliveTask) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) voipKeepAliveTask.Description, 256);
          empty.szContent = string.IsNullOrEmpty(voipKeepAliveTask.Description) ? string.Empty : voipKeepAliveTask.Description;
          empty.dwRecurringIntervalInSeconds = (uint) voipKeepAliveTask.Interval.TotalSeconds;
          break;
        case ScheduledActionType.VoipHttpIncomingCallTask:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_INCOMINGCALL_TASK;
          VoipHttpIncomingCallTask incomingCallTask = (VoipHttpIncomingCallTask) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) incomingCallTask.Description, 256);
          empty.szContent = string.IsNullOrEmpty(incomingCallTask.Description) ? string.Empty : incomingCallTask.Description;
          SystemNotificationInterop.CheckStringArgumentLength((object) incomingCallTask.ChannelName, 256);
          empty.szPushChannel = !string.IsNullOrEmpty(incomingCallTask.ChannelName) ? incomingCallTask.ChannelName : throw new ArgumentOutOfRangeException("ChannelName");
          break;
        case ScheduledActionType.IncomingMobileNetworkMessageTask:
          empty.notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_NABSYNC_TASK;
          IncomingMobileNetworkMessageTask networkMessageTask = (IncomingMobileNetworkMessageTask) ScheduledAction;
          SystemNotificationInterop.CheckStringArgumentLength((object) networkMessageTask.Description, 256);
          empty.szContent = string.IsNullOrEmpty(networkMessageTask.Description) ? string.Empty : networkMessageTask.Description;
          break;
        default:
          throw new NotSupportedException();
      }
      if (ScheduledAction is ScheduledNotification)
      {
        switch ((ScheduledAction as ScheduledNotification).RecurrenceType)
        {
          case RecurrenceInterval.None:
            empty.recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_NONE;
            break;
          case RecurrenceInterval.Daily:
            empty.recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_DAILY;
            break;
          case RecurrenceInterval.Weekly:
            empty.recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_WEEKLY;
            break;
          case RecurrenceInterval.Monthly:
            empty.recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_MONTHLY;
            break;
          case RecurrenceInterval.EndOfMonth:
            empty.recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_ENDOFMONTH;
            break;
          case RecurrenceInterval.Yearly:
            empty.recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_YEARLY;
            break;
          default:
            throw new NotSupportedException();
        }
      }
      empty.startTime = new SystemNotificationInterop.SYSTEMTIME(ScheduledAction.BeginTimeInternal);
      empty.endTime = new SystemNotificationInterop.SYSTEMTIME(ScheduledAction.ExpirationTimeInternal);
      empty.szSound = string.Empty;
      if (ScheduledAction.Type == ScheduledActionType.Alarm)
      {
        Alarm alarm2 = ScheduledAction as Alarm;
        SystemNotificationInterop.CheckStringArgumentLength((object) alarm2.Sound, 260);
        empty.szSound = alarm2.Sound != (Uri) null ? alarm2.Sound.ToString() : string.Empty;
      }
      empty.szLaunchingContext = string.Empty;
      if (ScheduledAction.Type == ScheduledActionType.Reminder)
      {
        Reminder reminder2 = ScheduledAction as Reminder;
        SystemNotificationInterop.CheckStringArgumentLength((object) reminder2.NavigationUri, 128);
        empty.szLaunchingContext = reminder2.NavigationUri != (Uri) null ? reminder2.NavigationUri.ToString() : string.Empty;
      }
      empty.szAppInstallPath = string.Empty;
      empty.szAppBaseUri = string.Empty;
      return empty;
    }

    internal static ScheduledTask CreateManagedScheduleAgentFromNative(
      string id,
      string name,
      uint type,
      uint state,
      string content,
      DateTime lastScheduleTime,
      DateTime endTime,
      int lastExitReason,
      string pushChannel,
      byte[] pushRawMessage,
      byte[] nabHeader,
      byte[] nabBody,
      byte[] nabDigest,
      Guid contractOperationId,
      bool isSocialContract)
    {
      SystemNotificationInterop.BNS_NOTIFICATION empty = SystemNotificationInterop.BNS_NOTIFICATION.Empty;
      empty.notificationID = new Guid(id);
      empty.szFriendlyName = name;
      empty.notificationType = (SystemNotificationInterop.BNS_NOTIFICATION_TYPE) type;
      empty.state = (SystemNotificationInterop.BNS_NOTIFICATION_STATE) state;
      empty.szContent = content;
      empty.lastScheduledTime = new SystemNotificationInterop.SYSTEMTIME(lastScheduleTime);
      empty.endTime = new SystemNotificationInterop.SYSTEMTIME(endTime);
      empty.lastResult = lastExitReason;
      empty.szPushChannel = pushChannel;
      ScheduledTask notificationFromNative = (ScheduledTask) SystemNotificationInterop.CreateManagedNotificationFromNative(empty);
      switch ((SystemNotificationInterop.BNS_NOTIFICATION_TYPE) type)
      {
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_INCOMINGCALL_TASK:
          ((VoipHttpIncomingCallTask) notificationFromNative).MessageBody = pushRawMessage;
          break;
        case SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_NABSYNC_TASK:
          IncomingMobileNetworkMessageTask networkMessageTask = (IncomingMobileNetworkMessageTask) notificationFromNative;
          networkMessageTask.Header = nabHeader;
          networkMessageTask.Body = nabBody;
          networkMessageTask.Digest = nabDigest;
          break;
      }
      if (contractOperationId != Guid.Empty)
      {
        string str = contractOperationId.ToString();
        notificationFromNative.Description = str;
        if (isSocialContract)
          SystemNotificationInterop.CheckHr(SystemNotificationInterop.SetSocialContractId(contractOperationId));
      }
      return notificationFromNative;
    }

    [SecuritySafeCritical]
    internal static void CreateNotification(ScheduledAction action)
    {
      SystemNotificationInterop.BNS_NOTIFICATION notificationFromManaged = SystemNotificationInterop.CreateNativeNotificationFromManaged(action);
      SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSICreateNotification(ref notificationFromManaged));
      action.UpdateStatusFrom(SystemNotificationInterop.CreateManagedNotificationFromNative(notificationFromManaged));
    }

    [SecuritySafeCritical]
    internal static void DeleteNotification(Guid notificationID) => SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSIDeleteNotification(notificationID));

    [SecuritySafeCritical]
    internal static uint GetNotificationCount()
    {
      uint notificationCount1 = 0;
      int notificationCount2 = SystemNotificationInterop.BNSIGetNotificationCount(ref notificationCount1);
      if (notificationCount2 != -2130443774)
        SystemNotificationInterop.CheckHr(notificationCount2);
      return notificationCount1;
    }

    [SecuritySafeCritical]
    internal static ScheduledAction GetNotificationByID(Guid notificationID)
    {
      SystemNotificationInterop.BNS_NOTIFICATION empty = SystemNotificationInterop.BNS_NOTIFICATION.Empty;
      SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSIGetNotificationByID(notificationID, ref empty));
      return SystemNotificationInterop.CreateManagedNotificationFromNative(empty);
    }

    [SecuritySafeCritical]
    internal static ScheduledAction GetNotificationByIndex(uint index)
    {
      SystemNotificationInterop.BNS_NOTIFICATION empty = SystemNotificationInterop.BNS_NOTIFICATION.Empty;
      SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSIGetNotificationByIndex(index, ref empty));
      return SystemNotificationInterop.CreateManagedNotificationFromNative(empty);
    }

    [SecuritySafeCritical]
    internal static void LaunchNotification(ScheduledAction action)
    {
      SystemNotificationInterop.BNS_NOTIFICATION notificationFromManaged = SystemNotificationInterop.CreateNativeNotificationFromManaged(action);
      SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSILaunchNotification(ref notificationFromManaged));
    }

    [SecuritySafeCritical]
    internal static void LaunchImmediateNotification(ScheduledAction action)
    {
      SystemNotificationInterop.BNS_NOTIFICATION notificationFromManaged = SystemNotificationInterop.CreateNativeNotificationFromManaged(action);
      SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSILaunchImmediateNotification(ref notificationFromManaged));
    }

    [SecuritySafeCritical]
    internal static void UpdateNotification(ScheduledAction action)
    {
      SystemNotificationInterop.BNS_NOTIFICATION notificationFromManaged = SystemNotificationInterop.CreateNativeNotificationFromManaged(action);
      SystemNotificationInterop.CheckHr(SystemNotificationInterop.BNSIUpdateNotification(ref notificationFromManaged));
      action.UpdateStatusFrom(SystemNotificationInterop.CreateManagedNotificationFromNative(notificationFromManaged));
    }

    [SecuritySafeCritical]
    private static string GetMessageStringFromHResult(int hr)
    {
      StringBuilder messagePointer = new StringBuilder(1024);
      SystemNotificationInterop.BNSILoadErrorMessage(hr, messagePointer, 1024U);
      return messagePointer.ToString();
    }

    private static bool FAILED(int hr) => hr < 0;

    private static bool SUCCEEDED(int hr) => hr >= 0;

    private static void CheckHr(int hr)
    {
      if (hr <= -2147024809)
      {
        if (hr <= -2147024890)
        {
          if (hr == -2147467263)
            throw new NotSupportedException();
          if (hr != -2147024890)
            goto label_16;
        }
        else
        {
          if (hr == -2147024882)
            throw new OutOfMemoryException();
          if (hr != -2147024809)
            goto label_16;
        }
        throw new ArgumentException("E_INVALIDARG");
      }
      if (hr <= -2147023173)
      {
        if (hr == -2147023174 || hr == -2147023173)
          throw new SchedulerServiceException(hr, "System is not ready");
      }
      else
      {
        if (hr == -2130444030)
          throw new SchedulerServiceException(hr, SystemNotificationInterop.GetMessageStringFromHResult(hr));
        if (hr == 0 || hr == 1)
          return;
      }
label_16:
      string message;
      try
      {
        message = SystemNotificationInterop.GetMessageStringFromHResult(hr);
      }
      catch (Exception ex)
      {
        message = (string) null;
      }
      if (string.IsNullOrEmpty(message))
        throw new SchedulerServiceException(hr, hr.ToString("X"));
      throw new InvalidOperationException(message);
    }

    internal static void ThrowExceptionFromHResult(int hr) => SystemNotificationInterop.CheckHr(hr);

    private static void CheckStringArgumentLength(object argument, int length) => SystemNotificationInterop.CheckStringArgumentLength(argument, length, (string) null);

    private static void CheckStringArgumentLength(object argument, int length, string paramName) => StringHelper.ValidateString(argument == null ? (string) null : argument.ToString(), length, paramName);

    private static AgentExitReason HRESULTToAgentExitReason(int hr)
    {
      switch (hr)
      {
        case -2147418113:
        case -2147220978:
          return AgentExitReason.UnhandledException;
        case -2147220983:
          return AgentExitReason.ExecutionTimeExceeded;
        case -2147220982:
        case -2147024882:
          return AgentExitReason.MemoryQuotaExceeded;
        case -2147220981:
          return AgentExitReason.Terminated;
        case -2147220721:
          return AgentExitReason.Aborted;
        case -1:
          return AgentExitReason.None;
        case 0:
          return AgentExitReason.Completed;
        default:
          return AgentExitReason.Other;
      }
    }

    internal static void ValidateTitle(string title, string paramName)
    {
      if (title == null)
        throw new ArgumentNullException(paramName);
      SystemNotificationInterop.CheckStringArgumentLength((object) title, 64, paramName);
    }

    internal static void ValidateContent(string content, string paramName)
    {
      if (content == null)
        throw new ArgumentNullException(paramName);
      SystemNotificationInterop.CheckStringArgumentLength((object) content, 256, paramName);
    }

    internal static void ValidateName(string name, string paramName)
    {
      switch (name)
      {
        case "":
          throw new ArgumentOutOfRangeException(paramName);
        case null:
          throw new ArgumentNullException(paramName);
        default:
          if (!StringHelper.IsPrintable(name))
            throw new ArgumentOutOfRangeException(paramName);
          SystemNotificationInterop.CheckStringArgumentLength((object) name, 256, paramName);
          break;
      }
    }

    internal static void ValidateSoundUri(string soundUri, string paramName)
    {
      if (!string.IsNullOrEmpty(soundUri) && !StringHelper.IsPrintable(soundUri))
        throw new ArgumentOutOfRangeException(paramName);
      SystemNotificationInterop.CheckStringArgumentLength((object) soundUri, 128, paramName);
    }

    internal static void ValidateNavigationUri(Uri navigationUri, string paramName)
    {
      if (navigationUri == (Uri) null)
        return;
      string s = !navigationUri.IsAbsoluteUri ? navigationUri.ToString() : throw new ArgumentOutOfRangeException(string.Format("'{0}' must be relative", (object) paramName));
      if (!string.IsNullOrEmpty(s) && !StringHelper.IsPrintable(s))
        throw new ArgumentOutOfRangeException(paramName);
      SystemNotificationInterop.CheckStringArgumentLength((object) s, 128, paramName);
    }

    [Conditional("DEBUG")]
    private static void PrintOut(string format, params object[] args)
    {
    }

    [Conditional("DEBUG")]
    private static void PrintNativeStructure(
      SystemNotificationInterop.BNS_NOTIFICATION nativeNotification)
    {
    }

    [Conditional("DEBUG")]
    private static void PrintManagedClasse(ScheduledAction action)
    {
      ScheduledNotification scheduledNotification = action as ScheduledNotification;
      Reminder reminder = action as Reminder;
    }

    private struct SYSTEMTIME
    {
      [MarshalAs(UnmanagedType.U2)]
      internal short Year;
      [MarshalAs(UnmanagedType.U2)]
      internal short Month;
      [MarshalAs(UnmanagedType.U2)]
      internal short DayOfWeek;
      [MarshalAs(UnmanagedType.U2)]
      internal short Day;
      [MarshalAs(UnmanagedType.U2)]
      internal short Hour;
      [MarshalAs(UnmanagedType.U2)]
      internal short Minute;
      [MarshalAs(UnmanagedType.U2)]
      internal short Second;
      [MarshalAs(UnmanagedType.U2)]
      internal short Milliseconds;

      internal static SystemNotificationInterop.SYSTEMTIME Empty
      {
        get
        {
          SystemNotificationInterop.SYSTEMTIME systemtime;
          systemtime.Year = (short) 0;
          systemtime.Month = (short) 0;
          systemtime.DayOfWeek = (short) 0;
          systemtime.Day = (short) 0;
          systemtime.Hour = (short) 0;
          systemtime.Minute = (short) 0;
          systemtime.Second = (short) 0;
          systemtime.Milliseconds = (short) 0;
          return systemtime;
        }
      }

      internal SYSTEMTIME(DateTime dt)
      {
        this.Year = dt.Year == 1 ? (short) 0 : (short) dt.Year;
        this.Month = (short) dt.Month;
        this.DayOfWeek = (short) dt.DayOfWeek;
        this.Day = (short) dt.Day;
        this.Hour = (short) dt.Hour;
        this.Minute = (short) dt.Minute;
        this.Second = (short) dt.Second;
        this.Milliseconds = (short) dt.Millisecond;
      }

      internal DateTime ToDateTime() => new DateTime(this.Year == (short) 0 ? 1 : (int) this.Year, this.Month == (short) 0 ? 1 : (int) this.Month, this.Day == (short) 0 ? 1 : (int) this.Day, (int) this.Hour, (int) this.Minute, (int) this.Second);
    }

    [Flags]
    private enum BNS_RECURRING_TYPE
    {
      BNS_RECURRING_TYPE_NONE = 0,
      BNS_RECURRING_TYPE_DAILY = 1,
      BNS_RECURRING_TYPE_WEEKLY = 2,
      BNS_RECURRING_TYPE_MONTHLY = BNS_RECURRING_TYPE_WEEKLY | BNS_RECURRING_TYPE_DAILY, // 0x00000003
      BNS_RECURRING_TYPE_ENDOFMONTH = 4,
      BNS_RECURRING_TYPE_YEARLY = BNS_RECURRING_TYPE_ENDOFMONTH | BNS_RECURRING_TYPE_DAILY, // 0x00000005
      BNS_RECURRING_TYPE_MAXIMUM = BNS_RECURRING_TYPE_ENDOFMONTH | BNS_RECURRING_TYPE_WEEKLY, // 0x00000006
    }

    [Flags]
    private enum BNS_NOTIFICATION_TYPE
    {
      BNS_NOTIFICATION_TYPE_TIMEBASED_ALARM = 0,
      BNS_NOTIFICATION_TYPE_TIMEBASED_REMINDER = 1,
      BNS_NOTIFICATION_TYPE_PERIODIC_TASK = 2,
      BNS_NOTIFICATION_TYPE_ONIDLE_TASK = BNS_NOTIFICATION_TYPE_PERIODIC_TASK | BNS_NOTIFICATION_TYPE_TIMEBASED_REMINDER, // 0x00000003
      BNS_NOTIFICATION_TYPE_KEEPALIVE_TASK = 4,
      BNS_NOTIFICATION_TYPE_INCOMINGCALL_TASK = BNS_NOTIFICATION_TYPE_KEEPALIVE_TASK | BNS_NOTIFICATION_TYPE_TIMEBASED_REMINDER, // 0x00000005
      BNS_NOTIFICATION_TYPE_NABSYNC_TASK = BNS_NOTIFICATION_TYPE_KEEPALIVE_TASK | BNS_NOTIFICATION_TYPE_PERIODIC_TASK, // 0x00000006
      BNS_NOTIFICATION_TYPE_MAXIMUM = BNS_NOTIFICATION_TYPE_NABSYNC_TASK | BNS_NOTIFICATION_TYPE_TIMEBASED_REMINDER, // 0x00000007
    }

    [Flags]
    private enum BNS_NOTIFICATION_STATE
    {
      BNS_NOTIFICATION_STATE_SCHEDULED = 0,
      BNS_NOTIFICATION_STATE_COMPLETED = 1,
      BNS_NOTIFICATION_STATE_DISABLED = 2,
    }

    [Flags]
    private enum BNS_LAST_USER_ACTION
    {
      BNS_LAST_USER_ACTION_NONE = 0,
      BNS_LAST_USER_ACTION_DISMISS = 1,
      BNS_LAST_USER_ACTION_SNOOZE = 2,
      BNS_LAST_USER_ACTION_OPEN_APP = BNS_LAST_USER_ACTION_SNOOZE | BNS_LAST_USER_ACTION_DISMISS, // 0x00000003
      BNS_LAST_USER_ACTION_TASK_LAUNCHED = 4,
      BNS_LAST_USER_ACTION_TASK_LAUNCH_FAILED = BNS_LAST_USER_ACTION_TASK_LAUNCHED | BNS_LAST_USER_ACTION_DISMISS, // 0x00000005
      BNS_LAST_USER_ACTION_TASK_CANCELLED = BNS_LAST_USER_ACTION_TASK_LAUNCHED | BNS_LAST_USER_ACTION_SNOOZE, // 0x00000006
      BNS_LAST_USER_ACTION_TASK_CANCEL_FAILED = BNS_LAST_USER_ACTION_TASK_CANCELLED | BNS_LAST_USER_ACTION_DISMISS, // 0x00000007
      BNS_LAST_USER_ACTION_TASK_COMPLETE = 8,
      BNS_LAST_USER_ACTION_TASK_COMPLETE_FAILED = BNS_LAST_USER_ACTION_TASK_COMPLETE | BNS_LAST_USER_ACTION_DISMISS, // 0x00000009
      BNS_LAST_USER_ACTION_MAXIMUM = BNS_LAST_USER_ACTION_TASK_COMPLETE | BNS_LAST_USER_ACTION_SNOOZE, // 0x0000000A
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct BNS_NOTIFICATION
    {
      internal Guid notificationID;
      internal Guid productID;
      internal uint taskID;
      internal SystemNotificationInterop.SYSTEMTIME startTime;
      internal SystemNotificationInterop.SYSTEMTIME endTime;
      internal SystemNotificationInterop.BNS_NOTIFICATION_TYPE notificationType;
      internal SystemNotificationInterop.BNS_RECURRING_TYPE recurringType;
      internal SystemNotificationInterop.BNS_NOTIFICATION_STATE state;
      internal SystemNotificationInterop.BNS_LAST_USER_ACTION lastUserAction;
      internal SystemNotificationInterop.SYSTEMTIME lastScheduledTime;
      internal int lastResult;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      internal string szContent;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      internal string szFriendlyName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      internal string szLaunchingContext;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      internal string szSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      internal string szTitle;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
      internal string szAppInstallPath;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      internal string szAppBaseUri;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      internal string szPushChannel;
      internal uint dwRecurringIntervalInSeconds;

      internal static SystemNotificationInterop.BNS_NOTIFICATION Empty => new SystemNotificationInterop.BNS_NOTIFICATION()
      {
        notificationID = Guid.Empty,
        productID = Guid.Empty,
        taskID = 0,
        startTime = SystemNotificationInterop.SYSTEMTIME.Empty,
        endTime = SystemNotificationInterop.SYSTEMTIME.Empty,
        notificationType = SystemNotificationInterop.BNS_NOTIFICATION_TYPE.BNS_NOTIFICATION_TYPE_MAXIMUM,
        recurringType = SystemNotificationInterop.BNS_RECURRING_TYPE.BNS_RECURRING_TYPE_NONE,
        state = SystemNotificationInterop.BNS_NOTIFICATION_STATE.BNS_NOTIFICATION_STATE_COMPLETED,
        lastUserAction = SystemNotificationInterop.BNS_LAST_USER_ACTION.BNS_LAST_USER_ACTION_NONE,
        szContent = string.Empty,
        szFriendlyName = string.Empty,
        szLaunchingContext = string.Empty,
        szSound = string.Empty,
        szTitle = string.Empty,
        szAppInstallPath = string.Empty,
        szAppBaseUri = string.Empty,
        lastScheduledTime = SystemNotificationInterop.SYSTEMTIME.Empty,
        lastResult = -1,
        szPushChannel = string.Empty,
        dwRecurringIntervalInSeconds = 0
      };
    }
  }
}
