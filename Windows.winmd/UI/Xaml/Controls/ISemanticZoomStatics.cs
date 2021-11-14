// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SemanticZoom))]
  [Guid(2398191346, 39064, 18022, 178, 133, 62, 211, 138, 7, 145, 14)]
  [WebHostHidden]
  internal interface ISemanticZoomStatics
  {
    DependencyProperty ZoomedInViewProperty { get; }

    DependencyProperty ZoomedOutViewProperty { get; }

    DependencyProperty IsZoomedInViewActiveProperty { get; }

    DependencyProperty CanChangeViewsProperty { get; }

    DependencyProperty IsZoomOutButtonEnabledProperty { get; }
  }
}
