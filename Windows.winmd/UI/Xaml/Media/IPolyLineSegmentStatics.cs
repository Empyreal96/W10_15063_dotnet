// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPolyLineSegmentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (PolyLineSegment))]
  [Guid(3595185287, 13297, 20080, 164, 127, 180, 152, 30, 246, 72, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPolyLineSegmentStatics
  {
    DependencyProperty PointsProperty { get; }
  }
}
