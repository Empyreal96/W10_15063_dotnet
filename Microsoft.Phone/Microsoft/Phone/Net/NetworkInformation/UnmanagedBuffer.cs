// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.UnmanagedBuffer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecurityCritical]
  internal sealed class UnmanagedBuffer : SafeHandle
  {
    private static IntPtr _processHeap;
    private static readonly object _sync = new object();

    private UnmanagedBuffer()
      : base(IntPtr.Zero, true)
    {
    }

    public override bool IsInvalid
    {
      [SecurityCritical] get => IntPtr.Zero == this.handle;
    }

    [SecurityCritical]
    protected override bool ReleaseHandle()
    {
      UnmanagedBuffer.NativeFree(this.handle);
      return true;
    }

    [DllImport("api-ms-win-core-heap-l1-1-0.dll")]
    private static extern UnmanagedBuffer HeapAlloc(
      IntPtr hHeap,
      uint dwFlags,
      uint dwBytes);

    [DllImport("api-ms-win-core-heap-l1-1-0.dll", SetLastError = true)]
    private static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

    [DllImport("api-ms-win-core-heap-l1-1-0.dll", SetLastError = true)]
    private static extern IntPtr GetProcessHeap();

    public static UnmanagedBuffer Allocate(uint size)
    {
      UnmanagedBuffer unmanagedBuffer = UnmanagedBuffer.HeapAlloc(UnmanagedBuffer.NativeGetProcessHeap(true), 8U, size);
      return !unmanagedBuffer.IsInvalid ? unmanagedBuffer : throw new OutOfMemoryException();
    }

    private static IntPtr NativeGetProcessHeap(bool throwOnFailure)
    {
      IntPtr num;
      lock (UnmanagedBuffer._sync)
      {
        num = UnmanagedBuffer._processHeap;
        if (IntPtr.Zero == num)
        {
          num = UnmanagedBuffer._processHeap = UnmanagedBuffer.GetProcessHeap();
          if (throwOnFailure)
          {
            if (num == IntPtr.Zero)
              throw new SystemException("GetProcessHeap failed: " + (object) Marshal.GetLastWin32Error());
          }
        }
      }
      return num;
    }

    private static bool NativeFree(IntPtr lpMem)
    {
      bool flag = false;
      IntPtr processHeap = UnmanagedBuffer._processHeap;
      if (IntPtr.Zero != processHeap)
        flag = UnmanagedBuffer.HeapFree(processHeap, 0U, lpMem);
      return flag;
    }
  }
}
