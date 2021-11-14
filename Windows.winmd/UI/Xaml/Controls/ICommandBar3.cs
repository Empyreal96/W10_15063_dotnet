// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBar3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CommandBar))]
  [WebHostHidden]
  [Guid(1089190947, 10873, 18611, 154, 103, 100, 155, 133, 45, 133, 137)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICommandBar3
  {
    CommandBarDefaultLabelPosition DefaultLabelPosition { get; set; }

    CommandBarOverflowButtonVisibility OverflowButtonVisibility { get; set; }

    bool IsDynamicOverflowEnabled { get; set; }

    event TypedEventHandler<CommandBar, DynamicOverflowItemsChangingEventArgs> DynamicOverflowItemsChanging;
  }
}
