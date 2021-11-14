// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class MapContextRequestedEventArgs : IMapContextRequestedEventArgs
  {
    [MethodImpl]
    public extern MapContextRequestedEventArgs();

    public extern Point Position { [MethodImpl] get; }

    public extern Geopoint Location { [MethodImpl] get; }

    public extern IVectorView<MapElement> MapElements { [MethodImpl] get; }
  }
}
