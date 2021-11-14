// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4183530156, 42529, 18574, 145, 86, 142, 227, 17, 101, 190, 4)]
  [ExclusiveTo(typeof (ItemsPickedEventArgs))]
  internal interface IItemsPickedEventArgs
  {
    IVector<object> AddedItems { get; }

    IVector<object> RemovedItems { get; }
  }
}
