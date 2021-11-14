// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlBusinessLandmarkRightTappedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;
using Windows.Services.Maps.LocalSearch;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControlBusinessLandmarkRightTappedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [Guid(1504414439, 61828, 19121, 176, 176, 53, 200, 191, 6, 84, 178)]
  internal interface IMapControlBusinessLandmarkRightTappedEventArgs
  {
    IVectorView<LocalLocation> LocalLocations { get; }
  }
}
