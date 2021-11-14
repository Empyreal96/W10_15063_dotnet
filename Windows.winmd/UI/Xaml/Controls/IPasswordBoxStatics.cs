// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBoxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1592161635, 11636, 19150, 189, 121, 252, 171, 97, 167, 215, 123)]
  [ExclusiveTo(typeof (PasswordBox))]
  internal interface IPasswordBoxStatics
  {
    DependencyProperty PasswordProperty { get; }

    DependencyProperty PasswordCharProperty { get; }

    DependencyProperty IsPasswordRevealButtonEnabledProperty { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty MaxLengthProperty { get; }
  }
}
