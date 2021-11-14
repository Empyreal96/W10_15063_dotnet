// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleMenuFlyoutItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2706478703, 15351, 18102, 182, 28, 155, 44, 27, 166, 136, 67)]
  [ExclusiveTo(typeof (ToggleMenuFlyoutItem))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToggleMenuFlyoutItemFactory
  {
    ToggleMenuFlyoutItem CreateInstance(object outer, out object inner);
  }
}
