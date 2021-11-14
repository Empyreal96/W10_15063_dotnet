// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.HeadlessApplication
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Phone
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SecuritySafeCritical]
  public class HeadlessApplication : Application
  {
    internal const int E_UNEXPECTED = -2147418113;
    internal const int E_OUTOFMEMORY = -2147024882;
    private HeadlessApplication.CreateTaskDelegate mCreateTask;
    private IBackgroundAgentDispatcherFactory _dispatcherFactory;
    private Dictionary<uint, IBackgroundAgentDispatcher> _mapDispatchers = new Dictionary<uint, IBackgroundAgentDispatcher>();

    [SecuritySafeCritical]
    public HeadlessApplication()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.HA_CONSTRUCTION, "HeadlessApplication ctor");
      this.mCreateTask = new HeadlessApplication.CreateTaskDelegate(this.CreateTask);
      ApplicationHost.RegisterCallbacks(ref new ApplicationHostCallbacks()
      {
        pfnCreateTask = Marshal.GetFunctionPointerForDelegate((Delegate) this.mCreateTask)
      });
      this.UnhandledException += new EventHandler<ApplicationUnhandledExceptionEventArgs>(this.App_UnhandledException);
      this.Startup += new StartupEventHandler(this.App_Startup);
      this._dispatcherFactory = (IBackgroundAgentDispatcherFactory) new BackgroundAgentDispatcherFactory();
      PerfLog.EndLogMarker(PerfMarkerEvents.HA_CONSTRUCTION, "HeadlessApplication ctor");
    }

    internal HeadlessApplication(
      IBackgroundAgentDispatcherFactory dispatcherFactory)
    {
      this._dispatcherFactory = dispatcherFactory;
    }

    [SecurityCritical]
    [AllowReversePInvokeCalls]
    internal void CreateTask(uint taskID, IntPtr ptrTaskUri)
    {
      string stringUni = Marshal.PtrToStringUni(ptrTaskUri);
      this.DispatchTask(ApplicationHost.Current.CreateTask(taskID), new Uri(stringUni));
    }

    private void DispatchTask(Task task, Uri taskUri)
    {
      byte[] buf = new byte[(int) task.InputBufferSizeForTask];
      task.GetInputBufferForTask(buf);
      PerfLog.BeginLogMarker(PerfMarkerEvents.HA_DISPATCH, "HeadlessApplication.Dispatch");
      if (buf.Length != 0)
      {
        byte[] buffer = buf;
        ParameterPropertyBag propbag = new ParameterPropertyBag(buffer, (uint) buffer.Length);
        ParameterProperty property = propbag.GetProperty("IsConcurrent");
        if (property != null && property.ValueType == ParameterPropertyValueType.ValueType_Bool && property.BoolValue)
        {
          this._dispatcherFactory.CreateInstance().Dispatch(task.ID, taskUri, propbag);
        }
        else
        {
          uint uint32Value = propbag.GetProperty("AgentType").UInt32Value;
          if (!this._mapDispatchers.ContainsKey(uint32Value))
            this._mapDispatchers[uint32Value] = this._dispatcherFactory.CreateInstance();
          this._mapDispatchers[uint32Value].Dispatch(task.ID, taskUri, propbag);
        }
      }
      PerfLog.EndLogMarker(PerfMarkerEvents.HA_DISPATCH, "HeadlessApplication.Dispatch");
    }

    private void App_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
    {
      if (e.ExceptionObject is OutOfMemoryException)
        NativeMethods.SetHostErrorCode(-2147024882);
      else
        NativeMethods.SetHostErrorCode(-2147418113);
    }

    private void App_Startup(object sender, StartupEventArgs e)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.HA_STARTUP, "HeadlessApplication.App_Startup");
      this.DispatchTask(ApplicationHost.Current.RootTask, new Uri(ApplicationHost.Current.Uri));
      PerfLog.EndLogMarker(PerfMarkerEvents.HA_STARTUP, "HeadlessApplication.App_Startup");
    }

    public bool DisableCellular { get; set; }

    internal delegate void CreateTaskDelegate(uint taskID, IntPtr taskUri);
  }
}
