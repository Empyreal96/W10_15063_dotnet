// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ViewModePreferences
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Static(typeof (IViewModePreferencesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ViewModePreferences : IViewModePreferences
  {
    public extern ViewSizePreference ViewSizePreference { [MethodImpl] get; [MethodImpl] set; }

    public extern Size CustomSize { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern ViewModePreferences CreateDefault(
      ApplicationViewMode mode);
  }
}
