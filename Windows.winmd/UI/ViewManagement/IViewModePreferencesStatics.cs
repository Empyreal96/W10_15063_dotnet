// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IViewModePreferencesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ViewModePreferences))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1773537893, 24037, 16600, 131, 6, 56, 51, 223, 122, 34, 116)]
  internal interface IViewModePreferencesStatics
  {
    ViewModePreferences CreateDefault(ApplicationViewMode mode);
  }
}
