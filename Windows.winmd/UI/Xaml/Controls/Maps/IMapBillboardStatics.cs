// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapBillboardStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(4260903422, 57847, 20400, 136, 135, 125, 166, 140, 100, 115, 51)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MapBillboard))]
  internal interface IMapBillboardStatics
  {
    DependencyProperty LocationProperty { get; }

    DependencyProperty NormalizedAnchorPointProperty { get; }

    DependencyProperty CollisionBehaviorDesiredProperty { get; }
  }
}
