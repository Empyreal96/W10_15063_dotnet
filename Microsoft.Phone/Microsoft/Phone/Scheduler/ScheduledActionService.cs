// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.ScheduledActionService
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Networking.Voip;
using System;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public sealed class ScheduledActionService
  {
    private static object m_syncRoot = new object();
    private static Dictionary<string, Microsoft.Phone.Scheduler.ScheduledAction> m_notificationDictionary = (Dictionary<string, Microsoft.Phone.Scheduler.ScheduledAction>) null;

    private ScheduledActionService()
    {
    }

    private static Dictionary<string, Microsoft.Phone.Scheduler.ScheduledAction> ActionDictionary
    {
      get
      {
        lock (ScheduledActionService.m_syncRoot)
        {
          if (ScheduledActionService.m_notificationDictionary == null)
          {
            ScheduledActionService.m_notificationDictionary = new Dictionary<string, Microsoft.Phone.Scheduler.ScheduledAction>();
            uint notificationCount = SystemNotificationInterop.GetNotificationCount();
            for (uint index = 0; index < notificationCount; ++index)
            {
              Microsoft.Phone.Scheduler.ScheduledAction notificationByIndex = SystemNotificationInterop.GetNotificationByIndex(index);
              ScheduledActionService.m_notificationDictionary.Add(notificationByIndex.Name, notificationByIndex);
            }
          }
          return ScheduledActionService.m_notificationDictionary;
        }
      }
    }

    public static void Add(Microsoft.Phone.Scheduler.ScheduledAction action)
    {
      lock (ScheduledActionService.m_syncRoot)
      {
        if (ScheduledActionService.ActionDictionary.ContainsKey(action.Name))
          throw new InvalidOperationException(string.Format("'{0}' exists already", (object) action.Name));
        SystemNotificationInterop.CreateNotification(action);
        ScheduledActionService.ActionDictionary[action.Name] = action.CreateCopy();
      }
    }

    public static Microsoft.Phone.Scheduler.ScheduledAction Find(string name)
    {
      lock (ScheduledActionService.m_syncRoot)
      {
        Microsoft.Phone.Scheduler.ScheduledAction scheduledAction = (Microsoft.Phone.Scheduler.ScheduledAction) null;
        if (ScheduledActionService.ActionDictionary.ContainsKey(name))
        {
          scheduledAction = ScheduledActionService.ActionDictionary[name];
          if (scheduledAction != null && scheduledAction.NeedUpdateStatus)
            scheduledAction.UpdateStatusFrom(SystemNotificationInterop.GetNotificationByID(scheduledAction.ID));
        }
        return scheduledAction == null ? (Microsoft.Phone.Scheduler.ScheduledAction) null : scheduledAction.CreateCopy();
      }
    }

    public static IEnumerable<T> GetActions<T>() where T : Microsoft.Phone.Scheduler.ScheduledAction
    {
      lock (ScheduledActionService.m_syncRoot)
      {
        List<T> objList = new List<T>();
        foreach (Microsoft.Phone.Scheduler.ScheduledAction scheduledAction in ScheduledActionService.ActionDictionary.Values)
        {
          if (scheduledAction != null && scheduledAction is T obj3)
            objList.Add(obj3);
        }
        return (IEnumerable<T>) objList;
      }
    }

    internal static IEnumerable<Microsoft.Phone.Scheduler.ScheduledAction> ScheduledAction
    {
      get
      {
        lock (ScheduledActionService.m_syncRoot)
        {
          foreach (Microsoft.Phone.Scheduler.ScheduledAction scheduledAction in ScheduledActionService.ActionDictionary.Values)
          {
            if (scheduledAction != null && scheduledAction.NeedUpdateStatus)
              scheduledAction.UpdateStatusFrom(SystemNotificationInterop.GetNotificationByID(scheduledAction.ID));
          }
          return (IEnumerable<Microsoft.Phone.Scheduler.ScheduledAction>) ScheduledActionService.ActionDictionary.Values;
        }
      }
    }

    public static void Remove(string name)
    {
      lock (ScheduledActionService.m_syncRoot)
      {
        if (!ScheduledActionService.ActionDictionary.ContainsKey(name))
          throw new InvalidOperationException(string.Format("'{0}' doesn't exist", (object) name));
        SystemNotificationInterop.DeleteNotification(ScheduledActionService.ActionDictionary[name].ID);
        ScheduledActionService.ActionDictionary.Remove(name);
      }
    }

    public static void Replace(Microsoft.Phone.Scheduler.ScheduledAction action)
    {
      lock (ScheduledActionService.m_syncRoot)
      {
        switch (action)
        {
          case ScheduledNotification _:
          case VoipHttpIncomingCallTask _:
          case VoipKeepAliveTask _:
            if (!ScheduledActionService.ActionDictionary.ContainsKey(action.Name))
              throw new InvalidOperationException(string.Format("'{0}' doesn't exist", (object) action.Name));
            SystemNotificationInterop.UpdateNotification(action);
            ScheduledActionService.ActionDictionary[action.Name] = action.CreateCopy();
            break;
          default:
            throw new NotSupportedException(string.Format("{0} is not supported", (object) "Replacing a ScheduledTask"));
        }
      }
    }

    public static void LaunchForTest(string name, TimeSpan delay)
    {
      lock (ScheduledActionService.m_syncRoot)
      {
        if (!ScheduledActionService.ActionDictionary.ContainsKey(name))
          throw new InvalidOperationException(string.Format("'{0}' doesn't exist", (object) name));
        if (!(ScheduledActionService.ActionDictionary[name] is ScheduledTask action2))
          throw new NotSupportedException(string.Format("{0} is not supported", (object) nameof (LaunchForTest)));
        Microsoft.Phone.Scheduler.ScheduledAction copy = action2.CreateCopy();
        copy.BeginTimeInternal = DateTime.Now + delay;
        SystemNotificationInterop.LaunchNotification(copy);
      }
    }

    public static void LaunchVoipHttpIncomingCallTask() => throw new NotImplementedException();
  }
}
