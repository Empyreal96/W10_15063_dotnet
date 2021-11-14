// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathGeometryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (PathGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3655699386, 11450, 18241, 143, 141, 49, 152, 207, 81, 134, 185)]
  internal interface IPathGeometryStatics
  {
    DependencyProperty FillRuleProperty { get; }

    DependencyProperty FiguresProperty { get; }
  }
}
