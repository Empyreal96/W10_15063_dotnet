// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDragItemsCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2936402479, 40568, 19233, 154, 142, 65, 194, 209, 54, 122, 42)]
  [ExclusiveTo(typeof (DragItemsCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDragItemsCompletedEventArgs
  {
    IVectorView<object> Items { get; }

    DataPackageOperation DropResult { get; }
  }
}
