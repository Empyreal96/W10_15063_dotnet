// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(4163584862, 26035, 16838, 169, 226, 119, 182, 123, 196, 192, 12)]
  [ExclusiveTo(typeof (FlyoutBase))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IFlyoutBase2
  {
    FrameworkElement Target { get; }

    bool AllowFocusOnInteraction { get; set; }

    LightDismissOverlayMode LightDismissOverlayMode { get; set; }

    bool AllowFocusWhenDisabled { get; set; }

    ElementSoundMode ElementSoundMode { get; set; }

    event TypedEventHandler<FlyoutBase, FlyoutBaseClosingEventArgs> Closing;
  }
}
