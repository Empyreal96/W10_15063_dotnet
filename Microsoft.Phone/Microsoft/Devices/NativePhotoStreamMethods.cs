// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.NativePhotoStreamMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Devices
{
  [SecurityCritical]
  internal class NativePhotoStreamMethods
  {
    public const uint FILE_SHARE_READ = 1;
    public const uint FILE_SHARE_WRITE = 2;
    public const uint GENERIC_READ = 2147483648;
    public const uint OPEN_EXISTING = 4;
    public const uint FILE_ATTRIBUTE_NORMAL = 128;
    public const uint FILE_FLAG_DELETE_ON_CLOSE = 67108864;

    [DllImport("coredll", SetLastError = true)]
    public static extern PhotoHandle CreateFile(
      string lpFileName,
      uint dwDesiredAccess,
      uint dwShareMode,
      IntPtr lpSecurityAttributes,
      uint dwCreationDisposition,
      uint dwFlagsAndAttributes,
      IntPtr hTemplateFile);

    [DllImport("coredll", SetLastError = true)]
    public static extern bool CloseHandle(IntPtr hObject);
  }
}
