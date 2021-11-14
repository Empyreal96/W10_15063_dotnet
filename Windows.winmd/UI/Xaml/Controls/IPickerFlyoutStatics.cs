// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPickerFlyoutStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PickerFlyout))]
  [Guid(2937627702, 62346, 19133, 185, 51, 98, 134, 193, 21, 176, 127)]
  [WebHostHidden]
  internal interface IPickerFlyoutStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty ConfirmationButtonsVisibleProperty { get; }
  }
}
