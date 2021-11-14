// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ApplicationHostNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecurityCritical]
  internal class ApplicationHostNativeMethods
  {
    internal const string TestEnabledEvent = "YTestEnabled";
    internal const uint EVENT_ALL_ACCESS = 2031619;
    internal const int WAIT_OBJECT_0 = 0;

    [DllImport("emclient.dll")]
    internal static extern void GetHostInfo(out HostInformation hostInformation);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern int RegisterAppCallbacks(ref ApplicationHostCallbacks appCallbacks);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern uint GetCanonicalPathName(
      string pathName,
      StringBuilder canonicalPathName,
      uint canonicalPathSize);

    [DllImport("api-ms-win-core-synch-l1-1-1.dll", SetLastError = true)]
    internal static extern int WaitForSingleObject(IntPtr handle, int milliseconds);

    [DllImport("api-ms-win-core-synch-l1-1-1.dll", EntryPoint = "OpenEventW", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern IntPtr OpenEvent(
      uint dwDesiredAccess,
      bool bInheritHandle,
      string lpName);

    [DllImport("api-ms-win-core-synch-l1-1-1.dll", EntryPoint = "CreateEventW", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern IntPtr CreateEvent(
      IntPtr lpEventAttributes,
      bool bManualReset,
      bool bInitialState,
      string lpName);

    [DllImport("api-ms-win-core-handle-l1-1-0.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool CloseHandle(IntPtr hObject);
  }
}
