// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1693040129, 19906, 18750, 171, 232, 203, 211, 197, 119, 73, 14)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScrollViewerView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScrollViewerView
  {
    double HorizontalOffset { get; }

    double VerticalOffset { get; }

    float ZoomFactor { get; }
  }
}
