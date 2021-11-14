// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPickerFlyoutBaseOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1543262026, 18466, 18356, 169, 88, 119, 194, 11, 161, 32, 211)]
  [ExclusiveTo(typeof (PickerFlyoutBase))]
  internal interface IPickerFlyoutBaseOverrides
  {
    void OnConfirmed();

    bool ShouldShowConfirmationButtons();
  }
}
