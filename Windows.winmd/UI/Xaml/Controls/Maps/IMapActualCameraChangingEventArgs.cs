// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapActualCameraChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1796062934, 37879, 18050, 141, 229, 164, 122, 28, 199, 169, 69)]
  [ExclusiveTo(typeof (MapActualCameraChangingEventArgs))]
  [WebHostHidden]
  internal interface IMapActualCameraChangingEventArgs
  {
    MapCamera Camera { get; }
  }
}
