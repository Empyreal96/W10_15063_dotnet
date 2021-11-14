// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4096853821, 40108, 17058, 130, 223, 15, 68, 144, 188, 78, 46)]
  [ExclusiveTo(typeof (ListViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListViewItemFactory
  {
    ListViewItem CreateInstance(object outer, out object inner);
  }
}
