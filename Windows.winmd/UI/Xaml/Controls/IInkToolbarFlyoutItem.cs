// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarFlyoutItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(2461435782, 14318, 18709, 158, 137, 225, 135, 86, 74, 136, 154)]
  internal interface IInkToolbarFlyoutItem
  {
    InkToolbarFlyoutItemKind Kind { get; set; }

    bool IsChecked { get; set; }

    event TypedEventHandler<InkToolbarFlyoutItem, object> Checked;

    event TypedEventHandler<InkToolbarFlyoutItem, object> Unchecked;
  }
}
