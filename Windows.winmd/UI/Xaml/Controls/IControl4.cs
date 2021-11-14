// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(236498670, 24366, 17642, 133, 19, 211, 135, 92, 10, 117, 19)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Control))]
  internal interface IControl4
  {
    bool IsFocusEngagementEnabled { get; set; }

    bool IsFocusEngaged { get; set; }

    RequiresPointer RequiresPointer { get; set; }

    DependencyObject XYFocusLeft { get; set; }

    DependencyObject XYFocusRight { get; set; }

    DependencyObject XYFocusUp { get; set; }

    DependencyObject XYFocusDown { get; set; }

    ElementSoundMode ElementSoundMode { get; set; }

    event TypedEventHandler<Control, FocusEngagedEventArgs> FocusEngaged;

    event TypedEventHandler<Control, FocusDisengagedEventArgs> FocusDisengaged;

    void RemoveFocusEngagement();
  }
}
