// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.NetworkInterfaceList
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  public class NetworkInterfaceList : 
    IEnumerable<NetworkInterfaceInfo>,
    IEnumerable,
    IEnumerator<NetworkInterfaceInfo>,
    IEnumerator,
    IDisposable
  {
    private CmSessionSafeHandle m_hSession;
    private IntPtr m_hConnection = IntPtr.Zero;
    private bool bReset;
    private bool disposed;

    public IEnumerator<NetworkInterfaceInfo> GetEnumerator() => (IEnumerator<NetworkInterfaceInfo>) this;

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this;

    public NetworkInterfaceInfo Current
    {
      [SecuritySafeCritical] get
      {
        NetworkInterfaceInfo interfaceInfo = new NetworkInterfaceInfo();
        int connectionDetail = (int) ConnectionMgrUtils.GetConnectionDetail(this.m_hConnection, ref interfaceInfo);
        return interfaceInfo;
      }
    }

    object IEnumerator.Current => (object) this.Current;

    [SecuritySafeCritical]
    public bool MoveNext()
    {
      if (this.m_hSession == null || this.m_hSession.IsInvalid)
      {
        this.m_hSession = CmSessionSafeHandle.CreateCMSession();
        if (this.m_hSession.IsInvalid)
        {
          this.m_hSession = (CmSessionSafeHandle) null;
          return false;
        }
      }
      CM_RESULT candidateConnection;
      if (this.bReset || this.m_hConnection == IntPtr.Zero)
      {
        candidateConnection = ConnectionMgrMethods.CmGetFirstCandidateConnection(this.m_hSession, (string) null, ConnectionMgrMethods.CM_CONNECTION_SELECTION_OPTION.CMSO_DEFAULT, out this.m_hConnection);
        this.bReset = false;
      }
      else
        candidateConnection = ConnectionMgrMethods.CmGetNextCandidateConnection(this.m_hSession, out this.m_hConnection);
      if (candidateConnection == CM_RESULT.CMRE_SUCCESS && this.m_hConnection != IntPtr.Zero)
        return true;
      this.m_hConnection = IntPtr.Zero;
      return false;
    }

    public void Reset()
    {
      this.m_hConnection = IntPtr.Zero;
      this.bReset = true;
    }

    private void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (this.m_hSession != null && !this.m_hSession.IsInvalid)
      {
        this.m_hSession.Dispose();
        this.m_hConnection = IntPtr.Zero;
        this.m_hSession = (CmSessionSafeHandle) null;
      }
      this.disposed = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~NetworkInterfaceList() => this.Dispose(false);
  }
}
