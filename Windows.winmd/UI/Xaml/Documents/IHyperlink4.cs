// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(4157614425, 33531, 16394, 164, 7, 90, 78, 230, 119, 152, 138)]
  [ExclusiveTo(typeof (Hyperlink))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHyperlink4
  {
    FocusState FocusState { get; }

    XYFocusNavigationStrategy XYFocusUpNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusDownNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get; set; }

    event RoutedEventHandler GotFocus;

    event RoutedEventHandler LostFocus;

    bool Focus(FocusState value);
  }
}
