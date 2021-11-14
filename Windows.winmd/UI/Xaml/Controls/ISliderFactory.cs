// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISliderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(61242167, 51135, 17276, 132, 143, 140, 181, 183, 83, 234, 180)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Slider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISliderFactory
  {
    Slider CreateInstance(object outer, out object inner);
  }
}
