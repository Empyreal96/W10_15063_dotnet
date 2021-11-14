// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(45722129, 2887, 20093, 173, 145, 58, 65, 104, 237, 35, 13)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PasswordBox))]
  internal interface IPasswordBox
  {
    string Password { get; set; }

    string PasswordChar { get; set; }

    bool IsPasswordRevealButtonEnabled { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    int MaxLength { get; set; }

    event RoutedEventHandler PasswordChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;

    void SelectAll();
  }
}
