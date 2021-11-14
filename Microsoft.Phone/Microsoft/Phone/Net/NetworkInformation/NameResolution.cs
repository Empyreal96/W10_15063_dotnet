// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.NameResolution
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  internal sealed class NameResolution
  {
    internal DnsEndPoint m_HostEndPoint;
    internal string m_NetInterface;
    internal NameResolutionCallback m_Callback;
    internal object m_hContext;
    internal NameResolution.NativeCallback m_nativeCallback;
    internal GCHandle m_hgcnativeCallback;

    public NameResolution(DnsEndPoint hostEndPoint) => this.m_HostEndPoint = hostEndPoint;

    [SecuritySafeCritical]
    public void BeginResolveHostNameAsync(NameResolutionCallback callback, object Context)
    {
      this.m_Callback = callback;
      this.m_hContext = Context;
      try
      {
        this.m_nativeCallback = new NameResolution.NativeCallback(this.ResolveCallback);
        this.m_hgcnativeCallback = GCHandle.Alloc((object) this.m_nativeCallback);
        PlatformInteropMethods.ResolveHostName(this.m_HostEndPoint.Host, this.m_nativeCallback, (ushort) this.m_HostEndPoint.AddressFamily, (ushort) this.m_HostEndPoint.Port, (string) null, HelperMethods.IsCellularDisabled());
      }
      catch (SystemException ex)
      {
      }
    }

    [AllowReversePInvokeCalls]
    private void ResolveCallback(int result, IntPtr pAddrs, int numAddr, IntPtr pConnDetails)
    {
      NameResolutionResult result1 = new NameResolutionResult();
      result1.callbackContext = this.m_hContext;
      result1.hostname = this.m_HostEndPoint.Host;
      if (result == 0)
      {
        result1.errorCode = NetworkError.Success;
        ConnectionMgrMethods.CM_CONNECTION_DETAILS structure = (ConnectionMgrMethods.CM_CONNECTION_DETAILS) Marshal.PtrToStructure(pConnDetails, typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS));
        result1.netInterface = new NetworkInterfaceInfo();
        ref NetworkInterfaceInfo local = ref result1.netInterface;
        ConnectionMgrUtils.ParseConnectionDetails(structure, ref local);
        result1.ipEndPoints = new IPEndPoint[numAddr];
        for (int index = 0; index < numAddr; ++index)
        {
          IntPtr ptr = new IntPtr((long) pAddrs.ToInt32() + (long) index * 128L);
          int num1 = (int) Marshal.ReadInt16(ptr);
          ushort hostOrder = (ushort) IPAddress.NetworkToHostOrder(Marshal.ReadInt16(ptr, 2));
          int num2;
          int length;
          if (num1 == 2)
          {
            num2 = 4;
            length = 4;
          }
          else
          {
            num2 = 8;
            length = 16;
          }
          byte[] numArray = new byte[length];
          Marshal.Copy(new IntPtr(ptr.ToInt32() + num2), numArray, 0, length);
          result1.ipEndPoints[index] = new IPEndPoint(new IPAddress(numArray), (int) hostOrder);
        }
      }
      else
        result1.errorCode = 995 != result ? NetworkError.NameResolutionNoHostAddresses : NetworkError.NameResolutionOperationAborted;
      if (result1.errorCode != NetworkError.Success && this.m_NetInterface != null)
      {
        result1.netInterface = new NetworkInterfaceInfo();
        int connectionDetailByName = (int) ConnectionMgrUtils.GetConnectionDetailByName(this.m_NetInterface, ref result1.netInterface);
      }
      this.m_Callback(result1);
      this.m_hgcnativeCallback.Free();
    }

    internal void BeginResolveHostNameAsyncOnInterface(
      NetworkInterfaceInfo networkInterface,
      NameResolutionCallback callback,
      object Context)
    {
      this.m_NetInterface = networkInterface.m_UnderlyingInterfaceName;
      this.m_Callback = callback;
      this.m_hContext = Context;
      try
      {
        this.m_nativeCallback = new NameResolution.NativeCallback(this.ResolveCallback);
        this.m_hgcnativeCallback = GCHandle.Alloc((object) this.m_nativeCallback);
        PlatformInteropMethods.ResolveHostName(this.m_HostEndPoint.Host, this.m_nativeCallback, (ushort) this.m_HostEndPoint.AddressFamily, (ushort) this.m_HostEndPoint.Port, this.m_NetInterface, HelperMethods.IsCellularDisabled());
      }
      catch (SystemException ex)
      {
      }
    }

    internal delegate void NativeCallback(
      int result,
      IntPtr pAddrs,
      int numAddr,
      IntPtr pConnDetails);
  }
}
