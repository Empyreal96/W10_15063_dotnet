// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.Logging.SubsystemId
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.ComponentModel;

namespace Microsoft.Phone.Interop.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal enum SubsystemId : uint
  {
    IsSubsystemMask = 2147483648, // 0x80000000
    CELID = 2147483649, // 0x80000001
    Kernel = 2147483649, // 0x80000001
    Silverlight = 2147483650, // 0x80000002
    XCP_EVENT_MARKER = 2147483650, // 0x80000002
    YH_EVENT = 2147483651, // 0x80000003
    YHarness = 2147483651, // 0x80000003
    XNA = 2147483652, // 0x80000004
    NetCF = 2147483653, // 0x80000005
    TaskHost = 2147483654, // 0x80000006
    PowerMonitor = 2147483655, // 0x80000007
    LINQ2SQL = 2147483664, // 0x80000010
    ShellInterop = 2147483665, // 0x80000011
  }
}
