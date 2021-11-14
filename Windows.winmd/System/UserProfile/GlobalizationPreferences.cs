// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.GlobalizationPreferences
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.System.UserProfile
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGlobalizationPreferencesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class GlobalizationPreferences
  {
    public static extern IVectorView<string> Calendars { [MethodImpl] get; }

    public static extern IVectorView<string> Clocks { [MethodImpl] get; }

    public static extern IVectorView<string> Currencies { [MethodImpl] get; }

    public static extern IVectorView<string> Languages { [MethodImpl] get; }

    public static extern string HomeGeographicRegion { [MethodImpl] get; }

    public static extern DayOfWeek WeekStartsOn { [MethodImpl] get; }
  }
}
