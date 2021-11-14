// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.CameraNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Devices
{
  [SecurityCritical]
  internal static class CameraNativeMethods
  {
    public const int E_HANDLE = -2147024890;
    public const int E_INSUFFICIENT_BUFFER = -2147024774;
    public const int E_FAIL = -2147467259;
    public const int E_UNEXPECTED = -2147418113;
    public const int E_NOTIMPL = -2147467263;
    public const int E_INVALIDARG = -2147024809;
    public const int E_OUTOFMEMORY = -2147483646;
    public const int WIN32HR_ERROR_DISK_FULL = -2147024784;
    public const int WIN32HR_ERROR_NOT_SUPPORTED = -2147024846;
    public const int E_CAPTURE_API_UNAVAILABLE_WHILE_DORMANT = -2141650941;
    public const int WIN32HR_ERROR_ACCESS_DENIED_BY_POLICY = -2147023636;
    public const int E_CAPTURE_API_INSTANCE_NOT_INITIALIZED = -2141650940;
    public const int E_CAPTURE_API_INSTANCE_DISPOSED = -2141650939;
    public const int PHOTOS_E_CALLBACK_FAILURE = -2145058720;

    [DllImport("CaptureServiceClient.dll")]
    public static extern void PInvoke_CameraButtons_SetCallback(ManagedEventCallback cb);

    [DllImport("CaptureServiceClient.dll")]
    public static extern void PInvoke_CameraButtons_AddRefAcquire();

    [DllImport("CaptureServiceClient.dll")]
    public static extern void PInvoke_CameraButtons_ReleaseAcquire();

    [DllImport("PhotosAPI.dll", PreserveSig = false)]
    public static extern void MediaApi_AddCapturedFile(
      string sourceFile,
      string comment,
      string artFile,
      out IntPtr pzmiOut);

    [DllImport("zuneapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void MediaApi_AddRingtone(Stream pRingtoneStream, string nameInDirectory);

    [DllImport("zuneapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void MediaApi_AddRingtoneFile(
      string relativeFilePath,
      string nameInDirectory);
  }
}
