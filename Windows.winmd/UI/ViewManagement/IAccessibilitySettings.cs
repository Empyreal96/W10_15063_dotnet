// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IAccessibilitySettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AccessibilitySettings))]
  [Guid(4262363463, 50368, 17762, 185, 98, 19, 39, 181, 42, 213, 185)]
  internal interface IAccessibilitySettings
  {
    bool HighContrast { get; }

    string HighContrastScheme { get; }

    event TypedEventHandler<AccessibilitySettings, object> HighContrastChanged;
  }
}
