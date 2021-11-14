// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometryGroupStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1456035316, 33942, 19382, 171, 240, 97, 123, 31, 231, 139, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GeometryGroup))]
  [WebHostHidden]
  internal interface IGeometryGroupStatics
  {
    DependencyProperty FillRuleProperty { get; }

    DependencyProperty ChildrenProperty { get; }
  }
}
