// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlBusinessLandmarkPointerEnteredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;
using Windows.Services.Maps.LocalSearch;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControlBusinessLandmarkPointerEnteredEventArgs))]
  [Guid(1581285798, 60056, 20373, 140, 175, 91, 66, 105, 111, 245, 4)]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  [WebHostHidden]
  internal interface IMapControlBusinessLandmarkPointerEnteredEventArgs
  {
    IVectorView<LocalLocation> LocalLocations { get; }
  }
}
