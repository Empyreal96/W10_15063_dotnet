// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlipViewFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4057901502, 39656, 19787, 171, 67, 22, 211, 30, 5, 244, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FlipView))]
  internal interface IFlipViewFactory
  {
    FlipView CreateInstance(object outer, out object inner);
  }
}
