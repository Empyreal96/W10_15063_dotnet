// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPolyBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(914379377, 14532, 19407, 150, 205, 2, 138, 109, 56, 175, 37)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PolyBezierSegment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPolyBezierSegment
  {
    PointCollection Points { get; set; }
  }
}
