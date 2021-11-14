// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainPanelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SwapChainPanel))]
  [Guid(4086271359, 6728, 18891, 134, 210, 16, 234, 170, 246, 253, 112)]
  [WebHostHidden]
  internal interface ISwapChainPanelFactory
  {
    SwapChainPanel CreateInstance(object outer, out object inner);
  }
}
