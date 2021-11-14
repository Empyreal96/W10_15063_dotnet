// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridViewHeaderItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(920701294, 46442, 19259, 139, 172, 122, 239, 94, 111, 153, 69)]
  [ExclusiveTo(typeof (GridViewHeaderItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewHeaderItemFactory
  {
    GridViewHeaderItem CreateInstance(object outer, out object inner);
  }
}
