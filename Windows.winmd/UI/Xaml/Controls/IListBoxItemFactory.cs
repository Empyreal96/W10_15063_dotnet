// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBoxItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1134082260, 41950, 16428, 178, 61, 25, 3, 132, 178, 124, 168)]
  [ExclusiveTo(typeof (ListBoxItem))]
  internal interface IListBoxItemFactory
  {
    ListBoxItem CreateInstance(object outer, out object inner);
  }
}
