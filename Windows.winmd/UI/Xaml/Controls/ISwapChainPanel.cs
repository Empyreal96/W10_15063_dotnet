// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3314115663, 60328, 17018, 183, 90, 159, 31, 147, 161, 26, 233)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SwapChainPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISwapChainPanel
  {
    float CompositionScaleX { get; }

    float CompositionScaleY { get; }

    event TypedEventHandler<SwapChainPanel, object> CompositionScaleChanged;

    CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);
  }
}
