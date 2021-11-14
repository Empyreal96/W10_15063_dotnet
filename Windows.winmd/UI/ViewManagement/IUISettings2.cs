// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3134727169, 10017, 17657, 187, 145, 43, 178, 40, 190, 68, 47)]
  internal interface IUISettings2
  {
    double TextScaleFactor { get; }

    event TypedEventHandler<UISettings, object> TextScaleFactorChanged;
  }
}
