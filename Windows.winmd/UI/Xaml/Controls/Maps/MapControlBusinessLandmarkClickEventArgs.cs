// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkClickEventArgs
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
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(131072, "Windows.Services.Maps.LocalSearchContract")]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  public sealed class MapControlBusinessLandmarkClickEventArgs : 
    IMapControlBusinessLandmarkClickEventArgs
  {
    [MethodImpl]
    public extern MapControlBusinessLandmarkClickEventArgs();

    public extern IVectorView<LocalLocation> LocalLocations { [MethodImpl] get; }
  }
}
