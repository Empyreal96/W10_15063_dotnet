// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPickerFlyoutBaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PickerFlyoutBase))]
  [Guid(1514998469, 35246, 16613, 167, 241, 187, 112, 35, 85, 173, 243)]
  [WebHostHidden]
  internal interface IPickerFlyoutBaseStatics
  {
    DependencyProperty TitleProperty { get; }

    string GetTitle(DependencyObject element);

    void SetTitle(DependencyObject element, string value);
  }
}
