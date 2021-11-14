// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(50469860, 21076, 18305, 129, 148, 81, 104, 247, 208, 109, 123)]
  [ExclusiveTo(typeof (UISettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUISettings3
  {
    Color GetColorValue(UIColorType desiredColor);

    event TypedEventHandler<UISettings, object> ColorValuesChanged;
  }
}
