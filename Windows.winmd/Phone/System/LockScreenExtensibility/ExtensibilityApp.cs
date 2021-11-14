// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.LockScreenExtensibility.ExtensibilityApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.LockScreenExtensibility
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Static(typeof (ILockScreenExtensibilityStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class ExtensibilityApp
  {
    [MethodImpl]
    public static extern void RegisterLockScreenApplication();

    [MethodImpl]
    public static extern void UnregisterLockScreenApplication();

    [MethodImpl]
    public static extern bool IsLockScreenApplicationRegistered();

    [MethodImpl]
    public static extern void RegisterSystemOverlayApplication();

    [MethodImpl]
    public static extern void UnregisterSystemOverlayApplication();

    [MethodImpl]
    public static extern bool IsSystemOverlayApplicationRegistered();

    [MethodImpl]
    public static extern int GetLockPinpadHeight();

    [MethodImpl]
    public static extern void BeginUnlock();

    [MethodImpl]
    public static extern void EndUnlock();

    [MethodImpl]
    public static extern void RaiseToastNotifications();
  }
}
