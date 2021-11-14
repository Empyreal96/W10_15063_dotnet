// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.SystemProtection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System
{
  [Static(typeof (ISystemProtectionStatics), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Static(typeof (ISystemProtectionUnlockStatics), 65536, "Windows.Phone.PhoneContract")]
  public static class SystemProtection
  {
    [MethodImpl]
    public static extern void RequestScreenUnlock();

    public static extern bool ScreenLocked { [MethodImpl] get; }
  }
}
