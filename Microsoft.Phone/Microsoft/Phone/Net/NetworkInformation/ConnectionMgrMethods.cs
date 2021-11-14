// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.ConnectionMgrMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecurityCritical]
  internal static class ConnectionMgrMethods
  {
    private const string CMNET = "cmnet.dll";
    internal const int CM_CURRENT_VERSION = 4;
    private const int CM_CONNECTION_NAME_LENGTH = 65;
    private const int CM_CONNECTION_DESCRIPTION_LENGTH = 128;
    private const int CM_CONNECTION_ADAPTER_NAME_LENGTH = 128;
    private const int CM_HOST_NAME_LENGTH = 256;
    private const int CM_CLIENT_ID_LENGTH = 128;
    internal const uint IF_TYPE_SOFTWARE_LOOPBACK = 24;
    internal const uint CM_UNKNOWN_CHARACTERISTIC_VALUE = 4294967295;

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CM_RESULT CmGetFirstCandidateConnection(
      [In] CmSessionSafeHandle hSession,
      [In] string pszHost,
      [In] ConnectionMgrMethods.CM_CONNECTION_SELECTION_OPTION Option,
      out IntPtr phConnection);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CM_RESULT CmGetNextCandidateConnection(
      [In] CmSessionSafeHandle hSession,
      out IntPtr phConnection);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CM_RESULT CmGetConnectionDetailsByHandle(
      [In] IntPtr hConnection,
      [In, Out] IntPtr pDetails,
      [In, Out] ref uint pcbDetails);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CM_RESULT CmGetConnectionDetailsByHandleWithDetailsLevel(
      [In] IntPtr hConnection,
      [In, Out] IntPtr pDetails,
      [In, Out] ref uint pcbetails,
      [In] ConnectionMgrMethods.CM_DETAILS_LEVEL DetailsLevel);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CM_RESULT CmGetConnectionDetailsByName(
      [In] string pszConnection,
      [In, Out] IntPtr pDetails,
      [In, Out] ref uint pcbDetails);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern IntPtr CmGetCurrentConnection([In] CmSessionSafeHandle hSession);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CmSessionSafeHandle CmCreateSession();

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern uint CmCloseSession(IntPtr hSession);

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern bool CmApiInit();

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern void CmApiDeinit();

    [DllImport("cmnet.dll", SetLastError = true)]
    internal static extern CmSessionSafeHandle WSAGetCmSession(IntPtr s);

    [DllImport("ConnState.dll", SetLastError = true)]
    internal static extern bool ConnectivityGetStatusMask(ref ulong pdwStatusMask);

    internal enum ADDRESS_FAMILY
    {
      AF_UNSPEC = 0,
      AF_INET = 2,
      AF_INET6 = 23, // 0x00000017
    }

    internal enum CM_CHARACTERISTIC
    {
      CMCH_BANDWIDTH_KBITPS,
      CMCH_ROAMING,
      CMCH_PERSISTENT,
      CMCH_CELLULAR,
      CMCH_DATA_PLAN_USAGE_STATE,
      CMCH_VOICECALL_CONFLICT_STATE,
      CMCH_CLAIMED,
      CMCH_EXECUTOR,
      CMCH_LAST,
    }

    internal struct GUID
    {
      private int a;
      private short b;
      private short c;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      private byte[] d;

      public Guid ToGuid() => new Guid(this.a, this.b, this.c, this.d);
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct CM_CONNECTION_DETAILS
    {
      public uint Version;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
      public string szName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
      public string szCspConnectionName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      public string szDescription;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      public string szAdapter;
      public ConnectionMgrMethods.GUID Type;
      public ConnectionMgrMethods.GUID Device;
      public ConnectionMgrMethods.GUID Network;
      public ConnectionMgrMethods.CM_CONNECTION_STATE State;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] Characteristic;
      public uint IfIndex;
      public uint IfType;
      public uint cIpAddr;
      [MarshalAs(UnmanagedType.Struct)]
      public ConnectionMgrMethods.SockAddrStorage sockaddr;

      public void init()
      {
        this.Version = 4U;
        this.szName = new string(char.MinValue, 65);
        this.szDescription = new string(char.MinValue, 128);
        this.szAdapter = new string(char.MinValue, 128);
        this.Type = new ConnectionMgrMethods.GUID();
        this.Device = new ConnectionMgrMethods.GUID();
        this.Network = new ConnectionMgrMethods.GUID();
        this.Characteristic = new uint[8];
      }
    }

    internal enum CM_CONNECTION_STATE
    {
      CMCS_DISCONNECTED = 0,
      CMCS_DISCONNECTED_UNAVAILABLE = 1,
      CMCS_DISCONNECTED_DISABLED = 2,
      CMCS_CONNECTING = 100, // 0x00000064
      CMCS_CONNECTING_ASSOCIATING = 101, // 0x00000065
      CMCS_CONNECTING_AUTHENTICATING = 102, // 0x00000066
      CMCS_CONNECTING_WAITING_FOR_IP = 103, // 0x00000067
      CMCS_CONNECTED = 200, // 0x000000C8
      CMCS_SUSPENDED = 300, // 0x0000012C
      CMCS_DISCONNECTING = 400, // 0x00000190
      CMCS_LAST = 401, // 0x00000191
    }

    internal enum CM_CONNECTION_SELECTION_OPTION
    {
      CMSO_DEFAULT,
      CMSO_LAST,
    }

    internal enum CM_DETAILS_LEVEL
    {
      CMDL_ALL,
      CMDL_FIXED_SIZE_ONLY,
      CMDL_LAST,
    }

    internal struct SockAddrStorage
    {
      public const uint Size = 128;
      internal short ss_family;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      internal byte[] __ss_pad1;
      internal long __ss_align;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 112)]
      internal byte[] __ss_pad2;
    }

    [Flags]
    internal enum ConnState : ulong
    {
      None = 0,
      CellularRadioOff = 1,
      CellularNotConfigured = 2,
      CellularRoaming = 4,
      CellularDisabled = 8,
      WifiRadioOff = 4294967296, // 0x0000000100000000
      WifiNotConfigured = 8589934592, // 0x0000000200000000
      CallSuspended = 1152921504606846976, // 0x1000000000000000
      DpuOffTrack = 4611686018427387904, // 0x4000000000000000
      DpuOverLimit = 9223372036854775808, // 0x8000000000000000
    }
  }
}
