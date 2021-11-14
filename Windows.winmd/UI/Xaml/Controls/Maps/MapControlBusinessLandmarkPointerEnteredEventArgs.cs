// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerEnteredEventArgs
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
  [Activatable(196608, "Windows.Services.Maps.LocalSearchContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  public sealed class MapControlBusinessLandmarkPointerEnteredEventArgs : 
    IMapControlBusinessLandmarkPointerEnteredEventArgs
  {
    [MethodImpl]
    public extern MapControlBusinessLandmarkPointerEnteredEventArgs();

    public extern IVectorView<LocalLocation> LocalLocations { [MethodImpl] get; }
  }
}
