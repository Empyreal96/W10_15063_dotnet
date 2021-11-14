// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileBitmapRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapTileBitmapRequestedEventArgs))]
  [Guid(863987997, 39682, 19106, 139, 30, 204, 77, 145, 113, 155, 243)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapTileBitmapRequestedEventArgs
  {
    int X { get; }

    int Y { get; }

    int ZoomLevel { get; }

    MapTileBitmapRequest Request { get; }
  }
}
