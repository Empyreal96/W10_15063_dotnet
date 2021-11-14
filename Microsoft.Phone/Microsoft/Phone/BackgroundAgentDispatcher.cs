// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAgentDispatcher
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.BackgroundAgentSharedConsts;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;

namespace Microsoft.Phone
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class BackgroundAgentDispatcher : IBackgroundAgentDispatcher
  {
    private const int AgentCompletionGracePeriod = 2000;
    private BackgroundAgentDispatcher.AgentRequest _currentAgentRequest;
    private Queue<BackgroundAgentDispatcher.AgentRequest> _dispatchQueue = new Queue<BackgroundAgentDispatcher.AgentRequest>();
    private Thread _consumerThread;
    private Thread _invocationThread;
    private EventWaitHandle _checkQueueEvent = (EventWaitHandle) new AutoResetEvent(false);
    private EventWaitHandle _invocationEvent = (EventWaitHandle) new AutoResetEvent(false);
    private EventWaitHandle _invocationReadyEvent = (EventWaitHandle) new ManualResetEvent(false);
    private IBackgroundAgentActivator _activator;
    private ITaskFactory _taskFactory;

    internal BackgroundAgentDispatcher()
    {
      this._activator = BackgroundAgentActivatorFactory.CreateInstance();
      this._taskFactory = (ITaskFactory) new TaskFactory();
    }

    internal BackgroundAgentDispatcher(
      IBackgroundAgentActivator activator,
      ITaskFactory taskFactory)
    {
      this._activator = activator;
      this._taskFactory = taskFactory;
    }

    void IBackgroundAgentDispatcher.Dispatch(
      uint taskID,
      Uri uri,
      ParameterPropertyBag propbag)
    {
      if (this._consumerThread == null)
      {
        this._consumerThread = new Thread(new ThreadStart(this.ConsumerThread));
        this._consumerThread.Start();
        this._invocationThread = new Thread(new ThreadStart(this.InvocationThread));
        this._invocationThread.Start();
      }
      BackgroundAgentDispatcher.AgentRequest agentRequest = new BackgroundAgentDispatcher.AgentRequest(taskID, uri, propbag, this._taskFactory.FetchInstance(taskID), this._activator, this);
      lock (((ICollection) this._dispatchQueue).SyncRoot)
        this._dispatchQueue.Enqueue(agentRequest);
      this._checkQueueEvent.Set();
    }

    private void ConsumerThread()
    {
      while (this._checkQueueEvent.WaitOne())
      {
        lock (((ICollection) this._dispatchQueue).SyncRoot)
        {
          if (this._dispatchQueue.Count != 0)
          {
            if (this._currentAgentRequest == null)
            {
              this._currentAgentRequest = this._dispatchQueue.Dequeue();
              if (!this._invocationReadyEvent.WaitOne(2000))
              {
                this.ThrowUnrecoverableException((Exception) new TimeoutException("The BackgroundAgent did not return from the invocation after it reported that it had completed."));
                break;
              }
              this._invocationEvent.Set();
            }
          }
        }
      }
    }

    private void InvocationThread()
    {
      this._invocationReadyEvent.Set();
      while (this._invocationEvent.WaitOne())
      {
        BackgroundAgentDispatcher.AgentRequest currentAgentRequest;
        lock (((ICollection) this._dispatchQueue).SyncRoot)
          currentAgentRequest = this._currentAgentRequest;
        this._invocationReadyEvent.Reset();
        currentAgentRequest.Invoke();
        this._invocationReadyEvent.Set();
      }
    }

    internal void OnRequestComplete()
    {
      lock (((ICollection) this._dispatchQueue).SyncRoot)
        this._currentAgentRequest = (BackgroundAgentDispatcher.AgentRequest) null;
      this._checkQueueEvent.Set();
    }

    [SecuritySafeCritical]
    private void ThrowUnrecoverableException(Exception ex)
    {
      Application.ShouldIgnoreUnhandledException(ex);
      throw ex;
    }

    private class AgentRequest
    {
      internal uint _taskID;
      private Uri _taskUri;
      private ParameterPropertyBag _propbag;
      private ITask _task;
      private IBackgroundAgentActivator _activator;
      private bool _isCancelled;
      private bool _isCompleted;
      private BackgroundAgent _agent;
      private object _agentLock = new object();
      private object _invocationLock = new object();
      private object _completionLock = new object();
      private BackgroundAgentDispatcher _dispatcher;
      private EventWaitHandle _agentRequestComplete = (EventWaitHandle) new AutoResetEvent(false);

      public AgentRequest(
        uint taskID,
        Uri uri,
        ParameterPropertyBag propbag,
        ITask task,
        IBackgroundAgentActivator activator,
        BackgroundAgentDispatcher dispatcher)
      {
        this._taskID = taskID;
        this._taskUri = uri;
        this._propbag = propbag;
        this._activator = activator;
        this._dispatcher = dispatcher;
        this._task = task;
        this._task.OnCancel += new ITask.Cancel(this.Cancel);
      }

      internal void Cancel()
      {
        if (Monitor.TryEnter(this._invocationLock))
        {
          lock (this._agentLock)
            this._isCancelled = true;
          try
          {
            this.Complete(0);
          }
          finally
          {
            Monitor.Exit(this._invocationLock);
          }
        }
        else
        {
          lock (this._agentLock)
          {
            if (this._agent != null)
            {
              this._agent.OnCancel();
            }
            else
            {
              this._isCancelled = true;
              this.Complete(0);
            }
          }
        }
      }

      [SecuritySafeCritical]
      internal void Invoke()
      {
        BackgroundAgent backgroundAgent = (BackgroundAgent) null;
        BackgroundAgentDispatcher.AgentRequest.OnAgentRequestInvoked(this._taskID);
        lock (this._invocationLock)
        {
          lock (this._agentLock)
          {
            if (!this._isCancelled)
            {
              string stringValue1 = this._propbag.GetProperty("Assembly").StringValue;
              string stringValue2 = this._propbag.GetProperty("TypeInfo").StringValue;
              BackgroundAgentDispatcher.AgentRequest.SetIsCellularDisabled(false);
              ParameterProperty property = this._propbag.GetProperty("AgentFlags");
              if (property != null && property.ValueType == ParameterPropertyValueType.ValueType_UInt32 && Application.Current is HeadlessApplication current5)
              {
                current5.DisableCellular = ((int) property.UInt32Value & 1) == 1;
                BackgroundAgentDispatcher.AgentRequest.SetIsCellularDisabled(current5.DisableCellular);
                BackgroundAgentDispatcher.AgentRequest.SetConnectionPriority(((int) property.UInt32Value & 2) == 2 ? ConnectionPriority.P2 : ConnectionPriority.P1);
              }
              PerfLog.BeginLogMarker(PerfMarkerEvents.HA_CREATEAGENT, "BackgroundAgentDispatcher.CreateAgent");
              backgroundAgent = this._agent = this._activator.CreateBackgroundAgent(stringValue1, stringValue2);
              PerfLog.EndLogMarker(PerfMarkerEvents.HA_CREATEAGENT, "BackgroundAgentDispatcher.CreateAgent");
            }
          }
          if (backgroundAgent != null)
          {
            backgroundAgent.RequestComplete += new AgentRequestCompleteEventHandler(this.OnAgentComplete);
            PerfLog.BeginLogMarker(PerfMarkerEvents.HA_INVOCATION, "BackgroundAgentDispatcher.Invoke");
            backgroundAgent.Invoke(this._taskUri, this._propbag);
            PerfLog.EndLogMarker(PerfMarkerEvents.HA_INVOCATION, "BackgroundAgentDispatcher.Invoke");
            this._agentRequestComplete.WaitOne();
            backgroundAgent.RequestComplete -= new AgentRequestCompleteEventHandler(this.OnAgentComplete);
          }
          else
            this._dispatcher.OnRequestComplete();
        }
      }

      private void Complete(int result)
      {
        lock (this._completionLock)
        {
          if (this._isCompleted)
            return;
          this._task.Detach();
          PerfLog.InfoLogMarker(PerfMarkerEvents.HA_COMPLETEAGENT, "Queueing up agent completion. Exit code: " + result.ToString());
          Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this._task.Complete(result)));
          this._isCompleted = true;
        }
      }

      private void OnAgentComplete(object sender, AgentRequestCompleteEventArgs args)
      {
        lock (this._completionLock)
        {
          if (!this._isCompleted)
          {
            this._agentRequestComplete.Set();
            this._dispatcher.OnRequestComplete();
            this.Complete(args.Result);
          }
        }
        lock (this._agentLock)
          this._agent = (BackgroundAgent) null;
      }

      [SecurityCritical]
      [DllImport("emclient.dll")]
      private static extern int OnAgentRequestInvoked(uint taskId);

      [SecurityCritical]
      [DllImport("emclient.dll")]
      private static extern int SetIsCellularDisabled([MarshalAs(UnmanagedType.Bool)] bool isCellularDisabled);

      [SecurityCritical]
      [DllImport("emclient.dll")]
      private static extern int SetConnectionPriority(ConnectionPriority priority);
    }
  }
}
