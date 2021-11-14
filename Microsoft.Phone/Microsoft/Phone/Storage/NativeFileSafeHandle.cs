// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.NativeFileSafeHandle
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Storage
{
  [SecurityCritical]
  internal class NativeFileSafeHandle : SafeHandle
  {
    private static readonly IntPtr InvalidHandleValue = (IntPtr) -1;

    [SecurityCritical]
    public NativeFileSafeHandle()
      : base(NativeFileSafeHandle.InvalidHandleValue, true)
    {
    }

    public override bool IsInvalid
    {
      [SecurityCritical] get => this.handle == NativeFileSafeHandle.InvalidHandleValue;
    }

    [SecurityCritical]
    protected override bool ReleaseHandle() => NativeFileSafeHandle.CloseHandle(this.handle);

    [DllImport("api-ms-win-core-handle-l1-1-0.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hObject);
  }
}
