// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [Guid(1362684248, 13149, 16912, 139, 187, 10, 162, 180, 181, 194, 158)]
  internal interface IContentPresenter2
  {
    OpticalMarginAlignment OpticalMarginAlignment { get; set; }

    TextLineBounds TextLineBounds { get; set; }
  }
}
