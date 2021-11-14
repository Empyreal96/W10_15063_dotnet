// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapTileUriRequestedEventArgs : IMapTileUriRequestedEventArgs
  {
    [MethodImpl]
    public extern MapTileUriRequestedEventArgs();

    public extern int X { [MethodImpl] get; }

    public extern int Y { [MethodImpl] get; }

    public extern int ZoomLevel { [MethodImpl] get; }

    public extern MapTileUriRequest Request { [MethodImpl] get; }
  }
}
