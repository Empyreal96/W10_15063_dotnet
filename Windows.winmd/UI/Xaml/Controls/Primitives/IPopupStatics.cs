// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopupStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Popup))]
  [Guid(1524875034, 28212, 16598, 138, 127, 202, 130, 42, 175, 89, 227)]
  [WebHostHidden]
  internal interface IPopupStatics
  {
    DependencyProperty ChildProperty { get; }

    DependencyProperty IsOpenProperty { get; }

    DependencyProperty HorizontalOffsetProperty { get; }

    DependencyProperty VerticalOffsetProperty { get; }

    DependencyProperty ChildTransitionsProperty { get; }

    DependencyProperty IsLightDismissEnabledProperty { get; }
  }
}
