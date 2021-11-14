// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.InternalNetworkChange
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [SecuritySafeCritical]
  internal class InternalNetworkChange
  {
    private uint count;
    private InternalNetworkChange.NetworkChangeCallback m_NotificationCallback;

    internal static void FireNetworkAvailabilityChangedEvent(
      object sender,
      NetworkNotificationEventArgs e)
    {
      EventHandler<NetworkNotificationEventArgs> internalAddressChanged = InternalNetworkChange._internalAddressChanged;
      if (internalAddressChanged == null)
        return;
      internalAddressChanged(sender, e);
    }

    internal void AddNetworkAvailabilityChanged(EventHandler<NetworkNotificationEventArgs> value)
    {
      lock (this)
      {
        if (this.count == 0U)
          this.RegisterForNotification();
        ++this.count;
        InternalNetworkChange._internalAddressChanged += value;
      }
    }

    internal void RemoveNetworkAvailabilityChanged(EventHandler<NetworkNotificationEventArgs> value)
    {
      lock (this)
      {
        --this.count;
        InternalNetworkChange._internalAddressChanged -= value;
        if (this.count != 0U)
          return;
        this.UnregisterForNotification();
      }
    }

    private void UnregisterForNotification()
    {
      try
      {
        PlatformInteropMethods.UnregisterForNetworkNotification();
      }
      catch (SystemException ex)
      {
      }
    }

    private void RegisterForNotification()
    {
      try
      {
        this.m_NotificationCallback = new InternalNetworkChange.NetworkChangeCallback(this.OnNotification);
        PlatformInteropMethods.RegisterForNetworkNotification(Marshal.GetFunctionPointerForDelegate((Delegate) this.m_NotificationCallback));
      }
      catch (SystemException ex)
      {
      }
    }

    [AllowReversePInvokeCalls]
    private void OnNotification(NetworkNotificationType notificationType, IntPtr pConnDetails)
    {
      NetworkNotificationEventArgs e = new NetworkNotificationEventArgs();
      e.notificationType = notificationType;
      ConnectionMgrUtils.ParseConnectionDetails((ConnectionMgrMethods.CM_CONNECTION_DETAILS) Marshal.PtrToStructure(pConnDetails, typeof (ConnectionMgrMethods.CM_CONNECTION_DETAILS)), ref e.netInterface);
      InternalNetworkChange.FireNetworkAvailabilityChangedEvent((object) this, e);
    }

    private static event EventHandler<NetworkNotificationEventArgs> _internalAddressChanged;

    private delegate void NetworkChangeCallback(
      NetworkNotificationType notificationType,
      IntPtr pConnDetails);
  }
}
