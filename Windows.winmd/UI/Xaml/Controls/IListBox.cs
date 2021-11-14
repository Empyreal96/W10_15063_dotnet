// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ListBox))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3925064191, 36497, 20175, 167, 7, 201, 39, 246, 148, 248, 129)]
  internal interface IListBox
  {
    IVector<object> SelectedItems { get; }

    SelectionMode SelectionMode { get; set; }

    void ScrollIntoView(object item);

    void SelectAll();
  }
}
