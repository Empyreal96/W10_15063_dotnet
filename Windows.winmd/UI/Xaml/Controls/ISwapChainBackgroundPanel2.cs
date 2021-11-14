// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainBackgroundPanel2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SwapChainBackgroundPanel))]
  [Guid(568750834, 9618, 19512, 135, 15, 40, 251, 207, 82, 192, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISwapChainBackgroundPanel2
  {
    CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);
  }
}
