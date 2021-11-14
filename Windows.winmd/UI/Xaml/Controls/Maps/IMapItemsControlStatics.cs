// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapItemsControlStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapItemsControl))]
  [Guid(866671047, 30875, 16988, 138, 10, 50, 56, 88, 150, 203, 74)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapItemsControlStatics
  {
    DependencyProperty ItemsSourceProperty { get; }

    DependencyProperty ItemsProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }
  }
}
