// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISelectionChangedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SelectionChangedEventArgs))]
  [Guid(296269493, 10288, 17687, 132, 205, 85, 36, 200, 184, 139, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISelectionChangedEventArgsFactory
  {
    SelectionChangedEventArgs CreateInstanceWithRemovedItemsAndAddedItems(
      IVector<object> removedItems,
      IVector<object> addedItems,
      object outer,
      out object inner);
  }
}
