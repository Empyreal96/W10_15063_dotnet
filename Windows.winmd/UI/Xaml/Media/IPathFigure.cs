// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathFigure
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1570069644, 24489, 19930, 163, 204, 16, 252, 220, 170, 32, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PathFigure))]
  [WebHostHidden]
  internal interface IPathFigure
  {
    PathSegmentCollection Segments { get; set; }

    Point StartPoint { get; set; }

    bool IsClosed { get; set; }

    bool IsFilled { get; set; }
  }
}
