// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.TaskNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecurityCritical]
  internal static class TaskNativeMethods
  {
    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void RegisterTaskCallbacks(uint taskId, ref TaskCallbacks taskCallbacks);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void TaskReadyToNavigate(uint taskId);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void RequestCloseTask(uint taskId);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void RequestNavigateBack(uint taskId);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void SetSupportedOrientations(uint taskId, Orientations orientations);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void GetSupportedOrientations(
      uint taskId,
      out Orientations supportedOrientations);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void GetCurrentOrientation(
      uint taskId,
      out Orientations currentOrientation);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void CompleteTask(
      uint taskId,
      IntPtr outputBuffer,
      uint bufsize,
      int result);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void GetTaskInputBuffer(
      uint taskId,
      byte[] inputBuffer,
      uint bufsize,
      out uint actualBufSize);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void DestroyTaskCallbacks(uint taskId);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void LaunchSession(
      uint taskId,
      [MarshalAs(UnmanagedType.LPWStr)] string taskUri,
      byte[] parameterData,
      uint parameterDataSize,
      IntPtr launchSessionCallback);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void LaunchChildTask(
      uint taskId,
      [MarshalAs(UnmanagedType.LPWStr)] string taskUri,
      byte[] parameterData,
      uint parameterDataSize,
      IntPtr launchChildTaskCallback);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void LaunchModernChooser(
      uint taskId,
      [MarshalAs(UnmanagedType.LPWStr)] string appUri,
      [MarshalAs(UnmanagedType.LPWStr)] string chooserTargetPackageFamilyName,
      byte[] parameterData,
      uint parameterDataSize);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void GetTaskState(
      uint taskId,
      ref IntPtr ptrStateBuffer,
      out uint stateBufferSize);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void SetTaskState(uint _taskId, byte[] state, uint stateSize);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void GetTaskAppChromeHandle(
      uint taskId,
      out SafeAppChromeHandle appChromeHandle);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void SetTaskPauseOnLock(uint taskId, [MarshalAs(UnmanagedType.Bool)] bool pauseOnLock);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void UnmarshalTaskInputBuffer(
      uint taskId,
      bool fReleaseMarshalData,
      [MarshalAs(UnmanagedType.FunctionPtr | UnmanagedType.U4)] out object taskInputObject);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void SetTaskFullScreen(uint taskId, [MarshalAs(UnmanagedType.Bool)] bool fullScreen);

    [DllImport("TaskHostSvcs.dll", PreserveSig = false)]
    internal static extern void TaskFirstPresentCompleted(uint taskId);
  }
}
