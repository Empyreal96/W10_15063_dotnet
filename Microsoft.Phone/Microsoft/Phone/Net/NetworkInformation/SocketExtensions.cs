// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.SocketExtensions
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  public static class SocketExtensions
  {
    public static void SetNetworkPreference(
      this Socket socket,
      NetworkSelectionCharacteristics preference)
    {
      if (socket == null)
        throw new ArgumentNullException("Socket");
      if (socket.IsBound)
        throw new NetworkException(NetworkError.SocketAlreadyBound);
    }

    public static void SetNetworkRequirement(
      this Socket socket,
      NetworkSelectionCharacteristics requirement)
    {
      if (socket == null)
        throw new ArgumentNullException("Socket");
      if (socket.IsBound)
        throw new NetworkException(NetworkError.SocketAlreadyBound);
      if (requirement == NetworkSelectionCharacteristics.Cellular && HelperMethods.IsCellularDisabled())
        throw new InvalidOperationException(LocalizeString.CellularConnectionNotAllowed);
      CmSessionSafeHandle sessionSafeHandle = new CmSessionSafeHandle(((SafeHandle) socket.CmSessionHandle).DangerousGetHandle(), false);
      if (sessionSafeHandle == null || sessionSafeHandle.IsInvalid)
        throw new NetworkException(NetworkError.NetworkSelectionRequirementFailed);
      socket.networkRequirement = requirement == NetworkSelectionCharacteristics.Cellular ? (Socket.NetworkSelectionCharacteristics) 1 : (Socket.NetworkSelectionCharacteristics) 2;
    }

    public static NetworkInterfaceInfo GetCurrentNetworkInterface(
      this Socket socket)
    {
      NetworkInterfaceInfo interfaceInfo = (NetworkInterfaceInfo) null;
      if (socket == null)
        throw new ArgumentNullException("Socket");
      IntPtr zero = IntPtr.Zero;
      NetworkError error = NetworkError.Success;
      try
      {
        if (!socket.IsBound)
        {
          error = NetworkError.SocketNotConnected;
        }
        else
        {
          CmSessionSafeHandle hSession = new CmSessionSafeHandle(((SafeHandle) socket.CmSessionHandle).DangerousGetHandle(), false);
          if (hSession.IsInvalid)
          {
            error = NetworkError.NetworkOperationFailedError;
          }
          else
          {
            IntPtr currentConnection = ConnectionMgrMethods.CmGetCurrentConnection(hSession);
            if (currentConnection == IntPtr.Zero)
            {
              error = NetworkError.SocketNotConnected;
            }
            else
            {
              interfaceInfo = new NetworkInterfaceInfo();
              if (ConnectionMgrUtils.GetConnectionDetail(currentConnection, ref interfaceInfo) != CM_RESULT.CMRE_SUCCESS)
                error = NetworkError.NetworkOperationFailedError;
            }
          }
        }
      }
      catch (SystemException ex)
      {
        error = NetworkError.NetworkOperationFailedError;
      }
      if (error != NetworkError.Success)
        throw new NetworkException(error);
      return interfaceInfo;
    }

    public static void AssociateToNetworkInterface(
      this Socket socket,
      NetworkInterfaceInfo networkInterface)
    {
      if (socket == null)
        throw new ArgumentNullException("Socket");
      if (networkInterface == null)
        throw new ArgumentNullException(nameof (networkInterface));
      if (networkInterface.InterfaceState == ConnectState.Disconnected)
        throw new ArgumentException(LocalizeString.InvalidNetworkInterfaceError, nameof (networkInterface));
      if (socket.IsBound)
        throw new NetworkException(NetworkError.SocketAlreadyBound);
      socket.InterfaceName = networkInterface.InterfaceType != NetworkInterfaceType.MobileBroadbandGsm && networkInterface.InterfaceType != NetworkInterfaceType.MobileBroadbandCdma || !HelperMethods.IsCellularDisabled() ? networkInterface.m_UnderlyingInterfaceName : throw new InvalidOperationException(LocalizeString.CellularConnectionNotAllowed);
    }
  }
}
