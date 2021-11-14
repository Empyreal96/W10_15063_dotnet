// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ISelectionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(772983430, 57837, 16965, 190, 73, 32, 126, 66, 174, 197, 36)]
  [WebHostHidden]
  public interface ISelectionInfo
  {
    void SelectRange(ItemIndexRange itemIndexRange);

    void DeselectRange(ItemIndexRange itemIndexRange);

    bool IsSelected(int index);

    IVectorView<ItemIndexRange> GetSelectedRanges();
  }
}
