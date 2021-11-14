// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControl))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(157445888, 47069, 16777, 167, 247, 131, 12, 65, 45, 238, 163)]
  [WebHostHidden]
  internal interface IMapControlStatics5
  {
    DependencyProperty MapProjectionProperty { get; }

    DependencyProperty StyleSheetProperty { get; }

    DependencyProperty ViewPaddingProperty { get; }
  }
}
