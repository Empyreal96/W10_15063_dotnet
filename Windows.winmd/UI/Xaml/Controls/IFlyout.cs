// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Flyout))]
  [WebHostHidden]
  [Guid(1703209951, 52167, 19993, 132, 58, 161, 79, 36, 167, 147, 234)]
  internal interface IFlyout
  {
    UIElement Content { get; set; }

    Style FlyoutPresenterStyle { get; set; }
  }
}
