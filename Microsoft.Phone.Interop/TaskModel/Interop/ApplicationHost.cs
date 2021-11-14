// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ApplicationHost
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecuritySafeCritical]
  internal class ApplicationHost
  {
    private HostInformation _hostInformation;
    internal uint MaxPath = 260;
    private Task _rootTask;
    private Dictionary<uint, Task> _tasks;
    private static ApplicationHost _current = (ApplicationHost) null;
    internal const string AppDataUriScheme = "appdata";
    internal const string IsoStoreUriScheme = "isostore";
    internal const string fileUriScheme = "file";
    internal static readonly object _gate = new object();

    private ApplicationHost()
    {
      this._tasks = new Dictionary<uint, Task>();
      this._hostInformation.ullLastInstanceId = 0U;
      this._hostInformation.hHostWnd = IntPtr.Zero;
      this._hostInformation.hTouchWnd = IntPtr.Zero;
      this.GetHostInformation();
      if (this.IsHeadless)
        return;
      ApplicationHost.CreateTestFrameworkHook();
      this.InitializeTestShowCompleteEvent();
    }

    public static ApplicationHost Current
    {
      [SecuritySafeCritical] get
      {
        lock (ApplicationHost._gate)
        {
          if (ApplicationHost._current == null)
            ApplicationHost._current = new ApplicationHost();
          return ApplicationHost._current;
        }
      }
    }

    [SecuritySafeCritical]
    ~ApplicationHost() => this.UninitializeTestPageShowCompleteEvent();

    [SecuritySafeCritical]
    private void GetHostInformation() => ApplicationHostNativeMethods.GetHostInfo(out this._hostInformation);

    public static void RegisterCallbacks(ref ApplicationHostCallbacks appCallbacks) => ApplicationHostNativeMethods.RegisterAppCallbacks(ref appCallbacks);

    public Task CreateTask(uint taskID)
    {
      if (taskID == 0U)
        throw new ArgumentException("TaskID cannot be 0");
      Dictionary<uint, Task> dictionary = !this._tasks.ContainsKey(taskID) ? this._tasks : throw new ArgumentException("Task already exists");
      int num = (int) taskID;
      Task task = new Task((uint) num);
      dictionary[(uint) num] = task;
      return this._tasks[taskID];
    }

    public Task GetTask(uint taskID) => this._tasks.ContainsKey(taskID) ? this._tasks[taskID] : throw new ArgumentException("Task [" + (object) taskID + "] doesn't exist");

    public void RemoveTask(uint taskID)
    {
      if (!this._tasks.ContainsKey(taskID))
        throw new ArgumentException("Task [" + (object) taskID + "] doesn't exist");
      this._tasks.Remove(taskID);
    }

    public Task RootTask
    {
      get
      {
        if (this._rootTask == null)
        {
          this._rootTask = new Task(this._hostInformation.ullLastInstanceId);
          this._tasks[this._hostInformation.ullLastInstanceId] = this._rootTask;
        }
        return this._rootTask;
      }
    }

    public string ProductId => this._hostInformation.szProductId;

    public IntPtr HostWnd
    {
      get
      {
        IntPtr zero = IntPtr.Zero;
        return this._hostInformation.hHostWnd;
      }
    }

    public IntPtr TouchWnd
    {
      get
      {
        IntPtr zero = IntPtr.Zero;
        return this._hostInformation.hTouchWnd;
      }
    }

    public string AppInstallFolder => this._hostInformation.szAppInstallFolder;

    public string AppDataFolder => this._hostInformation.szAppDataFolder;

    public string AppIsolatedStorePath => this._hostInformation.szAppIsolatedStorePath;

    public string Uri
    {
      get
      {
        this.GetHostInformation();
        return this._hostInformation.szUri;
      }
    }

    public string TaskPage => this._hostInformation.szTaskPage;

    public bool Rehydrated
    {
      get
      {
        this.GetHostInformation();
        return this._hostInformation.fRehydrated > 0U;
      }
    }

    public bool Dehydrating
    {
      get
      {
        if (this._hostInformation.fDehydrating == 0U)
          this.GetHostInformation();
        return this._hostInformation.fDehydrating > 0U;
      }
    }

    public bool IsHeadless => this._hostInformation.fIsHeadlessHost > 0U;

    public bool IsExecutingInBackground
    {
      get
      {
        this.GetHostInformation();
        return this._hostInformation.fIsExecutingInBackground > 0U;
      }
    }

    public string GuidInstanceId => this._hostInformation.szGuidInstanceId;

    [SecuritySafeCritical]
    public string GetFileSystemPath(string uri)
    {
      System.Uri uri1 = !string.IsNullOrEmpty(uri) ? new System.Uri(uri, UriKind.RelativeOrAbsolute) : throw new ArgumentException(nameof (uri));
      if (uri1.IsAbsoluteUri && (uri1.Port != -1 || !string.IsNullOrEmpty(uri1.Query) || !string.IsNullOrEmpty(uri1.Host)))
        throw new ArgumentException(nameof (uri));
      string path1;
      if (!uri1.IsAbsoluteUri || string.CompareOrdinal(uri1.Scheme, "appdata") == 0 || string.CompareOrdinal(uri1.Scheme, "file") == 0)
      {
        path1 = this.AppInstallFolder;
      }
      else
      {
        if (string.CompareOrdinal(uri1.Scheme, "isostore") != 0)
          throw new ArgumentException(nameof (uri));
        path1 = this.AppIsolatedStorePath;
      }
      string path2 = !uri1.IsAbsoluteUri ? uri1.OriginalString : uri1.LocalPath;
      if (path2 == null)
        throw new ArgumentException(nameof (uri));
      if (path2.StartsWith("/") || path2.StartsWith("\\"))
        path2 = path2.Substring(1);
      string pathName = Path.Combine(path1, path2);
      StringBuilder canonicalPathName = new StringBuilder((int) this.MaxPath);
      if (ApplicationHostNativeMethods.GetCanonicalPathName(pathName, canonicalPathName, this.MaxPath) == 0U)
        throw new ArgumentException(nameof (uri));
      string str = canonicalPathName.ToString();
      return str.StartsWith(path1, StringComparison.InvariantCultureIgnoreCase) ? str : throw new ArgumentException(nameof (uri));
    }

    public uint AppTargetRuntimeMajorVersion => this._hostInformation.uAppTargetMajorVersion;

    public uint AppTargetRuntimeMinorVersion => this._hostInformation.uAppTargetMinorVersion;

    public ApplicationType ApplicationType => this._hostInformation.appType;

    [SecuritySafeCritical]
    private static void CreateTestFrameworkHook()
    {
      IntPtr num = IntPtr.Zero;
      try
      {
        num = ApplicationHostNativeMethods.OpenEvent(2031619U, false, "Global\\TestNamedObjects\\YTestEnabled");
        if (!(IntPtr.Zero != num))
          return;
        if (ApplicationHostNativeMethods.WaitForSingleObject(num, 0) != 0)
          return;
        try
        {
          Assembly.Load("Microsoft.Phone.Test.AppPlatform.SLM.MessagingLibrary").GetType("Microsoft.Phone.Test.AppPlatform.SLM.MessagingLibrary.TestDispatcher").GetProperty("TestDispatcherInstance").GetValue((object) null, (object[]) null);
        }
        catch (Exception ex)
        {
        }
      }
      catch (Exception ex)
      {
      }
      finally
      {
        if (IntPtr.Zero != num)
          ApplicationHostNativeMethods.CloseHandle(num);
      }
    }

    internal IntPtr TestPageCompleteEvent { get; private set; }

    [SecuritySafeCritical]
    private void InitializeTestShowCompleteEvent()
    {
      if (!(this.TestPageCompleteEvent == IntPtr.Zero))
        return;
      this.TestPageCompleteEvent = ApplicationHostNativeMethods.OpenEvent(2031619U, false, "Global\\TestNamedObjects\\Global_PageShowComplete");
      Marshal.GetLastWin32Error();
      int num = this.TestPageCompleteEvent == IntPtr.Zero ? 1 : 0;
    }

    [SecuritySafeCritical]
    private void UninitializeTestPageShowCompleteEvent()
    {
      if (!(this.TestPageCompleteEvent != IntPtr.Zero))
        return;
      ApplicationHostNativeMethods.CloseHandle(this.TestPageCompleteEvent);
      this.TestPageCompleteEvent = IntPtr.Zero;
    }
  }
}
