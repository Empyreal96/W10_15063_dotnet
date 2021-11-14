// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IButtonWithFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Button))]
  [Guid(152080263, 57196, 16768, 155, 58, 230, 8, 69, 130, 88, 17)]
  internal interface IButtonWithFlyout
  {
    FlyoutBase Flyout { get; set; }
  }
}
