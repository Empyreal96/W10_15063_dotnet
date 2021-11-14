// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapIconStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapIcon))]
  [Guid(3703348822, 4496, 19293, 158, 86, 229, 182, 114, 74, 163, 40)]
  internal interface IMapIconStatics
  {
    DependencyProperty LocationProperty { get; }

    DependencyProperty TitleProperty { get; }

    DependencyProperty NormalizedAnchorPointProperty { get; }
  }
}
