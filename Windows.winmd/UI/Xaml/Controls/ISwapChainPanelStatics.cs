// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainPanelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SwapChainPanel))]
  [WebHostHidden]
  [Guid(4170973847, 61096, 18828, 153, 196, 37, 126, 54, 96, 223, 126)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISwapChainPanelStatics
  {
    DependencyProperty CompositionScaleXProperty { get; }

    DependencyProperty CompositionScaleYProperty { get; }
  }
}
