// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlBusinessLandmarkClickEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;
using Windows.Services.Maps.LocalSearch;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControlBusinessLandmarkClickEventArgs))]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [Guid(1581664546, 18970, 18327, 190, 183, 92, 247, 117, 76, 184, 103)]
  [WebHostHidden]
  internal interface IMapControlBusinessLandmarkClickEventArgs
  {
    IVectorView<LocalLocation> LocalLocations { get; }
  }
}
