// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IListViewItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class ListViewItem : SelectorItem, IListViewItem
  {
    [MethodImpl]
    public extern ListViewItem();

    public extern ListViewItemTemplateSettings TemplateSettings { [MethodImpl] get; }
  }
}
