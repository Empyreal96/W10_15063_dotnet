// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ICustomMapTileDataSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CustomMapTileDataSource))]
  [Guid(1708800074, 11697, 19425, 177, 85, 61, 12, 158, 207, 71, 153)]
  internal interface ICustomMapTileDataSource
  {
    event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> BitmapRequested;
  }
}
