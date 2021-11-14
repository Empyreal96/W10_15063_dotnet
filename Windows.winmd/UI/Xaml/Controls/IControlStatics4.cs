// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Control))]
  [WebHostHidden]
  [Guid(1509795624, 49242, 20162, 138, 75, 6, 173, 105, 182, 110, 21)]
  internal interface IControlStatics4
  {
    DependencyProperty IsFocusEngagementEnabledProperty { get; }

    DependencyProperty IsFocusEngagedProperty { get; }

    DependencyProperty RequiresPointerProperty { get; }

    DependencyProperty XYFocusLeftProperty { get; }

    DependencyProperty XYFocusRightProperty { get; }

    DependencyProperty XYFocusUpProperty { get; }

    DependencyProperty XYFocusDownProperty { get; }

    DependencyProperty ElementSoundModeProperty { get; }
  }
}
