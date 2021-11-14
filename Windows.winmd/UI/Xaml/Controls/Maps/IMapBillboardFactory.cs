// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapBillboardFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(3192235205, 36617, 19334, 174, 40, 120, 55, 64, 235, 139, 49)]
  [ExclusiveTo(typeof (MapBillboard))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMapBillboardFactory
  {
    MapBillboard CreateInstanceFromCamera(MapCamera camera);
  }
}
