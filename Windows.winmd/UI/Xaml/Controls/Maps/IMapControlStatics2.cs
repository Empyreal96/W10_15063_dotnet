// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapControl))]
  [WebHostHidden]
  [Guid(75836307, 46150, 19761, 151, 82, 30, 198, 154, 89, 150, 174)]
  internal interface IMapControlStatics2
  {
    DependencyProperty BusinessLandmarksVisibleProperty { get; }

    DependencyProperty TransitFeaturesVisibleProperty { get; }

    DependencyProperty PanInteractionModeProperty { get; }

    DependencyProperty RotateInteractionModeProperty { get; }

    DependencyProperty TiltInteractionModeProperty { get; }

    DependencyProperty ZoomInteractionModeProperty { get; }

    DependencyProperty Is3DSupportedProperty { get; }

    DependencyProperty IsStreetsideSupportedProperty { get; }

    DependencyProperty SceneProperty { get; }
  }
}
