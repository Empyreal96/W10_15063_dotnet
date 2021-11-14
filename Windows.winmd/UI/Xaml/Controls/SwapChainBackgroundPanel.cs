// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwapChainBackgroundPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISwapChainBackgroundPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class SwapChainBackgroundPanel : Grid, ISwapChainBackgroundPanel, ISwapChainBackgroundPanel2
  {
    [MethodImpl]
    public extern SwapChainBackgroundPanel();

    [MethodImpl]
    public extern CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);
  }
}
