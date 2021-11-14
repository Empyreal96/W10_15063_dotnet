// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Control))]
  [Guid(4130715043, 61326, 16463, 135, 123, 85, 128, 71, 55, 16, 166)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IControlStatics5
  {
    DependencyProperty DefaultStyleResourceUriProperty { get; }

    DependencyProperty IsTemplateKeyTipTargetProperty { get; }

    bool GetIsTemplateKeyTipTarget(DependencyObject element);

    void SetIsTemplateKeyTipTarget(DependencyObject element, bool value);
  }
}
