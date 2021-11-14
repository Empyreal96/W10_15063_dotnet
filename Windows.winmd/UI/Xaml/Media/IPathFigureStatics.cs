// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathFigureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3053818329, 9109, 17175, 149, 82, 58, 88, 82, 111, 140, 123)]
  [ExclusiveTo(typeof (PathFigure))]
  internal interface IPathFigureStatics
  {
    DependencyProperty SegmentsProperty { get; }

    DependencyProperty StartPointProperty { get; }

    DependencyProperty IsClosedProperty { get; }

    DependencyProperty IsFilledProperty { get; }
  }
}
