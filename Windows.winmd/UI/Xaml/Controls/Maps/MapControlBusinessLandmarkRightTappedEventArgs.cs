// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkRightTappedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;
using Windows.Services.Maps.LocalSearch;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Activatable(131072, "Windows.Services.Maps.LocalSearchContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapControlBusinessLandmarkRightTappedEventArgs : 
    IMapControlBusinessLandmarkRightTappedEventArgs
  {
    [MethodImpl]
    public extern MapControlBusinessLandmarkRightTappedEventArgs();

    public extern IVectorView<LocalLocation> LocalLocations { [MethodImpl] get; }
  }
}
