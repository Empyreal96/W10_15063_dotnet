// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Composable(typeof (ICustomMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class CustomMapTileDataSource : MapTileDataSource, ICustomMapTileDataSource
  {
    [MethodImpl]
    public extern CustomMapTileDataSource();

    public extern event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> BitmapRequested;
  }
}
