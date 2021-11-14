// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.ConnectionMgrUtils
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  internal static class ConnectionMgrUtils
  {
    internal static void ParseConnectionDetails(
      ConnectionMgrMethods.CM_CONNECTION_DETAILS connDetails,
      ref NetworkInterfaceInfo interfaceInfo)
    {
      interfaceInfo.m_PublicInterfaceName = connDetails.szName;
      interfaceInfo.m_UnderlyingInterfaceName = connDetails.szName;
      interfaceInfo.m_Description = connDetails.szDescription == null || connDetails.szDescription.Length <= 1 ? connDetails.szAdapter : connDetails.szDescription;
      interfaceInfo.m_Bandwidth = (int) connDetails.Characteristic[0];
      interfaceInfo.m_InterfaceState = connDetails.State != ConnectionMgrMethods.CM_CONNECTION_STATE.CMCS_CONNECTED ? ConnectState.Disconnected : ConnectState.Connected;
      interfaceInfo.m_Characteristics = connDetails.Characteristic[1] == uint.MaxValue || connDetails.Characteristic[1] == 0U ? NetworkCharacteristics.None : NetworkCharacteristics.Roaming;
      if (connDetails.Characteristic[3] != uint.MaxValue && connDetails.Characteristic[3] != 0U)
      {
        interfaceInfo.m_InterfaceType = NetworkInterfaceType.MobileBroadbandGsm;
        Guid guid = connDetails.Network.ToGuid();
        Guid g1 = new Guid("{1C9031AB-D7CF-4781-A831-C45DA745F4AD}");
        Guid g2 = new Guid("{AFB7D659-FC1F-4ea5-BDD0-0FDA62676D96}");
        Guid g3 = new Guid("{B1E700AE-A62F-49ff-9BBE-B880C995F27D}");
        Guid g4 = new Guid("{C347F8EC-7095-423d-B838-7C7A7F38CD03}");
        Guid g5 = new Guid("{A72F04C6-9BE6-4151-B5EF-15A53E12C482}");
        Guid g6 = new Guid("{B8326098-F845-42f3-804E-8CC3FF7B50B4}");
        Guid g7 = new Guid("{DD42DF39-EBDF-407c-8146-1685416401B2}");
        Guid g8 = new Guid("{61BF1BFD-5218-4cd4-949C-241CA3F326F6}");
        Guid g9 = new Guid("{047F7282-BABD-4893-AA77-B8B312657F8C}");
        Guid g10 = new Guid("{1536A1C6-A4AF-423c-8884-6BDDA3656F84}");
        Guid g11 = new Guid("{B41CBF43-6994-46FF-9C2F-D6CA6D45889B}");
        Guid g12 = new Guid("{7cfa04a5-0f3f-445c-88a4-c86ed2ad94ea}");
        if (guid.Equals(g1))
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Unknown;
        else if (guid.Equals(g2))
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_GPRS;
        else if (guid.Equals(g3))
        {
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.MobileBroadbandCdma;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_1XRTT;
        }
        else if (guid.Equals(g4))
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_EDGE;
        else if (guid.Equals(g5))
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_3G;
        else if (guid.Equals(g6))
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_3G;
        else if (guid.Equals(g7))
        {
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.MobileBroadbandCdma;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_EVDO;
        }
        else if (guid.Equals(g8))
        {
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.MobileBroadbandCdma;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Cellular_EVDV;
        }
        else
          interfaceInfo.m_InterfaceSubtype = !guid.Equals(g9) ? (!guid.Equals(g10) ? (!QuirksMode.ShouldReportLTENetworkType() || !guid.Equals(g12) ? (!QuirksMode.ShouldReportLTENetworkType() || !guid.Equals(g11) ? NetworkInterfaceSubType.Unknown : NetworkInterfaceSubType.Cellular_LTE) : NetworkInterfaceSubType.Cellular_EHRPD) : NetworkInterfaceSubType.Cellular_HSPA) : NetworkInterfaceSubType.Cellular_HSPA;
      }
      else
      {
        Guid guid = connDetails.Type.ToGuid();
        Guid g1 = new Guid("{2CBB64A7-8CAB-4331-8D2B-4D19E36F12AA}");
        Guid g2 = new Guid("{8568B401-858E-4b7b-B3DF-0FD4927F131B}");
        Guid g3 = new Guid("{98AF6531-6F64-4796-9719-1FD9A850DC1B}");
        Guid g4 = new Guid("{39CC7826-F08B-4ac5-8920-A91521D1DBE6}");
        if (guid.Equals(g2) || guid.Equals(g3))
        {
          interfaceInfo.m_PublicInterfaceName = connDetails.szDescription;
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.Wireless80211;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.WiFi;
        }
        else if (guid.Equals(g1))
        {
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.Ethernet;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Desktop_PassThru;
        }
        else if (guid.Equals(g4))
        {
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.Ethernet;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Unknown;
        }
        else
        {
          interfaceInfo.m_InterfaceType = NetworkInterfaceType.Unknown;
          interfaceInfo.m_InterfaceSubtype = NetworkInterfaceSubType.Unknown;
        }
      }
      if (connDetails.IfType != 24U)
        return;
      interfaceInfo.IsSoftwareLoopback = true;
      if (!QuirksMode.ShouldFixSoftwareLoopbackInterfaceName())
        return;
      interfaceInfo.m_Description = "Software Loopback Interface 1";
      string interfaceName = interfaceInfo.InterfaceName;
      int num = interfaceName.LastIndexOf("_-");
      if (num <= 0 || num + 2 >= interfaceName.Length)
        return;
      string str = "Software Loopback Interface 1_" + interfaceName.Substring(num + 2);
      interfaceInfo.m_PublicInterfaceName = str;
    }

    internal static CM_RESULT GetConnectionDetail(
      IntPtr hConn,
      ref NetworkInterfaceInfo interfaceInfo)
    {
      return ConnectionMgrUtils.GetConnectionDetailWithLevel(hConn, ConnectionMgrMethods.CM_DETAILS_LEVEL.CMDL_ALL, ref interfaceInfo);
    }

    internal static CM_RESULT GetConnectionDetailWithLevel(
      IntPtr hConn,
      ConnectionMgrMethods.CM_DETAILS_LEVEL detailsLevel,
      ref NetworkInterfaceInfo interfaceInfo)
    {
      CM_RESULT cmResult = CM_RESULT.CMRE_SUCCESS;
      uint pcbetails = (uint) Marshal.SizeOf(typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS));
      UnmanagedBuffer unmanagedBuffer = (UnmanagedBuffer) null;
      ConnectionMgrMethods.CM_CONNECTION_DETAILS connectionDetails = new ConnectionMgrMethods.CM_CONNECTION_DETAILS();
      try
      {
        connectionDetails.init();
        for (int index = 3; index > 0; --index)
        {
          unmanagedBuffer = UnmanagedBuffer.Allocate(pcbetails);
          Marshal.StructureToPtr((object) connectionDetails, unmanagedBuffer.DangerousGetHandle(), false);
          cmResult = ConnectionMgrMethods.CmGetConnectionDetailsByHandleWithDetailsLevel(hConn, unmanagedBuffer.DangerousGetHandle(), ref pcbetails, detailsLevel);
          if (cmResult == CM_RESULT.CMRE_INSUFFICIENT_BUFFER)
            unmanagedBuffer.Dispose();
          else
            break;
        }
        if (cmResult == CM_RESULT.CMRE_SUCCESS)
          ConnectionMgrUtils.ParseConnectionDetails((ConnectionMgrMethods.CM_CONNECTION_DETAILS) Marshal.PtrToStructure(unmanagedBuffer.DangerousGetHandle(), typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS)), ref interfaceInfo);
      }
      catch (SystemException ex)
      {
        cmResult = CM_RESULT.CMRE_UNEXPECTED;
      }
      finally
      {
        unmanagedBuffer?.Dispose();
      }
      return cmResult;
    }

    internal static CM_RESULT GetConnectionDetailByName(
      string connName,
      ref NetworkInterfaceInfo interfaceInfo)
    {
      CM_RESULT cmResult = CM_RESULT.CMRE_SUCCESS;
      uint pcbDetails = (uint) Marshal.SizeOf(typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS));
      UnmanagedBuffer unmanagedBuffer = (UnmanagedBuffer) null;
      ConnectionMgrMethods.CM_CONNECTION_DETAILS connectionDetails = new ConnectionMgrMethods.CM_CONNECTION_DETAILS();
      try
      {
        connectionDetails.init();
        for (int index = 3; index > 0; --index)
        {
          unmanagedBuffer = UnmanagedBuffer.Allocate(pcbDetails);
          Marshal.StructureToPtr((object) connectionDetails, unmanagedBuffer.DangerousGetHandle(), false);
          cmResult = ConnectionMgrMethods.CmGetConnectionDetailsByName(connName, unmanagedBuffer.DangerousGetHandle(), ref pcbDetails);
          if (cmResult == CM_RESULT.CMRE_INSUFFICIENT_BUFFER)
            unmanagedBuffer.Dispose();
          else
            break;
        }
        if (cmResult == CM_RESULT.CMRE_SUCCESS)
          ConnectionMgrUtils.ParseConnectionDetails((ConnectionMgrMethods.CM_CONNECTION_DETAILS) Marshal.PtrToStructure(unmanagedBuffer.DangerousGetHandle(), typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS)), ref interfaceInfo);
      }
      catch (SystemException ex)
      {
        cmResult = CM_RESULT.CMRE_UNEXPECTED;
      }
      finally
      {
        unmanagedBuffer?.Dispose();
      }
      return cmResult;
    }

    internal static bool IsCellularDataEnabled()
    {
      bool flag = true;
      ulong pdwStatusMask = 0;
      try
      {
        ConnectionMgrMethods.CmApiInit();
        if (ConnectionMgrMethods.ConnectivityGetStatusMask(ref pdwStatusMask))
        {
          ConnectionMgrMethods.ConnState connState = (ConnectionMgrMethods.ConnState) pdwStatusMask;
          if ((connState & ConnectionMgrMethods.ConnState.CellularRadioOff) != ConnectionMgrMethods.ConnState.CellularRadioOff && (connState & ConnectionMgrMethods.ConnState.CellularNotConfigured) != ConnectionMgrMethods.ConnState.CellularNotConfigured)
          {
            if ((connState & ConnectionMgrMethods.ConnState.CellularDisabled) != ConnectionMgrMethods.ConnState.CellularDisabled)
              goto label_7;
          }
          flag = false;
        }
      }
      catch (SystemException ex)
      {
      }
      finally
      {
        ConnectionMgrMethods.CmApiDeinit();
      }
label_7:
      return flag;
    }

    internal static bool IsWiFiEnabled()
    {
      bool flag = true;
      ulong pdwStatusMask = 0;
      try
      {
        ConnectionMgrMethods.CmApiInit();
        if (ConnectionMgrMethods.ConnectivityGetStatusMask(ref pdwStatusMask))
        {
          ConnectionMgrMethods.ConnState connState = (ConnectionMgrMethods.ConnState) pdwStatusMask;
          if ((connState & ConnectionMgrMethods.ConnState.WifiRadioOff) != ConnectionMgrMethods.ConnState.WifiRadioOff)
          {
            if ((connState & ConnectionMgrMethods.ConnState.WifiNotConfigured) != ConnectionMgrMethods.ConnState.WifiNotConfigured)
              goto label_7;
          }
          flag = false;
        }
      }
      catch (SystemException ex)
      {
      }
      finally
      {
        ConnectionMgrMethods.CmApiDeinit();
      }
label_7:
      return flag;
    }

    internal static string GetMobileOperatorName()
    {
      try
      {
        StringBuilder operatorName = new StringBuilder(64);
        return PlatformInteropMethods.GetMobileOperatorName(operatorName, 64U) != 0 ? (string) null : operatorName.ToString();
      }
      catch (Exception ex)
      {
      }
      return (string) null;
    }

    internal static bool IsNetworkAvailable()
    {
      bool flag = false;
      IntPtr phConnection = IntPtr.Zero;
      try
      {
        CmSessionSafeHandle cmSession = CmSessionSafeHandle.CreateCMSession();
        if (!cmSession.IsInvalid)
        {
          for (CM_RESULT candidateConnection = ConnectionMgrMethods.CmGetFirstCandidateConnection(cmSession, (string) null, ConnectionMgrMethods.CM_CONNECTION_SELECTION_OPTION.CMSO_DEFAULT, out phConnection); candidateConnection == CM_RESULT.CMRE_SUCCESS; candidateConnection = ConnectionMgrMethods.CmGetNextCandidateConnection(cmSession, out phConnection))
          {
            NetworkInterfaceInfo interfaceInfo = new NetworkInterfaceInfo();
            if (ConnectionMgrUtils.GetConnectionDetailWithLevel(phConnection, ConnectionMgrMethods.CM_DETAILS_LEVEL.CMDL_FIXED_SIZE_ONLY, ref interfaceInfo) == CM_RESULT.CMRE_SUCCESS && !interfaceInfo.IsSoftwareLoopback && interfaceInfo.InterfaceState == ConnectState.Connected)
            {
              flag = true;
              break;
            }
          }
        }
      }
      catch (SystemException ex)
      {
        Console.WriteLine(ex.Message);
      }
      return flag;
    }
  }
}
