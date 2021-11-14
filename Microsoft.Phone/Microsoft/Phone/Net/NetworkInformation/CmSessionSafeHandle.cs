// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.CmSessionSafeHandle
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecurityCritical]
  internal class CmSessionSafeHandle : SafeHandle
  {
    protected CmSessionSafeHandle()
      : base(IntPtr.Zero, true)
    {
    }

    internal CmSessionSafeHandle(IntPtr handle, bool ownsHandle)
      : base(handle, ownsHandle)
    {
    }

    [SecurityCritical]
    protected override bool ReleaseHandle()
    {
      int num = (int) ConnectionMgrMethods.CmCloseSession(this.handle);
      ConnectionMgrMethods.CmApiDeinit();
      return true;
    }

    public override bool IsInvalid
    {
      [SecurityCritical] get => this.IsClosed || this.handle == IntPtr.Zero;
    }

    internal static CmSessionSafeHandle CreateCMSession()
    {
      ConnectionMgrMethods.CmApiInit();
      return ConnectionMgrMethods.CmCreateSession();
    }
  }
}
