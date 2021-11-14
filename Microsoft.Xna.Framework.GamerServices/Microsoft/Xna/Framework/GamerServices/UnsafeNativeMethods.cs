// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.UnsafeNativeMethods
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class UnsafeNativeMethods
  {
    [DllImport("XnaFrameworkCore.dll", EntryPoint = "PMIsDebug")]
    public static extern uint IsDebugMode(ref Guid productId, out bool isDebug);

    [DllImport("LicenseInterop.dll")]
    public static extern int IsTrial(ref bool pfIsTrial);

    [DllImport("XnaFrameworkCore.dll", CharSet = CharSet.Unicode)]
    public static extern uint CreateTextInputDialog(
      string title,
      string description,
      string defaultText,
      string button1,
      string button2,
      bool usePasswordMode);

    [DllImport("XnaFrameworkCore.dll", CharSet = CharSet.Unicode)]
    public static extern uint CreateMessageBoxDialog(
      string title,
      string text,
      string button1,
      string button2,
      MessageBoxIcon icon);

    [DllImport("XnaFrameworkCore.dll")]
    public static extern uint GetDialogResult(uint hDialog, out GS_ActionDialogResult result);

    [DllImport("XnaFrameworkCore.dll", CharSet = CharSet.Unicode)]
    public static extern uint GetDialogEditField(uint hDialog, StringBuilder value, int length);

    [DllImport("XnaFrameworkCore.dll")]
    public static extern uint DismissDialog(uint hDialog);

    [DllImport("XnaFrameworkCore.dll")]
    public static extern uint ReleaseDialog(uint hDialog);

    [DllImport("XnaFrameworkCore.dll")]
    public static extern uint RegisterPausingAndResumedHostEventDelegates(
      IntPtr pausingCallback,
      IntPtr resumedCallback);

    [DllImport("XnaFrameworkCore.dll")]
    public static extern uint GuideCanOpenARD();

    [DllImport("XnaFrameworkCore.dll", CharSet = CharSet.Unicode)]
    public static extern bool TryGetResourceStringForCE(
      int stringId,
      StringBuilder value,
      int length);
  }
}
