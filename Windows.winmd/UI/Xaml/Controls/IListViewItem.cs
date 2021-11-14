// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewItem))]
  [Guid(3082502917, 15833, 17374, 168, 192, 196, 114, 240, 133, 188, 17)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListViewItem
  {
    ListViewItemTemplateSettings TemplateSettings { get; }
  }
}
