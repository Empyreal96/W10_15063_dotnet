// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SharedModeSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Static(typeof (ISharedModeSettingsStatics2), 131072, "Windows.System.Profile.ProfileSharedModeContract")]
  [Static(typeof (ISharedModeSettingsStatics), 65536, "Windows.System.Profile.ProfileSharedModeContract")]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (ProfileSharedModeContract), 65536)]
  public static class SharedModeSettings
  {
    public static extern bool ShouldAvoidLocalStorage { [MethodImpl] get; }

    public static extern bool IsEnabled { [MethodImpl] get; }
  }
}
