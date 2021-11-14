// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(446459545, 5913, 19328, 179, 53, 98, 131, 49, 160, 112, 25)]
  [ExclusiveTo(typeof (ListViewBase))]
  [WebHostHidden]
  internal interface IListViewBase5
  {
    bool SingleSelectionFollowsFocus { get; set; }

    bool IsDragSource();
  }
}
