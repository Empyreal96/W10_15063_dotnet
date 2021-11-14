// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBaseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3867044991, 5391, 18128, 166, 172, 197, 0, 43, 217, 202, 83)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListViewBaseFactory
  {
    ListViewBase CreateInstance(object outer, out object inner);
  }
}
