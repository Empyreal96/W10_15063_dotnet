// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewHeaderItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewHeaderItem))]
  [Guid(1758644586, 38576, 20232, 167, 165, 241, 8, 103, 32, 160, 250)]
  internal interface IListViewHeaderItemFactory
  {
    ListViewHeaderItem CreateInstance(object outer, out object inner);
  }
}
