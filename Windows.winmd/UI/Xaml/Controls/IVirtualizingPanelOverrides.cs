// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingPanelOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VirtualizingPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1593228669, 26495, 16525, 169, 108, 177, 149, 7, 117, 4, 102)]
  internal interface IVirtualizingPanelOverrides
  {
    void OnItemsChanged(object sender, ItemsChangedEventArgs args);

    void OnClearChildren();

    void BringIndexIntoView(int index);
  }
}
