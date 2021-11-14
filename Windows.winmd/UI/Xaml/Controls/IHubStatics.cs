// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Hub))]
  [Guid(242196532, 44348, 20274, 183, 1, 226, 79, 171, 86, 32, 40)]
  internal interface IHubStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty DefaultSectionIndexProperty { get; }

    DependencyProperty SemanticZoomOwnerProperty { get; }

    DependencyProperty IsActiveViewProperty { get; }

    DependencyProperty IsZoomedInViewProperty { get; }
  }
}
