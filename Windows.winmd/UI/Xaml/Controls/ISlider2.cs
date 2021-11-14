// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISlider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1084474638, 34774, 19759, 177, 207, 178, 121, 204, 153, 111, 38)]
  [ExclusiveTo(typeof (Slider))]
  internal interface ISlider2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }
  }
}
