// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridViewItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (GridViewItem))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(580583599, 16294, 17385, 151, 157, 7, 234, 13, 98, 128, 220)]
  internal interface IGridViewItemFactory
  {
    GridViewItem CreateInstance(object outer, out object inner);
  }
}
