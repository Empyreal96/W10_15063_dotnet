// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Control))]
  [Guid(2865847905, 58553, 19826, 182, 83, 147, 65, 73, 170, 80, 3)]
  [WebHostHidden]
  internal interface IControlStatics3
  {
    DependencyProperty UseSystemFocusVisualsProperty { get; }

    DependencyProperty IsTemplateFocusTargetProperty { get; }

    bool GetIsTemplateFocusTarget(FrameworkElement element);

    void SetIsTemplateFocusTarget(FrameworkElement element, bool value);
  }
}
