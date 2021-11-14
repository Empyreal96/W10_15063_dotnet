// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapControl))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4269301143, 23827, 20385, 191, 29, 132, 6, 23, 104, 193, 131)]
  internal interface IMapControlStatics4
  {
    DependencyProperty BusinessLandmarksEnabledProperty { get; }

    DependencyProperty TransitFeaturesEnabledProperty { get; }
  }
}
