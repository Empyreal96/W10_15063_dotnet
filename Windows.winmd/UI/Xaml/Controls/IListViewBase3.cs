// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3009724469, 2579, 16495, 163, 251, 243, 14, 125, 220, 169, 76)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListViewBase3
  {
    ListViewReorderMode ReorderMode { get; set; }
  }
}
