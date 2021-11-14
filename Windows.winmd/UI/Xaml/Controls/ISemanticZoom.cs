// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoom
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(27262753, 60646, 20412, 191, 64, 137, 56, 212, 129, 62, 39)]
  [ExclusiveTo(typeof (SemanticZoom))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISemanticZoom
  {
    ISemanticZoomInformation ZoomedInView { get; set; }

    ISemanticZoomInformation ZoomedOutView { get; set; }

    bool IsZoomedInViewActive { get; set; }

    bool CanChangeViews { get; set; }

    event SemanticZoomViewChangedEventHandler ViewChangeStarted;

    event SemanticZoomViewChangedEventHandler ViewChangeCompleted;

    void ToggleActiveView();

    bool IsZoomOutButtonEnabled { get; set; }
  }
}
