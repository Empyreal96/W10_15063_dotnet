// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitViewStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SplitView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2241548143, 17579, 20043, 145, 193, 23, 183, 5, 109, 155, 95)]
  internal interface ISplitViewStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty PaneProperty { get; }

    DependencyProperty IsPaneOpenProperty { get; }

    DependencyProperty OpenPaneLengthProperty { get; }

    DependencyProperty CompactPaneLengthProperty { get; }

    DependencyProperty PanePlacementProperty { get; }

    DependencyProperty DisplayModeProperty { get; }

    DependencyProperty TemplateSettingsProperty { get; }

    DependencyProperty PaneBackgroundProperty { get; }
  }
}
