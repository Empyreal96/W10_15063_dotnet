// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.WebRequestExtensions
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
  public static class WebRequestExtensions
  {
    public static void SetNetworkPreference(
      this WebRequest request,
      NetworkSelectionCharacteristics preference)
    {
      ((HttpWebRequest) request ?? throw new ArgumentNullException(nameof (request))).SetNetworkPreference((NetworkSelectionCharacteristicsInternal) preference);
    }

    public static void SetNetworkRequirement(
      this WebRequest request,
      NetworkSelectionCharacteristics requirement)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) request;
      if (httpWebRequest == null)
        throw new ArgumentNullException(nameof (request));
      if (requirement == NetworkSelectionCharacteristics.Cellular && HelperMethods.IsCellularDisabled())
        throw new InvalidOperationException();
      httpWebRequest.SetNetworkRequirement((NetworkSelectionCharacteristicsInternal) requirement);
    }

    public static NetworkInterfaceInfo GetCurrentNetworkInterface(
      this WebRequest request)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) request;
      int num = 0;
      IntPtr zero = IntPtr.Zero;
      if (request == null)
        throw new ArgumentNullException(nameof (request));
      if (!httpWebRequest.Pending)
        throw new NetworkException(NetworkError.WebRequestAlreadyFinished);
      httpWebRequest.GetConnectionDetails(ref zero, ref num);
      if (!(zero != IntPtr.Zero))
        throw new NetworkException(NetworkError.NetworkOperationFailedError);
      NetworkInterfaceInfo interfaceInfo = new NetworkInterfaceInfo();
      try
      {
        ConnectionMgrUtils.ParseConnectionDetails((ConnectionMgrMethods.CM_CONNECTION_DETAILS) Marshal.PtrToStructure(zero, typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS)), ref interfaceInfo);
      }
      finally
      {
        OSNativeMethods.CoTaskMemFree(zero);
      }
      return interfaceInfo;
    }
  }
}
