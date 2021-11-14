// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IGlobalizationPreferencesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.System.UserProfile
{
  [Guid(29311782, 60727, 20118, 176, 233, 193, 52, 13, 30, 161, 88)]
  [ExclusiveTo(typeof (GlobalizationPreferences))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGlobalizationPreferencesStatics
  {
    IVectorView<string> Calendars { get; }

    IVectorView<string> Clocks { get; }

    IVectorView<string> Currencies { get; }

    IVectorView<string> Languages { get; }

    string HomeGeographicRegion { get; }

    DayOfWeek WeekStartsOn { get; }
  }
}
