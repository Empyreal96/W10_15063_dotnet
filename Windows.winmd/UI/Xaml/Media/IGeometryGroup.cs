// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometryGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (GeometryGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1428314721, 34423, 19596, 142, 70, 238, 61, 195, 85, 17, 75)]
  internal interface IGeometryGroup
  {
    FillRule FillRule { get; set; }

    GeometryCollection Children { get; set; }
  }
}
