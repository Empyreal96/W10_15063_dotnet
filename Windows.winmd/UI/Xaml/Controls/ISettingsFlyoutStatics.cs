// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISettingsFlyoutStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SettingsFlyout))]
  [WebHostHidden]
  [Guid(3504583989, 37207, 19428, 164, 42, 245, 145, 105, 136, 70, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISettingsFlyoutStatics
  {
    DependencyProperty TitleProperty { get; }

    DependencyProperty HeaderBackgroundProperty { get; }

    DependencyProperty HeaderForegroundProperty { get; }

    DependencyProperty IconSourceProperty { get; }
  }
}
