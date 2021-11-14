// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IItemsRangeInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4032779877, 29181, 17826, 190, 19, 160, 129, 210, 148, 166, 141)]
  [WebHostHidden]
  public interface IItemsRangeInfo : IClosable
  {
    void RangesChanged(ItemIndexRange visibleRange, IVectorView<ItemIndexRange> trackedItems);
  }
}
