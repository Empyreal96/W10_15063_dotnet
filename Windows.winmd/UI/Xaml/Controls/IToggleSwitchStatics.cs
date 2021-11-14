// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleSwitchStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ToggleSwitch))]
  [Guid(490148991, 38879, 16934, 146, 202, 221, 244, 83, 215, 253, 90)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToggleSwitchStatics
  {
    DependencyProperty IsOnProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty OnContentProperty { get; }

    DependencyProperty OnContentTemplateProperty { get; }

    DependencyProperty OffContentProperty { get; }

    DependencyProperty OffContentTemplateProperty { get; }
  }
}
