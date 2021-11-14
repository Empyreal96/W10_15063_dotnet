// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainBackgroundPanelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(427985364, 51355, 18866, 137, 108, 89, 23, 191, 138, 220, 174)]
  [ExclusiveTo(typeof (SwapChainBackgroundPanel))]
  internal interface ISwapChainBackgroundPanelFactory
  {
    SwapChainBackgroundPanel CreateInstance(object outer, out object inner);
  }
}
