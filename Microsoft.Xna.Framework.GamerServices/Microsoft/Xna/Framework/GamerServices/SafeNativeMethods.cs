// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.SafeNativeMethods
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class SafeNativeMethods
  {
    private static HostInfo hostInfo;
    public const int IDS_MESSAGEBOX_OK_TEXT = 10004;
    public const int IDS_MESSAGEBOX_CANCEL_TEXT = 10005;

    [SecuritySafeCritical]
    public static bool IsDebugMode()
    {
      if (SafeNativeMethods.hostInfo == null)
        SafeNativeMethods.hostInfo = new HostInfo();
      string productId1 = SafeNativeMethods.hostInfo.ProductId;
      if (string.IsNullOrEmpty(productId1))
        return false;
      Guid productId2 = new Guid(productId1);
      bool isDebug = false;
      if (UnsafeNativeMethods.IsDebugMode(ref productId2, out isDebug) != 0U)
        isDebug = false;
      return isDebug;
    }

    [SecuritySafeCritical]
    public static int IsTrial(ref bool pfIsTrial) => UnsafeNativeMethods.IsTrial(ref pfIsTrial);

    [SecuritySafeCritical]
    public static uint CreateTextInputDialog(
      string title,
      string description,
      string defaultText,
      string button1,
      string button2,
      bool usePasswordMode)
    {
      return UnsafeNativeMethods.CreateTextInputDialog(title, description, defaultText, button1, button2, usePasswordMode);
    }

    [SecuritySafeCritical]
    public static uint CreateMessageBoxDialog(
      string title,
      string text,
      string button1,
      string button2,
      MessageBoxIcon icon)
    {
      return UnsafeNativeMethods.CreateMessageBoxDialog(title, text, button1, button2, icon);
    }

    [SecuritySafeCritical]
    public static uint GetDialogResult(uint hDialog, out GS_ActionDialogResult result) => UnsafeNativeMethods.GetDialogResult(hDialog, out result);

    [SecuritySafeCritical]
    public static uint GetDialogEditField(uint hDialog, StringBuilder value, int length) => UnsafeNativeMethods.GetDialogEditField(hDialog, value, length);

    [SecuritySafeCritical]
    public static uint DismissDialog(uint hDialog) => UnsafeNativeMethods.DismissDialog(hDialog);

    [SecuritySafeCritical]
    public static uint ReleaseDialog(uint hDialog) => UnsafeNativeMethods.ReleaseDialog(hDialog);

    [SecuritySafeCritical]
    public static uint RegisterPausingAndResumedHostEventDelegates(
      IntPtr pausingCallback,
      IntPtr resumedCallback)
    {
      return UnsafeNativeMethods.RegisterPausingAndResumedHostEventDelegates(pausingCallback, resumedCallback);
    }

    [SecuritySafeCritical]
    public static bool CanOpenARD() => UnsafeNativeMethods.GuideCanOpenARD() != 0U;

    [SecuritySafeCritical]
    public static string TryGetResourceStringForCE(int stringId)
    {
      int num = 1024;
      StringBuilder stringBuilder = new StringBuilder(num);
      return UnsafeNativeMethods.TryGetResourceStringForCE(stringId, stringBuilder, num) ? stringBuilder.ToString() : (string) null;
    }
  }
}
