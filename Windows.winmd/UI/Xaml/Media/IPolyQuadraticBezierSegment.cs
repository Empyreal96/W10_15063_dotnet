// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPolyQuadraticBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (PolyQuadraticBezierSegment))]
  [Guid(3713854845, 59099, 19606, 182, 161, 63, 206, 150, 233, 135, 166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPolyQuadraticBezierSegment
  {
    PointCollection Points { get; set; }
  }
}
