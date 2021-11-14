// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlBusinessLandmarkPointerExitedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;
using Windows.Services.Maps.LocalSearch;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(733293743, 62026, 18128, 180, 99, 101, 247, 25, 115, 16, 87)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapControlBusinessLandmarkPointerExitedEventArgs))]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  internal interface IMapControlBusinessLandmarkPointerExitedEventArgs
  {
    IVectorView<LocalLocation> LocalLocations { get; }
  }
}
