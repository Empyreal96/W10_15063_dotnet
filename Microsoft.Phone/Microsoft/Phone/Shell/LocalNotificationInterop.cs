// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.LocalNotificationInterop
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell
{
  internal class LocalNotificationInterop
  {
    internal const int LN_MAX_APP_BASE_URI_SIZE = 256;

    [SecuritySafeCritical]
    [DllImport("ShellChromeAPI.dll", EntryPoint = "Shell_PostMessageToast")]
    internal static extern int SHPostMessageToast(
      ref LocalNotificationInterop.MessageToastData mtData);

    [SecuritySafeCritical]
    [DllImport("PlatformInterop.dll")]
    internal static extern int LNGetAppTaskInfo(ref LocalNotificationInterop.LNTaskInfo lnTaskInfo);

    [SecuritySafeCritical]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct MessageToastData
    {
      public Guid ProductId;
      [MarshalAs(UnmanagedType.LPWStr)]
      public string Title;
      [MarshalAs(UnmanagedType.LPWStr)]
      public string Content;
      [MarshalAs(UnmanagedType.LPWStr)]
      public string TaskUri;
      [MarshalAs(UnmanagedType.LPWStr)]
      public string SoundFile;

      public MessageToastData(Guid productId, string taskUri, string soundFileUri)
      {
        this.ProductId = productId;
        this.TaskUri = taskUri;
        this.Title = "";
        this.Content = "";
        this.SoundFile = soundFileUri;
      }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct LNTaskInfo
    {
      internal int IsAppInForeground;
      internal Guid ProductId;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      internal string AppBaseUri;
      internal int IsXAMLLightup;
    }
  }
}
