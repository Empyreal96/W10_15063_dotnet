// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapScene
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapScene))]
  [Guid(2344226985, 20711, 18476, 151, 137, 198, 136, 177, 120, 172, 36)]
  [WebHostHidden]
  internal interface IMapScene
  {
    MapCamera TargetCamera { get; }

    event TypedEventHandler<MapScene, MapTargetCameraChangedEventArgs> TargetCameraChanged;
  }
}
