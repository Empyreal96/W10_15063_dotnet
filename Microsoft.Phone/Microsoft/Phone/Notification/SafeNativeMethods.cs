// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Notification.SafeNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Notification
{
  [SecurityCritical]
  internal sealed class SafeNativeMethods
  {
    internal const int S_OK = 0;
    internal const int S_FALSE = 1;
    internal const int E_OUTOFMEMORY = -2147024882;
    internal const int E_INVALIDARG = -2147024809;
    internal const int E_HANDLE = -2147024890;
    internal const int E_NOTIMPL = -2147467263;
    internal const int E_ACCESSDENIED = -2147024891;
    internal const int PUSH_INTEROP_E_SUBSCRIPTION_TYPE_NO_CHANNEL_URI = -2129590009;

    internal static void ThrowExceptionFromHResult(int hr) => SafeNativeMethods.ThrowExceptionFromHResult(hr, (Exception) new InvalidOperationException());

    internal static void ThrowExceptionFromHResult(int hr, Exception defaultException)
    {
      if (hr <= -2147024882)
      {
        if (hr <= -2147024891)
        {
          if (hr == -2147467263)
            throw new NotSupportedException();
          if (hr == -2147024891)
            throw new UnauthorizedAccessException("Access to Push Notifications requires ID_CAP_PUSH_NOTIFICATION to be defined in the manifest");
          goto label_16;
        }
        else if (hr != -2147024890)
        {
          if (hr == -2147024882)
            throw new InvalidOperationException();
          goto label_16;
        }
      }
      else if (hr <= -2129590009)
      {
        if (hr != -2147024809)
        {
          if (hr == -2129590009)
            throw new InvalidOperationException(LocalizeString.PushNotificationChannelNotOpened);
          goto label_16;
        }
      }
      else
      {
        if (hr == 0 || hr == 1)
          return;
        goto label_16;
      }
      throw new ArgumentException("E_INVALIDARG");
label_16:
      throw defaultException;
    }

    private SafeNativeMethods()
    {
    }

    [DllImport("PlatformInterop.dll")]
    internal static extern int PushInteropInitialize(SafeNativeMethods.ReverseHandler reverseHandler);

    [DllImport("PlatformInterop.dll")]
    internal static extern int PushInteropUninitialize();

    [DllImport("PlatformInterop.dll")]
    internal static extern void PushInteropFreeMemory(ref IntPtr memory);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int PushInteropFindChannel(string channelName, out uint channelId);

    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern int PushInteropOpenChannel(
      string channelName,
      string serviceName,
      out uint channelId);

    [DllImport("PlatformInterop.dll")]
    internal static extern int PushInteropCloseChannel(uint channelId);

    [DllImport("PlatformInterop.dll")]
    internal static extern int PushInteropGetChannelUri(
      uint channelId,
      out IntPtr channelUri,
      out uint channelUriSize);

    [DllImport("PlatformInterop.dll")]
    internal static extern int PushInteropGetConnectionStatus(
      uint channelId,
      [MarshalAs(UnmanagedType.Bool)] out bool connectionStatus);

    internal delegate void ReverseHandler(
      uint channelId,
      uint eventType,
      IntPtr blob1,
      uint blobSize1);

    internal enum PushInteropBindingType
    {
      ToastBindingType,
      TileBindingType,
    }

    internal enum PushInteropEventType
    {
      ChannelUriReceived,
      ToastNotificationReceived,
      RawNotificationReceived,
      ConnectionStatusChanged,
    }
  }
}
