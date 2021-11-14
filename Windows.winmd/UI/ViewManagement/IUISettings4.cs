// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [Guid(1387999234, 37275, 19819, 155, 120, 141, 214, 111, 244, 185, 59)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUISettings4
  {
    bool AdvancedEffectsEnabled { get; }

    event TypedEventHandler<UISettings, object> AdvancedEffectsEnabledChanged;
  }
}
